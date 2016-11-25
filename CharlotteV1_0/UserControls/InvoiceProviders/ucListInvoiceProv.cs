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
    public partial class ucListInvoiceProv : UserControl
    {
        #region "Constructor"
            public ucListInvoiceProv()
            {
                InitializeComponent();
            }
        #endregion

        #region "Eventos"
            private void btnAdd_Click(object sender, EventArgs e)
            {
                UserControl content = new ucAddInvoiceProv();
                Global.mainForm.pContent.Controls.Clear();
                Global.mainForm.pContent.Controls.Add(content);
            }

            private void btnSearch_Click(object sender, EventArgs e)
            {
                try
                {
                    DataTable listaFacturas = null;

                    Cursor.Current = Cursors.WaitCursor;

                    dgvInvProv.Columns.Clear();
                    dgvInvProv.DataSource = null;

                    if (isFiltered())
                    {
                        string filter = getFilter();
                        listaFacturas = Global.common.getFilteredInvoiceProvSQL(filter);
                    }
                    else
                    {
                        listaFacturas = Global.common.getAllInvoiceProviderSQL();
                    }


                    if ((listaFacturas != null) && (listaFacturas.Rows.Count > 0))
                    {
                        dgvInvProv.DataSource = listaFacturas;

                        dgvInvProv.DefaultCellStyle.ForeColor = Color.Black;

                    DataGridViewButtonColumn colEdit = new DataGridViewButtonColumn();
                    colEdit.HeaderText = "Ver detalle";
                    colEdit.Text = "VER DETALLE";
                    colEdit.UseColumnTextForButtonValue = true;
                    colEdit.Width = 200;

                    DataGridViewButtonColumn colDel = new DataGridViewButtonColumn();
                        colDel.HeaderText = "Anular ticket";
                        colDel.Text = "ANULAR FACTURA";
                        colDel.UseColumnTextForButtonValue = true;
                        colDel.Width = 170;

                        dgvInvProv.EnableHeadersVisualStyles = false;

                        dgvInvProv.Columns.Add(colEdit);
                        dgvInvProv.Columns.Add(colDel);
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

            private void dgvInvProv_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            var senderGrid = (DataGridView)sender;

            try
            {
                if (senderGrid.Columns[e.ColumnIndex] is DataGridViewButtonColumn &&
                e.RowIndex >= 0)
                {
                    int.TryParse(senderGrid.Rows[e.RowIndex].Cells[0].Value.ToString(), out Global.idInvoice);
                    if (e.ColumnIndex == 3)
                    {
                        Cursor.Current = Cursors.WaitCursor;
                        UserControl content = new ucViewInvoiceProv();
                        Global.mainForm.pContent.Controls.Clear();
                        Global.mainForm.pContent.Controls.Add(content);
                        Cursor.Current = Cursors.Default;
                    }
                    else if (e.ColumnIndex == 4)
                    {

                        DialogResult result = MessageBox.Show("¿Quieres anular la factura?", "Charlotte", MessageBoxButtons.YesNo, MessageBoxIcon.Question);

                        if (result == DialogResult.Yes)
                        {
                            if (Global.common.deleteInvProvSQL(Global.idInvoice))
                            {
                                dgvInvProv.Columns.Clear();
                                MessageBox.Show("Factura eliminada correctamente", "Charlotte", MessageBoxButtons.OK, MessageBoxIcon.Information);
                            }
                            else
                            {
                                MessageBox.Show("ERROR", "Charlotte", MessageBoxButtons.OK, MessageBoxIcon.Information);
                            }
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
                    filter = "NOMBRE LIKE '%" + tbName.Text + "%'";
                }

                return filter;
            }
        #endregion      
    }
}
