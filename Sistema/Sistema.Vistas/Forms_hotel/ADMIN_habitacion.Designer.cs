
namespace Sistema.Vistas.Forms_hotel
{
    partial class ADMIN_habitacion
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(ADMIN_habitacion));
            this.panel1 = new System.Windows.Forms.Panel();
            this.fechas = new System.Windows.Forms.Label();
            this.horas = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.tiempo = new System.Windows.Forms.Timer(this.components);
            this.btnVerHabitaciones = new System.Windows.Forms.Button();
            this.btnElimHB = new System.Windows.Forms.Button();
            this.btnEditarHb = new System.Windows.Forms.Button();
            this.label12 = new System.Windows.Forms.Label();
            this.dataGridHabitaciones = new System.Windows.Forms.DataGridView();
            this.btnRegistrarH = new System.Windows.Forms.Button();
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            this.label11 = new System.Windows.Forms.Label();
            this.numericPisos = new System.Windows.Forms.NumericUpDown();
            this.label10 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.textPrecio = new System.Windows.Forms.TextBox();
            this.label8 = new System.Windows.Forms.Label();
            this.textID_habitaciones = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.comboBoxTipos = new System.Windows.Forms.ComboBox();
            this.numericPersonas = new System.Windows.Forms.NumericUpDown();
            this.label6 = new System.Windows.Forms.Label();
            this.comboBoxNivel = new System.Windows.Forms.ComboBox();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.radioJardin = new System.Windows.Forms.RadioButton();
            this.radioPlaya = new System.Windows.Forms.RadioButton();
            this.radioPiscina = new System.Windows.Forms.RadioButton();
            this.label7 = new System.Windows.Forms.Label();
            this.textID_hotel = new System.Windows.Forms.TextBox();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridHabitaciones)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericPisos)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericPersonas)).BeginInit();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.DimGray;
            this.panel1.Controls.Add(this.fechas);
            this.panel1.Controls.Add(this.horas);
            this.panel1.Controls.Add(this.label4);
            this.panel1.Controls.Add(this.label3);
            this.panel1.Controls.Add(this.label2);
            this.panel1.Controls.Add(this.label1);
            this.panel1.Controls.Add(this.pictureBox1);
            this.panel1.Location = new System.Drawing.Point(-1, -3);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(906, 121);
            this.panel1.TabIndex = 1;
            // 
            // fechas
            // 
            this.fechas.AutoSize = true;
            this.fechas.Font = new System.Drawing.Font("Segoe UI", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.fechas.ForeColor = System.Drawing.Color.White;
            this.fechas.Location = new System.Drawing.Point(532, 67);
            this.fechas.Name = "fechas";
            this.fechas.Size = new System.Drawing.Size(59, 23);
            this.fechas.TabIndex = 9;
            this.fechas.Text = "label6";
            // 
            // horas
            // 
            this.horas.AutoSize = true;
            this.horas.Font = new System.Drawing.Font("Segoe UI", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.horas.ForeColor = System.Drawing.Color.White;
            this.horas.Location = new System.Drawing.Point(265, 67);
            this.horas.Name = "horas";
            this.horas.Size = new System.Drawing.Size(59, 23);
            this.horas.TabIndex = 8;
            this.horas.Text = "label5";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Segoe UI", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.ForeColor = System.Drawing.Color.White;
            this.label4.Location = new System.Drawing.Point(430, 21);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(59, 23);
            this.label4.TabIndex = 7;
            this.label4.Text = "label4";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.ForeColor = System.Drawing.Color.White;
            this.label3.Location = new System.Drawing.Point(459, 67);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(58, 23);
            this.label3.TabIndex = 6;
            this.label3.Text = "Fecha:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.ForeColor = System.Drawing.Color.White;
            this.label2.Location = new System.Drawing.Point(208, 67);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(51, 23);
            this.label2.TabIndex = 5;
            this.label2.Text = "Hora:";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.ForeColor = System.Drawing.Color.White;
            this.label1.Location = new System.Drawing.Point(208, 21);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(216, 23);
            this.label1.TabIndex = 4;
            this.label1.Text = "Nombre del administrador:\r\n";
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(38, 30);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(116, 58);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox1.TabIndex = 0;
            this.pictureBox1.TabStop = false;
            // 
            // tiempo
            // 
            this.tiempo.Enabled = true;
            this.tiempo.Tick += new System.EventHandler(this.tiempo_Tick);
            // 
            // btnVerHabitaciones
            // 
            this.btnVerHabitaciones.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(255)))), ((int)(((byte)(128)))));
            this.btnVerHabitaciones.Font = new System.Drawing.Font("Segoe UI", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnVerHabitaciones.Location = new System.Drawing.Point(730, 558);
            this.btnVerHabitaciones.Name = "btnVerHabitaciones";
            this.btnVerHabitaciones.Size = new System.Drawing.Size(128, 63);
            this.btnVerHabitaciones.TabIndex = 50;
            this.btnVerHabitaciones.Text = "Ver habitaciones";
            this.btnVerHabitaciones.UseVisualStyleBackColor = false;
            // 
            // btnElimHB
            // 
            this.btnElimHB.BackColor = System.Drawing.Color.Red;
            this.btnElimHB.Font = new System.Drawing.Font("Segoe UI", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnElimHB.Location = new System.Drawing.Point(730, 694);
            this.btnElimHB.Name = "btnElimHB";
            this.btnElimHB.Size = new System.Drawing.Size(128, 47);
            this.btnElimHB.TabIndex = 49;
            this.btnElimHB.Text = "Eliminar";
            this.btnElimHB.UseVisualStyleBackColor = false;
            // 
            // btnEditarHb
            // 
            this.btnEditarHb.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(0)))));
            this.btnEditarHb.Font = new System.Drawing.Font("Segoe UI", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnEditarHb.Location = new System.Drawing.Point(730, 627);
            this.btnEditarHb.Name = "btnEditarHb";
            this.btnEditarHb.Size = new System.Drawing.Size(128, 61);
            this.btnEditarHb.TabIndex = 48;
            this.btnEditarHb.Text = "Editar";
            this.btnEditarHb.UseVisualStyleBackColor = false;
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Location = new System.Drawing.Point(52, 490);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(678, 46);
            this.label12.TabIndex = 47;
            this.label12.Text = "Presione el botón \"Ver habitaciones\" para ver las habitaciones registradas en el " +
    "sistema.\r\nDe click sobre la celda y oprima el botón con la opción que desea real" +
    "izar al dato.\r\n";
            // 
            // dataGridHabitaciones
            // 
            this.dataGridHabitaciones.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridHabitaciones.Location = new System.Drawing.Point(56, 558);
            this.dataGridHabitaciones.Name = "dataGridHabitaciones";
            this.dataGridHabitaciones.ReadOnly = true;
            this.dataGridHabitaciones.RowHeadersWidth = 51;
            this.dataGridHabitaciones.RowTemplate.Height = 24;
            this.dataGridHabitaciones.Size = new System.Drawing.Size(645, 183);
            this.dataGridHabitaciones.TabIndex = 46;
            // 
            // btnRegistrarH
            // 
            this.btnRegistrarH.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            this.btnRegistrarH.Font = new System.Drawing.Font("Segoe UI", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnRegistrarH.Location = new System.Drawing.Point(619, 361);
            this.btnRegistrarH.Name = "btnRegistrarH";
            this.btnRegistrarH.Size = new System.Drawing.Size(186, 60);
            this.btnRegistrarH.TabIndex = 45;
            this.btnRegistrarH.Text = "Registrar";
            this.btnRegistrarH.UseVisualStyleBackColor = false;
            // 
            // pictureBox2
            // 
            this.pictureBox2.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox2.Image")));
            this.pictureBox2.Location = new System.Drawing.Point(56, 186);
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Size = new System.Drawing.Size(170, 166);
            this.pictureBox2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox2.TabIndex = 44;
            this.pictureBox2.TabStop = false;
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Location = new System.Drawing.Point(310, 289);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(124, 23);
            this.label11.TabIndex = 38;
            this.label11.Text = "Tipos de cama:";
            // 
            // numericPisos
            // 
            this.numericPisos.Location = new System.Drawing.Point(444, 247);
            this.numericPisos.Name = "numericPisos";
            this.numericPisos.Size = new System.Drawing.Size(100, 30);
            this.numericPisos.TabIndex = 37;
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(280, 249);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(154, 23);
            this.label10.TabIndex = 36;
            this.label10.Text = "Número de camas:";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(273, 434);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(161, 23);
            this.label9.TabIndex = 34;
            this.label9.Text = "Nivel de habitación:";
            // 
            // textPrecio
            // 
            this.textPrecio.Location = new System.Drawing.Point(444, 337);
            this.textPrecio.Name = "textPrecio";
            this.textPrecio.Size = new System.Drawing.Size(146, 30);
            this.textPrecio.TabIndex = 33;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(290, 337);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(144, 23);
            this.label8.TabIndex = 32;
            this.label8.Text = "Precio por noche:";
            // 
            // textID_habitaciones
            // 
            this.textID_habitaciones.Location = new System.Drawing.Point(444, 159);
            this.textID_habitaciones.Name = "textID_habitaciones";
            this.textID_habitaciones.Size = new System.Drawing.Size(146, 30);
            this.textID_habitaciones.TabIndex = 30;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(294, 162);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(140, 23);
            this.label5.TabIndex = 51;
            this.label5.Text = "ID de habitación:";
            // 
            // comboBoxTipos
            // 
            this.comboBoxTipos.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboBoxTipos.FormattingEnabled = true;
            this.comboBoxTipos.Location = new System.Drawing.Point(444, 287);
            this.comboBoxTipos.Name = "comboBoxTipos";
            this.comboBoxTipos.Size = new System.Drawing.Size(121, 31);
            this.comboBoxTipos.TabIndex = 52;
            // 
            // numericPersonas
            // 
            this.numericPersonas.Location = new System.Drawing.Point(444, 381);
            this.numericPersonas.Name = "numericPersonas";
            this.numericPersonas.Size = new System.Drawing.Size(100, 30);
            this.numericPersonas.TabIndex = 53;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(260, 382);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(174, 23);
            this.label6.TabIndex = 54;
            this.label6.Text = "Número de personas:";
            // 
            // comboBoxNivel
            // 
            this.comboBoxNivel.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboBoxNivel.FormattingEnabled = true;
            this.comboBoxNivel.Location = new System.Drawing.Point(444, 429);
            this.comboBoxNivel.Name = "comboBoxNivel";
            this.comboBoxNivel.Size = new System.Drawing.Size(121, 31);
            this.comboBoxNivel.TabIndex = 55;
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.radioPiscina);
            this.groupBox1.Controls.Add(this.radioPlaya);
            this.groupBox1.Controls.Add(this.radioJardin);
            this.groupBox1.Location = new System.Drawing.Point(619, 169);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(186, 159);
            this.groupBox1.TabIndex = 56;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Vista";
            // 
            // radioJardin
            // 
            this.radioJardin.AutoSize = true;
            this.radioJardin.Checked = true;
            this.radioJardin.Location = new System.Drawing.Point(17, 37);
            this.radioJardin.Name = "radioJardin";
            this.radioJardin.Size = new System.Drawing.Size(145, 27);
            this.radioJardin.TabIndex = 0;
            this.radioJardin.TabStop = true;
            this.radioJardin.Text = "Frente al jardín";
            this.radioJardin.UseVisualStyleBackColor = true;
            // 
            // radioPlaya
            // 
            this.radioPlaya.AutoSize = true;
            this.radioPlaya.Location = new System.Drawing.Point(17, 70);
            this.radioPlaya.Name = "radioPlaya";
            this.radioPlaya.Size = new System.Drawing.Size(156, 27);
            this.radioPlaya.TabIndex = 1;
            this.radioPlaya.Text = "Frente a la playa";
            this.radioPlaya.UseVisualStyleBackColor = true;
            // 
            // radioPiscina
            // 
            this.radioPiscina.AutoSize = true;
            this.radioPiscina.Location = new System.Drawing.Point(17, 103);
            this.radioPiscina.Name = "radioPiscina";
            this.radioPiscina.Size = new System.Drawing.Size(168, 27);
            this.radioPiscina.TabIndex = 2;
            this.radioPiscina.Text = "Frente a la piscina";
            this.radioPiscina.UseVisualStyleBackColor = true;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(259, 210);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(175, 23);
            this.label7.TabIndex = 57;
            this.label7.Text = "ID del hotel asociado:";
            // 
            // textID_hotel
            // 
            this.textID_hotel.Location = new System.Drawing.Point(444, 203);
            this.textID_hotel.Name = "textID_hotel";
            this.textID_hotel.Size = new System.Drawing.Size(146, 30);
            this.textID_hotel.TabIndex = 58;
            // 
            // ADMIN_habitacion
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 23F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.BackColor = System.Drawing.Color.Gold;
            this.ClientSize = new System.Drawing.Size(900, 772);
            this.Controls.Add(this.textID_hotel);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.comboBoxNivel);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.numericPersonas);
            this.Controls.Add(this.comboBoxTipos);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.btnVerHabitaciones);
            this.Controls.Add(this.btnElimHB);
            this.Controls.Add(this.btnEditarHb);
            this.Controls.Add(this.label12);
            this.Controls.Add(this.dataGridHabitaciones);
            this.Controls.Add(this.btnRegistrarH);
            this.Controls.Add(this.pictureBox2);
            this.Controls.Add(this.label11);
            this.Controls.Add(this.numericPisos);
            this.Controls.Add(this.label10);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.textPrecio);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.textID_habitaciones);
            this.Controls.Add(this.panel1);
            this.Font = new System.Drawing.Font("Segoe UI", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.MaximizeBox = false;
            this.Name = "ADMIN_habitacion";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Registro de habitaciones";
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridHabitaciones)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericPisos)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericPersonas)).EndInit();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label fechas;
        private System.Windows.Forms.Label horas;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Timer tiempo;
        private System.Windows.Forms.Button btnVerHabitaciones;
        private System.Windows.Forms.Button btnElimHB;
        private System.Windows.Forms.Button btnEditarHb;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.DataGridView dataGridHabitaciones;
        private System.Windows.Forms.Button btnRegistrarH;
        private System.Windows.Forms.PictureBox pictureBox2;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.NumericUpDown numericPisos;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.TextBox textPrecio;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.TextBox textID_habitaciones;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.ComboBox comboBoxTipos;
        private System.Windows.Forms.NumericUpDown numericPersonas;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.ComboBox comboBoxNivel;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.RadioButton radioPiscina;
        private System.Windows.Forms.RadioButton radioPlaya;
        private System.Windows.Forms.RadioButton radioJardin;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.TextBox textID_hotel;
    }
}