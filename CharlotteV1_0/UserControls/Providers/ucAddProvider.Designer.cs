namespace CharlotteV1_0
{
    partial class ucAddProvider
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
            this.lbName = new System.Windows.Forms.Label();
            this.lbAddress = new System.Windows.Forms.Label();
            this.tbName = new System.Windows.Forms.TextBox();
            this.tbAddress = new System.Windows.Forms.TextBox();
            this.btnSave = new System.Windows.Forms.Button();
            this.lbAddProvider = new System.Windows.Forms.Label();
            this.tbPhone = new System.Windows.Forms.TextBox();
            this.lbPhone = new System.Windows.Forms.Label();
            this.btnBack = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // lbName
            // 
            this.lbName.AutoSize = true;
            this.lbName.Font = new System.Drawing.Font("Times New Roman", 12F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbName.ForeColor = System.Drawing.Color.DarkGoldenrod;
            this.lbName.Location = new System.Drawing.Point(83, 157);
            this.lbName.Name = "lbName";
            this.lbName.Size = new System.Drawing.Size(84, 19);
            this.lbName.TabIndex = 6;
            this.lbName.Text = "NOMBRE:";
            // 
            // lbAddress
            // 
            this.lbAddress.AutoSize = true;
            this.lbAddress.Font = new System.Drawing.Font("Times New Roman", 12F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))));
            this.lbAddress.ForeColor = System.Drawing.Color.DarkGoldenrod;
            this.lbAddress.Location = new System.Drawing.Point(83, 196);
            this.lbAddress.Name = "lbAddress";
            this.lbAddress.Size = new System.Drawing.Size(106, 19);
            this.lbAddress.TabIndex = 7;
            this.lbAddress.Text = "DIRECCIÓN:";
            // 
            // tbName
            // 
            this.tbName.Location = new System.Drawing.Point(209, 156);
            this.tbName.Name = "tbName";
            this.tbName.Size = new System.Drawing.Size(322, 20);
            this.tbName.TabIndex = 1;
            // 
            // tbAddress
            // 
            this.tbAddress.Location = new System.Drawing.Point(209, 195);
            this.tbAddress.Name = "tbAddress";
            this.tbAddress.Size = new System.Drawing.Size(322, 20);
            this.tbAddress.TabIndex = 2;
            // 
            // btnSave
            // 
            this.btnSave.BackColor = System.Drawing.Color.DarkGoldenrod;
            this.btnSave.Font = new System.Drawing.Font("Times New Roman", 10F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSave.ForeColor = System.Drawing.Color.Black;
            this.btnSave.Location = new System.Drawing.Point(83, 431);
            this.btnSave.Name = "btnSave";
            this.btnSave.Size = new System.Drawing.Size(128, 42);
            this.btnSave.TabIndex = 4;
            this.btnSave.Text = "GUARDAR";
            this.btnSave.UseVisualStyleBackColor = false;
            this.btnSave.Click += new System.EventHandler(this.btnSave_Click);
            // 
            // lbAddProvider
            // 
            this.lbAddProvider.AutoSize = true;
            this.lbAddProvider.Font = new System.Drawing.Font("Times New Roman", 20F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbAddProvider.ForeColor = System.Drawing.Color.DarkGoldenrod;
            this.lbAddProvider.Location = new System.Drawing.Point(231, 41);
            this.lbAddProvider.Name = "lbAddProvider";
            this.lbAddProvider.Size = new System.Drawing.Size(300, 31);
            this.lbAddProvider.TabIndex = 10;
            this.lbAddProvider.Text = "ALTA DE PROVEEDOR";
            // 
            // tbPhone
            // 
            this.tbPhone.Location = new System.Drawing.Point(209, 234);
            this.tbPhone.Name = "tbPhone";
            this.tbPhone.Size = new System.Drawing.Size(322, 20);
            this.tbPhone.TabIndex = 3;
            // 
            // lbPhone
            // 
            this.lbPhone.AutoSize = true;
            this.lbPhone.Font = new System.Drawing.Font("Times New Roman", 12F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))));
            this.lbPhone.ForeColor = System.Drawing.Color.DarkGoldenrod;
            this.lbPhone.Location = new System.Drawing.Point(83, 235);
            this.lbPhone.Name = "lbPhone";
            this.lbPhone.Size = new System.Drawing.Size(103, 19);
            this.lbPhone.TabIndex = 8;
            this.lbPhone.Text = "TELÉFONO:";
            // 
            // btnBack
            // 
            this.btnBack.BackColor = System.Drawing.Color.DarkGoldenrod;
            this.btnBack.Font = new System.Drawing.Font("Times New Roman", 10F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnBack.ForeColor = System.Drawing.Color.Black;
            this.btnBack.Location = new System.Drawing.Point(501, 431);
            this.btnBack.Name = "btnBack";
            this.btnBack.Size = new System.Drawing.Size(128, 42);
            this.btnBack.TabIndex = 5;
            this.btnBack.Text = "VOLVER";
            this.btnBack.UseVisualStyleBackColor = false;
            this.btnBack.Click += new System.EventHandler(this.btnBack_Click);
            // 
            // ucAddProvider
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Beige;
            this.Controls.Add(this.btnBack);
            this.Controls.Add(this.tbPhone);
            this.Controls.Add(this.lbPhone);
            this.Controls.Add(this.lbAddProvider);
            this.Controls.Add(this.btnSave);
            this.Controls.Add(this.tbAddress);
            this.Controls.Add(this.tbName);
            this.Controls.Add(this.lbAddress);
            this.Controls.Add(this.lbName);
            this.Name = "ucAddProvider";
            this.Size = new System.Drawing.Size(809, 730);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lbName;
        private System.Windows.Forms.Label lbAddress;
        private System.Windows.Forms.TextBox tbName;
        private System.Windows.Forms.TextBox tbAddress;
        private System.Windows.Forms.Button btnSave;
        private System.Windows.Forms.Label lbAddProvider;
        private System.Windows.Forms.TextBox tbPhone;
        private System.Windows.Forms.Label lbPhone;
        private System.Windows.Forms.Button btnBack;
    }
}
