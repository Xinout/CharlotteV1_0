namespace CharlotteV1_0
{
    partial class ucListInvoiceProv
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
            this.lbProviderList = new System.Windows.Forms.Label();
            this.btnAdd = new System.Windows.Forms.Button();
            this.dgvInvProv = new System.Windows.Forms.DataGridView();
            this.btnSearch = new System.Windows.Forms.Button();
            this.pnFilter = new System.Windows.Forms.Panel();
            this.lbName = new System.Windows.Forms.Label();
            this.tbName = new System.Windows.Forms.TextBox();
            ((System.ComponentModel.ISupportInitialize)(this.dgvInvProv)).BeginInit();
            this.pnFilter.SuspendLayout();
            this.SuspendLayout();
            // 
            // lbProviderList
            // 
            this.lbProviderList.AutoSize = true;
            this.lbProviderList.Font = new System.Drawing.Font("Times New Roman", 20F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbProviderList.ForeColor = System.Drawing.Color.DarkGoldenrod;
            this.lbProviderList.Location = new System.Drawing.Point(145, 65);
            this.lbProviderList.Name = "lbProviderList";
            this.lbProviderList.Size = new System.Drawing.Size(499, 31);
            this.lbProviderList.TabIndex = 7;
            this.lbProviderList.Text = "LISTA DE FACTURAS DE PROVEEDOR";
            // 
            // btnAdd
            // 
            this.btnAdd.BackColor = System.Drawing.Color.DarkGoldenrod;
            this.btnAdd.Font = new System.Drawing.Font("Times New Roman", 10F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAdd.ForeColor = System.Drawing.Color.Black;
            this.btnAdd.Location = new System.Drawing.Point(14, 130);
            this.btnAdd.Name = "btnAdd";
            this.btnAdd.Size = new System.Drawing.Size(142, 46);
            this.btnAdd.TabIndex = 6;
            this.btnAdd.Text = "ALTA NUEVA FACTURA";
            this.btnAdd.UseVisualStyleBackColor = false;
            this.btnAdd.Click += new System.EventHandler(this.btnAdd_Click);
            // 
            // dgvInvProv
            // 
            this.dgvInvProv.AllowUserToAddRows = false;
            this.dgvInvProv.AllowUserToDeleteRows = false;
            dataGridViewCellStyle1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(192)))), ((int)(((byte)(128)))));
            dataGridViewCellStyle1.ForeColor = System.Drawing.Color.Black;
            this.dgvInvProv.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle1;
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle2.BackColor = System.Drawing.Color.DarkGoldenrod;
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle2.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgvInvProv.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle2;
            this.dgvInvProv.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle3.BackColor = System.Drawing.SystemColors.Info;
            dataGridViewCellStyle3.Font = new System.Drawing.Font("Times New Roman", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle3.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle3.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle3.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dgvInvProv.DefaultCellStyle = dataGridViewCellStyle3;
            this.dgvInvProv.Location = new System.Drawing.Point(14, 282);
            this.dgvInvProv.Name = "dgvInvProv";
            this.dgvInvProv.ReadOnly = true;
            this.dgvInvProv.RowHeadersVisible = false;
            this.dgvInvProv.Size = new System.Drawing.Size(779, 294);
            this.dgvInvProv.TabIndex = 5;
            this.dgvInvProv.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvInvProv_CellContentClick);
            // 
            // btnSearch
            // 
            this.btnSearch.BackColor = System.Drawing.Color.DarkGoldenrod;
            this.btnSearch.Font = new System.Drawing.Font("Times New Roman", 10F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSearch.ForeColor = System.Drawing.Color.Black;
            this.btnSearch.Location = new System.Drawing.Point(633, 25);
            this.btnSearch.Name = "btnSearch";
            this.btnSearch.Size = new System.Drawing.Size(128, 42);
            this.btnSearch.TabIndex = 3;
            this.btnSearch.Text = "BUSCAR";
            this.btnSearch.UseVisualStyleBackColor = false;
            this.btnSearch.Click += new System.EventHandler(this.btnSearch_Click);
            // 
            // pnFilter
            // 
            this.pnFilter.BackColor = System.Drawing.Color.Wheat;
            this.pnFilter.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.pnFilter.Controls.Add(this.lbName);
            this.pnFilter.Controls.Add(this.tbName);
            this.pnFilter.Controls.Add(this.btnSearch);
            this.pnFilter.Location = new System.Drawing.Point(14, 191);
            this.pnFilter.Name = "pnFilter";
            this.pnFilter.Size = new System.Drawing.Size(779, 85);
            this.pnFilter.TabIndex = 8;
            // 
            // lbName
            // 
            this.lbName.AutoSize = true;
            this.lbName.Font = new System.Drawing.Font("Times New Roman", 9.75F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbName.ForeColor = System.Drawing.SystemColors.ControlText;
            this.lbName.Location = new System.Drawing.Point(40, 29);
            this.lbName.Name = "lbName";
            this.lbName.Size = new System.Drawing.Size(56, 16);
            this.lbName.TabIndex = 5;
            this.lbName.Text = "Nombre:";
            // 
            // tbName
            // 
            this.tbName.Location = new System.Drawing.Point(102, 25);
            this.tbName.Name = "tbName";
            this.tbName.Size = new System.Drawing.Size(112, 20);
            this.tbName.TabIndex = 4;
            // 
            // ucListInvoiceProv
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Beige;
            this.Controls.Add(this.lbProviderList);
            this.Controls.Add(this.btnAdd);
            this.Controls.Add(this.dgvInvProv);
            this.Controls.Add(this.pnFilter);
            this.Name = "ucListInvoiceProv";
            this.Size = new System.Drawing.Size(809, 730);
            ((System.ComponentModel.ISupportInitialize)(this.dgvInvProv)).EndInit();
            this.pnFilter.ResumeLayout(false);
            this.pnFilter.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lbProviderList;
        private System.Windows.Forms.Button btnAdd;
        private System.Windows.Forms.DataGridView dgvInvProv;
        private System.Windows.Forms.Button btnSearch;
        private System.Windows.Forms.Panel pnFilter;
        private System.Windows.Forms.Label lbName;
        private System.Windows.Forms.TextBox tbName;
    }
}
