using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace CharlotteV1_0
{
    public partial class ucReportYear : UserControl
    {
        public ucReportYear()
        {
            InitializeComponent();
            dtpDateInit.Value = new DateTime(DateTime.Now.Year, 1, 1);
            dtpDateClose.Value = new DateTime(DateTime.Now.Year, 12, 31);
        }

        private void btnRunReport_Click(object sender, EventArgs e)
        {
            Cursor.Current = Cursors.WaitCursor;
            Microsoft.Reporting.WinForms.ReportDataSource datasource = new 
                Microsoft.Reporting.WinForms.ReportDataSource("dsBalance",
          Global.common.getProvBalance(String.Format("{0:yyyyMMdd}", dtpDateInit.Value), String.Format("{0:yyyyMMdd}", dtpDateClose.Value)));

            DataTable dtDates = new DataTable();
            dtDates.Columns.Add("Ini");
            dtDates.Columns.Add("Fin");

            dtDates.Rows.Add(dtpDateInit.Value.ToShortDateString(),dtpDateClose.Value.ToShortDateString());

            Microsoft.Reporting.WinForms.ReportDataSource dates = new
                Microsoft.Reporting.WinForms.ReportDataSource("dsDates",
          dtDates);
            reportViewer1.LocalReport.DataSources.Clear();
            reportViewer1.LocalReport.DataSources.Add(datasource);
            reportViewer1.LocalReport.DataSources.Add(dates);
            reportViewer1.RefreshReport();
            Cursor.Current = Cursors.Default;
        }
    }
}
