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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle4 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle5 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle6 = new System.Windows.Forms.DataGridViewCellStyle();
            this.btnBack = new System.Windows.Forms.Button();
            this.lbAddProvider = new System.Windows.Forms.Label();
            this.btnSave = new System.Windows.Forms.Button();
            this.lbDate = new System.Windows.Forms.Label();
            this.lbName = new System.Windows.Forms.Label();
            this.dtpDateInv = new System.Windows.Forms.DateTimePicker();
            this.cbProv = new System.Windows.Forms.ComboBox();
            this.dgvItemInvProv = new System.Windows.Forms.DataGridView();
            this.colRef = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colDescripcion = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colPrecio = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colPVP = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colCantidad = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colDelete = new System.Windows.Forms.DataGridViewButtonColumn();
            this.pnFilter = new System.Windows.Forms.Panel();
            this.lbItem = new System.Windows.Forms.Label();
            this.tbQuant = new System.Windows.Forms.TextBox();
            this.lbQuant = new System.Windows.Forms.Label();
            this.lbPVP = new System.Windows.Forms.Label();
            this.tbPVP = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.tbCostUnit = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.tbDescription = new System.Windows.Forms.TextBox();
            this.lbRef = new System.Windows.Forms.Label();
            this.tbRef = new System.Windows.Forms.TextBox();
            this.btnAddItem = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dgvItemInvProv)).BeginInit();
            this.pnFilter.SuspendLayout();
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
            this.lbDate.Location = new System.Drawing.Point(398, 132);
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
            this.lbName.Location = new System.Drawing.Point(26, 129);
            this.lbName.Name = "lbName";
            this.lbName.Size = new System.Drawing.Size(115, 19);
            this.lbName.TabIndex = 16;
            this.lbName.Text = "PROVEEDOR:";
            // 
            // dtpDateInv
            // 
            this.dtpDateInv.Location = new System.Drawing.Point(530, 130);
            this.dtpDateInv.Name = "dtpDateInv";
            this.dtpDateInv.Size = new System.Drawing.Size(200, 20);
            this.dtpDateInv.TabIndex = 20;
            // 
            // cbProv
            // 
            this.cbProv.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbProv.Location = new System.Drawing.Point(158, 129);
            this.cbProv.Name = "cbProv";
            this.cbProv.Size = new System.Drawing.Size(200, 21);
            this.cbProv.TabIndex = 21;
            // 
            // dgvItemInvProv
            // 
            this.dgvItemInvProv.AllowUserToAddRows = false;
            this.dgvItemInvProv.AllowUserToDeleteRows = false;
            this.dgvItemInvProv.AllowUserToResizeColumns = false;
            this.dgvItemInvProv.AllowUserToResizeRows = false;
            dataGridViewCellStyle4.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(192)))), ((int)(((byte)(128)))));
            dataGridViewCellStyle4.ForeColor = System.Drawing.Color.Black;
            this.dgvItemInvProv.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle4;
            dataGridViewCellStyle5.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle5.BackColor = System.Drawing.Color.DarkGoldenrod;
            dataGridViewCellStyle5.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle5.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle5.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle5.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle5.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgvItemInvProv.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle5;
            this.dgvItemInvProv.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvItemInvProv.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.colRef,
            this.colDescripcion,
            this.colPrecio,
            this.colPVP,
            this.colCantidad,
            this.colDelete});
            dataGridViewCellStyle6.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle6.BackColor = System.Drawing.SystemColors.Info;
            dataGridViewCellStyle6.Font = new System.Drawing.Font("Times New Roman", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle6.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle6.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle6.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle6.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dgvItemInvProv.DefaultCellStyle = dataGridViewCellStyle6;
            this.dgvItemInvProv.Location = new System.Drawing.Point(15, 319);
            this.dgvItemInvProv.Name = "dgvItemInvProv";
            this.dgvItemInvProv.ReadOnly = true;
            this.dgvItemInvProv.RowHeadersVisible = false;
            this.dgvItemInvProv.Size = new System.Drawing.Size(779, 216);
            this.dgvItemInvProv.TabIndex = 22;
            this.dgvItemInvProv.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvItemInvProv_CellContentClick);
            // 
            // colRef
            // 
            this.colRef.HeaderText = "Referencia";
            this.colRef.Name = "colRef";
            this.colRef.ReadOnly = true;
            this.colRef.Width = 105;
            // 
            // colDescripcion
            // 
            this.colDescripcion.HeaderText = "Descripcion";
            this.colDescripcion.Name = "colDescripcion";
            this.colDescripcion.ReadOnly = true;
            this.colDescripcion.Width = 270;
            // 
            // colPrecio
            // 
            this.colPrecio.HeaderText = "P. Unidad";
            this.colPrecio.Name = "colPrecio";
            this.colPrecio.ReadOnly = true;
            // 
            // colPVP
            // 
            this.colPVP.HeaderText = "PVP";
            this.colPVP.Name = "colPVP";
            this.colPVP.ReadOnly = true;
            // 
            // colCantidad
            // 
            this.colCantidad.HeaderText = "Cantidad";
            this.colCantidad.Name = "colCantidad";
            this.colCantidad.ReadOnly = true;
            // 
            // colDelete
            // 
            this.colDelete.HeaderText = "";
            this.colDelete.Name = "colDelete";
            this.colDelete.ReadOnly = true;
            this.colDelete.Text = "Quitar";
            this.colDelete.UseColumnTextForButtonValue = true;
            // 
            // pnFilter
            // 
            this.pnFilter.BackColor = System.Drawing.Color.Wheat;
            this.pnFilter.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.pnFilter.Controls.Add(this.lbItem);
            this.pnFilter.Controls.Add(this.tbQuant);
            this.pnFilter.Controls.Add(this.lbQuant);
            this.pnFilter.Controls.Add(this.lbPVP);
            this.pnFilter.Controls.Add(this.tbPVP);
            this.pnFilter.Controls.Add(this.label3);
            this.pnFilter.Controls.Add(this.tbCostUnit);
            this.pnFilter.Controls.Add(this.label2);
            this.pnFilter.Controls.Add(this.tbDescription);
            this.pnFilter.Controls.Add(this.lbRef);
            this.pnFilter.Controls.Add(this.tbRef);
            this.pnFilter.Controls.Add(this.btnAddItem);
            this.pnFilter.Location = new System.Drawing.Point(15, 181);
            this.pnFilter.Name = "pnFilter";
            this.pnFilter.Size = new System.Drawing.Size(779, 131);
            this.pnFilter.TabIndex = 23;
            // 
            // lbItem
            // 
            this.lbItem.AutoSize = true;
            this.lbItem.Font = new System.Drawing.Font("Times New Roman", 12F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbItem.ForeColor = System.Drawing.Color.DarkGoldenrod;
            this.lbItem.Location = new System.Drawing.Point(12, 13);
            this.lbItem.Name = "lbItem";
            this.lbItem.Size = new System.Drawing.Size(158, 19);
            this.lbItem.TabIndex = 17;
            this.lbItem.Text = "NUEVO ARTICULO:";
            // 
            // tbQuant
            // 
            this.tbQuant.Location = new System.Drawing.Point(534, 76);
            this.tbQuant.Name = "tbQuant";
            this.tbQuant.Size = new System.Drawing.Size(60, 20);
            this.tbQuant.TabIndex = 14;
            // 
            // lbQuant
            // 
            this.lbQuant.AutoSize = true;
            this.lbQuant.Font = new System.Drawing.Font("Times New Roman", 9.75F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbQuant.ForeColor = System.Drawing.SystemColors.ControlText;
            this.lbQuant.Location = new System.Drawing.Point(464, 78);
            this.lbQuant.Name = "lbQuant";
            this.lbQuant.Size = new System.Drawing.Size(64, 16);
            this.lbQuant.TabIndex = 13;
            this.lbQuant.Text = "Cantidad:";
            // 
            // lbPVP
            // 
            this.lbPVP.AutoSize = true;
            this.lbPVP.Font = new System.Drawing.Font("Times New Roman", 9.75F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbPVP.ForeColor = System.Drawing.SystemColors.ControlText;
            this.lbPVP.Location = new System.Drawing.Point(250, 74);
            this.lbPVP.Name = "lbPVP";
            this.lbPVP.Size = new System.Drawing.Size(37, 16);
            this.lbPVP.TabIndex = 11;
            this.lbPVP.Text = "PVP:";
            // 
            // tbPVP
            // 
            this.tbPVP.Location = new System.Drawing.Point(335, 74);
            this.tbPVP.Name = "tbPVP";
            this.tbPVP.Size = new System.Drawing.Size(112, 20);
            this.tbPVP.TabIndex = 10;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Times New Roman", 9.75F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.SystemColors.ControlText;
            this.label3.Location = new System.Drawing.Point(13, 78);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(92, 16);
            this.label3.TabIndex = 9;
            this.label3.Text = "Precio Unidad:";
            // 
            // tbCostUnit
            // 
            this.tbCostUnit.Location = new System.Drawing.Point(111, 74);
            this.tbCostUnit.Name = "tbCostUnit";
            this.tbCostUnit.Size = new System.Drawing.Size(112, 20);
            this.tbCostUnit.TabIndex = 8;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Times New Roman", 9.75F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.SystemColors.ControlText;
            this.label2.Location = new System.Drawing.Point(251, 50);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(78, 16);
            this.label2.TabIndex = 7;
            this.label2.Text = "Descripcion:";
            // 
            // tbDescription
            // 
            this.tbDescription.Location = new System.Drawing.Point(335, 48);
            this.tbDescription.Name = "tbDescription";
            this.tbDescription.Size = new System.Drawing.Size(259, 20);
            this.tbDescription.TabIndex = 6;
            // 
            // lbRef
            // 
            this.lbRef.AutoSize = true;
            this.lbRef.Font = new System.Drawing.Font("Times New Roman", 9.75F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbRef.ForeColor = System.Drawing.SystemColors.ControlText;
            this.lbRef.Location = new System.Drawing.Point(13, 48);
            this.lbRef.Name = "lbRef";
            this.lbRef.Size = new System.Drawing.Size(72, 16);
            this.lbRef.TabIndex = 5;
            this.lbRef.Text = "Referencia:";
            // 
            // tbRef
            // 
            this.tbRef.Location = new System.Drawing.Point(111, 48);
            this.tbRef.Name = "tbRef";
            this.tbRef.Size = new System.Drawing.Size(112, 20);
            this.tbRef.TabIndex = 4;
            // 
            // btnAddItem
            // 
            this.btnAddItem.BackColor = System.Drawing.Color.DarkGoldenrod;
            this.btnAddItem.Font = new System.Drawing.Font("Times New Roman", 10F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAddItem.ForeColor = System.Drawing.Color.Black;
            this.btnAddItem.Location = new System.Drawing.Point(623, 48);
            this.btnAddItem.Name = "btnAddItem";
            this.btnAddItem.Size = new System.Drawing.Size(128, 65);
            this.btnAddItem.TabIndex = 3;
            this.btnAddItem.Text = "AÑADIR ARTICULO";
            this.btnAddItem.UseVisualStyleBackColor = false;
            this.btnAddItem.Click += new System.EventHandler(this.btnAddItem_Click);
            // 
            // ucAddInvoiceProv
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Beige;
            this.Controls.Add(this.dgvItemInvProv);
            this.Controls.Add(this.pnFilter);
            this.Controls.Add(this.cbProv);
            this.Controls.Add(this.dtpDateInv);
            this.Controls.Add(this.btnBack);
            this.Controls.Add(this.lbAddProvider);
            this.Controls.Add(this.btnSave);
            this.Controls.Add(this.lbDate);
            this.Controls.Add(this.lbName);
            this.Name = "ucAddInvoiceProv";
            this.Size = new System.Drawing.Size(809, 730);
            ((System.ComponentModel.ISupportInitialize)(this.dgvItemInvProv)).EndInit();
            this.pnFilter.ResumeLayout(false);
            this.pnFilter.PerformLayout();
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
        private System.Windows.Forms.DataGridView dgvItemInvProv;
        private System.Windows.Forms.Panel pnFilter;
        private System.Windows.Forms.TextBox tbQuant;
        private System.Windows.Forms.Label lbQuant;
        private System.Windows.Forms.Label lbPVP;
        private System.Windows.Forms.TextBox tbPVP;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox tbCostUnit;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox tbDescription;
        private System.Windows.Forms.Label lbRef;
        private System.Windows.Forms.TextBox tbRef;
        private System.Windows.Forms.Button btnAddItem;
        private System.Windows.Forms.Label lbItem;
        private System.Windows.Forms.DataGridViewTextBoxColumn colRef;
        private System.Windows.Forms.DataGridViewTextBoxColumn colDescripcion;
        private System.Windows.Forms.DataGridViewTextBoxColumn colPrecio;
        private System.Windows.Forms.DataGridViewTextBoxColumn colPVP;
        private System.Windows.Forms.DataGridViewTextBoxColumn colCantidad;
        private System.Windows.Forms.DataGridViewButtonColumn colDelete;
    }
}
