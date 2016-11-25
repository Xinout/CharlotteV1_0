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
    public partial class ucViewTicket : UserControl
    {       
        #region "Constructor"
            public ucViewTicket()
        {
            InitializeComponent();
        }
        #endregion

        #region "Eventos"
            private void btnBack_Click(object sender, EventArgs e)
            {
                try
                {
                    Cursor.Current = Cursors.WaitCursor;
                    UserControl content = new ucSales();
                    Global.mainForm.pContent.Controls.Clear();
                    Global.mainForm.pContent.Controls.Add(content);
                    Cursor.Current = Cursors.Default;
                }
                catch (Exception ex)
                {
                    Mail.gestionaError(ex.Message);Global.error = true;
                    MessageBox.Show("ERROR", "Charlotte", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }

            private void btnRemove_Click(object sender, EventArgs e)
            {
                try
                {
                    DialogResult result = MessageBox.Show("¿Quieres anular el ticket?", "Charlotte", MessageBoxButtons.YesNo, MessageBoxIcon.Question);

                    if (result == DialogResult.Yes)
                    {
                        if (Global.common.deleteTicketSQL(Global.idTicket))
                        {
                            Global.idTicket = 0;

                            MessageBox.Show("Ticket eliminado correctamente", "Charlotte", MessageBoxButtons.OK, MessageBoxIcon.Information);
                            Cursor.Current = Cursors.WaitCursor;
                            UserControl content = new ucListProvider();
                            Global.mainForm.pContent.Controls.Clear();
                            Global.mainForm.pContent.Controls.Add(content);
                            Cursor.Current = Cursors.Default;
                        }
                        else
                        {
                            MessageBox.Show("ERROR", "Charlotte", MessageBoxButtons.OK, MessageBoxIcon.Information);
                            Cursor.Current = Cursors.WaitCursor;
                            UserControl content = new ucListProvider();
                            Global.mainForm.pContent.Controls.Clear();
                            Global.mainForm.pContent.Controls.Add(content);
                            Cursor.Current = Cursors.Default;
                        }
                    }
                    else if (result == DialogResult.No)
                    {
                        Cursor.Current = Cursors.WaitCursor;
                        UserControl content = new ucListProvider();
                        Global.mainForm.pContent.Controls.Clear();
                        Global.mainForm.pContent.Controls.Add(content);
                        Cursor.Current = Cursors.Default;
                    }
                }
                catch (Exception ex)
                {
                    Mail.gestionaError(ex.Message);Global.error = true;
                    MessageBox.Show("ERROR", "Charlotte", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }

            private void ucViewTicket_Load(object sender, EventArgs e)
            {
                LoadLines();
            }
        #endregion

        #region "Métodos Privados"
        private void LoadLines()
            {
                try
                {
                    DataTable listaItems = null;

                    Cursor.Current = Cursors.WaitCursor;

                    dgvItem.Columns.Clear();
                    dgvItem.DataSource = null;

                    listaItems = Global.common.getAllLinesTicketSQL(Global.idTicket);

                    if ((listaItems != null) && (listaItems.Rows.Count > 0))
                    {
                        dgvItem.DataSource = listaItems;

                    dgvItem.Columns[0].Width = 150;
                    dgvItem.Columns[1].Width = 320;

                    dgvItem.DefaultCellStyle.ForeColor = Color.Black;


                    dgvItem.EnableHeadersVisualStyles = false;

    
                }
                    else
                    {
                        MessageBox.Show("No hay datos", "Charlotte", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    }

                Cursor.Current = Cursors.Default;
                }
                catch(Exception ex)
                {
                    Mail.gestionaError(ex.Message);Global.error = true;
                    MessageBox.Show("ERROR", "Charlotte", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        #endregion

       
    }
}
