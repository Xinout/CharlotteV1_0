using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Text;
using System.Windows.Forms;
using Utils;
using System.Configuration;


namespace CharlotteV1_0
{
    public partial class Main : Form
    {
        #region "Constructor"
            public Main()
            {
                InitializeComponent();
            }
        #endregion

        #region Public Methods 
            public bool LoadForm()
        {
            Cursor.Current = Cursors.WaitCursor;
            UserControl content = new ucListProvider();
            Global.mainForm.pContent.Controls.Clear();
            pContent.Controls.Add(content);
            Cursor.Current = Cursors.Default;

            return true;
        }
        #endregion

        #region Eventos
            private void btnProvider_Click(object sender, EventArgs e)
            {
                LoadForm();
            }

            private void btnExit_Click(object sender, EventArgs e)
            {
                try
                {
                Application.Exit();
            }
                catch (Exception ex)
                {
                    Mail.gestionaError(ex.Message);Global.error = true;
                    MessageBox.Show("ERROR", "Charlotte", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    Application.Exit();
                }
            }

            private void button4_Click(object sender, EventArgs e)
            {
                try
                {
                    UserControl content = new ucGetTicket();
                    Global.mainForm.pContent.Controls.Clear();
                    pContent.Controls.Add(content);

                }
                catch (Exception ex)
                {
                    Mail.gestionaError(ex.Message);Global.error = true;
                    MessageBox.Show("ERROR", "Charlotte", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }

            private void btnInvoices_Click(object sender, EventArgs e)
            {
                UserControl content = new ucListInvoiceProv();
                Global.mainForm.pContent.Controls.Clear();
                pContent.Controls.Add(content);
            }

            private void btnStock_Click(object sender, EventArgs e)
            {
                UserControl content = new ucListItem();
                Global.mainForm.pContent.Controls.Clear();
                pContent.Controls.Add(content);
            }

            private void btnCierreCaja_Click(object sender, EventArgs e)
            {
                try
                {
                    DataTable sales = Global.common.getSalesTodaySQL(DateTime.Now.ToShortDateString());


                    if (sales.Rows.Count >= 0)
                    {
                        Ticket ticket = new Ticket();
                        ticket.getClosingCash(sales, DateTime.Now.ToShortDateString());
                    }

                }
                catch (Exception ex)
                {
                    Mail.gestionaError(ex.Message);Global.error = true;
                    MessageBox.Show("ERROR", "Charlotte", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }


            }

            private void btnSales_Click(object sender, EventArgs e)
            {
                UserControl content = new ucSales();
                Global.mainForm.pContent.Controls.Clear();
                pContent.Controls.Add(content);
            }

            private void btnManualSale_Click(object sender, EventArgs e)
            {
                UserControl content = new ucManualSale();
                Global.mainForm.pContent.Controls.Clear();
                pContent.Controls.Add(content);
            }

            private void Main_FormClosed(object sender, FormClosedEventArgs e)
            {
                try
                {
                    if (ConfigurationManager.AppSettings["Debug"].ToString() != "Y") {

                        Cursor.Current = Cursors.WaitCursor;
                        Mail.backup();
                        if (Global.error)
                        {
                            Mail.sendMail();
                        }          
                        Cursor.Current = Cursors.Default;
                    }
                }
                    catch (Exception ex)
                    {
                        Mail.gestionaError(ex.Message);Global.error = true;
                        MessageBox.Show("ERROR", "Charlotte", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        Application.Exit();
                    }
                }

            private void btnHistoric_Click(object sender, EventArgs e)
            {
                UserControl content = new ucHistoric();
                Global.mainForm.pContent.Controls.Clear();
                pContent.Controls.Add(content);
            }

        #endregion

        private void btnReports_Click(object sender, EventArgs e)
        {
            UserControl content = new ucReportYear();
            Global.mainForm.pContent.Controls.Clear();
            pContent.Controls.Add(content);
        }
    }
    
}
