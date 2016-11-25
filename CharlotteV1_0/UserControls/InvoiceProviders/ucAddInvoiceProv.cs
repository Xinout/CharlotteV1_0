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
    public partial class ucAddInvoiceProv : UserControl
    {
        
        #region "Constructor"
            public ucAddInvoiceProv()
            {
                InitializeComponent();
                loadCombo();
            }
        #endregion

        #region "Eventos"
            private void btnBack_Click(object sender, EventArgs e)
            {
                UserControl content = new ucListInvoiceProv();
                Global.mainForm.pContent.Controls.Clear();
                Global.mainForm.pContent.Controls.Add(content);
            }

            private void btnAddItem_Click(object sender, EventArgs e)
            {
                try
                {
                    dgvItemInvProv.DefaultCellStyle.ForeColor = Color.Black;
                    dgvItemInvProv.EnableHeadersVisualStyles = false;
                    string texto = validate();
                    if (string.IsNullOrEmpty(texto))
                    {
                        dgvItemInvProv.Rows.Add(tbRef.Text.Trim().ToUpper(), tbDescription.Text.ToUpper(), Convert.ToDouble(tbCostUnit.Text).ToString("#.##"), Convert.ToDouble(tbPVP.Text).ToString("#.##"), Convert.ToInt32(tbQuant.Text));
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

            private void dgvItemInvProv_CellContentClick(object sender, DataGridViewCellEventArgs e)
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
                                dgvItemInvProv.Rows.RemoveAt(e.RowIndex);
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

            private void btnSave_Click(object sender, EventArgs e)
            {

                int idProv = 0;

                if (cbProv.SelectedValue != null)
                {
                    int.TryParse(cbProv.SelectedValue.ToString(), out idProv);
                }


                if ((idProv <= 0) || (dtpDateInv.Value == null))
                {
                    MessageBox.Show("El campo PROVEEDOR y FECHA deben rellenarse", "Charlotte", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                }
                else if (dgvItemInvProv.Rows.Count <= 0)
                {
                    MessageBox.Show("Debe añadir algún articulo", "Charlotte", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                }
                else
                {

                    long idInvoiceInserted = 0;
                    long idItemInserted = 0;

                    try
                    {
                        idInvoiceInserted = Global.common.insertInvoiceProvSQL(idProv, dtpDateInv.Value.ToShortDateString());

                        if (idInvoiceInserted > 0)
                        {
                            //Insertamos articulos y linea de factura
                            foreach (DataGridViewRow row in dgvItemInvProv.Rows)
                            {
                                double pvp, cost = 0;
                                int cantidad = 0;

                                double.TryParse(row.Cells[3].Value.ToString(), out pvp);
                                double.TryParse(row.Cells[2].Value.ToString(), out cost);
                                int.TryParse(row.Cells[4].Value.ToString(), out cantidad);

                                idItemInserted = Global.common.insertItemSQL(row.Cells[0].Value.ToString(), idInvoiceInserted, row.Cells[1].Value.ToString(), pvp, cantidad);

                                if (idItemInserted > 0)
                                {
                                    idItemInserted = Global.common.insertLineInvoiceSQL(idInvoiceInserted, idItemInserted, cost, cantidad);
                                }
                                else
                                {
                                    throw new Exception();
                                }
                            }


                        }
                        else
                        {
                            throw new Exception();
                        }

                        MessageBox.Show("Datos guardados correctamente", "Charlotte", MessageBoxButtons.OK, MessageBoxIcon.Information);

                        UserControl content = new ucListInvoiceProv();
                        Global.mainForm.pContent.Controls.Clear();
                        Global.mainForm.pContent.Controls.Add(content);
                    }
                    catch (Exception ex)
                    {
                        Mail.gestionaError(ex.Message);Global.error = true;
                        MessageBox.Show("ERROR", "Charlotte", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                }

            }
        #endregion

        #region "Métodos Privados"

        private void loadCombo()
            {
                try
                {
                    DataTable listaProveedores = Global.common.getAllProviderSQL();

                    if ((listaProveedores != null) && (listaProveedores.Rows.Count > 0))
                    {
                        cbProv.DataSource = listaProveedores.DefaultView;
                        cbProv.DisplayMember = "NOMBRE";
                        cbProv.ValueMember = "ID";
                    }
                }
                catch (Exception ex)
                {
                    Mail.gestionaError(ex.Message);Global.error = true;
                    MessageBox.Show("ERROR", "Charlotte", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }

            private string validate()
            {
                try
                {
                    double aux = 0;
                    int auxNum = 0;
                    string strMessage = string.Empty;

                    if (string.IsNullOrEmpty(tbCostUnit.Text))
                    {
                        strMessage += "- Debe rellenar el coste\n";
                    }
                    else
                    {
                        double.TryParse(tbCostUnit.Text.Replace(".", ","), out aux);

                        if (aux <= 0)
                        {
                            strMessage += "- El coste no tiene el formato correcto\n";
                        }
                    }

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

        #endregion
    }
}
