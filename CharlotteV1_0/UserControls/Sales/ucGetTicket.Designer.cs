namespace CharlotteV1_0
{
    partial class ucGetTicket
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle4 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle5 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle7 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle6 = new System.Windows.Forms.DataGridViewCellStyle();
            this.lbProviderList = new System.Windows.Forms.Label();
            this.btnGetTicket = new System.Windows.Forms.Button();
            this.pnFilter = new System.Windows.Forms.Panel();
            this.lbRefSearch = new System.Windows.Forms.Label();
            this.tbName = new System.Windows.Forms.TextBox();
            this.btnSearch = new System.Windows.Forms.Button();
            this.dgvItem = new System.Windows.Forms.DataGridView();
            this.dgvTicket = new System.Windows.Forms.DataGridView();
            this.rbCash = new System.Windows.Forms.RadioButton();
            this.rbCard = new System.Windows.Forms.RadioButton();
            this.label1 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.tbAmount = new System.Windows.Forms.TextBox();
            this.chbTarjetaRegalo = new System.Windows.Forms.CheckBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.tbIdTk = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.btnDisc = new System.Windows.Forms.Button();
            this.panel1 = new System.Windows.Forms.Panel();
            this.label6 = new System.Windows.Forms.Label();
            this.tbTk = new System.Windows.Forms.TextBox();
            this.chbTicketRegalo = new System.Windows.Forms.CheckBox();
            this.lbTotal = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.btnTarjetaRegalo = new System.Windows.Forms.Button();
            this.lbNombre = new System.Windows.Forms.Label();
            this.tbNombreVale = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.btnValeDev = new System.Windows.Forms.Button();
            this.colID = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colRef = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colDesc = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colPrecioUni = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colCantidad = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colDescuento = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colQuitar = new System.Windows.Forms.DataGridViewButtonColumn();
            this.colDisponible = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.pnFilter.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvItem)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvTicket)).BeginInit();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // lbProviderList
            // 
            this.lbProviderList.AutoSize = true;
            this.lbProviderList.Font = new System.Drawing.Font("Times New Roman", 20F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbProviderList.ForeColor = System.Drawing.Color.DarkGoldenrod;
            this.lbProviderList.Location = new System.Drawing.Point(279, 63);
            this.lbProviderList.Name = "lbProviderList";
            this.lbProviderList.Size = new System.Drawing.Size(244, 31);
            this.lbProviderList.TabIndex = 11;
            this.lbProviderList.Text = "REALIZAR VENTA";
            // 
            // btnGetTicket
            // 
            this.btnGetTicket.BackColor = System.Drawing.Color.DarkGoldenrod;
            this.btnGetTicket.Font = new System.Drawing.Font("Times New Roman", 10F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))));
            this.btnGetTicket.Location = new System.Drawing.Point(498, 514);
            this.btnGetTicket.Name = "btnGetTicket";
            this.btnGetTicket.Size = new System.Drawing.Size(184, 78);
            this.btnGetTicket.TabIndex = 19;
            this.btnGetTicket.Text = "IMPRIMIR TICKET";
            this.btnGetTicket.UseVisualStyleBackColor = false;
            this.btnGetTicket.Click += new System.EventHandler(this.btnGetTicket_Click);
            // 
            // pnFilter
            // 
            this.pnFilter.BackColor = System.Drawing.Color.Wheat;
            this.pnFilter.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.pnFilter.Controls.Add(this.lbRefSearch);
            this.pnFilter.Controls.Add(this.tbName);
            this.pnFilter.Controls.Add(this.btnSearch);
            this.pnFilter.Location = new System.Drawing.Point(39, 124);
            this.pnFilter.Name = "pnFilter";
            this.pnFilter.Size = new System.Drawing.Size(348, 72);
            this.pnFilter.TabIndex = 22;
            // 
            // lbRefSearch
            // 
            this.lbRefSearch.AutoSize = true;
            this.lbRefSearch.Font = new System.Drawing.Font("Times New Roman", 9.75F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbRefSearch.ForeColor = System.Drawing.SystemColors.ControlText;
            this.lbRefSearch.Location = new System.Drawing.Point(13, 29);
            this.lbRefSearch.Name = "lbRefSearch";
            this.lbRefSearch.Size = new System.Drawing.Size(72, 16);
            this.lbRefSearch.TabIndex = 5;
            this.lbRefSearch.Text = "Referencia:";
            // 
            // tbName
            // 
            this.tbName.Location = new System.Drawing.Point(91, 27);
            this.tbName.Name = "tbName";
            this.tbName.Size = new System.Drawing.Size(112, 20);
            this.tbName.TabIndex = 4;
            // 
            // btnSearch
            // 
            this.btnSearch.BackColor = System.Drawing.Color.DarkGoldenrod;
            this.btnSearch.Font = new System.Drawing.Font("Times New Roman", 10F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSearch.ForeColor = System.Drawing.Color.Black;
            this.btnSearch.Location = new System.Drawing.Point(209, 16);
            this.btnSearch.Name = "btnSearch";
            this.btnSearch.Size = new System.Drawing.Size(128, 42);
            this.btnSearch.TabIndex = 3;
            this.btnSearch.Text = "BUSCAR REFERENCIA";
            this.btnSearch.UseVisualStyleBackColor = false;
            this.btnSearch.Click += new System.EventHandler(this.btnSearch_Click);
            // 
            // dgvItem
            // 
            this.dgvItem.AllowUserToAddRows = false;
            this.dgvItem.AllowUserToDeleteRows = false;
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
            dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle3.BackColor = System.Drawing.SystemColors.Info;
            dataGridViewCellStyle3.Font = new System.Drawing.Font("Times New Roman", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle3.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle3.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle3.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dgvItem.DefaultCellStyle = dataGridViewCellStyle3;
            this.dgvItem.Location = new System.Drawing.Point(39, 202);
            this.dgvItem.Name = "dgvItem";
            this.dgvItem.ReadOnly = true;
            this.dgvItem.RowHeadersVisible = false;
            this.dgvItem.Size = new System.Drawing.Size(686, 134);
            this.dgvItem.TabIndex = 21;
            this.dgvItem.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvItem_CellContentClick);
            // 
            // dgvTicket
            // 
            this.dgvTicket.AllowUserToAddRows = false;
            this.dgvTicket.AllowUserToDeleteRows = false;
            dataGridViewCellStyle4.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(192)))), ((int)(((byte)(128)))));
            dataGridViewCellStyle4.ForeColor = System.Drawing.Color.Black;
            this.dgvTicket.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle4;
            dataGridViewCellStyle5.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle5.BackColor = System.Drawing.Color.DarkGoldenrod;
            dataGridViewCellStyle5.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle5.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle5.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle5.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle5.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgvTicket.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle5;
            this.dgvTicket.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvTicket.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.colID,
            this.colRef,
            this.colDesc,
            this.colPrecioUni,
            this.colCantidad,
            this.colDescuento,
            this.colQuitar,
            this.colDisponible});
            dataGridViewCellStyle7.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle7.BackColor = System.Drawing.SystemColors.Info;
            dataGridViewCellStyle7.Font = new System.Drawing.Font("Times New Roman", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle7.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle7.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle7.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle7.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dgvTicket.DefaultCellStyle = dataGridViewCellStyle7;
            this.dgvTicket.Location = new System.Drawing.Point(39, 385);
            this.dgvTicket.Name = "dgvTicket";
            this.dgvTicket.RowHeadersVisible = false;
            this.dgvTicket.Size = new System.Drawing.Size(744, 107);
            this.dgvTicket.TabIndex = 23;
            this.dgvTicket.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvTicket_CellContentClick);
            this.dgvTicket.CellValueChanged += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvTicket_CellValueChanged);
            // 
            // rbCash
            // 
            this.rbCash.AutoSize = true;
            this.rbCash.Checked = true;
            this.rbCash.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rbCash.ForeColor = System.Drawing.Color.Black;
            this.rbCash.Location = new System.Drawing.Point(39, 545);
            this.rbCash.Name = "rbCash";
            this.rbCash.Size = new System.Drawing.Size(82, 23);
            this.rbCash.TabIndex = 24;
            this.rbCash.TabStop = true;
            this.rbCash.Text = "Efectivo";
            this.rbCash.UseVisualStyleBackColor = true;
            this.rbCash.CheckedChanged += new System.EventHandler(this.rbCash_CheckedChanged);
            // 
            // rbCard
            // 
            this.rbCard.AutoSize = true;
            this.rbCard.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold);
            this.rbCard.ForeColor = System.Drawing.Color.Black;
            this.rbCard.Location = new System.Drawing.Point(39, 569);
            this.rbCard.Name = "rbCard";
            this.rbCard.Size = new System.Drawing.Size(75, 23);
            this.rbCard.TabIndex = 25;
            this.rbCard.Text = "Tarjeta";
            this.rbCard.UseVisualStyleBackColor = true;
            this.rbCard.CheckedChanged += new System.EventHandler(this.rbCard_CheckedChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Times New Roman", 12F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))));
            this.label1.ForeColor = System.Drawing.Color.DarkGoldenrod;
            this.label1.Location = new System.Drawing.Point(261, 354);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(164, 19);
            this.label1.TabIndex = 26;
            this.label1.Text = "TICKET A GENERAR";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Times New Roman", 12F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))));
            this.label5.ForeColor = System.Drawing.Color.DarkGoldenrod;
            this.label5.Location = new System.Drawing.Point(35, 514);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(141, 19);
            this.label5.TabIndex = 27;
            this.label5.Text = "FORMA DE PAGO";
            // 
            // tbAmount
            // 
            this.tbAmount.Location = new System.Drawing.Point(127, 548);
            this.tbAmount.Name = "tbAmount";
            this.tbAmount.Size = new System.Drawing.Size(71, 20);
            this.tbAmount.TabIndex = 29;
            // 
            // chbTarjetaRegalo
            // 
            this.chbTarjetaRegalo.AutoSize = true;
            this.chbTarjetaRegalo.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold);
            this.chbTarjetaRegalo.ForeColor = System.Drawing.Color.Black;
            this.chbTarjetaRegalo.Location = new System.Drawing.Point(250, 587);
            this.chbTarjetaRegalo.Name = "chbTarjetaRegalo";
            this.chbTarjetaRegalo.Size = new System.Drawing.Size(128, 23);
            this.chbTarjetaRegalo.TabIndex = 30;
            this.chbTarjetaRegalo.Text = "Tarjeta Regalo";
            this.chbTarjetaRegalo.UseVisualStyleBackColor = true;
            this.chbTarjetaRegalo.CheckedChanged += new System.EventHandler(this.chbTarjetaRegalo_CheckedChanged);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Times New Roman", 12F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))));
            this.label2.ForeColor = System.Drawing.Color.DarkGoldenrod;
            this.label2.Location = new System.Drawing.Point(246, 514);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(63, 19);
            this.label2.TabIndex = 31;
            this.label2.Text = "OTROS";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold);
            this.label3.ForeColor = System.Drawing.Color.Black;
            this.label3.Location = new System.Drawing.Point(204, 548);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(17, 19);
            this.label3.TabIndex = 32;
            this.label3.Text = "€";
            // 
            // tbIdTk
            // 
            this.tbIdTk.Location = new System.Drawing.Point(72, 25);
            this.tbIdTk.Name = "tbIdTk";
            this.tbIdTk.Size = new System.Drawing.Size(100, 20);
            this.tbIdTk.TabIndex = 33;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold);
            this.label4.ForeColor = System.Drawing.Color.Black;
            this.label4.Location = new System.Drawing.Point(9, 26);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(57, 19);
            this.label4.TabIndex = 34;
            this.label4.Text = "Nº TK:";
            // 
            // btnDisc
            // 
            this.btnDisc.BackColor = System.Drawing.Color.DarkGoldenrod;
            this.btnDisc.Font = new System.Drawing.Font("Times New Roman", 10F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnDisc.ForeColor = System.Drawing.Color.Black;
            this.btnDisc.Location = new System.Drawing.Point(191, 16);
            this.btnDisc.Name = "btnDisc";
            this.btnDisc.Size = new System.Drawing.Size(134, 42);
            this.btnDisc.TabIndex = 6;
            this.btnDisc.Text = "DESCONTAR VALE";
            this.btnDisc.UseVisualStyleBackColor = false;
            this.btnDisc.Click += new System.EventHandler(this.btnDisc_Click);
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.Wheat;
            this.panel1.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.panel1.Controls.Add(this.btnDisc);
            this.panel1.Controls.Add(this.label4);
            this.panel1.Controls.Add(this.tbIdTk);
            this.panel1.Location = new System.Drawing.Point(393, 124);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(332, 72);
            this.panel1.TabIndex = 23;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold);
            this.label6.ForeColor = System.Drawing.Color.Black;
            this.label6.Location = new System.Drawing.Point(453, 588);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(17, 19);
            this.label6.TabIndex = 34;
            this.label6.Text = "€";
            // 
            // tbTk
            // 
            this.tbTk.Enabled = false;
            this.tbTk.Location = new System.Drawing.Point(376, 588);
            this.tbTk.Name = "tbTk";
            this.tbTk.Size = new System.Drawing.Size(71, 20);
            this.tbTk.TabIndex = 33;
            // 
            // chbTicketRegalo
            // 
            this.chbTicketRegalo.AutoSize = true;
            this.chbTicketRegalo.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold);
            this.chbTicketRegalo.ForeColor = System.Drawing.Color.Black;
            this.chbTicketRegalo.Location = new System.Drawing.Point(250, 544);
            this.chbTicketRegalo.Name = "chbTicketRegalo";
            this.chbTicketRegalo.Size = new System.Drawing.Size(185, 23);
            this.chbTicketRegalo.TabIndex = 35;
            this.chbTicketRegalo.Text = "Imprimir Ticket Regalo";
            this.chbTicketRegalo.UseVisualStyleBackColor = true;
            // 
            // lbTotal
            // 
            this.lbTotal.AutoSize = true;
            this.lbTotal.Font = new System.Drawing.Font("Times New Roman", 20F, System.Drawing.FontStyle.Bold);
            this.lbTotal.ForeColor = System.Drawing.Color.Black;
            this.lbTotal.Location = new System.Drawing.Point(699, 532);
            this.lbTotal.Name = "lbTotal";
            this.lbTotal.Size = new System.Drawing.Size(84, 31);
            this.lbTotal.TabIndex = 36;
            this.lbTotal.Text = "0.00 €";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Times New Roman", 12F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))));
            this.label8.ForeColor = System.Drawing.Color.DarkGoldenrod;
            this.label8.Location = new System.Drawing.Point(697, 510);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(61, 19);
            this.label8.TabIndex = 37;
            this.label8.Text = "TOTAL";
            // 
            // btnTarjetaRegalo
            // 
            this.btnTarjetaRegalo.BackColor = System.Drawing.Color.DarkGoldenrod;
            this.btnTarjetaRegalo.Font = new System.Drawing.Font("Times New Roman", 10F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))));
            this.btnTarjetaRegalo.Location = new System.Drawing.Point(547, 598);
            this.btnTarjetaRegalo.Name = "btnTarjetaRegalo";
            this.btnTarjetaRegalo.Size = new System.Drawing.Size(135, 59);
            this.btnTarjetaRegalo.TabIndex = 38;
            this.btnTarjetaRegalo.Text = "IMPRIMIR TARJETA REGALO";
            this.btnTarjetaRegalo.UseVisualStyleBackColor = false;
            this.btnTarjetaRegalo.Visible = false;
            this.btnTarjetaRegalo.Click += new System.EventHandler(this.btnTarjetaRegalo_Click);
            // 
            // lbNombre
            // 
            this.lbNombre.AutoSize = true;
            this.lbNombre.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold);
            this.lbNombre.ForeColor = System.Drawing.Color.Black;
            this.lbNombre.Location = new System.Drawing.Point(246, 624);
            this.lbNombre.Name = "lbNombre";
            this.lbNombre.Size = new System.Drawing.Size(68, 19);
            this.lbNombre.TabIndex = 39;
            this.lbNombre.Text = "Nombre:";
            // 
            // tbNombreVale
            // 
            this.tbNombreVale.Enabled = false;
            this.tbNombreVale.Location = new System.Drawing.Point(320, 623);
            this.tbNombreVale.Name = "tbNombreVale";
            this.tbNombreVale.Size = new System.Drawing.Size(221, 20);
            this.tbNombreVale.TabIndex = 40;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Times New Roman", 12F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))));
            this.label7.ForeColor = System.Drawing.Color.DarkGoldenrod;
            this.label7.Location = new System.Drawing.Point(35, 598);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(118, 19);
            this.label7.TabIndex = 41;
            this.label7.Text = "DEVOLUCION";
            // 
            // btnValeDev
            // 
            this.btnValeDev.BackColor = System.Drawing.Color.DarkGoldenrod;
            this.btnValeDev.Font = new System.Drawing.Font("Times New Roman", 10F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))));
            this.btnValeDev.Location = new System.Drawing.Point(30, 620);
            this.btnValeDev.Name = "btnValeDev";
            this.btnValeDev.Size = new System.Drawing.Size(168, 47);
            this.btnValeDev.TabIndex = 42;
            this.btnValeDev.Text = "VALE POR DEVOLUCION";
            this.btnValeDev.UseVisualStyleBackColor = false;
            this.btnValeDev.Click += new System.EventHandler(this.btnValeDev_Click);
            // 
            // colID
            // 
            this.colID.HeaderText = "ID";
            this.colID.Name = "colID";
            this.colID.Visible = false;
            // 
            // colRef
            // 
            this.colRef.HeaderText = "REFERENCIA";
            this.colRef.Name = "colRef";
            this.colRef.Width = 120;
            // 
            // colDesc
            // 
            this.colDesc.HeaderText = "DESCRIPCIÓN";
            this.colDesc.Name = "colDesc";
            this.colDesc.Width = 200;
            // 
            // colPrecioUni
            // 
            dataGridViewCellStyle6.NullValue = null;
            this.colPrecioUni.DefaultCellStyle = dataGridViewCellStyle6;
            this.colPrecioUni.HeaderText = "PRECIO U.";
            this.colPrecioUni.Name = "colPrecioUni";
            this.colPrecioUni.Width = 120;
            // 
            // colCantidad
            // 
            this.colCantidad.HeaderText = "CANTIDAD";
            this.colCantidad.Name = "colCantidad";
            // 
            // colDescuento
            // 
            this.colDescuento.HeaderText = "DESCUENTO";
            this.colDescuento.Name = "colDescuento";
            // 
            // colQuitar
            // 
            this.colQuitar.HeaderText = "QUITAR";
            this.colQuitar.Name = "colQuitar";
            this.colQuitar.Text = "Quitar";
            this.colQuitar.UseColumnTextForButtonValue = true;
            // 
            // colDisponible
            // 
            this.colDisponible.HeaderText = "DISPONIBLE";
            this.colDisponible.Name = "colDisponible";
            this.colDisponible.Visible = false;
            // 
            // ucGetTicket
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Beige;
            this.Controls.Add(this.btnValeDev);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.tbNombreVale);
            this.Controls.Add(this.lbNombre);
            this.Controls.Add(this.btnTarjetaRegalo);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.lbTotal);
            this.Controls.Add(this.chbTicketRegalo);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.tbTk);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.chbTarjetaRegalo);
            this.Controls.Add(this.tbAmount);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.rbCard);
            this.Controls.Add(this.rbCash);
            this.Controls.Add(this.dgvTicket);
            this.Controls.Add(this.pnFilter);
            this.Controls.Add(this.dgvItem);
            this.Controls.Add(this.btnGetTicket);
            this.Controls.Add(this.lbProviderList);
            this.Name = "ucGetTicket";
            this.Size = new System.Drawing.Size(809, 730);
            this.pnFilter.ResumeLayout(false);
            this.pnFilter.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvItem)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvTicket)).EndInit();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lbProviderList;
        private System.Windows.Forms.Button btnGetTicket;
        private System.Windows.Forms.Panel pnFilter;
        private System.Windows.Forms.Label lbRefSearch;
        private System.Windows.Forms.TextBox tbName;
        private System.Windows.Forms.Button btnSearch;
        private System.Windows.Forms.DataGridView dgvItem;
        private System.Windows.Forms.DataGridView dgvTicket;
        private System.Windows.Forms.RadioButton rbCash;
        private System.Windows.Forms.RadioButton rbCard;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox tbAmount;
        private System.Windows.Forms.CheckBox chbTarjetaRegalo;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox tbIdTk;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Button btnDisc;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox tbTk;
        private System.Windows.Forms.CheckBox chbTicketRegalo;
        private System.Windows.Forms.Label lbTotal;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Button btnTarjetaRegalo;
        private System.Windows.Forms.Label lbNombre;
        private System.Windows.Forms.TextBox tbNombreVale;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Button btnValeDev;
        private System.Windows.Forms.DataGridViewTextBoxColumn colID;
        private System.Windows.Forms.DataGridViewTextBoxColumn colRef;
        private System.Windows.Forms.DataGridViewTextBoxColumn colDesc;
        private System.Windows.Forms.DataGridViewTextBoxColumn colPrecioUni;
        private System.Windows.Forms.DataGridViewTextBoxColumn colCantidad;
        private System.Windows.Forms.DataGridViewTextBoxColumn colDescuento;
        private System.Windows.Forms.DataGridViewButtonColumn colQuitar;
        private System.Windows.Forms.DataGridViewTextBoxColumn colDisponible;
    }
}
