namespace CharlotteV1_0
{
    partial class ucReportYear
    {
        /// <summary> 
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary> 
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Component Designer generated code

        /// <summary> 
        /// Required method for Designer support - do not modify 
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.reportViewer1 = new Microsoft.Reporting.WinForms.ReportViewer();
            this.dtpDateInit = new System.Windows.Forms.DateTimePicker();
            this.btnRunReport = new System.Windows.Forms.Button();
            this.dtpDateClose = new System.Windows.Forms.DateTimePicker();
            this.lbIni = new System.Windows.Forms.Label();
            this.lbFin = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // reportViewer1
            // 
            this.reportViewer1.LocalReport.ReportEmbeddedResource = "CharlotteV1_0.Informes.Report.rdlc";
            this.reportViewer1.Location = new System.Drawing.Point(52, 98);
            this.reportViewer1.Name = "reportViewer1";
            this.reportViewer1.Size = new System.Drawing.Size(641, 446);
            this.reportViewer1.TabIndex = 0;
            // 
            // dtpDateInit
            // 
            this.dtpDateInit.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dtpDateInit.Location = new System.Drawing.Point(114, 35);
            this.dtpDateInit.Name = "dtpDateInit";
            this.dtpDateInit.Size = new System.Drawing.Size(125, 20);
            this.dtpDateInit.TabIndex = 11;
            // 
            // btnRunReport
            // 
            this.btnRunReport.BackColor = System.Drawing.Color.DarkGoldenrod;
            this.btnRunReport.Font = new System.Drawing.Font("Times New Roman", 10F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnRunReport.Location = new System.Drawing.Point(608, 24);
            this.btnRunReport.Name = "btnRunReport";
            this.btnRunReport.Size = new System.Drawing.Size(138, 49);
            this.btnRunReport.TabIndex = 10;
            this.btnRunReport.Text = "GENERAR BALANCE";
            this.btnRunReport.UseVisualStyleBackColor = false;
            this.btnRunReport.Click += new System.EventHandler(this.btnRunReport_Click);
            // 
            // dtpDateClose
            // 
            this.dtpDateClose.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dtpDateClose.Location = new System.Drawing.Point(339, 35);
            this.dtpDateClose.Name = "dtpDateClose";
            this.dtpDateClose.Size = new System.Drawing.Size(119, 20);
            this.dtpDateClose.TabIndex = 12;
            // 
            // lbIni
            // 
            this.lbIni.AutoSize = true;
            this.lbIni.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbIni.ForeColor = System.Drawing.Color.Black;
            this.lbIni.Location = new System.Drawing.Point(66, 35);
            this.lbIni.Name = "lbIni";
            this.lbIni.Size = new System.Drawing.Size(42, 13);
            this.lbIni.TabIndex = 13;
            this.lbIni.Text = "Inicio:";
            // 
            // lbFin
            // 
            this.lbFin.AutoSize = true;
            this.lbFin.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbFin.ForeColor = System.Drawing.Color.Black;
            this.lbFin.Location = new System.Drawing.Point(305, 35);
            this.lbFin.Name = "lbFin";
            this.lbFin.Size = new System.Drawing.Size(28, 13);
            this.lbFin.TabIndex = 14;
            this.lbFin.Text = "Fin:";
            // 
            // ucReportYear
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Beige;
            this.Controls.Add(this.lbFin);
            this.Controls.Add(this.lbIni);
            this.Controls.Add(this.dtpDateClose);
            this.Controls.Add(this.dtpDateInit);
            this.Controls.Add(this.btnRunReport);
            this.Controls.Add(this.reportViewer1);
            this.Name = "ucReportYear";
            this.Size = new System.Drawing.Size(809, 730);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Microsoft.Reporting.WinForms.ReportViewer reportViewer1;
        private System.Windows.Forms.DateTimePicker dtpDateInit;
        private System.Windows.Forms.Button btnRunReport;
        private System.Windows.Forms.DateTimePicker dtpDateClose;
        private System.Windows.Forms.Label lbIni;
        private System.Windows.Forms.Label lbFin;
    }
}
