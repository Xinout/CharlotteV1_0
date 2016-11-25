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
    public partial class ucSales : UserControl
    {
        #region "Constructor"
            public ucSales()
        {
            InitializeComponent();
        }
        #endregion

        #region "Eventos"
            private void btnSearch_Click(object sender, EventArgs e)
            {
                try
                {
                    DataTable listaTickets = null;

                    Cursor.Current = Cursors.WaitCursor;

                    dgvSales.Columns.Clear();
                    dgvSales.DataSource = null;

                    int aux = 0;

                    int.TryParse(tbIdTicket.Text, out aux);

                    if (aux > 0)
                    {
                        listaTickets = Global.common.getTicketByIdSQL(aux);
                    }
                    else
                    {
                        listaTickets = Global.common.getAllTicketsSQL();
                    }


                    if ((listaTickets != null) && (listaTickets.Rows.Count > 0))
                    {
                        dgvSales.DataSource = listaTickets;

                        //Ocultamos columnas
                        dgvSales.Columns[1].Visible = false;
                        dgvSales.Columns[4].Visible = false;
                        dgvSales.Columns[5].Visible = false;
                        dgvSales.Columns[7].Visible = false;

                        dgvSales.DefaultCellStyle.ForeColor = Color.Black;

                        DataGridViewButtonColumn colEdit = new DataGridViewButtonColumn();
                        colEdit.HeaderText = "Ver detalle";
                        colEdit.Text = "VER DETALLE";
                        colEdit.UseColumnTextForButtonValue = true;
                        colEdit.Width = 200;

                        DataGridViewButtonColumn colDel = new DataGridViewButtonColumn();
                        colDel.HeaderText = "Anular ticket";
                        colDel.Text = "ANULAR TICKET";
                        colDel.UseColumnTextForButtonValue = true;
                        colDel.Width = 170;

                        dgvSales.EnableHeadersVisualStyles = false;

                        dgvSales.Columns.Add(colEdit);
                        dgvSales.Columns.Add(colDel);
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

            private void dgvSales_CellContentClick(object sender, DataGridViewCellEventArgs e)
            {
                var senderGrid = (DataGridView)sender;

                try
                {
                    if (senderGrid.Columns[e.ColumnIndex] is DataGridViewButtonColumn &&
                    e.RowIndex >= 0)
                    {
                        int.TryParse(senderGrid.Rows[e.RowIndex].Cells[0].Value.ToString(), out Global.idTicket);
                        if (e.ColumnIndex == 8)
                        {

                            Cursor.Current = Cursors.WaitCursor;
                            UserControl content = new ucViewTicket();
                            Global.mainForm.pContent.Controls.Clear();
                            Global.mainForm.pContent.Controls.Add(content);
                            Cursor.Current = Cursors.Default;

                        }
                        else if (e.ColumnIndex == 9)
                        {

                            DialogResult result = MessageBox.Show("¿Quieres anular el ticket?", "Charlotte", MessageBoxButtons.YesNo, MessageBoxIcon.Question);

                            if (result == DialogResult.Yes)
                            {
                                if (Global.common.deleteTicketSQL(Global.idTicket))
                                {
                                    Global.idTicket = 0;
                                    dgvSales.Columns.Clear();
                                    MessageBox.Show("Ticket eliminado correctamente", "Charlotte", MessageBoxButtons.OK, MessageBoxIcon.Information);
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
    }
}
