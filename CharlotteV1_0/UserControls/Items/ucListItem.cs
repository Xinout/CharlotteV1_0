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
    public partial class ucListItem : UserControl
    {
        #region "Constructor"
            public ucListItem()
        {
            InitializeComponent();
        }
        #endregion

        #region "Eventos"
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
                        if (!String.IsNullOrEmpty(tbName.Text))
                        {
                            listaItems = Global.common.getFilteredItemSQL(filter);
                        }
                        else
                        {
                            listaItems = Global.common.getFilteredItemByProvSQL(filter);
                        }
                        
                    }
                    else
                    {
                        listaItems = Global.common.getAllItemSQL();
                    }


                    if ((listaItems != null) && (listaItems.Rows.Count > 0))
                    {
                        dgvItem.DataSource = listaItems;

                        //Ocultamos columnas
                        dgvItem.Columns[0].Visible = false;
                        dgvItem.Columns[2].Visible = false;

                        dgvItem.Columns[1].Width = 130;
                        dgvItem.Columns[3].Width = 245;

                        dgvItem.DefaultCellStyle.ForeColor = Color.Black;

                        DataGridViewButtonColumn colEdit = new DataGridViewButtonColumn();
                        colEdit.HeaderText = "Editar";
                        colEdit.Text = "EDITAR";
                        colEdit.UseColumnTextForButtonValue = true;

                        DataGridViewButtonColumn colDel = new DataGridViewButtonColumn();
                        colDel.HeaderText = "Eliminar";
                        colDel.Text = "ELIMINAR";
                        colDel.UseColumnTextForButtonValue = true;

                        dgvItem.EnableHeadersVisualStyles = false;

                        dgvItem.Columns.Add(colEdit);
                        dgvItem.Columns.Add(colDel);
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
                var senderGrid = (DataGridView)sender;

                try
                {


                    if (senderGrid.Columns[e.ColumnIndex] is DataGridViewButtonColumn &&
                        e.RowIndex >= 0)
                    {
                        int.TryParse(senderGrid.Rows[e.RowIndex].Cells[0].Value.ToString(), out Global.idItem);
                        if (e.ColumnIndex == 6)
                        {
                            if (Global.idItem == 1)
                            {
                                MessageBox.Show("Este articulo no se puede editar", "Charlotte", MessageBoxButtons.OK, MessageBoxIcon.Information);
                            }
                            else
                            {
                                Cursor.Current = Cursors.WaitCursor;
                                UserControl content = new ucEditItem();
                                Global.mainForm.pContent.Controls.Clear();
                                Global.mainForm.pContent.Controls.Add(content);
                                Cursor.Current = Cursors.Default;
                            }
                        }
                        else if (e.ColumnIndex == 7)
                        {
                            if (Global.idItem == 1)
                            {
                                MessageBox.Show("Este articulo no se puede eliminar", "Charlotte", MessageBoxButtons.OK, MessageBoxIcon.Information);
                            }
                            else
                            {
                                DialogResult result = MessageBox.Show("¿Quieres eliminar el articulo?", "Charlotte", MessageBoxButtons.YesNo, MessageBoxIcon.Question);

                                if (result == DialogResult.Yes)
                                {
                                    if (Global.common.deleteItemSQL(Global.idItem))
                                    {
                                        Global.idItem = 0;
                                        dgvItem.Columns.Clear();
                                        MessageBox.Show("Articulo eliminado correctamente", "Charlotte", MessageBoxButtons.OK, MessageBoxIcon.Information);
                                    }
                                }
                                else if (result == DialogResult.No)
                                {
                                    //...
                                }
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

                if ((String.IsNullOrEmpty(tbName.Text) && (String.IsNullOrEmpty(tbProv.Text))))
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
                else if (!String.IsNullOrEmpty(tbProv.Text))
                {
                    filter = "PROVEEDOR.NOMBRE LIKE '%" + tbProv.Text + "%'";
                }

            return filter;
            }
        #endregion
    }
}
