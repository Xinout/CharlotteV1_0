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

            private void btnSave_Click(object sender, EventArgs e)
            {
                string strMessage = string.Empty;

                strMessage = validate();

                if (strMessage != "")
                {
                    MessageBox.Show(strMessage, "Charlotte", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                }
                else
                {
                    try
                    {
                        double dAuxTotal = 0;
                        int idProv = 0;
                        long idInvoiceInserted = 0;

                        int.TryParse(cbProv.SelectedValue.ToString(), out idProv);
                        double.TryParse(tbTotal.Text.Replace(".", ","), out dAuxTotal);
                        idInvoiceInserted = Global.common.insertInvoiceProvSQL(idProv, dtpDateInv.Value.ToShortDateString(), Math.Round(dAuxTotal,2));
                        
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
                    double dAuxTotal = 0;
                    string strMessage = string.Empty;

                    if (string.IsNullOrEmpty(tbTotal.Text))
                    {
                        strMessage += "- Debe rellenar el coste\n";
                    }
                    else
                    {
                        double.TryParse(tbTotal.Text.Replace(".", ","), out dAuxTotal);

                        if (dAuxTotal <= 0)
                        {
                            strMessage += "- El coste no tiene el formato correcto\n";
                        }
                    }

                    int idProv = 0;

                    if (cbProv.SelectedValue != null)
                    {
                        int.TryParse(cbProv.SelectedValue.ToString(), out idProv);
                    }

                    if ((idProv <= 0) || (dtpDateInv.Value == null))
                    {
                        strMessage += "El campo PROVEEDOR y FECHA deben rellenarse";
                    }

                //if (string.IsNullOrEmpty(tbCostUnit.Text))
                //{
                //    strMessage += "- Debe rellenar el coste\n";
                //}
                //else
                //{
                //    double.TryParse(tbCostUnit.Text.Replace(".", ","), out aux);

                //    if (aux <= 0)
                //    {
                //        strMessage += "- El coste no tiene el formato correcto\n";
                //    }
                //}

                //if (string.IsNullOrEmpty(tbDescription.Text))
                //{
                //    strMessage += "- Debe rellenar la descripción\n";
                //}

                //if (string.IsNullOrEmpty(tbRef.Text))
                //{
                //    strMessage += "- Debe rellenar el nombre\n";
                //}

                //if (string.IsNullOrEmpty(tbPVP.Text))
                //{
                //    strMessage += "- Debe rellenar el PVP\n";
                //}
                //else
                //{
                //    double.TryParse(tbPVP.Text.Replace(".", ","), out aux);

                //    if (aux <= 0)
                //    {
                //        strMessage += "- El PVP no tiene el formato correcto\n";
                //    }
                //}

                //if (string.IsNullOrEmpty(tbQuant.Text))
                //{
                //    strMessage += "- Debe rellenar la cantidad\n";
                //}
                //else
                //{
                //    int.TryParse(tbQuant.Text, out auxNum);

                //    if (aux <= 0)
                //    {
                //        strMessage += "- La cantidad no tiene el formato correcto\n";
                //    }
                //}

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
