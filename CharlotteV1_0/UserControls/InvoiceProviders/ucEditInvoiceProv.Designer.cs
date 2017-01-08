namespace CharlotteV1_0
{
    partial class ucEditInvoiceProv
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
            this.tbImporte = new System.Windows.Forms.TextBox();
            this.lbPhone = new System.Windows.Forms.Label();
            this.lbEditProviderInvoiceLine = new System.Windows.Forms.Label();
            this.btnEdit = new System.Windows.Forms.Button();
            this.tbCantidad = new System.Windows.Forms.TextBox();
            this.lbAddress = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // btnBack
            // 
            this.btnBack.BackColor = System.Drawing.Color.DarkGoldenrod;
            this.btnBack.Font = new System.Drawing.Font("Times New Roman", 10F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnBack.ForeColor = System.Drawing.Color.Black;
            this.btnBack.Location = new System.Drawing.Point(549, 508);
            this.btnBack.Name = "btnBack";
            this.btnBack.Size = new System.Drawing.Size(128, 42);
            this.btnBack.TabIndex = 24;
            this.btnBack.Text = "VOLVER";
            this.btnBack.UseVisualStyleBackColor = false;
            this.btnBack.Click += new System.EventHandler(this.btnBack_Click);
            // 
            // tbImporte
            // 
            this.tbImporte.Location = new System.Drawing.Point(257, 311);
            this.tbImporte.Name = "tbImporte";
            this.tbImporte.Size = new System.Drawing.Size(81, 20);
            this.tbImporte.TabIndex = 22;
            // 
            // lbPhone
            // 
            this.lbPhone.AutoSize = true;
            this.lbPhone.Font = new System.Drawing.Font("Times New Roman", 12F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))));
            this.lbPhone.ForeColor = System.Drawing.Color.DarkGoldenrod;
            this.lbPhone.Location = new System.Drawing.Point(131, 312);
            this.lbPhone.Name = "lbPhone";
            this.lbPhone.Size = new System.Drawing.Size(87, 19);
            this.lbPhone.TabIndex = 27;
            this.lbPhone.Text = "IMPORTE:";
            // 
            // lbEditProviderInvoiceLine
            // 
            this.lbEditProviderInvoiceLine.AutoSize = true;
            this.lbEditProviderInvoiceLine.Font = new System.Drawing.Font("Times New Roman", 20F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbEditProviderInvoiceLine.ForeColor = System.Drawing.Color.DarkGoldenrod;
            this.lbEditProviderInvoiceLine.Location = new System.Drawing.Point(279, 118);
            this.lbEditProviderInvoiceLine.Name = "lbEditProviderInvoiceLine";
            this.lbEditProviderInvoiceLine.Size = new System.Drawing.Size(335, 31);
            this.lbEditProviderInvoiceLine.TabIndex = 28;
            this.lbEditProviderInvoiceLine.Text = "EDITAR LINEA FACTURA";
            // 
            // btnEdit
            // 
            this.btnEdit.BackColor = System.Drawing.Color.DarkGoldenrod;
            this.btnEdit.Font = new System.Drawing.Font("Times New Roman", 10F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnEdit.ForeColor = System.Drawing.Color.Black;
            this.btnEdit.Location = new System.Drawing.Point(131, 508);
            this.btnEdit.Name = "btnEdit";
            this.btnEdit.Size = new System.Drawing.Size(128, 42);
            this.btnEdit.TabIndex = 23;
            this.btnEdit.Text = "MODIFICAR";
            this.btnEdit.UseVisualStyleBackColor = false;
            this.btnEdit.Click += new System.EventHandler(this.btnEdit_Click);
            // 
            // tbCantidad
            // 
            this.tbCantidad.Location = new System.Drawing.Point(257, 272);
            this.tbCantidad.Name = "tbCantidad";
            this.tbCantidad.Size = new System.Drawing.Size(81, 20);
            this.tbCantidad.TabIndex = 21;
            // 
            // lbAddress
            // 
            this.lbAddress.AutoSize = true;
            this.lbAddress.Font = new System.Drawing.Font("Times New Roman", 12F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))));
            this.lbAddress.ForeColor = System.Drawing.Color.DarkGoldenrod;
            this.lbAddress.Location = new System.Drawing.Point(131, 273);
            this.lbAddress.Name = "lbAddress";
            this.lbAddress.Size = new System.Drawing.Size(99, 19);
            this.lbAddress.TabIndex = 26;
            this.lbAddress.Text = "CANTIDAD:";
            // 
            // ucEditInvoiceProv
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Beige;
            this.Controls.Add(this.btnBack);
            this.Controls.Add(this.tbImporte);
            this.Controls.Add(this.lbPhone);
            this.Controls.Add(this.lbEditProviderInvoiceLine);
            this.Controls.Add(this.btnEdit);
            this.Controls.Add(this.tbCantidad);
            this.Controls.Add(this.lbAddress);
            this.Name = "ucEditInvoiceProv";
            this.Size = new System.Drawing.Size(809, 730);
            this.Load += new System.EventHandler(this.ucEditInvoiceProv_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnBack;
        private System.Windows.Forms.TextBox tbImporte;
        private System.Windows.Forms.Label lbPhone;
        private System.Windows.Forms.Label lbEditProviderInvoiceLine;
        private System.Windows.Forms.Button btnEdit;
        private System.Windows.Forms.TextBox tbCantidad;
        private System.Windows.Forms.Label lbAddress;
    }
}
