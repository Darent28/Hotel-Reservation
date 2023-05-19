
namespace Sistema.Vistas.Forms_hotel
{
    partial class OPER_principal
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
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(OPER_principal));
            this.panel1 = new System.Windows.Forms.Panel();
            this.fecha = new System.Windows.Forms.Label();
            this.hora = new System.Windows.Forms.Label();
            this.nombreAd = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.registrarClienteToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.registrarReservaciónToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.cerrarSeciónToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.timerOP = new System.Windows.Forms.Timer(this.components);
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            this.label4 = new System.Windows.Forms.Label();
            this.txtCargar = new System.Windows.Forms.Button();
            this.tabPage4 = new System.Windows.Forms.TabPage();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.checkSerusados = new System.Windows.Forms.CheckBox();
            this.label10 = new System.Windows.Forms.Label();
            this.textServUsados = new System.Windows.Forms.TextBox();
            this.label12 = new System.Windows.Forms.Label();
            this.numericDescu = new System.Windows.Forms.NumericUpDown();
            this.textPrecio = new System.Windows.Forms.TextBox();
            this.textBox2 = new System.Windows.Forms.TextBox();
            this.textNumfactura = new System.Windows.Forms.TextBox();
            this.label9 = new System.Windows.Forms.Label();
            this.dgvFactura = new System.Windows.Forms.DataGridView();
            this.btnFacturar = new System.Windows.Forms.Button();
            this.comboBox1 = new System.Windows.Forms.ComboBox();
            this.textreserF = new System.Windows.Forms.TextBox();
            this.label11 = new System.Windows.Forms.Label();
            this.label14 = new System.Windows.Forms.Label();
            this.label15 = new System.Windows.Forms.Label();
            this.label16 = new System.Windows.Forms.Label();
            this.tabPage2 = new System.Windows.Forms.TabPage();
            this.dgvCheckin = new System.Windows.Forms.DataGridView();
            this.btnCheck = new System.Windows.Forms.Button();
            this.textIDcheckout = new System.Windows.Forms.TextBox();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.dateTimeExt = new System.Windows.Forms.DateTimePicker();
            this.checkBox1 = new System.Windows.Forms.CheckBox();
            this.textReserOut = new System.Windows.Forms.TextBox();
            this.label8 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.tabPage1 = new System.Windows.Forms.TabPage();
            this.gbasistio = new System.Windows.Forms.GroupBox();
            this.no = new System.Windows.Forms.RadioButton();
            this.si = new System.Windows.Forms.RadioButton();
            this.dgvReser = new System.Windows.Forms.DataGridView();
            this.pictureBox3 = new System.Windows.Forms.PictureBox();
            this.textcheckin = new System.Windows.Forms.TextBox();
            this.button1 = new System.Windows.Forms.Button();
            this.label6 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.tabControl1 = new System.Windows.Forms.TabControl();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.menuStrip1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            this.tabPage4.SuspendLayout();
            this.groupBox2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numericDescu)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvFactura)).BeginInit();
            this.tabPage2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvCheckin)).BeginInit();
            this.groupBox1.SuspendLayout();
            this.tabPage1.SuspendLayout();
            this.gbasistio.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvReser)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox3)).BeginInit();
            this.tabControl1.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.DimGray;
            this.panel1.Controls.Add(this.fecha);
            this.panel1.Controls.Add(this.hora);
            this.panel1.Controls.Add(this.nombreAd);
            this.panel1.Controls.Add(this.label3);
            this.panel1.Controls.Add(this.label2);
            this.panel1.Controls.Add(this.label1);
            this.panel1.Controls.Add(this.pictureBox1);
            this.panel1.Controls.Add(this.menuStrip1);
            this.panel1.Location = new System.Drawing.Point(0, -1);
            this.panel1.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1159, 180);
            this.panel1.TabIndex = 0;
            // 
            // fecha
            // 
            this.fecha.AutoSize = true;
            this.fecha.Font = new System.Drawing.Font("Segoe UI", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.fecha.ForeColor = System.Drawing.Color.White;
            this.fecha.Location = new System.Drawing.Point(640, 132);
            this.fecha.Name = "fecha";
            this.fecha.Size = new System.Drawing.Size(50, 19);
            this.fecha.TabIndex = 14;
            this.fecha.Text = "label6";
            // 
            // hora
            // 
            this.hora.AutoSize = true;
            this.hora.Font = new System.Drawing.Font("Segoe UI", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.hora.ForeColor = System.Drawing.Color.White;
            this.hora.Location = new System.Drawing.Point(374, 132);
            this.hora.Name = "hora";
            this.hora.Size = new System.Drawing.Size(50, 19);
            this.hora.TabIndex = 13;
            this.hora.Text = "label5";
            // 
            // nombreAd
            // 
            this.nombreAd.AutoSize = true;
            this.nombreAd.Font = new System.Drawing.Font("Segoe UI", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.nombreAd.ForeColor = System.Drawing.Color.White;
            this.nombreAd.Location = new System.Drawing.Point(539, 66);
            this.nombreAd.Name = "nombreAd";
            this.nombreAd.Size = new System.Drawing.Size(50, 19);
            this.nombreAd.TabIndex = 12;
            this.nombreAd.Text = "label4";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.ForeColor = System.Drawing.Color.White;
            this.label3.Location = new System.Drawing.Point(576, 132);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(47, 19);
            this.label3.TabIndex = 11;
            this.label3.Text = "Fecha:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.ForeColor = System.Drawing.Color.White;
            this.label2.Location = new System.Drawing.Point(317, 132);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(42, 19);
            this.label2.TabIndex = 10;
            this.label2.Text = "Hora:";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.ForeColor = System.Drawing.Color.White;
            this.label1.Location = new System.Drawing.Point(317, 66);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(144, 19);
            this.label1.TabIndex = 9;
            this.label1.Text = "Nombre del operador:\r\n";
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(94, 66);
            this.pictureBox1.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(163, 89);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox1.TabIndex = 8;
            this.pictureBox1.TabStop = false;
            // 
            // menuStrip1
            // 
            this.menuStrip1.BackColor = System.Drawing.Color.LightGray;
            this.menuStrip1.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.registrarClienteToolStripMenuItem,
            this.registrarReservaciónToolStripMenuItem,
            this.cerrarSeciónToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(1159, 24);
            this.menuStrip1.TabIndex = 15;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // registrarClienteToolStripMenuItem
            // 
            this.registrarClienteToolStripMenuItem.Name = "registrarClienteToolStripMenuItem";
            this.registrarClienteToolStripMenuItem.Size = new System.Drawing.Size(103, 20);
            this.registrarClienteToolStripMenuItem.Text = "Registrar cliente";
            this.registrarClienteToolStripMenuItem.Click += new System.EventHandler(this.registrarClienteToolStripMenuItem_Click);
            // 
            // registrarReservaciónToolStripMenuItem
            // 
            this.registrarReservaciónToolStripMenuItem.Name = "registrarReservaciónToolStripMenuItem";
            this.registrarReservaciónToolStripMenuItem.Size = new System.Drawing.Size(128, 20);
            this.registrarReservaciónToolStripMenuItem.Text = "Registrar reservación";
            this.registrarReservaciónToolStripMenuItem.Click += new System.EventHandler(this.registrarReservaciónToolStripMenuItem_Click);
            // 
            // cerrarSeciónToolStripMenuItem
            // 
            this.cerrarSeciónToolStripMenuItem.Name = "cerrarSeciónToolStripMenuItem";
            this.cerrarSeciónToolStripMenuItem.Size = new System.Drawing.Size(87, 20);
            this.cerrarSeciónToolStripMenuItem.Text = "Cerrar sesión";
            this.cerrarSeciónToolStripMenuItem.Click += new System.EventHandler(this.cerrarSeciónToolStripMenuItem_Click);
            // 
            // timerOP
            // 
            this.timerOP.Enabled = true;
            this.timerOP.Tick += new System.EventHandler(this.timerOP_Tick);
            // 
            // pictureBox2
            // 
            this.pictureBox2.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox2.Image")));
            this.pictureBox2.Location = new System.Drawing.Point(64, 370);
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Size = new System.Drawing.Size(163, 177);
            this.pictureBox2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox2.TabIndex = 1;
            this.pictureBox2.TabStop = false;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(263, 212);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(591, 57);
            this.label4.TabIndex = 2;
            this.label4.Text = "Hola operario. En esta página puede realizar el proceso de Check-in, Check-out y " +
    "cancelaciones.\r\nO puede hacer alguna reservación y registro del cliente, oprimie" +
    "ndo la opción en el\r\nmenú de arriba.\r\n";
            // 
            // txtCargar
            // 
            this.txtCargar.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            this.txtCargar.Location = new System.Drawing.Point(72, 607);
            this.txtCargar.Name = "txtCargar";
            this.txtCargar.Size = new System.Drawing.Size(147, 59);
            this.txtCargar.TabIndex = 2;
            this.txtCargar.Text = "Cargar";
            this.txtCargar.UseVisualStyleBackColor = false;
            this.txtCargar.Click += new System.EventHandler(this.txtCargar_Click);
            // 
            // tabPage4
            // 
            this.tabPage4.BackColor = System.Drawing.Color.LightGray;
            this.tabPage4.Controls.Add(this.groupBox2);
            this.tabPage4.Controls.Add(this.label12);
            this.tabPage4.Controls.Add(this.numericDescu);
            this.tabPage4.Controls.Add(this.textPrecio);
            this.tabPage4.Controls.Add(this.textBox2);
            this.tabPage4.Controls.Add(this.textNumfactura);
            this.tabPage4.Controls.Add(this.label9);
            this.tabPage4.Controls.Add(this.dgvFactura);
            this.tabPage4.Controls.Add(this.btnFacturar);
            this.tabPage4.Controls.Add(this.comboBox1);
            this.tabPage4.Controls.Add(this.textreserF);
            this.tabPage4.Controls.Add(this.label11);
            this.tabPage4.Controls.Add(this.label14);
            this.tabPage4.Controls.Add(this.label15);
            this.tabPage4.Controls.Add(this.label16);
            this.tabPage4.Location = new System.Drawing.Point(4, 28);
            this.tabPage4.Name = "tabPage4";
            this.tabPage4.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage4.Size = new System.Drawing.Size(850, 683);
            this.tabPage4.TabIndex = 3;
            this.tabPage4.Text = "Factura";
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.checkSerusados);
            this.groupBox2.Controls.Add(this.label10);
            this.groupBox2.Controls.Add(this.textServUsados);
            this.groupBox2.Location = new System.Drawing.Point(30, 557);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(783, 110);
            this.groupBox2.TabIndex = 97;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Servicios adicionales";
            // 
            // checkSerusados
            // 
            this.checkSerusados.AutoSize = true;
            this.checkSerusados.Location = new System.Drawing.Point(25, 29);
            this.checkSerusados.Name = "checkSerusados";
            this.checkSerusados.Size = new System.Drawing.Size(475, 23);
            this.checkSerusados.TabIndex = 0;
            this.checkSerusados.Text = "¿Uso algun servicio adicional? (se le añadira $1000.00 del monto original)";
            this.checkSerusados.UseVisualStyleBackColor = true;
            this.checkSerusados.CheckedChanged += new System.EventHandler(this.checkSerusados_CheckedChanged);
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(21, 69);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(111, 19);
            this.label10.TabIndex = 12;
            this.label10.Text = "Servicios usados:";
            this.label10.Click += new System.EventHandler(this.label10_Click);
            // 
            // textServUsados
            // 
            this.textServUsados.Location = new System.Drawing.Point(156, 66);
            this.textServUsados.Name = "textServUsados";
            this.textServUsados.Size = new System.Drawing.Size(611, 26);
            this.textServUsados.TabIndex = 13;
            this.textServUsados.TextChanged += new System.EventHandler(this.textServUsados_TextChanged);
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Location = new System.Drawing.Point(349, 468);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(49, 19);
            this.label12.TabIndex = 96;
            this.label12.Text = "Precio:";
            // 
            // numericDescu
            // 
            this.numericDescu.Location = new System.Drawing.Point(233, 465);
            this.numericDescu.Name = "numericDescu";
            this.numericDescu.Size = new System.Drawing.Size(62, 26);
            this.numericDescu.TabIndex = 94;
            // 
            // textPrecio
            // 
            this.textPrecio.Enabled = false;
            this.textPrecio.Location = new System.Drawing.Point(435, 465);
            this.textPrecio.Name = "textPrecio";
            this.textPrecio.Size = new System.Drawing.Size(148, 26);
            this.textPrecio.TabIndex = 14;
            // 
            // textBox2
            // 
            this.textBox2.Enabled = false;
            this.textBox2.Location = new System.Drawing.Point(447, 80);
            this.textBox2.Name = "textBox2";
            this.textBox2.Size = new System.Drawing.Size(50, 26);
            this.textBox2.TabIndex = 14;
            this.textBox2.Visible = false;
            // 
            // textNumfactura
            // 
            this.textNumfactura.Enabled = false;
            this.textNumfactura.Location = new System.Drawing.Point(638, 516);
            this.textNumfactura.Name = "textNumfactura";
            this.textNumfactura.Size = new System.Drawing.Size(145, 26);
            this.textNumfactura.TabIndex = 13;
            this.textNumfactura.TextChanged += new System.EventHandler(this.textServUsados_TextChanged);
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(71, 467);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(77, 19);
            this.label9.TabIndex = 12;
            this.label9.Text = "Descuento:";
            this.label9.Click += new System.EventHandler(this.label10_Click);
            // 
            // dgvFactura
            // 
            this.dgvFactura.AllowUserToAddRows = false;
            this.dgvFactura.AllowUserToDeleteRows = false;
            this.dgvFactura.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvFactura.Location = new System.Drawing.Point(53, 132);
            this.dgvFactura.Name = "dgvFactura";
            this.dgvFactura.RowHeadersWidth = 51;
            this.dgvFactura.RowTemplate.Height = 24;
            this.dgvFactura.Size = new System.Drawing.Size(730, 309);
            this.dgvFactura.TabIndex = 11;
            this.dgvFactura.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvFactura_CellClick);
            // 
            // btnFacturar
            // 
            this.btnFacturar.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            this.btnFacturar.Location = new System.Drawing.Point(638, 461);
            this.btnFacturar.Name = "btnFacturar";
            this.btnFacturar.Size = new System.Drawing.Size(145, 45);
            this.btnFacturar.TabIndex = 9;
            this.btnFacturar.Text = "Facturar";
            this.btnFacturar.UseVisualStyleBackColor = false;
            this.btnFacturar.Click += new System.EventHandler(this.btnFacturar_Click);
            // 
            // comboBox1
            // 
            this.comboBox1.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboBox1.FormattingEnabled = true;
            this.comboBox1.Location = new System.Drawing.Point(174, 510);
            this.comboBox1.Name = "comboBox1";
            this.comboBox1.Size = new System.Drawing.Size(121, 27);
            this.comboBox1.TabIndex = 7;
            this.comboBox1.SelectedIndexChanged += new System.EventHandler(this.comboBox1_SelectedIndexChanged);
            // 
            // textreserF
            // 
            this.textreserF.Enabled = false;
            this.textreserF.Location = new System.Drawing.Point(205, 79);
            this.textreserF.Name = "textreserF";
            this.textreserF.Size = new System.Drawing.Size(218, 26);
            this.textreserF.TabIndex = 5;
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Location = new System.Drawing.Point(489, 519);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(127, 19);
            this.label11.TabIndex = 3;
            this.label11.Text = "Numero de factura:";
            this.label11.Click += new System.EventHandler(this.label14_Click);
            // 
            // label14
            // 
            this.label14.AutoSize = true;
            this.label14.Location = new System.Drawing.Point(48, 514);
            this.label14.Name = "label14";
            this.label14.Size = new System.Drawing.Size(103, 19);
            this.label14.TabIndex = 3;
            this.label14.Text = "Modo de pago:";
            this.label14.Click += new System.EventHandler(this.label14_Click);
            // 
            // label15
            // 
            this.label15.AutoSize = true;
            this.label15.Location = new System.Drawing.Point(49, 82);
            this.label15.Name = "label15";
            this.label15.Size = new System.Drawing.Size(148, 19);
            this.label15.TabIndex = 1;
            this.label15.Text = "Código de reservación:";
            // 
            // label16
            // 
            this.label16.AutoSize = true;
            this.label16.Location = new System.Drawing.Point(78, 17);
            this.label16.Name = "label16";
            this.label16.Size = new System.Drawing.Size(442, 38);
            this.label16.TabIndex = 0;
            this.label16.Text = "Coloque el código de reservación y pregunté al cliente los campos que \r\naparecen " +
    "aquí abajo.\r\n";
            // 
            // tabPage2
            // 
            this.tabPage2.BackColor = System.Drawing.Color.LightGray;
            this.tabPage2.Controls.Add(this.dgvCheckin);
            this.tabPage2.Controls.Add(this.btnCheck);
            this.tabPage2.Controls.Add(this.textIDcheckout);
            this.tabPage2.Controls.Add(this.groupBox1);
            this.tabPage2.Controls.Add(this.textReserOut);
            this.tabPage2.Controls.Add(this.label8);
            this.tabPage2.Controls.Add(this.label7);
            this.tabPage2.Location = new System.Drawing.Point(4, 28);
            this.tabPage2.Name = "tabPage2";
            this.tabPage2.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage2.Size = new System.Drawing.Size(850, 683);
            this.tabPage2.TabIndex = 1;
            this.tabPage2.Text = "Check-Out";
            // 
            // dgvCheckin
            // 
            this.dgvCheckin.AllowUserToAddRows = false;
            this.dgvCheckin.AllowUserToDeleteRows = false;
            this.dgvCheckin.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvCheckin.Location = new System.Drawing.Point(36, 159);
            this.dgvCheckin.Name = "dgvCheckin";
            this.dgvCheckin.RowHeadersWidth = 51;
            this.dgvCheckin.RowTemplate.Height = 24;
            this.dgvCheckin.Size = new System.Drawing.Size(782, 432);
            this.dgvCheckin.TabIndex = 11;
            this.dgvCheckin.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvCheckin_CellClick);
            // 
            // btnCheck
            // 
            this.btnCheck.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            this.btnCheck.Location = new System.Drawing.Point(575, 597);
            this.btnCheck.Name = "btnCheck";
            this.btnCheck.Size = new System.Drawing.Size(243, 71);
            this.btnCheck.TabIndex = 9;
            this.btnCheck.Text = "Check-out";
            this.btnCheck.UseVisualStyleBackColor = false;
            this.btnCheck.Click += new System.EventHandler(this.btnCheck_Click);
            // 
            // textIDcheckout
            // 
            this.textIDcheckout.Enabled = false;
            this.textIDcheckout.Location = new System.Drawing.Point(431, 114);
            this.textIDcheckout.Name = "textIDcheckout";
            this.textIDcheckout.Size = new System.Drawing.Size(50, 26);
            this.textIDcheckout.TabIndex = 5;
            this.textIDcheckout.Visible = false;
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.dateTimeExt);
            this.groupBox1.Controls.Add(this.checkBox1);
            this.groupBox1.Location = new System.Drawing.Point(526, 17);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(292, 123);
            this.groupBox1.TabIndex = 8;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Extensión";
            // 
            // dateTimeExt
            // 
            this.dateTimeExt.Enabled = false;
            this.dateTimeExt.Location = new System.Drawing.Point(25, 72);
            this.dateTimeExt.Name = "dateTimeExt";
            this.dateTimeExt.Size = new System.Drawing.Size(238, 26);
            this.dateTimeExt.TabIndex = 1;
            // 
            // checkBox1
            // 
            this.checkBox1.AutoSize = true;
            this.checkBox1.Location = new System.Drawing.Point(25, 29);
            this.checkBox1.Name = "checkBox1";
            this.checkBox1.Size = new System.Drawing.Size(193, 23);
            this.checkBox1.TabIndex = 0;
            this.checkBox1.Text = "¿Desea extender sus visita?";
            this.checkBox1.UseVisualStyleBackColor = true;
            this.checkBox1.CheckedChanged += new System.EventHandler(this.checkBox1_CheckedChanged);
            // 
            // textReserOut
            // 
            this.textReserOut.Enabled = false;
            this.textReserOut.Location = new System.Drawing.Point(187, 114);
            this.textReserOut.Name = "textReserOut";
            this.textReserOut.Size = new System.Drawing.Size(218, 26);
            this.textReserOut.TabIndex = 5;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(31, 117);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(148, 19);
            this.label8.TabIndex = 1;
            this.label8.Text = "Código de reservación:";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(64, 17);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(442, 38);
            this.label7.TabIndex = 0;
            this.label7.Text = "Coloque el código de reservación y pregunté al cliente los campos que \r\naparecen " +
    "aquí abajo.\r\n";
            // 
            // tabPage1
            // 
            this.tabPage1.BackColor = System.Drawing.Color.LightGray;
            this.tabPage1.Controls.Add(this.gbasistio);
            this.tabPage1.Controls.Add(this.dgvReser);
            this.tabPage1.Controls.Add(this.pictureBox3);
            this.tabPage1.Controls.Add(this.textcheckin);
            this.tabPage1.Controls.Add(this.button1);
            this.tabPage1.Controls.Add(this.label6);
            this.tabPage1.Controls.Add(this.label5);
            this.tabPage1.Location = new System.Drawing.Point(4, 28);
            this.tabPage1.Name = "tabPage1";
            this.tabPage1.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage1.Size = new System.Drawing.Size(850, 683);
            this.tabPage1.TabIndex = 0;
            this.tabPage1.Text = "Check-In";
            // 
            // gbasistio
            // 
            this.gbasistio.Controls.Add(this.no);
            this.gbasistio.Controls.Add(this.si);
            this.gbasistio.Location = new System.Drawing.Point(492, 90);
            this.gbasistio.Name = "gbasistio";
            this.gbasistio.Size = new System.Drawing.Size(140, 59);
            this.gbasistio.TabIndex = 57;
            this.gbasistio.TabStop = false;
            this.gbasistio.Text = "Asistio";
            // 
            // no
            // 
            this.no.AutoSize = true;
            this.no.Location = new System.Drawing.Point(76, 25);
            this.no.Name = "no";
            this.no.Size = new System.Drawing.Size(45, 23);
            this.no.TabIndex = 1;
            this.no.Text = "No";
            this.no.UseVisualStyleBackColor = true;
            // 
            // si
            // 
            this.si.AutoSize = true;
            this.si.Checked = true;
            this.si.Location = new System.Drawing.Point(17, 25);
            this.si.Name = "si";
            this.si.Size = new System.Drawing.Size(37, 23);
            this.si.TabIndex = 0;
            this.si.TabStop = true;
            this.si.Text = "Si";
            this.si.UseVisualStyleBackColor = true;
            this.si.CheckedChanged += new System.EventHandler(this.si_CheckedChanged);
            // 
            // dgvReser
            // 
            this.dgvReser.AllowUserToAddRows = false;
            this.dgvReser.AllowUserToDeleteRows = false;
            this.dgvReser.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvReser.Location = new System.Drawing.Point(30, 164);
            this.dgvReser.Name = "dgvReser";
            this.dgvReser.RowHeadersWidth = 51;
            this.dgvReser.RowTemplate.Height = 24;
            this.dgvReser.Size = new System.Drawing.Size(805, 458);
            this.dgvReser.TabIndex = 10;
            this.dgvReser.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvReser_CellClick);
            // 
            // pictureBox3
            // 
            this.pictureBox3.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox3.Image")));
            this.pictureBox3.Location = new System.Drawing.Point(703, 19);
            this.pictureBox3.Name = "pictureBox3";
            this.pictureBox3.Size = new System.Drawing.Size(132, 116);
            this.pictureBox3.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox3.TabIndex = 4;
            this.pictureBox3.TabStop = false;
            // 
            // textcheckin
            // 
            this.textcheckin.Enabled = false;
            this.textcheckin.Location = new System.Drawing.Point(182, 123);
            this.textcheckin.Name = "textcheckin";
            this.textcheckin.Size = new System.Drawing.Size(219, 26);
            this.textcheckin.TabIndex = 3;
            this.textcheckin.TextChanged += new System.EventHandler(this.textcheckin_TextChanged);
            // 
            // button1
            // 
            this.button1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            this.button1.Location = new System.Drawing.Point(725, 628);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(110, 49);
            this.button1.TabIndex = 2;
            this.button1.Text = "Check-In";
            this.button1.UseVisualStyleBackColor = false;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(24, 126);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(148, 19);
            this.label6.TabIndex = 1;
            this.label6.Text = "Código de reservación:";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(81, 31);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(455, 38);
            this.label5.TabIndex = 0;
            this.label5.Text = "Para hacer el Check-In, por favor introduzca el código de reservación que\r\nle pro" +
    "porcionará el cliente.";
            // 
            // tabControl1
            // 
            this.tabControl1.Controls.Add(this.tabPage1);
            this.tabControl1.Controls.Add(this.tabPage2);
            this.tabControl1.Controls.Add(this.tabPage4);
            this.tabControl1.Location = new System.Drawing.Point(267, 294);
            this.tabControl1.Name = "tabControl1";
            this.tabControl1.SelectedIndex = 0;
            this.tabControl1.Size = new System.Drawing.Size(858, 715);
            this.tabControl1.TabIndex = 3;
            // 
            // OPER_principal
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 19F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.BackColor = System.Drawing.Color.Gold;
            this.ClientSize = new System.Drawing.Size(1145, 1021);
            this.Controls.Add(this.tabControl1);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.pictureBox2);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.txtCargar);
            this.Font = new System.Drawing.Font("Segoe UI", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MainMenuStrip = this.menuStrip1;
            this.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.MaximizeBox = false;
            this.Name = "OPER_principal";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Página principal del operador";
            this.Load += new System.EventHandler(this.OPER_principal_Load);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            this.tabPage4.ResumeLayout(false);
            this.tabPage4.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numericDescu)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvFactura)).EndInit();
            this.tabPage2.ResumeLayout(false);
            this.tabPage2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvCheckin)).EndInit();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.tabPage1.ResumeLayout(false);
            this.tabPage1.PerformLayout();
            this.gbasistio.ResumeLayout(false);
            this.gbasistio.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvReser)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox3)).EndInit();
            this.tabControl1.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label fecha;
        private System.Windows.Forms.Label hora;
        private System.Windows.Forms.Label nombreAd;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem registrarClienteToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem registrarReservaciónToolStripMenuItem;
        private System.Windows.Forms.Timer timerOP;
        private System.Windows.Forms.PictureBox pictureBox2;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.ToolStripMenuItem cerrarSeciónToolStripMenuItem;
        private System.Windows.Forms.Button txtCargar;
        private System.Windows.Forms.TabPage tabPage4;
        private System.Windows.Forms.DataGridView dgvFactura;
        private System.Windows.Forms.Button btnFacturar;
        private System.Windows.Forms.ComboBox comboBox1;
        private System.Windows.Forms.TextBox textreserF;
        private System.Windows.Forms.Label label14;
        private System.Windows.Forms.Label label15;
        private System.Windows.Forms.Label label16;
        private System.Windows.Forms.TabPage tabPage2;
        private System.Windows.Forms.DataGridView dgvCheckin;
        private System.Windows.Forms.Button btnCheck;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.DateTimePicker dateTimeExt;
        private System.Windows.Forms.CheckBox checkBox1;
        private System.Windows.Forms.TextBox textReserOut;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.TabPage tabPage1;
        private System.Windows.Forms.GroupBox gbasistio;
        private System.Windows.Forms.RadioButton no;
        private System.Windows.Forms.RadioButton si;
        private System.Windows.Forms.DataGridView dgvReser;
        private System.Windows.Forms.PictureBox pictureBox3;
        private System.Windows.Forms.TextBox textcheckin;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TabControl tabControl1;
        private System.Windows.Forms.TextBox textServUsados;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.TextBox textIDcheckout;
        private System.Windows.Forms.TextBox textBox2;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.NumericUpDown numericDescu;
        private System.Windows.Forms.TextBox textNumfactura;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.TextBox textPrecio;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.CheckBox checkSerusados;
    }
}