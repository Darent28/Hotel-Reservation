
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
            this.labelrfc = new System.Windows.Forms.Label();
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
            this.textCiudad = new System.Windows.Forms.TextBox();
            this.dgvCiudad = new System.Windows.Forms.DataGridView();
            this.label8 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.dtpInicio = new System.Windows.Forms.DateTimePicker();
            this.dtpFinal = new System.Windows.Forms.DateTimePicker();
            this.label11 = new System.Windows.Forms.Label();
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
            this.numericCanHab = new System.Windows.Forms.NumericUpDown();
            this.textAnticipo = new System.Windows.Forms.NumericUpDown();
            this.textPrecio = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvCliente)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvCiudad)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericCanHab)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.textAnticipo)).BeginInit();
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
            this.panel1.Size = new System.Drawing.Size(1020, 111);
            this.panel1.TabIndex = 0;
            // 
            // fecha
            // 
            this.fecha.AutoSize = true;
            this.fecha.Font = new System.Drawing.Font("Segoe UI", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.fecha.ForeColor = System.Drawing.Color.White;
            this.fecha.Location = new System.Drawing.Point(514, 75);
            this.fecha.Name = "fecha";
            this.fecha.Size = new System.Drawing.Size(59, 23);
            this.fecha.TabIndex = 21;
            this.fecha.Text = "label6";
            // 
            // hora
            // 
            this.hora.AutoSize = true;
            this.hora.Font = new System.Drawing.Font("Segoe UI", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.hora.ForeColor = System.Drawing.Color.White;
            this.hora.Location = new System.Drawing.Point(324, 75);
            this.hora.Name = "hora";
            this.hora.Size = new System.Drawing.Size(59, 23);
            this.hora.TabIndex = 20;
            this.hora.Text = "label5";
            // 
            // labelrfc
            // 
            this.labelrfc.AutoSize = true;
            this.labelrfc.Font = new System.Drawing.Font("Segoe UI", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelrfc.ForeColor = System.Drawing.Color.White;
            this.labelrfc.Location = new System.Drawing.Point(759, 78);
            this.labelrfc.Name = "labelrfc";
            this.labelrfc.Size = new System.Drawing.Size(59, 23);
            this.labelrfc.TabIndex = 19;
            this.labelrfc.Text = "label4";
            this.labelrfc.Visible = false;
            // 
            // nombreAd
            // 
            this.nombreAd.AutoSize = true;
            this.nombreAd.Font = new System.Drawing.Font("Segoe UI", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.nombreAd.ForeColor = System.Drawing.Color.White;
            this.nombreAd.Location = new System.Drawing.Point(468, 17);
            this.nombreAd.Name = "nombreAd";
            this.nombreAd.Size = new System.Drawing.Size(59, 23);
            this.nombreAd.TabIndex = 19;
            this.nombreAd.Text = "label4";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.ForeColor = System.Drawing.Color.White;
            this.label3.Location = new System.Drawing.Point(457, 75);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(50, 20);
            this.label3.TabIndex = 18;
            this.label3.Text = "Fecha:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.ForeColor = System.Drawing.Color.White;
            this.label2.Location = new System.Drawing.Point(263, 75);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(45, 20);
            this.label2.TabIndex = 17;
            this.label2.Text = "Hora:";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.ForeColor = System.Drawing.Color.White;
            this.label1.Location = new System.Drawing.Point(263, 17);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(189, 20);
            this.label1.TabIndex = 16;
            this.label1.Text = "Nombre del administrador:\r\n";
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(92, 17);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(145, 77);
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
            this.label4.Location = new System.Drawing.Point(143, 127);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(648, 40);
            this.label4.TabIndex = 1;
            this.label4.Text = "Para realizar la reservación por favor llene los siguientes campos. Para el clien" +
    "te lo puede buscar \r\npor los apellidos, RFC o correo electrónico.";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(44, 170);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(58, 20);
            this.label5.TabIndex = 2;
            this.label5.Text = "Cliente:";
            // 
            // textCliente
            // 
            this.textCliente.Location = new System.Drawing.Point(108, 166);
            this.textCliente.Name = "textCliente";
            this.textCliente.Size = new System.Drawing.Size(169, 27);
            this.textCliente.TabIndex = 3;
            this.textCliente.TextChanged += new System.EventHandler(this.textCliente_TextChanged);
            // 
            // dgvCliente
            // 
            this.dgvCliente.AllowUserToAddRows = false;
            this.dgvCliente.AllowUserToDeleteRows = false;
            this.dgvCliente.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvCliente.Location = new System.Drawing.Point(47, 201);
            this.dgvCliente.Name = "dgvCliente";
            this.dgvCliente.ReadOnly = true;
            this.dgvCliente.RowHeadersWidth = 51;
            this.dgvCliente.RowTemplate.Height = 24;
            this.dgvCliente.Size = new System.Drawing.Size(912, 117);
            this.dgvCliente.TabIndex = 4;
            this.dgvCliente.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvCliente_CellClick);
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(44, 337);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(59, 20);
            this.label6.TabIndex = 5;
            this.label6.Text = "Ciudad:";
            // 
            // textCiudad
            // 
            this.textCiudad.Location = new System.Drawing.Point(108, 331);
            this.textCiudad.Name = "textCiudad";
            this.textCiudad.Size = new System.Drawing.Size(168, 27);
            this.textCiudad.TabIndex = 7;
            this.textCiudad.TextChanged += new System.EventHandler(this.textCiudad_TextChanged);
            // 
            // dgvCiudad
            // 
            this.dgvCiudad.AllowUserToAddRows = false;
            this.dgvCiudad.AllowUserToDeleteRows = false;
            this.dgvCiudad.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvCiudad.Location = new System.Drawing.Point(47, 366);
            this.dgvCiudad.Name = "dgvCiudad";
            this.dgvCiudad.ReadOnly = true;
            this.dgvCiudad.RowHeadersWidth = 51;
            this.dgvCiudad.RowTemplate.Height = 24;
            this.dgvCiudad.Size = new System.Drawing.Size(912, 116);
            this.dgvCiudad.TabIndex = 8;
            this.dgvCiudad.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvCiudad_CellClick);
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(312, 500);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(248, 20);
            this.label8.TabIndex = 10;
            this.label8.Text = "Cantidad de personas a hospedarse:";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(699, 497);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(111, 20);
            this.label9.TabIndex = 12;
            this.label9.Text = "Fecha de inicio:";
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(721, 543);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(83, 20);
            this.label10.TabIndex = 13;
            this.label10.Text = "Fecha final:";
            // 
            // dtpInicio
            // 
            this.dtpInicio.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dtpInicio.Location = new System.Drawing.Point(817, 495);
            this.dtpInicio.Name = "dtpInicio";
            this.dtpInicio.Size = new System.Drawing.Size(137, 27);
            this.dtpInicio.TabIndex = 14;
            // 
            // dtpFinal
            // 
            this.dtpFinal.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dtpFinal.Location = new System.Drawing.Point(817, 541);
            this.dtpFinal.Name = "dtpFinal";
            this.dtpFinal.Size = new System.Drawing.Size(137, 27);
            this.dtpFinal.TabIndex = 15;
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Location = new System.Drawing.Point(315, 543);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(68, 20);
            this.label11.TabIndex = 16;
            this.label11.Text = "Anticipo:";
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Location = new System.Drawing.Point(269, 585);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(115, 20);
            this.label12.TabIndex = 18;
            this.label12.Text = "Medio de pago:";
            // 
            // cbMpago
            // 
            this.cbMpago.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbMpago.FormattingEnabled = true;
            this.cbMpago.Location = new System.Drawing.Point(390, 583);
            this.cbMpago.Name = "cbMpago";
            this.cbMpago.Size = new System.Drawing.Size(137, 28);
            this.cbMpago.TabIndex = 19;
            // 
            // btnReservar
            // 
            this.btnReservar.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            this.btnReservar.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnReservar.Location = new System.Drawing.Point(702, 622);
            this.btnReservar.Name = "btnReservar";
            this.btnReservar.Size = new System.Drawing.Size(253, 57);
            this.btnReservar.TabIndex = 20;
            this.btnReservar.Text = "Reservar";
            this.btnReservar.UseVisualStyleBackColor = false;
            this.btnReservar.Click += new System.EventHandler(this.btnReservar_Click);
            // 
            // pictureBox2
            // 
            this.pictureBox2.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox2.Image")));
            this.pictureBox2.Location = new System.Drawing.Point(76, 495);
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Size = new System.Drawing.Size(152, 155);
            this.pictureBox2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox2.TabIndex = 21;
            this.pictureBox2.TabStop = false;
            this.pictureBox2.Click += new System.EventHandler(this.pictureBox2_Click);
            // 
            // dtpRegistro
            // 
            this.dtpRegistro.Enabled = false;
            this.dtpRegistro.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dtpRegistro.Location = new System.Drawing.Point(390, 617);
            this.dtpRegistro.Name = "dtpRegistro";
            this.dtpRegistro.Size = new System.Drawing.Size(137, 27);
            this.dtpRegistro.TabIndex = 90;
            // 
            // label13
            // 
            this.label13.AutoSize = true;
            this.label13.Location = new System.Drawing.Point(256, 622);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(126, 20);
            this.label13.TabIndex = 89;
            this.label13.Text = "Fecha de registro:";
            // 
            // textcodigo
            // 
            this.textcodigo.Enabled = false;
            this.textcodigo.Location = new System.Drawing.Point(817, 585);
            this.textcodigo.Name = "textcodigo";
            this.textcodigo.Size = new System.Drawing.Size(139, 27);
            this.textcodigo.TabIndex = 92;
            // 
            // label14
            // 
            this.label14.AutoSize = true;
            this.label14.Location = new System.Drawing.Point(744, 588);
            this.label14.Name = "label14";
            this.label14.Size = new System.Drawing.Size(61, 20);
            this.label14.TabIndex = 91;
            this.label14.Text = "Codigo:";
            // 
            // label15
            // 
            this.label15.AutoSize = true;
            this.label15.Location = new System.Drawing.Point(743, 172);
            this.label15.Name = "label15";
            this.label15.Size = new System.Drawing.Size(37, 20);
            this.label15.TabIndex = 2;
            this.label15.Text = "RFC:";
            // 
            // textClienteRFC
            // 
            this.textClienteRFC.Enabled = false;
            this.textClienteRFC.Location = new System.Drawing.Point(787, 170);
            this.textClienteRFC.Name = "textClienteRFC";
            this.textClienteRFC.Size = new System.Drawing.Size(169, 27);
            this.textClienteRFC.TabIndex = 3;
            this.textClienteRFC.TextChanged += new System.EventHandler(this.textCliente_TextChanged);
            // 
            // label16
            // 
            this.label16.AutoSize = true;
            this.label16.Location = new System.Drawing.Point(770, 337);
            this.label16.Name = "label16";
            this.label16.Size = new System.Drawing.Size(118, 20);
            this.label16.TabIndex = 2;
            this.label16.Text = "ID seleccionado:";
            // 
            // textIDCiudad
            // 
            this.textIDCiudad.Enabled = false;
            this.textIDCiudad.Location = new System.Drawing.Point(894, 335);
            this.textIDCiudad.Name = "textIDCiudad";
            this.textIDCiudad.Size = new System.Drawing.Size(62, 27);
            this.textIDCiudad.TabIndex = 3;
            this.textIDCiudad.TextChanged += new System.EventHandler(this.textCliente_TextChanged);
            // 
            // numericCanHab
            // 
            this.numericCanHab.Location = new System.Drawing.Point(572, 498);
            this.numericCanHab.Name = "numericCanHab";
            this.numericCanHab.Size = new System.Drawing.Size(89, 27);
            this.numericCanHab.TabIndex = 93;
            // 
            // textAnticipo
            // 
            this.textAnticipo.DecimalPlaces = 2;
            this.textAnticipo.Location = new System.Drawing.Point(388, 540);
            this.textAnticipo.Maximum = new decimal(new int[] {
            9999,
            0,
            0,
            0});
            this.textAnticipo.Name = "textAnticipo";
            this.textAnticipo.Size = new System.Drawing.Size(89, 27);
            this.textAnticipo.TabIndex = 95;
            // 
            // textPrecio
            // 
            this.textPrecio.Enabled = false;
            this.textPrecio.Location = new System.Drawing.Point(572, 540);
            this.textPrecio.Name = "textPrecio";
            this.textPrecio.Size = new System.Drawing.Size(89, 27);
            this.textPrecio.TabIndex = 96;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(514, 543);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(50, 20);
            this.label7.TabIndex = 97;
            this.label7.Text = "Costo:";
            // 
            // OPER_reservacion
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.BackColor = System.Drawing.Color.Gold;
            this.ClientSize = new System.Drawing.Size(993, 717);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.textPrecio);
            this.Controls.Add(this.textAnticipo);
            this.Controls.Add(this.numericCanHab);
            this.Controls.Add(this.textcodigo);
            this.Controls.Add(this.label14);
            this.Controls.Add(this.dtpRegistro);
            this.Controls.Add(this.label13);
            this.Controls.Add(this.pictureBox2);
            this.Controls.Add(this.btnReservar);
            this.Controls.Add(this.cbMpago);
            this.Controls.Add(this.label12);
            this.Controls.Add(this.label11);
            this.Controls.Add(this.dtpFinal);
            this.Controls.Add(this.dtpInicio);
            this.Controls.Add(this.label10);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.dgvCiudad);
            this.Controls.Add(this.textCiudad);
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
            this.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
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
            ((System.ComponentModel.ISupportInitialize)(this.textAnticipo)).EndInit();
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
        private System.Windows.Forms.TextBox textCiudad;
        private System.Windows.Forms.DataGridView dgvCiudad;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.DateTimePicker dtpInicio;
        private System.Windows.Forms.DateTimePicker dtpFinal;
        private System.Windows.Forms.Label label11;
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
        private System.Windows.Forms.NumericUpDown textAnticipo;
        private System.Windows.Forms.TextBox textPrecio;
        private System.Windows.Forms.Label label7;
    }
}