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
    public partial class ucEditInvoiceProv : UserControl
    {
        public ucEditInvoiceProv()
        {
            InitializeComponent();
        }

        private void ucEditInvoiceProv_Load(object sender, EventArgs e)
        {
            LoadLines();
        }

        private void LoadLines()
        {
            try
            {
                DataTable listaItems = null;

                Cursor.Current = Cursors.WaitCursor;

                listaItems = Global.common.getLineInvoiceSQL(Global.idInvoiceLine);

                if ((listaItems != null) && (listaItems.Rows.Count > 0))
                {
                    tbCantidad.Text = listaItems.Rows[0][3].ToString();
                    tbImporte.Text = string.Format("{0:0.00}",listaItems.Rows[0][4]).ToString().Replace(".",",");

                }
                else
                {
                    MessageBox.Show("No hay datos", "Charlotte", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }

                Cursor.Current = Cursors.Default;
            }
            catch (Exception ex)
            {
                Mail.gestionaError(ex.Message); Global.error = true;
                MessageBox.Show("ERROR", "Charlotte", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btnBack_Click(object sender, EventArgs e)
        {
            try
            {
                Cursor.Current = Cursors.WaitCursor;
                UserControl content = new ucViewInvoiceProv();
                Global.mainForm.pContent.Controls.Clear();
                Global.mainForm.pContent.Controls.Add(content);
                Cursor.Current = Cursors.Default;
            }
            catch (Exception ex)
            {
                Mail.gestionaError(ex.Message); Global.error = true;
                MessageBox.Show("ERROR", "Charlotte", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btnEdit_Click(object sender, EventArgs e)
        {
            string strMessage = string.Empty;

            try
            {
                strMessage = validate();

                if (string.IsNullOrEmpty(strMessage))
                { 

                    if (Global.common.updateProviderInvoiceLineSQL(Global.idInvoiceLine, tbCantidad.Text, tbImporte.Text.Replace(",",".")))
                    {
                        //DataTable listaLineas = null;
                        //listaLineas = Global.common.getAllLinesInvoiceSQL(Global.idInvoice);

                        //double dTotal = 0;

                        //foreach (DataRow row in listaLineas.Rows)
                        //{
                        //    double dAux = 0;
                        //    int dAuxInt = 0;

                        //    double.TryParse(row[3].ToString(), out dAux);
                        //    int.TryParse(row[4].ToString(), out dAuxInt);

                        //    dTotal += dAux * dAuxInt;
                        //}

                        MessageBox.Show("Linea de factura actualizada", "Charlotte", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                        Cursor.Current = Cursors.WaitCursor;
                        UserControl content = new ucViewInvoiceProv();
                        Global.mainForm.pContent.Controls.Clear();
                        Global.mainForm.pContent.Controls.Add(content);
                        Cursor.Current = Cursors.Default;
                    }

                }
                else
                {
                    MessageBox.Show(strMessage, "Charlotte", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                }
            }
            catch (Exception ex)
            {
                Mail.gestionaError(ex.Message); Global.error = true;
                MessageBox.Show("ERROR", "Charlotte", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private string validate()
        {
            try
            {
                double dCash = 0;
                int iCant = 0;

                double.TryParse(tbImporte.Text.Replace(".",","), out dCash);
                int.TryParse(tbCantidad.Text, out iCant);

                if (dCash <= 0)
                {
                   return "Debe rellenar el importe";
                }

                tbImporte.Text = string.Format("{0:0.00}", Math.Round(dCash, 2)).ToString().Replace(".", ",");  


                if (iCant <= 0)
                {
                    return "Debe rellenar la cantidad";
                }



                return "";

            }
            catch (Exception ex)
            {

                Mail.gestionaError(ex.Message); Global.error = true;
                MessageBox.Show("ERROR", "Charlotte", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return "ERROR";
            }
        }
    }
}
