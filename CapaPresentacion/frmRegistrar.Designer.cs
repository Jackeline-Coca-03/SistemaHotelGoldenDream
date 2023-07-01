namespace CapaPresentacion
{
    partial class frmRegistrar
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

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle4 = new System.Windows.Forms.DataGridViewCellStyle();
            this.label10 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.rgbhospedaje = new System.Windows.Forms.GroupBox();
            this.txtnoche = new System.Windows.Forms.TextBox();
            this.txtdia = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.txtfechar = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.txtnombrecliente = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.txtcicliente = new System.Windows.Forms.TextBox();
            this.label12 = new System.Windows.Forms.Label();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.txtnumhab = new System.Windows.Forms.TextBox();
            this.label8 = new System.Windows.Forms.Label();
            this.txtcodigo = new System.Windows.Forms.TextBox();
            this.label9 = new System.Windows.Forms.Label();
            this.txtprecio = new System.Windows.Forms.TextBox();
            this.numericUpDown3 = new System.Windows.Forms.NumericUpDown();
            this.label11 = new System.Windows.Forms.Label();
            this.label13 = new System.Windows.Forms.Label();
            this.dgvdata = new System.Windows.Forms.DataGridView();
            this.txtcambio = new System.Windows.Forms.TextBox();
            this.txtpagocon = new System.Windows.Forms.TextBox();
            this.label14 = new System.Windows.Forms.Label();
            this.label15 = new System.Windows.Forms.Label();
            this.txttotalpagar = new System.Windows.Forms.TextBox();
            this.label16 = new System.Windows.Forms.Label();
            this.Id = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.numero = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.precio = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.cantidad = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.subtotal = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Btnseleccionar = new System.Windows.Forms.DataGridViewButtonColumn();
            this.txtidhab = new System.Windows.Forms.TextBox();
            this.dtmingreso = new System.Windows.Forms.DateTimePicker();
            this.dtmsalida = new System.Windows.Forms.DateTimePicker();
            this.btnRegistrar = new FontAwesome.Sharp.IconButton();
            this.btnagregar = new FontAwesome.Sharp.IconButton();
            this.btnbuscarhab = new FontAwesome.Sharp.IconButton();
            this.btnbuscarcliente = new FontAwesome.Sharp.IconButton();
            this.rgbhospedaje.SuspendLayout();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDown3)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvdata)).BeginInit();
            this.SuspendLayout();
            // 
            // label10
            // 
            this.label10.BackColor = System.Drawing.Color.White;
            this.label10.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label10.ForeColor = System.Drawing.Color.Black;
            this.label10.Location = new System.Drawing.Point(80, 35);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(928, 471);
            this.label10.TabIndex = 30;
            this.label10.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.Color.White;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(98, 54);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(207, 25);
            this.label2.TabIndex = 31;
            this.label2.Text = "Registrar Hospedaje";
            // 
            // rgbhospedaje
            // 
            this.rgbhospedaje.BackColor = System.Drawing.Color.White;
            this.rgbhospedaje.Controls.Add(this.dtmsalida);
            this.rgbhospedaje.Controls.Add(this.txtnoche);
            this.rgbhospedaje.Controls.Add(this.dtmingreso);
            this.rgbhospedaje.Controls.Add(this.txtdia);
            this.rgbhospedaje.Controls.Add(this.label6);
            this.rgbhospedaje.Controls.Add(this.label5);
            this.rgbhospedaje.Controls.Add(this.label4);
            this.rgbhospedaje.Controls.Add(this.label1);
            this.rgbhospedaje.Controls.Add(this.txtfechar);
            this.rgbhospedaje.Controls.Add(this.label3);
            this.rgbhospedaje.Location = new System.Drawing.Point(103, 82);
            this.rgbhospedaje.Name = "rgbhospedaje";
            this.rgbhospedaje.Size = new System.Drawing.Size(523, 80);
            this.rgbhospedaje.TabIndex = 32;
            this.rgbhospedaje.TabStop = false;
            this.rgbhospedaje.Text = "Informacion Hospedaje";
            // 
            // txtnoche
            // 
            this.txtnoche.Location = new System.Drawing.Point(243, 52);
            this.txtnoche.Name = "txtnoche";
            this.txtnoche.Size = new System.Drawing.Size(54, 20);
            this.txtnoche.TabIndex = 19;
            // 
            // txtdia
            // 
            this.txtdia.Location = new System.Drawing.Point(241, 21);
            this.txtdia.Name = "txtdia";
            this.txtdia.Size = new System.Drawing.Size(56, 20);
            this.txtdia.TabIndex = 18;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.BackColor = System.Drawing.Color.White;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(303, 55);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(85, 13);
            this.label6.TabIndex = 16;
            this.label6.Text = "Fecha Salida:";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.BackColor = System.Drawing.Color.White;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(303, 24);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(98, 13);
            this.label5.TabIndex = 15;
            this.label5.Text = "Fecha Ingrseso:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.BackColor = System.Drawing.Color.White;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(113, 55);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(124, 13);
            this.label4.TabIndex = 14;
            this.label4.Text = "Cantidad de noches:";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.White;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(113, 24);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(106, 13);
            this.label1.TabIndex = 13;
            this.label1.Text = "Cantidad de dias:";
            // 
            // txtfechar
            // 
            this.txtfechar.Location = new System.Drawing.Point(8, 39);
            this.txtfechar.Name = "txtfechar";
            this.txtfechar.Size = new System.Drawing.Size(99, 20);
            this.txtfechar.TabIndex = 11;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.BackColor = System.Drawing.Color.White;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(6, 23);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(46, 13);
            this.label3.TabIndex = 10;
            this.label3.Text = "Fecha:";
            // 
            // groupBox1
            // 
            this.groupBox1.BackColor = System.Drawing.Color.White;
            this.groupBox1.Controls.Add(this.btnbuscarcliente);
            this.groupBox1.Controls.Add(this.txtnombrecliente);
            this.groupBox1.Controls.Add(this.label7);
            this.groupBox1.Controls.Add(this.txtcicliente);
            this.groupBox1.Controls.Add(this.label12);
            this.groupBox1.Location = new System.Drawing.Point(641, 82);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(340, 80);
            this.groupBox1.TabIndex = 33;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Informacion Cliente";
            // 
            // txtnombrecliente
            // 
            this.txtnombrecliente.Location = new System.Drawing.Point(191, 48);
            this.txtnombrecliente.Name = "txtnombrecliente";
            this.txtnombrecliente.Size = new System.Drawing.Size(131, 20);
            this.txtnombrecliente.TabIndex = 19;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.BackColor = System.Drawing.Color.White;
            this.label7.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.Location = new System.Drawing.Point(188, 24);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(110, 13);
            this.label7.TabIndex = 16;
            this.label7.Text = "Nombre Completo:";
            // 
            // txtcicliente
            // 
            this.txtcicliente.Location = new System.Drawing.Point(15, 48);
            this.txtcicliente.Name = "txtcicliente";
            this.txtcicliente.Size = new System.Drawing.Size(99, 20);
            this.txtcicliente.TabIndex = 11;
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.BackColor = System.Drawing.Color.White;
            this.label12.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label12.Location = new System.Drawing.Point(16, 24);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(66, 13);
            this.label12.TabIndex = 10;
            this.label12.Text = "CI Cliente:";
            // 
            // groupBox2
            // 
            this.groupBox2.BackColor = System.Drawing.Color.White;
            this.groupBox2.Controls.Add(this.txtidhab);
            this.groupBox2.Controls.Add(this.btnbuscarhab);
            this.groupBox2.Controls.Add(this.txtnumhab);
            this.groupBox2.Controls.Add(this.label8);
            this.groupBox2.Controls.Add(this.txtcodigo);
            this.groupBox2.Controls.Add(this.label9);
            this.groupBox2.Controls.Add(this.txtprecio);
            this.groupBox2.Controls.Add(this.numericUpDown3);
            this.groupBox2.Controls.Add(this.label11);
            this.groupBox2.Controls.Add(this.label13);
            this.groupBox2.Location = new System.Drawing.Point(103, 168);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(694, 80);
            this.groupBox2.TabIndex = 34;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Informacion Habitacion";
            // 
            // txtnumhab
            // 
            this.txtnumhab.Location = new System.Drawing.Point(209, 52);
            this.txtnumhab.Name = "txtnumhab";
            this.txtnumhab.Size = new System.Drawing.Size(114, 20);
            this.txtnumhab.TabIndex = 42;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.BackColor = System.Drawing.Color.White;
            this.label8.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.Location = new System.Drawing.Point(435, 30);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(61, 13);
            this.label8.TabIndex = 39;
            this.label8.Text = "Cantidad:";
            // 
            // txtcodigo
            // 
            this.txtcodigo.Location = new System.Drawing.Point(21, 52);
            this.txtcodigo.Name = "txtcodigo";
            this.txtcodigo.Size = new System.Drawing.Size(112, 20);
            this.txtcodigo.TabIndex = 36;
            this.txtcodigo.KeyDown += new System.Windows.Forms.KeyEventHandler(this.txtcodigo_KeyDown);
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.BackColor = System.Drawing.Color.White;
            this.label9.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label9.Location = new System.Drawing.Point(18, 30);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(115, 13);
            this.label9.TabIndex = 35;
            this.label9.Text = "Codigo Habitacion:";
            // 
            // txtprecio
            // 
            this.txtprecio.Location = new System.Drawing.Point(348, 53);
            this.txtprecio.Name = "txtprecio";
            this.txtprecio.Size = new System.Drawing.Size(63, 20);
            this.txtprecio.TabIndex = 41;
            // 
            // numericUpDown3
            // 
            this.numericUpDown3.Location = new System.Drawing.Point(438, 53);
            this.numericUpDown3.Name = "numericUpDown3";
            this.numericUpDown3.Size = new System.Drawing.Size(85, 20);
            this.numericUpDown3.TabIndex = 40;
            this.numericUpDown3.Value = new decimal(new int[] {
            1,
            0,
            0,
            0});
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.BackColor = System.Drawing.Color.White;
            this.label11.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label11.Location = new System.Drawing.Point(345, 30);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(47, 13);
            this.label11.TabIndex = 38;
            this.label11.Text = "Precio:";
            // 
            // label13
            // 
            this.label13.AutoSize = true;
            this.label13.BackColor = System.Drawing.Color.White;
            this.label13.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label13.Location = new System.Drawing.Point(206, 30);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(117, 13);
            this.label13.TabIndex = 37;
            this.label13.Text = "Numero habitacion:";
            // 
            // dgvdata
            // 
            this.dgvdata.AllowUserToAddRows = false;
            this.dgvdata.AllowUserToDeleteRows = false;
            this.dgvdata.BackgroundColor = System.Drawing.Color.White;
            dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle3.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle3.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle3.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle3.Padding = new System.Windows.Forms.Padding(2);
            dataGridViewCellStyle3.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle3.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgvdata.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle3;
            this.dgvdata.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvdata.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Id,
            this.numero,
            this.precio,
            this.cantidad,
            this.subtotal,
            this.Btnseleccionar});
            this.dgvdata.Location = new System.Drawing.Point(103, 254);
            this.dgvdata.MultiSelect = false;
            this.dgvdata.Name = "dgvdata";
            this.dgvdata.ReadOnly = true;
            dataGridViewCellStyle4.SelectionBackColor = System.Drawing.Color.White;
            dataGridViewCellStyle4.SelectionForeColor = System.Drawing.Color.Black;
            this.dgvdata.RowsDefaultCellStyle = dataGridViewCellStyle4;
            this.dgvdata.RowTemplate.Height = 28;
            this.dgvdata.Size = new System.Drawing.Size(694, 227);
            this.dgvdata.TabIndex = 35;
            // 
            // txtcambio
            // 
            this.txtcambio.Location = new System.Drawing.Point(819, 390);
            this.txtcambio.Name = "txtcambio";
            this.txtcambio.Size = new System.Drawing.Size(156, 20);
            this.txtcambio.TabIndex = 42;
            // 
            // txtpagocon
            // 
            this.txtpagocon.Location = new System.Drawing.Point(819, 340);
            this.txtpagocon.Name = "txtpagocon";
            this.txtpagocon.Size = new System.Drawing.Size(156, 20);
            this.txtpagocon.TabIndex = 41;
            // 
            // label14
            // 
            this.label14.AutoSize = true;
            this.label14.BackColor = System.Drawing.Color.White;
            this.label14.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label14.Location = new System.Drawing.Point(816, 374);
            this.label14.Name = "label14";
            this.label14.Size = new System.Drawing.Size(52, 13);
            this.label14.TabIndex = 40;
            this.label14.Text = "Cambio:";
            // 
            // label15
            // 
            this.label15.AutoSize = true;
            this.label15.BackColor = System.Drawing.Color.White;
            this.label15.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label15.Location = new System.Drawing.Point(816, 324);
            this.label15.Name = "label15";
            this.label15.Size = new System.Drawing.Size(66, 13);
            this.label15.TabIndex = 39;
            this.label15.Text = "Paga Con:";
            // 
            // txttotalpagar
            // 
            this.txttotalpagar.Location = new System.Drawing.Point(819, 290);
            this.txttotalpagar.Name = "txttotalpagar";
            this.txttotalpagar.Size = new System.Drawing.Size(156, 20);
            this.txttotalpagar.TabIndex = 38;
            this.txttotalpagar.Text = "0";
            // 
            // label16
            // 
            this.label16.AutoSize = true;
            this.label16.BackColor = System.Drawing.Color.White;
            this.label16.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label16.Location = new System.Drawing.Point(816, 274);
            this.label16.Name = "label16";
            this.label16.Size = new System.Drawing.Size(87, 13);
            this.label16.TabIndex = 37;
            this.label16.Text = "Total a pagar:";
            // 
            // Id
            // 
            this.Id.HeaderText = "id_hab";
            this.Id.Name = "Id";
            this.Id.ReadOnly = true;
            this.Id.Visible = false;
            // 
            // numero
            // 
            this.numero.HeaderText = "Numero de Habitacion";
            this.numero.Name = "numero";
            this.numero.ReadOnly = true;
            this.numero.Width = 160;
            // 
            // precio
            // 
            this.precio.HeaderText = "Precio de Habitacion";
            this.precio.Name = "precio";
            this.precio.ReadOnly = true;
            this.precio.Width = 150;
            // 
            // cantidad
            // 
            this.cantidad.HeaderText = "Cantidad de Habitaciones";
            this.cantidad.Name = "cantidad";
            this.cantidad.ReadOnly = true;
            this.cantidad.Width = 180;
            // 
            // subtotal
            // 
            this.subtotal.HeaderText = "Subtotal";
            this.subtotal.Name = "subtotal";
            this.subtotal.ReadOnly = true;
            // 
            // Btnseleccionar
            // 
            this.Btnseleccionar.FillWeight = 150F;
            this.Btnseleccionar.HeaderText = "";
            this.Btnseleccionar.Name = "Btnseleccionar";
            this.Btnseleccionar.ReadOnly = true;
            this.Btnseleccionar.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            this.Btnseleccionar.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.Automatic;
            this.Btnseleccionar.Width = 25;
            // 
            // txtidhab
            // 
            this.txtidhab.Location = new System.Drawing.Point(151, 19);
            this.txtidhab.Name = "txtidhab";
            this.txtidhab.Size = new System.Drawing.Size(28, 20);
            this.txtidhab.TabIndex = 64;
            this.txtidhab.Visible = false;
            // 
            // dtmingreso
            // 
            this.dtmingreso.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dtmingreso.Location = new System.Drawing.Point(407, 18);
            this.dtmingreso.Name = "dtmingreso";
            this.dtmingreso.Size = new System.Drawing.Size(99, 20);
            this.dtmingreso.TabIndex = 44;
            this.dtmingreso.Value = new System.DateTime(2023, 7, 1, 1, 56, 37, 0);
            // 
            // dtmsalida
            // 
            this.dtmsalida.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dtmsalida.Location = new System.Drawing.Point(407, 52);
            this.dtmsalida.Name = "dtmsalida";
            this.dtmsalida.Size = new System.Drawing.Size(99, 20);
            this.dtmsalida.TabIndex = 65;
            this.dtmsalida.Value = new System.DateTime(2023, 7, 1, 1, 56, 37, 0);
            this.dtmsalida.ValueChanged += new System.EventHandler(this.dtmsalida_ValueChanged);
            // 
            // btnRegistrar
            // 
            this.btnRegistrar.BackColor = System.Drawing.Color.Silver;
            this.btnRegistrar.FlatAppearance.BorderColor = System.Drawing.Color.Teal;
            this.btnRegistrar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnRegistrar.ForeColor = System.Drawing.Color.Black;
            this.btnRegistrar.IconChar = FontAwesome.Sharp.IconChar.ListAlt;
            this.btnRegistrar.IconColor = System.Drawing.Color.DodgerBlue;
            this.btnRegistrar.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.btnRegistrar.IconSize = 25;
            this.btnRegistrar.ImageAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnRegistrar.Location = new System.Drawing.Point(819, 442);
            this.btnRegistrar.Name = "btnRegistrar";
            this.btnRegistrar.Size = new System.Drawing.Size(156, 39);
            this.btnRegistrar.TabIndex = 43;
            this.btnRegistrar.Text = "Registrar";
            this.btnRegistrar.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnRegistrar.UseVisualStyleBackColor = false;
            // 
            // btnagregar
            // 
            this.btnagregar.BackColor = System.Drawing.Color.Silver;
            this.btnagregar.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(192)))), ((int)(((byte)(0)))));
            this.btnagregar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnagregar.ForeColor = System.Drawing.Color.Black;
            this.btnagregar.IconChar = FontAwesome.Sharp.IconChar.PlusCircle;
            this.btnagregar.IconColor = System.Drawing.Color.Green;
            this.btnagregar.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.btnagregar.Location = new System.Drawing.Point(843, 178);
            this.btnagregar.Name = "btnagregar";
            this.btnagregar.Size = new System.Drawing.Size(93, 70);
            this.btnagregar.TabIndex = 36;
            this.btnagregar.Text = "Agregar";
            this.btnagregar.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            this.btnagregar.UseVisualStyleBackColor = false;
            // 
            // btnbuscarhab
            // 
            this.btnbuscarhab.BackColor = System.Drawing.Color.White;
            this.btnbuscarhab.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnbuscarhab.FlatAppearance.BorderColor = System.Drawing.Color.Black;
            this.btnbuscarhab.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnbuscarhab.ForeColor = System.Drawing.Color.White;
            this.btnbuscarhab.IconChar = FontAwesome.Sharp.IconChar.MagnifyingGlass;
            this.btnbuscarhab.IconColor = System.Drawing.Color.Black;
            this.btnbuscarhab.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.btnbuscarhab.IconSize = 16;
            this.btnbuscarhab.Location = new System.Drawing.Point(151, 50);
            this.btnbuscarhab.Name = "btnbuscarhab";
            this.btnbuscarhab.Size = new System.Drawing.Size(40, 23);
            this.btnbuscarhab.TabIndex = 43;
            this.btnbuscarhab.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnbuscarhab.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnbuscarhab.UseVisualStyleBackColor = false;
            this.btnbuscarhab.Click += new System.EventHandler(this.btnbuscarhab_Click);
            // 
            // btnbuscarcliente
            // 
            this.btnbuscarcliente.BackColor = System.Drawing.Color.White;
            this.btnbuscarcliente.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnbuscarcliente.FlatAppearance.BorderColor = System.Drawing.Color.Black;
            this.btnbuscarcliente.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnbuscarcliente.ForeColor = System.Drawing.Color.White;
            this.btnbuscarcliente.IconChar = FontAwesome.Sharp.IconChar.MagnifyingGlass;
            this.btnbuscarcliente.IconColor = System.Drawing.Color.Black;
            this.btnbuscarcliente.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.btnbuscarcliente.IconSize = 16;
            this.btnbuscarcliente.Location = new System.Drawing.Point(130, 45);
            this.btnbuscarcliente.Name = "btnbuscarcliente";
            this.btnbuscarcliente.Size = new System.Drawing.Size(40, 23);
            this.btnbuscarcliente.TabIndex = 34;
            this.btnbuscarcliente.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnbuscarcliente.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnbuscarcliente.UseVisualStyleBackColor = false;
            this.btnbuscarcliente.Click += new System.EventHandler(this.btnbuscarcliente_Click);
            // 
            // frmRegistrar
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Black;
            this.ClientSize = new System.Drawing.Size(1042, 531);
            this.Controls.Add(this.btnRegistrar);
            this.Controls.Add(this.txtcambio);
            this.Controls.Add(this.txtpagocon);
            this.Controls.Add(this.label14);
            this.Controls.Add(this.label15);
            this.Controls.Add(this.txttotalpagar);
            this.Controls.Add(this.label16);
            this.Controls.Add(this.btnagregar);
            this.Controls.Add(this.dgvdata);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.rgbhospedaje);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label10);
            this.Name = "frmRegistrar";
            this.Text = "frmRegistrar";
            this.Load += new System.EventHandler(this.frmRegistrar_Load);
            this.rgbhospedaje.ResumeLayout(false);
            this.rgbhospedaje.PerformLayout();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDown3)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvdata)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.GroupBox rgbhospedaje;
        private System.Windows.Forms.TextBox txtfechar;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox txtnoche;
        private System.Windows.Forms.TextBox txtdia;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.TextBox txtnombrecliente;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.TextBox txtcicliente;
        private System.Windows.Forms.Label label12;
        private FontAwesome.Sharp.IconButton btnbuscarcliente;
        private System.Windows.Forms.GroupBox groupBox2;
        private FontAwesome.Sharp.IconButton btnbuscarhab;
        private System.Windows.Forms.TextBox txtnumhab;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.TextBox txtcodigo;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.TextBox txtprecio;
        private System.Windows.Forms.NumericUpDown numericUpDown3;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.Label label13;
        private System.Windows.Forms.DataGridView dgvdata;
        private FontAwesome.Sharp.IconButton btnagregar;
        private System.Windows.Forms.TextBox txtcambio;
        private System.Windows.Forms.TextBox txtpagocon;
        private System.Windows.Forms.Label label14;
        private System.Windows.Forms.Label label15;
        private System.Windows.Forms.TextBox txttotalpagar;
        private System.Windows.Forms.Label label16;
        private FontAwesome.Sharp.IconButton btnRegistrar;
        private System.Windows.Forms.DataGridViewTextBoxColumn Id;
        private System.Windows.Forms.DataGridViewTextBoxColumn numero;
        private System.Windows.Forms.DataGridViewTextBoxColumn precio;
        private System.Windows.Forms.DataGridViewTextBoxColumn cantidad;
        private System.Windows.Forms.DataGridViewTextBoxColumn subtotal;
        private System.Windows.Forms.DataGridViewButtonColumn Btnseleccionar;
        private System.Windows.Forms.TextBox txtidhab;
        private System.Windows.Forms.DateTimePicker dtmsalida;
        private System.Windows.Forms.DateTimePicker dtmingreso;
    }
}