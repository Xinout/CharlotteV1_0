using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using Utils;


namespace CharlotteV1_0
{
    public partial class ucGetTicket : UserControl
    {

        #region "Constructor"
        public ucGetTicket()
        {
            InitializeComponent();

            dgvTicket.DefaultCellStyle.ForeColor = Color.Black;
            dgvTicket.EnableHeadersVisualStyles = false;
            dgvTicket.Columns[1].ReadOnly = true;
            dgvTicket.Columns[2].ReadOnly = true;

        }
        #endregion

        #region "Eventos"
            private void btnGetTicket_Click(object sender, EventArgs e)
            {
                bool bEfectivo, bTicketRegalo;
                double dEfectivo = 0;
                long idTicket = 0;
                string strMessage = string.Empty;
                string[,] aItems = null;

                try
                {
                    bTicketRegalo = chbTicketRegalo.Checked;
                    strMessage = validate(bTicketRegalo);

                    if (string.IsNullOrEmpty(strMessage))
                    {
                        bEfectivo = rbCash.Checked;

                        double.TryParse(tbAmount.Text, out dEfectivo);

                        if (saveTicket(bTicketRegalo, !bEfectivo, dEfectivo, getTotal(), ref idTicket))
                        {

                            if (updateStockItem())
                            {
                                aItems = new string[dgvTicket.Rows.Count, 6];

                                int cont = 0;
                                foreach (DataGridViewRow row in dgvTicket.Rows)
                                {
                                    aItems[cont, 0] = row.Cells[0].Value.ToString();
                                    aItems[cont, 1] = row.Cells[1].Value.ToString();
                                    aItems[cont, 2] = row.Cells[2].Value.ToString();
                                    aItems[cont, 3] = row.Cells[3].Value.ToString().Replace(".", ",");
                                    aItems[cont, 4] = row.Cells[4].Value.ToString().Replace(".", ",");
                                    aItems[cont, 5] = row.Cells[5].Value.ToString().Replace(".", ",");
                                    cont++;
                                }


                                Ticket ticket = new Ticket();
                                ticket.getTicket(aItems, bEfectivo, dEfectivo, false, idTicket);

                                if (bTicketRegalo)
                                {
                                    ticket.getTicket(aItems, bEfectivo, dEfectivo, true, idTicket);
                                }

                                DialogResult result = MessageBox.Show("¿Quieres imprimir una copia?", "Charlotte", MessageBoxButtons.YesNo, MessageBoxIcon.Question);

                                if (result == DialogResult.Yes)
                                {
                                    ticket.getTicket(aItems, bEfectivo, dEfectivo, false, idTicket);
                                }
                                else if (result == DialogResult.No)
                                {
                                    //...
                                }

                            Global.mainForm.pContent.Controls.Clear();
                            }

                        }
                        else
                        {
                            MessageBox.Show("Error, consultar administrador", "Charlotte", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                        }
                    }
                    else
                    {
                        MessageBox.Show(strMessage, "Charlotte", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    }
                }
                catch (Exception ex)
                {
                    Mail.gestionaError(ex.Message);Global.error = true;
                    MessageBox.Show("ERROR", "Charlotte", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }

            private void btnSearch_Click(object sender, EventArgs e)
            {
                try
                {
                    DataTable listaItems = null;

                    Cursor.Current = Cursors.WaitCursor;

                    dgvItem.Columns.Clear();
                    dgvItem.DataSource = null;

                    if (isFiltered())
                    {
                        string filter = getFilter();
                        listaItems = Global.common.getFilteredItemSQL(filter);
                    }
                    else
                    {
                        listaItems = Global.common.getItemsAvailableSQL();
                    }


                    if ((listaItems != null) && (listaItems.Rows.Count > 0))
                    {
                        dgvItem.DataSource = listaItems;

                        //Ocultamos columnas
                        dgvItem.Columns[0].Visible = false;
                        dgvItem.Columns[2].Visible = false;

                        dgvItem.Columns[1].Width = 130;
                        dgvItem.Columns[3].Width = 250;

                        dgvItem.DefaultCellStyle.ForeColor = Color.Black;

                        DataGridViewButtonColumn colAdd = new DataGridViewButtonColumn();
                        colAdd.HeaderText = "Añadir";
                        colAdd.Text = "AÑADIR";
                        colAdd.UseColumnTextForButtonValue = true;

                        dgvItem.EnableHeadersVisualStyles = false;

                        dgvItem.Columns.Add(colAdd);
                    }
                    else
                    {
                        MessageBox.Show("No hay datos", "Charlotte", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    }

                    Cursor.Current = Cursors.Default;
                }
                catch (Exception ex)
                {
                    Mail.gestionaError(ex.Message);Global.error = true;
                    MessageBox.Show("ERROR", "Charlotte", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }

            }

            private void dgvItem_CellContentClick(object sender, DataGridViewCellEventArgs e)
            {
                try
                {
                    var senderGrid = (DataGridView)sender;

                    if (senderGrid.Columns[e.ColumnIndex] is DataGridViewButtonColumn &&
                        e.RowIndex >= 0)
                    {
                        if (e.ColumnIndex == 6)
                        {
                            DataGridViewRow row;
                            int iCantidad = 0;
                            int auxId = 0;

                            if (senderGrid.Rows[e.RowIndex].Cells[5].Value.ToString() == "0")
                            {
                                iCantidad = 0;
                            }
                            else
                            {
                                iCantidad = getNewQuantity(senderGrid.Rows[e.RowIndex].Cells[0].Value.ToString(),
                                                        "1",
                                                        senderGrid.Rows[e.RowIndex].Cells[5].Value.ToString(),
                                                        ref auxId);
                            }


                            if (iCantidad == 1)
                            {
                                row = senderGrid.Rows[e.RowIndex];
                                dgvTicket.Rows.Add(row.Cells[0].Value.ToString(), row.Cells[1].Value.ToString(), row.Cells[3].Value.ToString(),
                                    row.Cells[4].Value.ToString(), "1", "0", null, row.Cells[5].Value.ToString());
                                calcultateTotal();
                            }
                            else if (iCantidad > 1)
                            {
                                dgvTicket.Rows[auxId].Cells[4].Value = iCantidad.ToString();
                                calcultateTotal();
                            }
                            else
                            {
                                row = senderGrid.Rows[e.RowIndex];
                                dgvTicket.Rows.Add(row.Cells[0].Value.ToString(), row.Cells[1].Value.ToString(), row.Cells[3].Value.ToString(),
                                    "-" + row.Cells[4].Value.ToString(), "1", "0", null, row.Cells[5].Value.ToString());
                                calcultateTotal();

                            }

                        }
                    }
                }
                catch (Exception ex)
                {
                    Mail.gestionaError(ex.Message);Global.error = true;
                    MessageBox.Show("ERROR", "Charlotte", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }


            }

            private void dgvTicket_CellContentClick(object sender, DataGridViewCellEventArgs e)
            {
                try
                {
                    var senderGrid = (DataGridView)sender;

                    if (senderGrid.Columns[e.ColumnIndex] is DataGridViewButtonColumn &&
                        e.RowIndex >= 0)
                    {
                        if (e.ColumnIndex == 6)
                        {
                            dgvTicket.Rows.RemoveAt(e.RowIndex);
                            calcultateTotal();
                        }
                    }
                }
                catch (Exception ex)
                {
                    Mail.gestionaError(ex.Message);Global.error = true;
                    MessageBox.Show("ERROR", "Charlotte", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }

            }

            private void rbCash_CheckedChanged(object sender, EventArgs e)
            {
                if (rbCash.Checked)
                {
                    tbAmount.Enabled = true;
                }
            }

            private void rbCard_CheckedChanged(object sender, EventArgs e)
            {
                if (rbCard.Checked)
                {
                    tbAmount.Text = string.Empty;
                    tbAmount.Enabled = false;
                }
            }

            private void dgvTicket_CellValueChanged(object sender, DataGridViewCellEventArgs e)
            {
                var senderGrid = (DataGridView)sender;
                int dDisponible = 0;
                int dNewValue = 0;
                double dNewAmount = 0;
                double dNewDesc = 0;

            try
                {
                    if (dgvTicket.Rows.Count > 0)
                    {
                        if (e.ColumnIndex == 4)
                        {
                            int.TryParse(senderGrid.Rows[e.RowIndex].Cells[4].Value.ToString(), out dNewValue);
                            int.TryParse(senderGrid.Rows[e.RowIndex].Cells[7].Value.ToString(), out dDisponible);

                            if ((dNewValue > 0) && (dNewValue <= dDisponible))
                            {
                                MessageBox.Show("Ha cambiado la cantidad de producto", "Charlotte", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                                calcultateTotal();
                            }
                            else
                            {
                                MessageBox.Show("Cantidad de producto incorrecta", "Charlotte", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                                senderGrid.Rows[e.RowIndex].Cells[4].Value = "1";
                                calcultateTotal();
                            }

                        }
                        else if (e.ColumnIndex == 3)
                        {
                            if (senderGrid.Rows[e.RowIndex].Cells[3].Value.ToString().Contains("."))
                            {
                                senderGrid.Rows[e.RowIndex].Cells[3].Value = senderGrid.Rows[e.RowIndex].Cells[3].Value.ToString().Replace(".", ",");
                            }
                            senderGrid.Rows[e.RowIndex].Cells[3].Value.ToString().Replace(".", ",");
                            double.TryParse(senderGrid.Rows[e.RowIndex].Cells[3].Value.ToString(), out dNewAmount);

                            if (!(dNewAmount > 0))
                            {
                                senderGrid.Rows[e.RowIndex].Cells[3].Value = "0,1";
                                MessageBox.Show("Precio de producto incorrecto", "Charlotte", MessageBoxButtons.OK, MessageBoxIcon.Warning);



                            }
                            calcultateTotal();
                        }
                        else if (e.ColumnIndex == 5)
                        {
                            if (senderGrid.Rows[e.RowIndex].Cells[5].Value.ToString().Contains("."))
                            {
                                senderGrid.Rows[e.RowIndex].Cells[5].Value = senderGrid.Rows[e.RowIndex].Cells[3].Value.ToString().Replace(".", ",");
                            }
                            senderGrid.Rows[e.RowIndex].Cells[5].Value.ToString().Replace(".", ",");
                            double.TryParse(senderGrid.Rows[e.RowIndex].Cells[5].Value.ToString(), out dNewDesc);

                            if (!(dNewDesc > 0))
                            {
                                senderGrid.Rows[e.RowIndex].Cells[5].Value = "0";                         
                                MessageBox.Show("Descuento de producto incorrecto", "Charlotte", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                            }
                            calcultateTotal();
                        }
                }
                }
                catch (Exception ex)
                {
                    Mail.gestionaError(ex.Message);Global.error = true;
                    MessageBox.Show("ERROR", "Charlotte", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }



            }

            private void chbTarjetaRegalo_CheckedChanged(object sender, EventArgs e)
            {
                if (chbTarjetaRegalo.Checked)
                {
                    tbTk.Enabled = true;

                    tbName.Text = string.Empty;
                    tbName.Enabled = false;
                    tbIdTk.Text = string.Empty;
                    tbIdTk.Enabled = false;

                    btnSearch.Enabled = false;
                    btnDisc.Enabled = false;

                    btnGetTicket.Visible = false;
                    btnTarjetaRegalo.Visible = true;

                    lbTotal.Text = "0.00 €";

                    tbNombreVale.Enabled = true;
                    chbTicketRegalo.Checked = false;
                    chbTicketRegalo.Enabled = false;
                }
                else
                {
                    tbTk.Enabled = false;

                    tbName.Enabled = true;
                    tbIdTk.Enabled = true;

                    btnSearch.Enabled = true;
                    btnDisc.Enabled = true;

                    btnGetTicket.Visible = true;
                    btnTarjetaRegalo.Visible = false;

                    tbNombreVale.Enabled = false;

                    chbTicketRegalo.Enabled = true;
                }
            }

            private void btnTarjetaRegalo_Click(object sender, EventArgs e)
            {
                try
                {
                    long idTicket = 0;
                    double dPrice = 0, dEfectivo = 0;
                    double.TryParse(tbTk.Text.Replace(".", ","), out dPrice);

                    if (dPrice <= 0)
                    {
                        MessageBox.Show("Debe rellenar correctamente al cantidad", "Charlotte", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    }
                    else
                    {
                        //Validamos pago
                        string strMessage = validatePayment(dPrice);

                        if (strMessage != string.Empty)
                        {
                            MessageBox.Show(strMessage, "Charlotte", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                        }
                        else
                        {
                            double dCash = 0;
                            double.TryParse(tbAmount.Text.Replace(".", ","), out dCash);

                            //Guardar en BBDD
                            if (saveTarjetaRegalo(rbCard.Checked, dCash, dPrice, ref idTicket))
                            {
                                Ticket ticket = new Ticket();
                                ticket.getTarjetaRegalo(dPrice, tbNombreVale.Text, idTicket);

                                Global.mainForm.pContent.Controls.Clear();
                            }
                        }
                    }
                }
                catch (Exception ex)
                {
                    Mail.gestionaError(ex.Message);Global.error = true;
                    MessageBox.Show("ERROR", "Charlotte", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }

            private void btnDisc_Click(object sender, EventArgs e)
            {
                try
                {

                    int idTicket = 0;
                    int.TryParse(tbIdTk.Text.Trim(), out idTicket);


                    if (idTicket > 0)
                    {
                        DataTable dtTicket = Global.common.getTicketByIdSQL(idTicket);

                        if ((dtTicket == null) || (dtTicket.Rows.Count == 0))
                        {
                            MessageBox.Show("ID de ticket NO encontrado", "Charlotte", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                        }
                        else
                        {
                            bool bUsado = false, bVale = false;
                            bool.TryParse(dtTicket.Rows[0][6].ToString(), out bUsado);
                            bool.TryParse(dtTicket.Rows[0][1].ToString(), out bVale);

                            if ((bUsado) || (!bVale))
                            {
                                MessageBox.Show("ID de ticket YA USADO o NO VÁLIDO", "Charlotte", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                            }
                            else
                            {
                                dgvTicket.Rows.Add(idTicket.ToString(), "VALE", "DEVOLUCION",
                                "-" + dtTicket.Rows[0][6].ToString(), "1", "0",null, "1");
                                calcultateTotal();
                            }
                        }


                    }
                    else
                    {
                        MessageBox.Show("ID de ticket NO válido", "Charlotte", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    }

                }
                catch (Exception ex)
                {
                    Mail.gestionaError(ex.Message);Global.error = true;
                    MessageBox.Show("ERROR", "Charlotte", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        #endregion

        #region "Métodos Privados"
        private bool isFiltered()
            {

                if (String.IsNullOrEmpty(tbName.Text))
                {
                    return false;
                }
                else
                    return true;
            }

            private string getFilter()
            {
                string filter = string.Empty;

                if (!String.IsNullOrEmpty(tbName.Text))
                {
                    filter = "REFERENCIA LIKE '%" + tbName.Text + "%'";
                }

                return filter;
            }

            private string validate(bool bTicketRegalo)
            {
                try
                {

                    double dTotal = 0;

                    if (dgvTicket.Rows.Count <= 0)
                    {
                        return "Debe añadir algún artículo";
                    }

                    //Validar precio y cantidad
                    foreach (DataGridViewRow row in dgvTicket.Rows)
                    {
                        double dAuxCantidad = 0;
                        double dAuxCostDesc,dDesc, dAuxCost = 0;
                        double.TryParse(row.Cells[4].Value.ToString().Replace(".", ","), out dAuxCantidad);
                        double.TryParse(row.Cells[3].Value.ToString().Replace(".", ","), out dAuxCost);
                        double.TryParse(row.Cells[5].Value.ToString(), out dDesc);


                    if ((dAuxCantidad <= 0) || ((dAuxCost <= 0) && (row.Cells[1].ToString() == "VALE")))
                        {
                            return "Error de formato, revisar cantidades y precios";
                        }

                        dAuxCostDesc = dAuxCost - (dAuxCost * (dDesc / 100));
                        dTotal += dAuxCantidad * dAuxCostDesc;
                    }


                    if (rbCash.Checked)
                    {
                        double dCash = 0;
                        double.TryParse(tbAmount.Text, out dCash);

                        if (dCash <= 0)
                        {
                            return "Debe rellenar el cantidad de efectivo";
                        }

                        if (dCash < dTotal)
                        {
                            return "La cantidad de efectivo es menor que el total";
                        }

                    }

                    return "";

                }
                catch (Exception ex)
                {

                    Mail.gestionaError(ex.Message);Global.error = true;
                    MessageBox.Show("ERROR", "Charlotte", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return "ERROR";
                }
            }

            private string validatePayment(double dTotal)
            {
                try
                {


                    if (rbCash.Checked)
                    {
                        double dCash = 0;
                        double.TryParse(tbAmount.Text, out dCash);

                        if (dCash <= 0)
                        {
                            return "Debe rellenar el cantidad de efectivo";
                        }

                        if (dCash < dTotal)
                        {
                            return "La cantidad de efectivo es menor que el total";
                        }

                    }

                    return "";

                }
                catch (Exception ex)
                {

                    Mail.gestionaError(ex.Message);Global.error = true;
                    MessageBox.Show("ERROR", "Charlotte", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return "ERROR";
                }
            }

            private bool saveTicket(bool bTicketRegalo, bool bByCard, double dEfectivo, double dTotal, ref long idTicket)
            {
                try
                {
                    //Guardar Ticket
                    idTicket = 0;
                    idTicket = Global.common.insertTicketSQL(bTicketRegalo, DateTime.Now.ToShortDateString(), DateTime.Now.ToShortTimeString(), bByCard, dEfectivo, dTotal);

                    //Guardar lineas
                    if (idTicket > 0)
                    {
                        long idTicketLine = 0;


                        foreach (DataGridViewRow row in dgvTicket.Rows)
                        {
                            double dDesc,dAuxCostDesc,dAuxCostTicket = 0;
                            long dAuxIdItem = 0;
                            int dAuxCantTicket = 0;
                            
                            double.TryParse(row.Cells[3].Value.ToString(), out dAuxCostTicket);
                            double.TryParse(row.Cells[5].Value.ToString(), out dDesc);
                            int.TryParse(row.Cells[4].Value.ToString(), out dAuxCantTicket);
                            long.TryParse(row.Cells[0].Value.ToString(), out dAuxIdItem);

                            dAuxCostDesc = dAuxCostTicket - (dAuxCostTicket * (dDesc / 100));
                            idTicketLine = Global.common.insertLineTicketSQL(idTicket, dAuxIdItem, dAuxCostDesc, dAuxCantTicket, dDesc);

                            if (idTicketLine <= 0)
                            {
                                return false;
                            }
                        }

                    }
                    else
                    {
                        return false;
                    }

                    MessageBox.Show("Venta guardada correctamente", "Charlotte", MessageBoxButtons.OK, MessageBoxIcon.Information);

                    return true;

                }
                catch (Exception ex)
                {
                    Mail.gestionaError(ex.Message);Global.error = true;
                    MessageBox.Show("ERROR", "Charlotte", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return false;
                }
            }

            private bool updateStockItem()
            {
                bool result = false;
                try
                {
                    foreach (DataGridViewRow row in dgvTicket.Rows)
                    {
                        int iIdItem = 0;
                        int iAmount = 0;
                        double dCost = 0;
                        int.TryParse(row.Cells[0].Value.ToString(), out iIdItem);
                        int.TryParse(row.Cells[4].Value.ToString(), out iAmount);
                        double.TryParse(row.Cells[3].Value.ToString(), out dCost);

                        if (row.Cells[0].Value.ToString() != "VALE")
                        {
                            if (dCost < 0)
                            {
                                result = Global.common.updateStockItemSQL2(iIdItem, iAmount);
                            }
                            else
                            {
                                result = Global.common.updateStockItemSQL(iIdItem, iAmount);
                            }

                        }
                        else
                        {
                            result = Global.common.updateTicketSQL(iIdItem);
                        }

                        if (result)
                        {
                            MessageBox.Show("Stock Actualizado", "Charlotte", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        }
                    }

                    return result;
                }
                catch (Exception ex)
                {
                    Mail.gestionaError(ex.Message);Global.error = true;
                    MessageBox.Show("ERROR", "Charlotte", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return result;
                }
            }

            private int getNewQuantity(string sIdItem, string sCantidad, string sDisponible, ref int auxId)
            {
                int idItem, cantidad, disponible;

                int.TryParse(sIdItem, out idItem);
                int.TryParse(sCantidad, out cantidad);
                int.TryParse(sDisponible, out disponible);


                int iIdItem = 0;
                int iAmount = 0;

                try
                {
                    foreach (DataGridViewRow row in dgvTicket.Rows)
                    {
                        int.TryParse(row.Cells[0].Value.ToString(), out iIdItem);

                        if (idItem == iIdItem)
                        {
                            int.TryParse(row.Cells[4].Value.ToString(), out iAmount);

                            if ((iAmount + cantidad) > disponible)
                            {
                                return -1;
                            }
                            else
                            {
                                auxId = row.Index;
                                return iAmount + cantidad;
                            }
                        }

                    }

                    return 1;
                }
                catch (Exception ex)
                {
                    Mail.gestionaError(ex.Message);Global.error = true;
                    MessageBox.Show("ERROR", "Charlotte", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return -1;
                }
            }

            private double getTotal()
            {
                double dTotal = 0;

                foreach (DataGridViewRow row in dgvTicket.Rows)
                {
                    double dAuxCostDesc, dDesc, dPrice = 0;
                    int iAmount = 0;
                    double.TryParse(row.Cells[3].Value.ToString(), out dPrice);
                    int.TryParse(row.Cells[4].Value.ToString(), out iAmount);
                    double.TryParse(row.Cells[5].Value.ToString(), out dDesc);

                    dAuxCostDesc = dPrice - (dPrice * (dDesc / 100));

                    if (dDesc > 0)
                    {
                        dAuxCostDesc = redondea(dAuxCostDesc);
                    }

                dTotal += dAuxCostDesc * iAmount;             
            }

                return dTotal;
            }

            private void calcultateTotal()
            {
                try
                {
                    double dTotal = 0;

                    foreach (DataGridViewRow row in dgvTicket.Rows)
                    {
                        double dPrice = 0;
                        int iAmount = 0;
                        double dAuxCost,dDesc = 0;
                        double.TryParse(row.Cells[3].Value.ToString(), out dPrice);
                        double.TryParse(row.Cells[5].Value.ToString(), out dDesc);
                        int.TryParse(row.Cells[4].Value.ToString(), out iAmount);

                        dAuxCost = dPrice - (dPrice * (dDesc / 100));

                        if (dDesc > 0)
                        {
                            dAuxCost = redondea(dAuxCost);
                        }

                        dTotal += dAuxCost * iAmount;      
                    }

                    lbTotal.Text = string.Format("{0:0.00} €", dTotal).ToString();
                }
                catch (Exception ex)
                {
                    Mail.gestionaError(ex.Message);Global.error = true;
                    MessageBox.Show("ERROR", "Charlotte", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }

            private bool saveTarjetaRegalo(bool bByCard, double dEfectivo, double dTotal, ref long idTicket)
            {
                try
                {
                    //Guardar Ticket
                    idTicket = Global.common.insertTicketSQL(true, DateTime.Now.ToShortDateString(), DateTime.Now.ToShortTimeString(), bByCard, dEfectivo, dTotal);

                    //Guardar lineas
                    if (idTicket > 0)
                    {
                        long idTicketLine = 0;

                        double dCostTicket = 0;
                        double.TryParse(tbTk.Text, out dCostTicket);
                        idTicketLine = Global.common.insertLineTicketSQL(idTicket, 1, dCostTicket, 1,0);

                        if (idTicketLine <= 0)
                        {
                            return false;
                        }


                    }
                    else
                    {
                        return false;
                    }

                    MessageBox.Show("Venta guardada correctamente", "Charlotte", MessageBoxButtons.OK, MessageBoxIcon.Information);

                    return true;

                }
                catch (Exception ex)
                {
                    Mail.gestionaError(ex.Message);Global.error = true;
                    MessageBox.Show("ERROR", "Charlotte", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return false;
                }
            }

            private string validateVALE()
        {
            try
            {

                if (dgvTicket.Rows.Count <= 0)
                {
                    return "Debe añadir algún artículo";
                }

                return "";
            }
            catch (Exception ex)
            {
                Mail.gestionaError(ex.Message);Global.error = true;
                MessageBox.Show("ERROR", "Charlotte", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return "ERROR";
            }
        }
        #endregion

        private void btnValeDev_Click(object sender, EventArgs e)
        {
            try
            {
                long idTicket = 0;
                string strMessage = string.Empty;
                string[,] aItems = null;

                strMessage = validateVALE();

                if (string.IsNullOrEmpty(strMessage))
                {
                    if (saveTarjetaRegalo(false, 0, Math.Abs(getTotal()), ref idTicket) && updateStockItem())
                    {

                        aItems = new string[dgvTicket.Rows.Count, 5];

                        int cont = 0;
                        foreach (DataGridViewRow row in dgvTicket.Rows)
                        {
                            aItems[cont, 0] = row.Cells[0].Value.ToString();
                            aItems[cont, 1] = row.Cells[1].Value.ToString();
                            aItems[cont, 2] = row.Cells[2].Value.ToString();
                            aItems[cont, 3] = row.Cells[3].Value.ToString().Replace(".", ",");
                            aItems[cont, 4] = row.Cells[4].Value.ToString().Replace(".", ",");
                            cont++;
                        }


                        Ticket ticket = new Ticket();
                        ticket.getTicketVale(aItems, idTicket);

                        Global.mainForm.pContent.Controls.Clear();
                    }
                    else
                    {
                        MessageBox.Show("ERROR", "Charlotte", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    }

                }
                else
                {
                    MessageBox.Show(strMessage, "Charlotte", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                }



            }
            catch (Exception ex)
            {
                Mail.gestionaError(ex.Message);Global.error = true;
                MessageBox.Show("ERROR", "Charlotte", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private double redondea(double total)
        {
            double aux = total * 2;
            aux = Math.Round(aux,MidpointRounding.AwayFromZero);
            aux = aux / 2;

            return aux;
        }
    }
}
