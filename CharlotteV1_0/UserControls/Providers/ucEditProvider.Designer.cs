namespace CharlotteV1_0
{
    partial class ucEditProvider
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
            this.tbPhone = new System.Windows.Forms.TextBox();
            this.lbPhone = new System.Windows.Forms.Label();
            this.lbEditProvider = new System.Windows.Forms.Label();
            this.btnEdit = new System.Windows.Forms.Button();
            this.tbAddress = new System.Windows.Forms.TextBox();
            this.tbName = new System.Windows.Forms.TextBox();
            this.lbAddress = new System.Windows.Forms.Label();
            this.lbName = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // btnBack
            // 
            this.btnBack.BackColor = System.Drawing.Color.DarkGoldenrod;
            this.btnBack.Font = new System.Drawing.Font("Times New Roman", 10F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnBack.ForeColor = System.Drawing.Color.Black;
            this.btnBack.Location = new System.Drawing.Point(556, 453);
            this.btnBack.Name = "btnBack";
            this.btnBack.Size = new System.Drawing.Size(128, 42);
            this.btnBack.TabIndex = 15;
            this.btnBack.Text = "VOLVER";
            this.btnBack.UseVisualStyleBackColor = false;
            this.btnBack.Click += new System.EventHandler(this.btnBack_Click);
            // 
            // tbPhone
            // 
            this.tbPhone.Location = new System.Drawing.Point(264, 256);
            this.tbPhone.Name = "tbPhone";
            this.tbPhone.Size = new System.Drawing.Size(322, 20);
            this.tbPhone.TabIndex = 13;
            // 
            // lbPhone
            // 
            this.lbPhone.AutoSize = true;
            this.lbPhone.Font = new System.Drawing.Font("Times New Roman", 12F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))));
            this.lbPhone.ForeColor = System.Drawing.Color.DarkGoldenrod;
            this.lbPhone.Location = new System.Drawing.Point(138, 257);
            this.lbPhone.Name = "lbPhone";
            this.lbPhone.Size = new System.Drawing.Size(103, 19);
            this.lbPhone.TabIndex = 18;
            this.lbPhone.Text = "TELÉFONO:";
            // 
            // lbEditProvider
            // 
            this.lbEditProvider.AutoSize = true;
            this.lbEditProvider.Font = new System.Drawing.Font("Times New Roman", 20F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbEditProvider.ForeColor = System.Drawing.Color.DarkGoldenrod;
            this.lbEditProvider.Location = new System.Drawing.Point(286, 63);
            this.lbEditProvider.Name = "lbEditProvider";
            this.lbEditProvider.Size = new System.Drawing.Size(287, 31);
            this.lbEditProvider.TabIndex = 19;
            this.lbEditProvider.Text = "EDITAR PROVEEDOR";
            // 
            // btnEdit
            // 
            this.btnEdit.BackColor = System.Drawing.Color.DarkGoldenrod;
            this.btnEdit.Font = new System.Drawing.Font("Times New Roman", 10F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnEdit.ForeColor = System.Drawing.Color.Black;
            this.btnEdit.Location = new System.Drawing.Point(138, 453);
            this.btnEdit.Name = "btnEdit";
            this.btnEdit.Size = new System.Drawing.Size(128, 42);
            this.btnEdit.TabIndex = 14;
            this.btnEdit.Text = "MODIFICAR";
            this.btnEdit.UseVisualStyleBackColor = false;
            this.btnEdit.Click += new System.EventHandler(this.btnEdit_Click);
            // 
            // tbAddress
            // 
            this.tbAddress.Location = new System.Drawing.Point(264, 217);
            this.tbAddress.Name = "tbAddress";
            this.tbAddress.Size = new System.Drawing.Size(322, 20);
            this.tbAddress.TabIndex = 12;
            // 
            // tbName
            // 
            this.tbName.Location = new System.Drawing.Point(264, 178);
            this.tbName.Name = "tbName";
            this.tbName.Size = new System.Drawing.Size(322, 20);
            this.tbName.TabIndex = 11;
            // 
            // lbAddress
            // 
            this.lbAddress.AutoSize = true;
            this.lbAddress.Font = new System.Drawing.Font("Times New Roman", 12F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))));
            this.lbAddress.ForeColor = System.Drawing.Color.DarkGoldenrod;
            this.lbAddress.Location = new System.Drawing.Point(138, 218);
            this.lbAddress.Name = "lbAddress";
            this.lbAddress.Size = new System.Drawing.Size(106, 19);
            this.lbAddress.TabIndex = 17;
            this.lbAddress.Text = "DIRECCIÓN:";
            // 
            // lbName
            // 
            this.lbName.AutoSize = true;
            this.lbName.Font = new System.Drawing.Font("Times New Roman", 12F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbName.ForeColor = System.Drawing.Color.DarkGoldenrod;
            this.lbName.Location = new System.Drawing.Point(138, 179);
            this.lbName.Name = "lbName";
            this.lbName.Size = new System.Drawing.Size(84, 19);
            this.lbName.TabIndex = 16;
            this.lbName.Text = "NOMBRE:";
            // 
            // ucEditProvider
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Beige;
            this.Controls.Add(this.btnBack);
            this.Controls.Add(this.tbPhone);
            this.Controls.Add(this.lbPhone);
            this.Controls.Add(this.lbEditProvider);
            this.Controls.Add(this.btnEdit);
            this.Controls.Add(this.tbAddress);
            this.Controls.Add(this.tbName);
            this.Controls.Add(this.lbAddress);
            this.Controls.Add(this.lbName);
            this.Name = "ucEditProvider";
            this.Size = new System.Drawing.Size(809, 730);
            this.Load += new System.EventHandler(this.ucEditProvider_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnBack;
        private System.Windows.Forms.TextBox tbPhone;
        private System.Windows.Forms.Label lbPhone;
        private System.Windows.Forms.Label lbEditProvider;
        private System.Windows.Forms.Button btnEdit;
        private System.Windows.Forms.TextBox tbAddress;
        private System.Windows.Forms.TextBox tbName;
        private System.Windows.Forms.Label lbAddress;
        private System.Windows.Forms.Label lbName;
    }
}
