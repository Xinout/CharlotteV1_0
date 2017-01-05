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
    public partial class ucManualSale : UserControl
    {
        #region "Constructor"
            public ucManualSale()
        {
            InitializeComponent();
        }
        #endregion

        #region "Eventos"
            private void btnAddItem_Click(object sender, EventArgs e)
            {
                try
                {
                    dgvItem.DefaultCellStyle.ForeColor = Color.Black;
                    dgvItem.EnableHeadersVisualStyles = false;
                    string texto = validate();
                    if (string.IsNullOrEmpty(texto))
                    {
                        dgvItem.Rows.Add(tbRef.Text.Trim().ToUpper(), tbDescription.Text.ToUpper(), Convert.ToDouble(tbPVP.Text).ToString("#.##"), Convert.ToInt32(tbQuant.Text),Convert.ToInt32(tbDescuento.Text));
                        calcultateTotal();
                    }
                    else
                    {
                        MessageBox.Show(texto, "Charlotte", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    }
                }
                catch (Exception ex)
                {
                    Mail.gestionaError(ex.Message);Global.error = true;
                    MessageBox.Show("ERROR", "Charlotte", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }

            private void dgvItem_CellContentClick(object sender, DataGridViewCellEventArgs e)
            {
                var senderGrid = (DataGridView)sender;

                try
                {
                    if (senderGrid.Columns[e.ColumnIndex] is DataGridViewButtonColumn &&
                    e.RowIndex >= 0)
                    {
                        int.TryParse(senderGrid.Rows[e.RowIndex].Cells[0].Value.ToString(), out Global.idProvider);

                        if (e.ColumnIndex == 5)
                        {
                            DialogResult result = MessageBox.Show("¿Quieres eliminar el articulo?", "Charlotte", MessageBoxButtons.YesNo, MessageBoxIcon.Question);

                            if (result == DialogResult.Yes)
                            {
                                dgvItem.Rows.RemoveAt(e.RowIndex);
                                calcultateTotal();
                            }
                            else if (result == DialogResult.No)
                            {
                                //...
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

            private void rbCard_CheckedChanged(object sender, EventArgs e)
            {
                if (rbCard.Checked)
                {
                    tbAmount.Text = string.Empty;
                    tbAmount.Enabled = false;
                }
            }

            private void rbCash_CheckedChanged(object sender, EventArgs e)
            {
                if (rbCash.Checked)
                {
                    tbAmount.Enabled = true;
                }
            }

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

                        //if (saveTicket(bTicketRegalo, !bEfectivo, dEfectivo, getTotal(), ref idTicket))
                        //{

                            aItems = new string[dgvItem.Rows.Count, 6];

                            int cont = 0;
                            foreach (DataGridViewRow row in dgvItem.Rows)
                            {
                                aItems[cont, 0] = "0";
                                aItems[cont, 1] = row.Cells[0].Value.ToString();
                                aItems[cont, 2] = row.Cells[1].Value.ToString();
                                aItems[cont, 3] = row.Cells[2].Value.ToString().Replace(".", ",");
                                aItems[cont, 4] = row.Cells[3].Value.ToString().Replace(".", ",");
                                aItems[cont, 5] = row.Cells[4].Value.ToString().Replace(".", ",");
                        cont++;
                            }


                            Ticket ticket = new Ticket();
                            ticket.getTicket(aItems, bEfectivo, dEfectivo, false, idTicket);

                            if (bTicketRegalo)
                            {
                                ticket.getTicket(aItems, bEfectivo, dEfectivo, true, idTicket);
                            }

                            Global.mainForm.pContent.Controls.Clear();


                        /*}
                        else
                        {
                            MessageBox.Show("Error, consultar administrador", "Charlotte", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                        }*/
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
        #endregion

        #region "Métodos Privados"
        private string validate()
            {
                try
                {
                    double aux = 0;
                    int auxNum = 0;
                    string strMessage = string.Empty;

                    if (string.IsNullOrEmpty(tbDescription.Text))
                    {
                        strMessage += "- Debe rellenar la descripción\n";
                    }

                    if (string.IsNullOrEmpty(tbRef.Text))
                    {
                        strMessage += "- Debe rellenar el nombre\n";
                    }

                    if (string.IsNullOrEmpty(tbPVP.Text))
                    {
                        strMessage += "- Debe rellenar el PVP\n";
                    }
                    else
                    {
                        double.TryParse(tbPVP.Text.Replace(".", ","), out aux);

                        if (aux <= 0)
                        {
                            strMessage += "- El PVP no tiene el formato correcto\n";
                        }
                    }

                    if (string.IsNullOrEmpty(tbQuant.Text))
                    {
                        strMessage += "- Debe rellenar la cantidad\n";
                    }
                    else
                    {
                        int.TryParse(tbQuant.Text, out auxNum);

                        if (aux <= 0)
                        {
                            strMessage += "- La cantidad no tiene el formato correcto\n";
                        }
                    }

                    return strMessage;
                }
                catch (Exception ex)
                {
                    Mail.gestionaError(ex.Message);Global.error = true;
                    MessageBox.Show("ERROR", "Charlotte", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return "ERROR";
                }
            }

            private string validate(bool bTicketRegalo)
            {
                try
                {

                    double dTotal = 0;

                    if (dgvItem.Rows.Count <= 0)
                    {
                        return "Debe añadir algún artículo";
                    }

                    //Validar precio y cantidad
                    foreach (DataGridViewRow row in dgvItem.Rows)
                    {
                        double dAuxCantidad = 0;
                        double dAuxCost = 0;
                        double.TryParse(row.Cells[3].Value.ToString().Replace(".", ","), out dAuxCantidad);
                        double.TryParse(row.Cells[2].Value.ToString().Replace(".", ","), out dAuxCost);

                        if ((dAuxCantidad <= 0) || ((dAuxCost <= 0) && (row.Cells[1].ToString() == "VALE")))
                        {
                            return "Error de formato, revisar cantidades y precios";
                        }

                        dTotal += dAuxCantidad * dAuxCost;
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

            private double getTotal()
            {
                double dTotal = 0;

                try
                {
                    foreach (DataGridViewRow row in dgvItem.Rows)
                    {
                        double dPrice = 0;
                        int iAmount = 0;
                        double dAuxCost, dDesc = 0;
                        double.TryParse(row.Cells[2].Value.ToString(), out dPrice);
                        int.TryParse(row.Cells[3].Value.ToString(), out iAmount);
                        double.TryParse(row.Cells[4].Value.ToString(), out dDesc);

                        dAuxCost = dPrice - (dPrice * (dDesc / 100));

                        if (dDesc > 0)
                        {
                            dAuxCost = redondea(dAuxCost);
                        }

                    dTotal += dAuxCost * iAmount;
                }
                }
                catch (Exception ex)
                {
                    Mail.gestionaError(ex.Message);Global.error = true;
                    MessageBox.Show("ERROR", "Charlotte", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }

                return dTotal;
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

                        foreach (DataGridViewRow row in dgvItem.Rows)
                        {
                            double dAuxCostTicket = 0;
                            long dAuxIdItem = 0;
                            int dAuxCantTicket = 0;
                            double.TryParse(row.Cells[3].Value.ToString(), out dAuxCostTicket);
                            int.TryParse(row.Cells[4].Value.ToString(), out dAuxCantTicket);
                            long.TryParse(row.Cells[0].Value.ToString(), out dAuxIdItem);
                            idTicketLine = Global.common.insertLineTicketSQL(idTicket, dAuxIdItem, dAuxCostTicket, dAuxCantTicket,0);

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

            private void calcultateTotal()
            {
                try
                {
                    double dTotal = 0;

                    foreach (DataGridViewRow row in dgvItem.Rows)
                    {
                        double dPrice = 0;
                        int iAmount = 0;
                        double dAuxCost, dDesc = 0;
                        double.TryParse(row.Cells[2].Value.ToString(), out dPrice);
                        int.TryParse(row.Cells[3].Value.ToString(), out iAmount);
                        double.TryParse(row.Cells[4].Value.ToString(), out dDesc);

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

            private double redondea(double total)
            {
                double aux = total * 2;
                aux = Math.Round(aux, MidpointRounding.AwayFromZero);
                aux = aux / 2;

                return aux;
            }
        #endregion
    }
}
