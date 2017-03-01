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
    public partial class ucHistoric : UserControl
    {
        public ucHistoric()
        {
            InitializeComponent();
        }

        private void btnHistoric_Click(object sender, EventArgs e)
        {
            try
            {
                DataTable sales = Global.common.getSalesTodaySQL(dtpDateClose.Value.ToShortDateString());


                if (sales.Rows.Count >= 0)
                {
                    long idFactura = 0;
                    DataTable dt = Global.common.getIdCloseDateSQL(dtpDateClose.Value.ToShortDateString());
                    if (dt.Rows.Count == 0)
                    {
                        idFactura = Global.common.insertCloseDateSQL(dtpDateClose.Value.ToShortDateString());
                    }
                    else
                    {
                        long.TryParse(dt.Rows[0][0].ToString(), out idFactura);
                    }
                    Ticket ticket = new Ticket();
                    ticket.getClosingCash(sales, dtpDateClose.Value.ToShortDateString(), idFactura);
                }

            }
            catch (Exception ex)
            {
                Mail.gestionaError(ex.Message);Global.error = true;
                MessageBox.Show("ERROR", "Charlotte", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
    }
}
