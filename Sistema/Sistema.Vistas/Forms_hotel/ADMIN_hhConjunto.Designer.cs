namespace Sistema.Vistas.Forms_hotel
{
    partial class ADMIN_hhConjunto
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(ADMIN_hhConjunto));
            this.panel1 = new System.Windows.Forms.Panel();
            this.fechas = new System.Windows.Forms.Label();
            this.horas = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.btnVerUsers = new System.Windows.Forms.Button();
            this.btnElimUsers = new System.Windows.Forms.Button();
            this.btnEditarUsers = new System.Windows.Forms.Button();
            this.label12 = new System.Windows.Forms.Label();
            this.dataGridUsers = new System.Windows.Forms.DataGridView();
            this.textHHID = new System.Windows.Forms.TextBox();
            this.label10 = new System.Windows.Forms.Label();
            this.comboBoxHabitacion = new System.Windows.Forms.ComboBox();
            this.textNivelHab = new System.Windows.Forms.TextBox();
            this.textNomHotel = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.comboBoxHotel = new System.Windows.Forms.ComboBox();
            this.btnRegistrarH = new System.Windows.Forms.Button();
            this.textTipoHab = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.textcaracteristicas = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.textAmenidades = new System.Windows.Forms.TextBox();
            this.label8 = new System.Windows.Forms.Label();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridUsers)).BeginInit();
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
            this.panel1.Location = new System.Drawing.Point(-20, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1017, 121);
            this.panel1.TabIndex = 3;
            // 
            // fechas
            // 
            this.fechas.AutoSize = true;
            this.fechas.Font = new System.Drawing.Font("Segoe UI", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.fechas.ForeColor = System.Drawing.Color.White;
            this.fechas.Location = new System.Drawing.Point(532, 67);
            this.fechas.Name = "fechas";
            this.fechas.Size = new System.Drawing.Size(50, 19);
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
            this.horas.Size = new System.Drawing.Size(50, 19);
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
            this.label4.Size = new System.Drawing.Size(50, 19);
            this.label4.TabIndex = 7;
            this.label4.Text = "label4";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.ForeColor = System.Drawing.Color.White;
            this.label3.Location = new System.Drawing.Point(459, 67);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(40, 13);
            this.label3.TabIndex = 6;
            this.label3.Text = "Fecha:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.ForeColor = System.Drawing.Color.White;
            this.label2.Location = new System.Drawing.Point(208, 67);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(33, 13);
            this.label2.TabIndex = 5;
            this.label2.Text = "Hora:";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.ForeColor = System.Drawing.Color.White;
            this.label1.Location = new System.Drawing.Point(208, 21);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(129, 13);
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
            // timer1
            // 
            this.timer1.Tick += new System.EventHandler(this.timer1_Tick_1);
            // 
            // btnVerUsers
            // 
            this.btnVerUsers.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(255)))), ((int)(((byte)(128)))));
            this.btnVerUsers.Font = new System.Drawing.Font("Segoe UI", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnVerUsers.Location = new System.Drawing.Point(768, 567);
            this.btnVerUsers.Name = "btnVerUsers";
            this.btnVerUsers.Size = new System.Drawing.Size(128, 53);
            this.btnVerUsers.TabIndex = 77;
            this.btnVerUsers.Text = "Ver Conjuntos";
            this.btnVerUsers.UseVisualStyleBackColor = false;
            this.btnVerUsers.Click += new System.EventHandler(this.btnVerUsers_Click);
            // 
            // btnElimUsers
            // 
            this.btnElimUsers.BackColor = System.Drawing.Color.Red;
            this.btnElimUsers.Font = new System.Drawing.Font("Segoe UI", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnElimUsers.Location = new System.Drawing.Point(768, 703);
            this.btnElimUsers.Name = "btnElimUsers";
            this.btnElimUsers.Size = new System.Drawing.Size(128, 47);
            this.btnElimUsers.TabIndex = 76;
            this.btnElimUsers.Text = "Eliminar";
            this.btnElimUsers.UseVisualStyleBackColor = false;
            this.btnElimUsers.Click += new System.EventHandler(this.btnElimUsers_Click);
            // 
            // btnEditarUsers
            // 
            this.btnEditarUsers.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(0)))));
            this.btnEditarUsers.Font = new System.Drawing.Font("Segoe UI", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnEditarUsers.Location = new System.Drawing.Point(768, 636);
            this.btnEditarUsers.Name = "btnEditarUsers";
            this.btnEditarUsers.Size = new System.Drawing.Size(128, 50);
            this.btnEditarUsers.TabIndex = 75;
            this.btnEditarUsers.Text = "Editar";
            this.btnEditarUsers.UseVisualStyleBackColor = false;
            this.btnEditarUsers.Click += new System.EventHandler(this.btnEditarUsers_Click);
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Location = new System.Drawing.Point(44, 528);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(532, 26);
            this.label12.TabIndex = 74;
            this.label12.Text = "Presione el botón \"Ver Conjunto\" para ver los conjuntos de los hoteles con habita" +
    "cion registrados en el sistema.\r\nDe click sobre la celda y oprima el botón con l" +
    "a opción que desea realizar al dato.\r\n";
            this.label12.Click += new System.EventHandler(this.label12_Click);
            // 
            // dataGridUsers
            // 
            this.dataGridUsers.AllowUserToAddRows = false;
            this.dataGridUsers.AllowUserToDeleteRows = false;
            this.dataGridUsers.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridUsers.Location = new System.Drawing.Point(43, 567);
            this.dataGridUsers.Name = "dataGridUsers";
            this.dataGridUsers.ReadOnly = true;
            this.dataGridUsers.RowHeadersWidth = 51;
            this.dataGridUsers.RowTemplate.Height = 24;
            this.dataGridUsers.Size = new System.Drawing.Size(692, 183);
            this.dataGridUsers.TabIndex = 73;
            this.dataGridUsers.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridUsers_CellContentClick);
            // 
            // textHHID
            // 
            this.textHHID.Location = new System.Drawing.Point(479, 168);
            this.textHHID.Name = "textHHID";
            this.textHHID.Size = new System.Drawing.Size(45, 20);
            this.textHHID.TabIndex = 91;
            this.textHHID.Visible = false;
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(374, 216);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(73, 13);
            this.label10.TabIndex = 92;
            this.label10.Text = "ID habitacion:";
            // 
            // comboBoxHabitacion
            // 
            this.comboBoxHabitacion.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboBoxHabitacion.FormattingEnabled = true;
            this.comboBoxHabitacion.Location = new System.Drawing.Point(479, 211);
            this.comboBoxHabitacion.Name = "comboBoxHabitacion";
            this.comboBoxHabitacion.Size = new System.Drawing.Size(61, 21);
            this.comboBoxHabitacion.TabIndex = 93;
            this.comboBoxHabitacion.SelectedIndexChanged += new System.EventHandler(this.comboBoxHabitacion_SelectedIndexChanged_1);
            // 
            // textNivelHab
            // 
            this.textNivelHab.Enabled = false;
            this.textNivelHab.Location = new System.Drawing.Point(559, 212);
            this.textNivelHab.Name = "textNivelHab";
            this.textNivelHab.Size = new System.Drawing.Size(129, 20);
            this.textNivelHab.TabIndex = 91;
            // 
            // textNomHotel
            // 
            this.textNomHotel.Enabled = false;
            this.textNomHotel.Location = new System.Drawing.Point(559, 250);
            this.textNomHotel.Name = "textNomHotel";
            this.textNomHotel.Size = new System.Drawing.Size(129, 20);
            this.textNomHotel.TabIndex = 91;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(398, 254);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(47, 13);
            this.label5.TabIndex = 92;
            this.label5.Text = "ID hotel:";
            // 
            // comboBoxHotel
            // 
            this.comboBoxHotel.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboBoxHotel.FormattingEnabled = true;
            this.comboBoxHotel.Location = new System.Drawing.Point(479, 250);
            this.comboBoxHotel.Name = "comboBoxHotel";
            this.comboBoxHotel.Size = new System.Drawing.Size(61, 21);
            this.comboBoxHotel.TabIndex = 93;
            this.comboBoxHotel.SelectedIndexChanged += new System.EventHandler(this.comboBoxHotel_SelectedIndexChanged);
            // 
            // btnRegistrarH
            // 
            this.btnRegistrarH.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            this.btnRegistrarH.Font = new System.Drawing.Font("Segoe UI", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnRegistrarH.Location = new System.Drawing.Point(612, 433);
            this.btnRegistrarH.Name = "btnRegistrarH";
            this.btnRegistrarH.Size = new System.Drawing.Size(186, 60);
            this.btnRegistrarH.TabIndex = 94;
            this.btnRegistrarH.Text = "Registrar";
            this.btnRegistrarH.UseVisualStyleBackColor = false;
            this.btnRegistrarH.Click += new System.EventHandler(this.btnRegistrarH_Click);
            // 
            // textTipoHab
            // 
            this.textTipoHab.Location = new System.Drawing.Point(478, 294);
            this.textTipoHab.Name = "textTipoHab";
            this.textTipoHab.Size = new System.Drawing.Size(129, 20);
            this.textTipoHab.TabIndex = 91;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(348, 299);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(98, 13);
            this.label6.TabIndex = 92;
            this.label6.Text = "Tipo de habitacion:";
            // 
            // textcaracteristicas
            // 
            this.textcaracteristicas.Location = new System.Drawing.Point(478, 337);
            this.textcaracteristicas.Name = "textcaracteristicas";
            this.textcaracteristicas.Size = new System.Drawing.Size(263, 20);
            this.textcaracteristicas.TabIndex = 91;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(366, 340);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(79, 13);
            this.label7.TabIndex = 92;
            this.label7.Text = "Caracteristicas:";
            // 
            // textAmenidades
            // 
            this.textAmenidades.Location = new System.Drawing.Point(478, 374);
            this.textAmenidades.Name = "textAmenidades";
            this.textAmenidades.Size = new System.Drawing.Size(263, 20);
            this.textAmenidades.TabIndex = 91;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(374, 381);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(68, 13);
            this.label8.TabIndex = 92;
            this.label8.Text = "Amenidades:";
            // 
            // ADMIN_hhConjunto
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Gold;
            this.ClientSize = new System.Drawing.Size(925, 772);
            this.Controls.Add(this.btnRegistrarH);
            this.Controls.Add(this.comboBoxHotel);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.textAmenidades);
            this.Controls.Add(this.textcaracteristicas);
            this.Controls.Add(this.textTipoHab);
            this.Controls.Add(this.comboBoxHabitacion);
            this.Controls.Add(this.textNomHotel);
            this.Controls.Add(this.label10);
            this.Controls.Add(this.textNivelHab);
            this.Controls.Add(this.textHHID);
            this.Controls.Add(this.btnVerUsers);
            this.Controls.Add(this.btnElimUsers);
            this.Controls.Add(this.btnEditarUsers);
            this.Controls.Add(this.label12);
            this.Controls.Add(this.dataGridUsers);
            this.Controls.Add(this.panel1);
            this.Name = "ADMIN_hhConjunto";
            this.Text = "Darle habitacion al hotel";
            this.Load += new System.EventHandler(this.ADMIN_hhConjunto_Load);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridUsers)).EndInit();
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
        private System.Windows.Forms.Timer timer1;
        private System.Windows.Forms.Button btnVerUsers;
        private System.Windows.Forms.Button btnElimUsers;
        private System.Windows.Forms.Button btnEditarUsers;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.DataGridView dataGridUsers;
        private System.Windows.Forms.TextBox textHHID;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.ComboBox comboBoxHabitacion;
        private System.Windows.Forms.TextBox textNivelHab;
        private System.Windows.Forms.TextBox textNomHotel;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.ComboBox comboBoxHotel;
        private System.Windows.Forms.Button btnRegistrarH;
        private System.Windows.Forms.TextBox textTipoHab;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox textcaracteristicas;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.TextBox textAmenidades;
        private System.Windows.Forms.Label label8;
    }
}