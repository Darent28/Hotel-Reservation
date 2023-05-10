
namespace Sistema.Vistas.Forms_hotel
{
    partial class OPER_reservacion
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(OPER_reservacion));
            this.panel1 = new System.Windows.Forms.Panel();
            this.fecha = new System.Windows.Forms.Label();
            this.hora = new System.Windows.Forms.Label();
            this.nombreAd = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.timerReser = new System.Windows.Forms.Timer(this.components);
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.textCliente = new System.Windows.Forms.TextBox();
            this.dgvCliente = new System.Windows.Forms.DataGridView();
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.textCiudad = new System.Windows.Forms.TextBox();
            this.dgvCiudad = new System.Windows.Forms.DataGridView();
            this.label8 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.dtpInicio = new System.Windows.Forms.DateTimePicker();
            this.dtpFinal = new System.Windows.Forms.DateTimePicker();
            this.label11 = new System.Windows.Forms.Label();
            this.textAnticipo = new System.Windows.Forms.TextBox();
            this.label12 = new System.Windows.Forms.Label();
            this.cbMpago = new System.Windows.Forms.ComboBox();
            this.btnReservar = new System.Windows.Forms.Button();
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            this.dtpRegistro = new System.Windows.Forms.DateTimePicker();
            this.label13 = new System.Windows.Forms.Label();
            this.textcodigo = new System.Windows.Forms.TextBox();
            this.label14 = new System.Windows.Forms.Label();
            this.label15 = new System.Windows.Forms.Label();
            this.textClienteRFC = new System.Windows.Forms.TextBox();
            this.label16 = new System.Windows.Forms.Label();
            this.textIDCiudad = new System.Windows.Forms.TextBox();
            this.labelrfc = new System.Windows.Forms.Label();
            this.numericCanHab = new System.Windows.Forms.NumericUpDown();
            this.numericPrecio = new System.Windows.Forms.NumericUpDown();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvCliente)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvCiudad)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericCanHab)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericPrecio)).BeginInit();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.DimGray;
            this.panel1.Controls.Add(this.fecha);
            this.panel1.Controls.Add(this.hora);
            this.panel1.Controls.Add(this.labelrfc);
            this.panel1.Controls.Add(this.nombreAd);
            this.panel1.Controls.Add(this.label3);
            this.panel1.Controls.Add(this.label2);
            this.panel1.Controls.Add(this.label1);
            this.panel1.Controls.Add(this.pictureBox1);
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1148, 128);
            this.panel1.TabIndex = 0;
            // 
            // fecha
            // 
            this.fecha.AutoSize = true;
            this.fecha.Font = new System.Drawing.Font("Segoe UI", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.fecha.ForeColor = System.Drawing.Color.White;
            this.fecha.Location = new System.Drawing.Point(578, 86);
            this.fecha.Name = "fecha";
            this.fecha.Size = new System.Drawing.Size(50, 19);
            this.fecha.TabIndex = 21;
            this.fecha.Text = "label6";
            // 
            // hora
            // 
            this.hora.AutoSize = true;
            this.hora.Font = new System.Drawing.Font("Segoe UI", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.hora.ForeColor = System.Drawing.Color.White;
            this.hora.Location = new System.Drawing.Point(365, 86);
            this.hora.Name = "hora";
            this.hora.Size = new System.Drawing.Size(50, 19);
            this.hora.TabIndex = 20;
            this.hora.Text = "label5";
            // 
            // nombreAd
            // 
            this.nombreAd.AutoSize = true;
            this.nombreAd.Font = new System.Drawing.Font("Segoe UI", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.nombreAd.ForeColor = System.Drawing.Color.White;
            this.nombreAd.Location = new System.Drawing.Point(527, 20);
            this.nombreAd.Name = "nombreAd";
            this.nombreAd.Size = new System.Drawing.Size(50, 19);
            this.nombreAd.TabIndex = 19;
            this.nombreAd.Text = "label4";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.ForeColor = System.Drawing.Color.White;
            this.label3.Location = new System.Drawing.Point(514, 86);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(47, 19);
            this.label3.TabIndex = 18;
            this.label3.Text = "Fecha:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.ForeColor = System.Drawing.Color.White;
            this.label2.Location = new System.Drawing.Point(296, 86);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(42, 19);
            this.label2.TabIndex = 17;
            this.label2.Text = "Hora:";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.ForeColor = System.Drawing.Color.White;
            this.label1.Location = new System.Drawing.Point(296, 20);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(173, 19);
            this.label1.TabIndex = 16;
            this.label1.Text = "Nombre del administrador:\r\n";
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(103, 20);
            this.pictureBox1.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(163, 89);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox1.TabIndex = 15;
            this.pictureBox1.TabStop = false;
            // 
            // timerReser
            // 
            this.timerReser.Enabled = true;
            this.timerReser.Tick += new System.EventHandler(this.timerReser_Tick);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(120, 151);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(494, 38);
            this.label4.TabIndex = 1;
            this.label4.Text = "Para realizar la reservación por favor llene los siguientes campos. Para el clien" +
    "te \r\nlo puede buscar por los apellidos, RFC o correo electrónico.";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(300, 222);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(54, 19);
            this.label5.TabIndex = 2;
            this.label5.Text = "Cliente:";
            // 
            // textCliente
            // 
            this.textCliente.Location = new System.Drawing.Point(396, 222);
            this.textCliente.Name = "textCliente";
            this.textCliente.Size = new System.Drawing.Size(190, 26);
            this.textCliente.TabIndex = 3;
            this.textCliente.TextChanged += new System.EventHandler(this.textCliente_TextChanged);
            // 
            // dgvCliente
            // 
            this.dgvCliente.AllowUserToAddRows = false;
            this.dgvCliente.AllowUserToDeleteRows = false;
            this.dgvCliente.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvCliente.Location = new System.Drawing.Point(300, 254);
            this.dgvCliente.Name = "dgvCliente";
            this.dgvCliente.RowHeadersWidth = 51;
            this.dgvCliente.RowTemplate.Height = 24;
            this.dgvCliente.Size = new System.Drawing.Size(775, 135);
            this.dgvCliente.TabIndex = 4;
            this.dgvCliente.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvCliente_CellClick);
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(300, 414);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(55, 19);
            this.label6.TabIndex = 5;
            this.label6.Text = "Ciudad:";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(327, 599);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(193, 19);
            this.label7.TabIndex = 6;
            this.label7.Text = "Precio de presonas por noche:";
            // 
            // textCiudad
            // 
            this.textCiudad.Location = new System.Drawing.Point(397, 411);
            this.textCiudad.Name = "textCiudad";
            this.textCiudad.Size = new System.Drawing.Size(189, 26);
            this.textCiudad.TabIndex = 7;
            this.textCiudad.TextChanged += new System.EventHandler(this.textCiudad_TextChanged);
            // 
            // dgvCiudad
            // 
            this.dgvCiudad.AllowUserToAddRows = false;
            this.dgvCiudad.AllowUserToDeleteRows = false;
            this.dgvCiudad.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvCiudad.Location = new System.Drawing.Point(300, 443);
            this.dgvCiudad.Name = "dgvCiudad";
            this.dgvCiudad.RowHeadersWidth = 51;
            this.dgvCiudad.RowTemplate.Height = 24;
            this.dgvCiudad.Size = new System.Drawing.Size(775, 133);
            this.dgvCiudad.TabIndex = 8;
            this.dgvCiudad.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvCiudad_CellClick);
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(290, 651);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(230, 19);
            this.label8.TabIndex = 10;
            this.label8.Text = "Cantidad de personas a hospedarse:";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(725, 599);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(101, 19);
            this.label9.TabIndex = 12;
            this.label9.Text = "Fecha de inicio:";
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(750, 652);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(76, 19);
            this.label10.TabIndex = 13;
            this.label10.Text = "Fecha final:";
            // 
            // dtpInicio
            // 
            this.dtpInicio.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dtpInicio.Location = new System.Drawing.Point(858, 596);
            this.dtpInicio.Name = "dtpInicio";
            this.dtpInicio.Size = new System.Drawing.Size(154, 26);
            this.dtpInicio.TabIndex = 14;
            // 
            // dtpFinal
            // 
            this.dtpFinal.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dtpFinal.Location = new System.Drawing.Point(858, 649);
            this.dtpFinal.Name = "dtpFinal";
            this.dtpFinal.Size = new System.Drawing.Size(154, 26);
            this.dtpFinal.TabIndex = 15;
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Location = new System.Drawing.Point(458, 703);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(62, 19);
            this.label11.TabIndex = 16;
            this.label11.Text = "Anticipo:";
            // 
            // textAnticipo
            // 
            this.textAnticipo.Location = new System.Drawing.Point(582, 700);
            this.textAnticipo.Name = "textAnticipo";
            this.textAnticipo.Size = new System.Drawing.Size(100, 26);
            this.textAnticipo.TabIndex = 17;
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Location = new System.Drawing.Point(722, 703);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(105, 19);
            this.label12.TabIndex = 18;
            this.label12.Text = "Medio de pago:";
            // 
            // cbMpago
            // 
            this.cbMpago.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbMpago.FormattingEnabled = true;
            this.cbMpago.Location = new System.Drawing.Point(858, 700);
            this.cbMpago.Name = "cbMpago";
            this.cbMpago.Size = new System.Drawing.Size(154, 27);
            this.cbMpago.TabIndex = 19;
            // 
            // btnReservar
            // 
            this.btnReservar.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            this.btnReservar.Location = new System.Drawing.Point(885, 819);
            this.btnReservar.Name = "btnReservar";
            this.btnReservar.Size = new System.Drawing.Size(190, 59);
            this.btnReservar.TabIndex = 20;
            this.btnReservar.Text = "Reservar";
            this.btnReservar.UseVisualStyleBackColor = false;
            this.btnReservar.Click += new System.EventHandler(this.btnReservar_Click);
            // 
            // pictureBox2
            // 
            this.pictureBox2.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox2.Image")));
            this.pictureBox2.Location = new System.Drawing.Point(67, 288);
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Size = new System.Drawing.Size(171, 178);
            this.pictureBox2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox2.TabIndex = 21;
            this.pictureBox2.TabStop = false;
            this.pictureBox2.Click += new System.EventHandler(this.pictureBox2_Click);
            // 
            // dtpRegistro
            // 
            this.dtpRegistro.Enabled = false;
            this.dtpRegistro.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dtpRegistro.Location = new System.Drawing.Point(858, 751);
            this.dtpRegistro.Name = "dtpRegistro";
            this.dtpRegistro.Size = new System.Drawing.Size(154, 26);
            this.dtpRegistro.TabIndex = 90;
            // 
            // label13
            // 
            this.label13.AutoSize = true;
            this.label13.Location = new System.Drawing.Point(709, 757);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(117, 19);
            this.label13.TabIndex = 89;
            this.label13.Text = "Fecha de registro:";
            // 
            // textcodigo
            // 
            this.textcodigo.Enabled = false;
            this.textcodigo.Location = new System.Drawing.Point(409, 748);
            this.textcodigo.Name = "textcodigo";
            this.textcodigo.Size = new System.Drawing.Size(273, 26);
            this.textcodigo.TabIndex = 92;
            // 
            // label14
            // 
            this.label14.AutoSize = true;
            this.label14.Location = new System.Drawing.Point(333, 752);
            this.label14.Name = "label14";
            this.label14.Size = new System.Drawing.Size(56, 19);
            this.label14.TabIndex = 91;
            this.label14.Text = "Codigo:";
            // 
            // label15
            // 
            this.label15.AutoSize = true;
            this.label15.Location = new System.Drawing.Point(834, 222);
            this.label15.Name = "label15";
            this.label15.Size = new System.Drawing.Size(36, 19);
            this.label15.TabIndex = 2;
            this.label15.Text = "RFC:";
            // 
            // textClienteRFC
            // 
            this.textClienteRFC.Enabled = false;
            this.textClienteRFC.Location = new System.Drawing.Point(885, 218);
            this.textClienteRFC.Name = "textClienteRFC";
            this.textClienteRFC.Size = new System.Drawing.Size(190, 26);
            this.textClienteRFC.TabIndex = 3;
            this.textClienteRFC.TextChanged += new System.EventHandler(this.textCliente_TextChanged);
            // 
            // label16
            // 
            this.label16.AutoSize = true;
            this.label16.Location = new System.Drawing.Point(881, 414);
            this.label16.Name = "label16";
            this.label16.Size = new System.Drawing.Size(107, 19);
            this.label16.TabIndex = 2;
            this.label16.Text = "ID seleccionado:";
            // 
            // textIDCiudad
            // 
            this.textIDCiudad.Enabled = false;
            this.textIDCiudad.Location = new System.Drawing.Point(1006, 411);
            this.textIDCiudad.Name = "textIDCiudad";
            this.textIDCiudad.Size = new System.Drawing.Size(69, 26);
            this.textIDCiudad.TabIndex = 3;
            this.textIDCiudad.TextChanged += new System.EventHandler(this.textCliente_TextChanged);
            // 
            // labelrfc
            // 
            this.labelrfc.AutoSize = true;
            this.labelrfc.Font = new System.Drawing.Font("Segoe UI", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelrfc.ForeColor = System.Drawing.Color.White;
            this.labelrfc.Location = new System.Drawing.Point(854, 90);
            this.labelrfc.Name = "labelrfc";
            this.labelrfc.Size = new System.Drawing.Size(50, 19);
            this.labelrfc.TabIndex = 19;
            this.labelrfc.Text = "label4";
            this.labelrfc.Visible = false;
            // 
            // numericCanHab
            // 
            this.numericCanHab.Location = new System.Drawing.Point(582, 649);
            this.numericCanHab.Name = "numericCanHab";
            this.numericCanHab.Size = new System.Drawing.Size(100, 26);
            this.numericCanHab.TabIndex = 93;
            // 
            // numericPrecio
            // 
            this.numericPrecio.DecimalPlaces = 2;
            this.numericPrecio.Location = new System.Drawing.Point(582, 596);
            this.numericPrecio.Maximum = new decimal(new int[] {
            9999,
            0,
            0,
            0});
            this.numericPrecio.Name = "numericPrecio";
            this.numericPrecio.Size = new System.Drawing.Size(100, 26);
            this.numericPrecio.TabIndex = 94;
            // 
            // OPER_reservacion
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 19F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.BackColor = System.Drawing.Color.Gold;
            this.ClientSize = new System.Drawing.Size(1117, 911);
            this.Controls.Add(this.numericPrecio);
            this.Controls.Add(this.numericCanHab);
            this.Controls.Add(this.textcodigo);
            this.Controls.Add(this.label14);
            this.Controls.Add(this.dtpRegistro);
            this.Controls.Add(this.label13);
            this.Controls.Add(this.pictureBox2);
            this.Controls.Add(this.btnReservar);
            this.Controls.Add(this.cbMpago);
            this.Controls.Add(this.label12);
            this.Controls.Add(this.textAnticipo);
            this.Controls.Add(this.label11);
            this.Controls.Add(this.dtpFinal);
            this.Controls.Add(this.dtpInicio);
            this.Controls.Add(this.label10);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.dgvCiudad);
            this.Controls.Add(this.textCiudad);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.dgvCliente);
            this.Controls.Add(this.textIDCiudad);
            this.Controls.Add(this.label16);
            this.Controls.Add(this.textClienteRFC);
            this.Controls.Add(this.label15);
            this.Controls.Add(this.textCliente);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.panel1);
            this.Font = new System.Drawing.Font("Segoe UI", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.MaximizeBox = false;
            this.Name = "OPER_reservacion";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Hacer reservación";
            this.Load += new System.EventHandler(this.OPER_reservacion_Load);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvCliente)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvCiudad)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericCanHab)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericPrecio)).EndInit();
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
        private System.Windows.Forms.Timer timerReser;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox textCliente;
        private System.Windows.Forms.DataGridView dgvCliente;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.TextBox textCiudad;
        private System.Windows.Forms.DataGridView dgvCiudad;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.DateTimePicker dtpInicio;
        private System.Windows.Forms.DateTimePicker dtpFinal;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.TextBox textAnticipo;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.ComboBox cbMpago;
        private System.Windows.Forms.Button btnReservar;
        private System.Windows.Forms.PictureBox pictureBox2;
        private System.Windows.Forms.DateTimePicker dtpRegistro;
        private System.Windows.Forms.Label label13;
        private System.Windows.Forms.TextBox textcodigo;
        private System.Windows.Forms.Label label14;
        private System.Windows.Forms.Label label15;
        private System.Windows.Forms.TextBox textClienteRFC;
        private System.Windows.Forms.Label label16;
        private System.Windows.Forms.TextBox textIDCiudad;
        private System.Windows.Forms.Label labelrfc;
        private System.Windows.Forms.NumericUpDown numericCanHab;
        private System.Windows.Forms.NumericUpDown numericPrecio;
    }
}