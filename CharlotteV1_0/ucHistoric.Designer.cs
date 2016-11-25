namespace CharlotteV1_0
{
    partial class ucHistoric
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
            this.btnHistoric = new System.Windows.Forms.Button();
            this.dtpDateClose = new System.Windows.Forms.DateTimePicker();
            this.lbProviderList = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // btnHistoric
            // 
            this.btnHistoric.BackColor = System.Drawing.Color.DarkGoldenrod;
            this.btnHistoric.Font = new System.Drawing.Font("Times New Roman", 10F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnHistoric.Location = new System.Drawing.Point(202, 285);
            this.btnHistoric.Name = "btnHistoric";
            this.btnHistoric.Size = new System.Drawing.Size(193, 62);
            this.btnHistoric.TabIndex = 8;
            this.btnHistoric.Text = "GENERAR CIERRE";
            this.btnHistoric.UseVisualStyleBackColor = false;
            this.btnHistoric.Click += new System.EventHandler(this.btnHistoric_Click);
            // 
            // dtpDateClose
            // 
            this.dtpDateClose.Location = new System.Drawing.Point(202, 244);
            this.dtpDateClose.Name = "dtpDateClose";
            this.dtpDateClose.Size = new System.Drawing.Size(200, 20);
            this.dtpDateClose.TabIndex = 9;
            // 
            // lbProviderList
            // 
            this.lbProviderList.AutoSize = true;
            this.lbProviderList.Font = new System.Drawing.Font("Times New Roman", 20F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbProviderList.ForeColor = System.Drawing.Color.DarkGoldenrod;
            this.lbProviderList.Location = new System.Drawing.Point(235, 94);
            this.lbProviderList.Name = "lbProviderList";
            this.lbProviderList.Size = new System.Drawing.Size(270, 31);
            this.lbProviderList.TabIndex = 10;
            this.lbProviderList.Text = "HISTORICO CIERRE";
            // 
            // ucHistoric
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Beige;
            this.Controls.Add(this.lbProviderList);
            this.Controls.Add(this.dtpDateClose);
            this.Controls.Add(this.btnHistoric);
            this.Name = "ucHistoric";
            this.Size = new System.Drawing.Size(809, 730);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnHistoric;
        private System.Windows.Forms.DateTimePicker dtpDateClose;
        private System.Windows.Forms.Label lbProviderList;
    }
}
