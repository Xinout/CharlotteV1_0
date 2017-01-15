namespace CharlotteV1_0
{
    partial class ucAddInvoiceProv
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
            this.btnBack = new System.Windows.Forms.Button();
            this.lbAddProvider = new System.Windows.Forms.Label();
            this.btnSave = new System.Windows.Forms.Button();
            this.lbDate = new System.Windows.Forms.Label();
            this.lbName = new System.Windows.Forms.Label();
            this.dtpDateInv = new System.Windows.Forms.DateTimePicker();
            this.cbProv = new System.Windows.Forms.ComboBox();
            this.lbTotal = new System.Windows.Forms.Label();
            this.tbTotal = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // btnBack
            // 
            this.btnBack.BackColor = System.Drawing.Color.DarkGoldenrod;
            this.btnBack.Font = new System.Drawing.Font("Times New Roman", 10F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnBack.ForeColor = System.Drawing.Color.Black;
            this.btnBack.Location = new System.Drawing.Point(530, 604);
            this.btnBack.Name = "btnBack";
            this.btnBack.Size = new System.Drawing.Size(128, 42);
            this.btnBack.TabIndex = 15;
            this.btnBack.Text = "VOLVER A LISTADO";
            this.btnBack.UseVisualStyleBackColor = false;
            this.btnBack.Click += new System.EventHandler(this.btnBack_Click);
            // 
            // lbAddProvider
            // 
            this.lbAddProvider.AutoSize = true;
            this.lbAddProvider.Font = new System.Drawing.Font("Times New Roman", 20F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbAddProvider.ForeColor = System.Drawing.Color.DarkGoldenrod;
            this.lbAddProvider.Location = new System.Drawing.Point(152, 60);
            this.lbAddProvider.Name = "lbAddProvider";
            this.lbAddProvider.Size = new System.Drawing.Size(476, 31);
            this.lbAddProvider.TabIndex = 19;
            this.lbAddProvider.Text = "ALTA DE FACTURA DE PROVEEDOR";
            // 
            // btnSave
            // 
            this.btnSave.BackColor = System.Drawing.Color.DarkGoldenrod;
            this.btnSave.Font = new System.Drawing.Font("Times New Roman", 10F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSave.ForeColor = System.Drawing.Color.Black;
            this.btnSave.Location = new System.Drawing.Point(112, 604);
            this.btnSave.Name = "btnSave";
            this.btnSave.Size = new System.Drawing.Size(128, 42);
            this.btnSave.TabIndex = 14;
            this.btnSave.Text = "GUARDAR FACTURA";
            this.btnSave.UseVisualStyleBackColor = false;
            this.btnSave.Click += new System.EventHandler(this.btnSave_Click);
            // 
            // lbDate
            // 
            this.lbDate.AutoSize = true;
            this.lbDate.Font = new System.Drawing.Font("Times New Roman", 12F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))));
            this.lbDate.ForeColor = System.Drawing.Color.DarkGoldenrod;
            this.lbDate.Location = new System.Drawing.Point(75, 206);
            this.lbDate.Name = "lbDate";
            this.lbDate.Size = new System.Drawing.Size(70, 19);
            this.lbDate.TabIndex = 17;
            this.lbDate.Text = "FECHA:";
            // 
            // lbName
            // 
            this.lbName.AutoSize = true;
            this.lbName.Font = new System.Drawing.Font("Times New Roman", 12F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbName.ForeColor = System.Drawing.Color.DarkGoldenrod;
            this.lbName.Location = new System.Drawing.Point(75, 157);
            this.lbName.Name = "lbName";
            this.lbName.Size = new System.Drawing.Size(115, 19);
            this.lbName.TabIndex = 16;
            this.lbName.Text = "PROVEEDOR:";
            // 
            // dtpDateInv
            // 
            this.dtpDateInv.Location = new System.Drawing.Point(217, 204);
            this.dtpDateInv.Name = "dtpDateInv";
            this.dtpDateInv.Size = new System.Drawing.Size(200, 20);
            this.dtpDateInv.TabIndex = 20;
            // 
            // cbProv
            // 
            this.cbProv.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbProv.Location = new System.Drawing.Point(217, 155);
            this.cbProv.Name = "cbProv";
            this.cbProv.Size = new System.Drawing.Size(200, 21);
            this.cbProv.TabIndex = 21;
            // 
            // lbTotal
            // 
            this.lbTotal.AutoSize = true;
            this.lbTotal.Font = new System.Drawing.Font("Times New Roman", 12F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))));
            this.lbTotal.ForeColor = System.Drawing.Color.DarkGoldenrod;
            this.lbTotal.Location = new System.Drawing.Point(76, 250);
            this.lbTotal.Name = "lbTotal";
            this.lbTotal.Size = new System.Drawing.Size(135, 19);
            this.lbTotal.TabIndex = 25;
            this.lbTotal.Text = "TOTAL CON IVA:";
            // 
            // tbTotal
            // 
            this.tbTotal.Location = new System.Drawing.Point(217, 249);
            this.tbTotal.Name = "tbTotal";
            this.tbTotal.Size = new System.Drawing.Size(112, 20);
            this.tbTotal.TabIndex = 24;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold);
            this.label3.ForeColor = System.Drawing.Color.Black;
            this.label3.Location = new System.Drawing.Point(335, 248);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(17, 19);
            this.label3.TabIndex = 33;
            this.label3.Text = "€";
            // 
            // ucAddInvoiceProv
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Beige;
            this.Controls.Add(this.label3);
            this.Controls.Add(this.lbTotal);
            this.Controls.Add(this.tbTotal);
            this.Controls.Add(this.cbProv);
            this.Controls.Add(this.dtpDateInv);
            this.Controls.Add(this.btnBack);
            this.Controls.Add(this.lbAddProvider);
            this.Controls.Add(this.btnSave);
            this.Controls.Add(this.lbDate);
            this.Controls.Add(this.lbName);
            this.Name = "ucAddInvoiceProv";
            this.Size = new System.Drawing.Size(809, 730);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnBack;
        private System.Windows.Forms.Label lbAddProvider;
        private System.Windows.Forms.Button btnSave;
        private System.Windows.Forms.Label lbDate;
        private System.Windows.Forms.Label lbName;
        private System.Windows.Forms.DateTimePicker dtpDateInv;
        private System.Windows.Forms.ComboBox cbProv;
        private System.Windows.Forms.Label lbTotal;
        private System.Windows.Forms.TextBox tbTotal;
        private System.Windows.Forms.Label label3;
    }
}
