namespace CharlotteV1_0
{
    partial class ucManualSale
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
            this.dgvItem = new System.Windows.Forms.DataGridView();
            this.pnFilter = new System.Windows.Forms.Panel();
            this.lbItem = new System.Windows.Forms.Label();
            this.tbQuant = new System.Windows.Forms.TextBox();
            this.lbQuant = new System.Windows.Forms.Label();
            this.lbPVP = new System.Windows.Forms.Label();
            this.tbPVP = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.tbDescription = new System.Windows.Forms.TextBox();
            this.lbRef = new System.Windows.Forms.Label();
            this.tbRef = new System.Windows.Forms.TextBox();
            this.btnAddItem = new System.Windows.Forms.Button();
            this.lbManualSale = new System.Windows.Forms.Label();
            this.chbTicketRegalo = new System.Windows.Forms.CheckBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.tbAmount = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.rbCard = new System.Windows.Forms.RadioButton();
            this.rbCash = new System.Windows.Forms.RadioButton();
            this.btnGetTicket = new System.Windows.Forms.Button();
            this.label8 = new System.Windows.Forms.Label();
            this.lbTotal = new System.Windows.Forms.Label();
            this.colRef = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colDescripcion = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colPVP = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colCantidad = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colDescuento = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colDelete = new System.Windows.Forms.DataGridViewButtonColumn();
            this.tbDescuento = new System.Windows.Forms.TextBox();
            this.lbDescuento = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.dgvItem)).BeginInit();
            this.pnFilter.SuspendLayout();
            this.SuspendLayout();
            // 
            // dgvItem
            // 
            this.dgvItem.AllowUserToAddRows = false;
            this.dgvItem.AllowUserToDeleteRows = false;
            this.dgvItem.AllowUserToResizeColumns = false;
            this.dgvItem.AllowUserToResizeRows = false;
            dataGridViewCellStyle1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(192)))), ((int)(((byte)(128)))));
            dataGridViewCellStyle1.ForeColor = System.Drawing.Color.Black;
            this.dgvItem.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle1;
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle2.BackColor = System.Drawing.Color.DarkGoldenrod;
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle2.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgvItem.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle2;
            this.dgvItem.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvItem.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.colRef,
            this.colDescripcion,
            this.colPVP,
            this.colCantidad,
            this.colDescuento,
            this.colDelete});
            dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle3.BackColor = System.Drawing.SystemColors.Info;
            dataGridViewCellStyle3.Font = new System.Drawing.Font("Times New Roman", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle3.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle3.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle3.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dgvItem.DefaultCellStyle = dataGridViewCellStyle3;
            this.dgvItem.Location = new System.Drawing.Point(15, 238);
            this.dgvItem.Name = "dgvItem";
            this.dgvItem.ReadOnly = true;
            this.dgvItem.RowHeadersVisible = false;
            this.dgvItem.Size = new System.Drawing.Size(779, 216);
            this.dgvItem.TabIndex = 24;
            this.dgvItem.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvItem_CellContentClick);
            // 
            // pnFilter
            // 
            this.pnFilter.BackColor = System.Drawing.Color.Wheat;
            this.pnFilter.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.pnFilter.Controls.Add(this.tbDescuento);
            this.pnFilter.Controls.Add(this.lbDescuento);
            this.pnFilter.Controls.Add(this.lbItem);
            this.pnFilter.Controls.Add(this.tbQuant);
            this.pnFilter.Controls.Add(this.lbQuant);
            this.pnFilter.Controls.Add(this.lbPVP);
            this.pnFilter.Controls.Add(this.tbPVP);
            this.pnFilter.Controls.Add(this.label2);
            this.pnFilter.Controls.Add(this.tbDescription);
            this.pnFilter.Controls.Add(this.lbRef);
            this.pnFilter.Controls.Add(this.tbRef);
            this.pnFilter.Controls.Add(this.btnAddItem);
            this.pnFilter.Location = new System.Drawing.Point(15, 100);
            this.pnFilter.Name = "pnFilter";
            this.pnFilter.Size = new System.Drawing.Size(779, 131);
            this.pnFilter.TabIndex = 25;
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
            this.tbQuant.Location = new System.Drawing.Point(335, 74);
            this.tbQuant.Name = "tbQuant";
            this.tbQuant.Size = new System.Drawing.Size(60, 20);
            this.tbQuant.TabIndex = 14;
            // 
            // lbQuant
            // 
            this.lbQuant.AutoSize = true;
            this.lbQuant.Font = new System.Drawing.Font("Times New Roman", 9.75F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbQuant.ForeColor = System.Drawing.SystemColors.ControlText;
            this.lbQuant.Location = new System.Drawing.Point(251, 74);
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
            this.lbPVP.Location = new System.Drawing.Point(13, 74);
            this.lbPVP.Name = "lbPVP";
            this.lbPVP.Size = new System.Drawing.Size(37, 16);
            this.lbPVP.TabIndex = 11;
            this.lbPVP.Text = "PVP:";
            // 
            // tbPVP
            // 
            this.tbPVP.Location = new System.Drawing.Point(111, 74);
            this.tbPVP.Name = "tbPVP";
            this.tbPVP.Size = new System.Drawing.Size(112, 20);
            this.tbPVP.TabIndex = 10;
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
            // lbManualSale
            // 
            this.lbManualSale.AutoSize = true;
            this.lbManualSale.Font = new System.Drawing.Font("Times New Roman", 20F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbManualSale.ForeColor = System.Drawing.Color.DarkGoldenrod;
            this.lbManualSale.Location = new System.Drawing.Point(275, 56);
            this.lbManualSale.Name = "lbManualSale";
            this.lbManualSale.Size = new System.Drawing.Size(226, 31);
            this.lbManualSale.TabIndex = 27;
            this.lbManualSale.Text = "VENTA MANUAL";
            // 
            // chbTicketRegalo
            // 
            this.chbTicketRegalo.AutoSize = true;
            this.chbTicketRegalo.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold);
            this.chbTicketRegalo.ForeColor = System.Drawing.Color.Black;
            this.chbTicketRegalo.Location = new System.Drawing.Point(236, 511);
            this.chbTicketRegalo.Name = "chbTicketRegalo";
            this.chbTicketRegalo.Size = new System.Drawing.Size(185, 23);
            this.chbTicketRegalo.TabIndex = 51;
            this.chbTicketRegalo.Text = "Imprimir Ticket Regalo";
            this.chbTicketRegalo.UseVisualStyleBackColor = true;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold);
            this.label1.ForeColor = System.Drawing.Color.Black;
            this.label1.Location = new System.Drawing.Point(190, 515);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(17, 19);
            this.label1.TabIndex = 48;
            this.label1.Text = "€";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Times New Roman", 12F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))));
            this.label4.ForeColor = System.Drawing.Color.DarkGoldenrod;
            this.label4.Location = new System.Drawing.Point(232, 481);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(63, 19);
            this.label4.TabIndex = 47;
            this.label4.Text = "OTROS";
            // 
            // tbAmount
            // 
            this.tbAmount.Location = new System.Drawing.Point(113, 515);
            this.tbAmount.Name = "tbAmount";
            this.tbAmount.Size = new System.Drawing.Size(71, 20);
            this.tbAmount.TabIndex = 45;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Times New Roman", 12F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))));
            this.label5.ForeColor = System.Drawing.Color.DarkGoldenrod;
            this.label5.Location = new System.Drawing.Point(21, 481);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(141, 19);
            this.label5.TabIndex = 44;
            this.label5.Text = "FORMA DE PAGO";
            // 
            // rbCard
            // 
            this.rbCard.AutoSize = true;
            this.rbCard.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold);
            this.rbCard.ForeColor = System.Drawing.Color.Black;
            this.rbCard.Location = new System.Drawing.Point(25, 536);
            this.rbCard.Name = "rbCard";
            this.rbCard.Size = new System.Drawing.Size(75, 23);
            this.rbCard.TabIndex = 43;
            this.rbCard.Text = "Tarjeta";
            this.rbCard.UseVisualStyleBackColor = true;
            this.rbCard.CheckedChanged += new System.EventHandler(this.rbCard_CheckedChanged);
            // 
            // rbCash
            // 
            this.rbCash.AutoSize = true;
            this.rbCash.Checked = true;
            this.rbCash.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rbCash.ForeColor = System.Drawing.Color.Black;
            this.rbCash.Location = new System.Drawing.Point(25, 512);
            this.rbCash.Name = "rbCash";
            this.rbCash.Size = new System.Drawing.Size(82, 23);
            this.rbCash.TabIndex = 42;
            this.rbCash.TabStop = true;
            this.rbCash.Text = "Efectivo";
            this.rbCash.UseVisualStyleBackColor = true;
            this.rbCash.CheckedChanged += new System.EventHandler(this.rbCash_CheckedChanged);
            // 
            // btnGetTicket
            // 
            this.btnGetTicket.BackColor = System.Drawing.Color.DarkGoldenrod;
            this.btnGetTicket.Font = new System.Drawing.Font("Times New Roman", 10F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))));
            this.btnGetTicket.Location = new System.Drawing.Point(484, 481);
            this.btnGetTicket.Name = "btnGetTicket";
            this.btnGetTicket.Size = new System.Drawing.Size(184, 78);
            this.btnGetTicket.TabIndex = 41;
            this.btnGetTicket.Text = "IMPRIMIR TICKET";
            this.btnGetTicket.UseVisualStyleBackColor = false;
            this.btnGetTicket.Click += new System.EventHandler(this.btnGetTicket_Click);
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Times New Roman", 12F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))));
            this.label8.ForeColor = System.Drawing.Color.DarkGoldenrod;
            this.label8.Location = new System.Drawing.Point(696, 477);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(61, 19);
            this.label8.TabIndex = 56;
            this.label8.Text = "TOTAL";
            // 
            // lbTotal
            // 
            this.lbTotal.AutoSize = true;
            this.lbTotal.Font = new System.Drawing.Font("Times New Roman", 20F, System.Drawing.FontStyle.Bold);
            this.lbTotal.ForeColor = System.Drawing.Color.Black;
            this.lbTotal.Location = new System.Drawing.Point(698, 515);
            this.lbTotal.Name = "lbTotal";
            this.lbTotal.Size = new System.Drawing.Size(84, 31);
            this.lbTotal.TabIndex = 55;
            this.lbTotal.Text = "0.00 €";
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
            // colDescuento
            // 
            this.colDescuento.HeaderText = "Descuento";
            this.colDescuento.Name = "colDescuento";
            this.colDescuento.ReadOnly = true;
            // 
            // colDelete
            // 
            this.colDelete.HeaderText = "";
            this.colDelete.Name = "colDelete";
            this.colDelete.ReadOnly = true;
            this.colDelete.Text = "Quitar";
            this.colDelete.UseColumnTextForButtonValue = true;
            // 
            // tbDescuento
            // 
            this.tbDescuento.Location = new System.Drawing.Point(503, 74);
            this.tbDescuento.Name = "tbDescuento";
            this.tbDescuento.Size = new System.Drawing.Size(60, 20);
            this.tbDescuento.TabIndex = 19;
            // 
            // lbDescuento
            // 
            this.lbDescuento.AutoSize = true;
            this.lbDescuento.Font = new System.Drawing.Font("Times New Roman", 9.75F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbDescuento.ForeColor = System.Drawing.SystemColors.ControlText;
            this.lbDescuento.Location = new System.Drawing.Point(419, 74);
            this.lbDescuento.Name = "lbDescuento";
            this.lbDescuento.Size = new System.Drawing.Size(69, 16);
            this.lbDescuento.TabIndex = 18;
            this.lbDescuento.Text = "Descuento:";
            // 
            // ucManualSale
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Beige;
            this.Controls.Add(this.label8);
            this.Controls.Add(this.lbTotal);
            this.Controls.Add(this.chbTicketRegalo);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.tbAmount);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.rbCard);
            this.Controls.Add(this.rbCash);
            this.Controls.Add(this.btnGetTicket);
            this.Controls.Add(this.lbManualSale);
            this.Controls.Add(this.dgvItem);
            this.Controls.Add(this.pnFilter);
            this.Name = "ucManualSale";
            this.Size = new System.Drawing.Size(809, 730);
            ((System.ComponentModel.ISupportInitialize)(this.dgvItem)).EndInit();
            this.pnFilter.ResumeLayout(false);
            this.pnFilter.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dgvItem;
        private System.Windows.Forms.Panel pnFilter;
        private System.Windows.Forms.Label lbItem;
        private System.Windows.Forms.TextBox tbQuant;
        private System.Windows.Forms.Label lbQuant;
        private System.Windows.Forms.Label lbPVP;
        private System.Windows.Forms.TextBox tbPVP;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox tbDescription;
        private System.Windows.Forms.Label lbRef;
        private System.Windows.Forms.TextBox tbRef;
        private System.Windows.Forms.Button btnAddItem;
        private System.Windows.Forms.Label lbManualSale;
        private System.Windows.Forms.CheckBox chbTicketRegalo;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox tbAmount;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.RadioButton rbCard;
        private System.Windows.Forms.RadioButton rbCash;
        private System.Windows.Forms.Button btnGetTicket;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label lbTotal;
        private System.Windows.Forms.DataGridViewTextBoxColumn colRef;
        private System.Windows.Forms.DataGridViewTextBoxColumn colDescripcion;
        private System.Windows.Forms.DataGridViewTextBoxColumn colPVP;
        private System.Windows.Forms.DataGridViewTextBoxColumn colCantidad;
        private System.Windows.Forms.DataGridViewTextBoxColumn colDescuento;
        private System.Windows.Forms.DataGridViewButtonColumn colDelete;
        private System.Windows.Forms.TextBox tbDescuento;
        private System.Windows.Forms.Label lbDescuento;
    }
}
