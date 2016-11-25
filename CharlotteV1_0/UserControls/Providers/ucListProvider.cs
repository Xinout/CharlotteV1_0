using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.Data.Objects;
using Utils;

namespace CharlotteV1_0
{
    public partial class ucListProvider : UserControl
    {
        #region "Constructor"
            public ucListProvider()
        {
            InitializeComponent();
        }
        #endregion

        #region "Eventos"
            private void btnSearch_Click(object sender, EventArgs e)
            {

                try
                {

                    DataTable listaProveedores = null;

                    Cursor.Current = Cursors.WaitCursor;
                    dgvProv.Columns.Clear();
                    dgvProv.DataSource = null;

                    if (isFiltered())
                    {
                        string filter = getFilter();
                        listaProveedores = Global.common.getFilteredProviderSQL(filter);
                    }
                    else
                    {
                        listaProveedores = Global.common.getAllProviderSQL();
                    }


                    if ((listaProveedores != null) && (listaProveedores.Rows.Count > 0))
                    {
                        dgvProv.DataSource = listaProveedores;

                        dgvProv.Columns[0].Visible = false;
                        dgvProv.Columns[1].Width = 175;
                        dgvProv.Columns[2].Width = 300;

                        dgvProv.DefaultCellStyle.ForeColor = Color.Black;

                        DataGridViewButtonColumn colEdit = new DataGridViewButtonColumn();
                        colEdit.HeaderText = "Editar";
                        colEdit.Text = "EDITAR";
                        colEdit.UseColumnTextForButtonValue = true;

                        DataGridViewButtonColumn colDel = new DataGridViewButtonColumn();
                        colDel.HeaderText = "Eliminar";
                        colDel.Text = "ELIMINAR";
                        colDel.UseColumnTextForButtonValue = true;

                        dgvProv.EnableHeadersVisualStyles = false;

                        dgvProv.Columns.Add(colEdit);
                        dgvProv.Columns.Add(colDel);
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

            private void btnAdd_Click(object sender, EventArgs e)
            {
                Cursor.Current = Cursors.WaitCursor;
                UserControl content = new ucAddProvider();
                Global.mainForm.pContent.Controls.Clear();
                Global.mainForm.pContent.Controls.Add(content);
                Cursor.Current = Cursors.Default;
            }

            private void dgvProv_CellContentClick(object sender, DataGridViewCellEventArgs e)
            {
                var senderGrid = (DataGridView)sender;

                try
                {


                    if (senderGrid.Columns[e.ColumnIndex] is DataGridViewButtonColumn &&
                        e.RowIndex >= 0)
                    {
                        int.TryParse(senderGrid.Rows[e.RowIndex].Cells[0].Value.ToString(), out Global.idProvider);
                        if (e.ColumnIndex == 4)
                        {
                            Cursor.Current = Cursors.WaitCursor;
                            UserControl content = new ucEditProvider();
                            Global.mainForm.pContent.Controls.Clear();
                            Global.mainForm.pContent.Controls.Add(content);
                            Cursor.Current = Cursors.Default;
                        }
                        else if (e.ColumnIndex == 5)
                        {
                            DialogResult result = MessageBox.Show("¿Quieres eliminar el proveedor?", "Charlotte", MessageBoxButtons.YesNo, MessageBoxIcon.Question);

                            if (result == DialogResult.Yes)
                            {
                                if (Global.common.deleteProviderSQL(Global.idProvider))
                                {
                                    Global.idProvider = 0;
                                    dgvProv.Columns.Clear();
                                    MessageBox.Show("Proveedor eliminado correctamente", "Charlotte", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
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
