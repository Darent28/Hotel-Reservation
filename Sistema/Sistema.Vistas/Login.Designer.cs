namespace Sistema.Vistas
{
    partial class Login
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
            this.log = new System.Windows.Forms.TabControl();
            this.tabPage2 = new System.Windows.Forms.TabPage();
            this.btn_aceptar = new System.Windows.Forms.Button();
            this.tb_contrasenaL = new System.Windows.Forms.TextBox();
            this.tb_correoL = new System.Windows.Forms.TextBox();
            this.label15 = new System.Windows.Forms.Label();
            this.label17 = new System.Windows.Forms.Label();
            this.label16 = new System.Windows.Forms.Label();
            this.tabPage1 = new System.Windows.Forms.TabPage();
            this.dateTimePicker1 = new System.Windows.Forms.DateTimePicker();
            this.tb_telefono = new System.Windows.Forms.TextBox();
            this.tb_nomina = new System.Windows.Forms.TextBox();
            this.tb_apellidom = new System.Windows.Forms.TextBox();
            this.tb_apellidop = new System.Windows.Forms.TextBox();
            this.tb_nombre = new System.Windows.Forms.TextBox();
            this.tb_contrasena = new System.Windows.Forms.TextBox();
            this.tb_correo = new System.Windows.Forms.TextBox();
            this.tb_rfc = new System.Windows.Forms.TextBox();
            this.btn_crear = new System.Windows.Forms.Button();
            this.rb_operador = new System.Windows.Forms.RadioButton();
            this.rb_admin = new System.Windows.Forms.RadioButton();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.tb_pais = new System.Windows.Forms.TextBox();
            this.tb_estado = new System.Windows.Forms.TextBox();
            this.tb_ciudad = new System.Windows.Forms.TextBox();
            this.tb_domicilio = new System.Windows.Forms.TextBox();
            this.label10 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label14 = new System.Windows.Forms.Label();
            this.label13 = new System.Windows.Forms.Label();
            this.label12 = new System.Windows.Forms.Label();
            this.label11 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.log.SuspendLayout();
            this.tabPage2.SuspendLayout();
            this.tabPage1.SuspendLayout();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // log
            // 
            this.log.Controls.Add(this.tabPage2);
            this.log.Controls.Add(this.tabPage1);
            this.log.Location = new System.Drawing.Point(12, 4);
            this.log.Name = "log";
            this.log.SelectedIndex = 0;
            this.log.Size = new System.Drawing.Size(582, 625);
            this.log.TabIndex = 0;
            // 
            // tabPage2
            // 
            this.tabPage2.BackColor = System.Drawing.Color.Tomato;
            this.tabPage2.Controls.Add(this.btn_aceptar);
            this.tabPage2.Controls.Add(this.tb_contrasenaL);
            this.tabPage2.Controls.Add(this.tb_correoL);
            this.tabPage2.Controls.Add(this.label15);
            this.tabPage2.Controls.Add(this.label17);
            this.tabPage2.Controls.Add(this.label16);
            this.tabPage2.Location = new System.Drawing.Point(4, 22);
            this.tabPage2.Name = "tabPage2";
            this.tabPage2.Padding = new System.Windows.Forms.Padding(3, 3, 3, 3);
            this.tabPage2.Size = new System.Drawing.Size(574, 599);
            this.tabPage2.TabIndex = 1;
            this.tabPage2.Text = "Log in";
            this.tabPage2.Click += new System.EventHandler(this.tabPage2_Click);
            // 
            // btn_aceptar
            // 
            this.btn_aceptar.Location = new System.Drawing.Point(216, 434);
            this.btn_aceptar.Name = "btn_aceptar";
            this.btn_aceptar.Size = new System.Drawing.Size(97, 40);
            this.btn_aceptar.TabIndex = 9;
            this.btn_aceptar.Text = "Aceptar";
            this.btn_aceptar.UseVisualStyleBackColor = true;
            this.btn_aceptar.Click += new System.EventHandler(this.btn_aceptar_Click);
            // 
            // tb_contrasenaL
            // 
            this.tb_contrasenaL.Location = new System.Drawing.Point(178, 322);
            this.tb_contrasenaL.Name = "tb_contrasenaL";
            this.tb_contrasenaL.Size = new System.Drawing.Size(178, 20);
            this.tb_contrasenaL.TabIndex = 7;
            this.tb_contrasenaL.UseSystemPasswordChar = true;
            // 
            // tb_correoL
            // 
            this.tb_correoL.Location = new System.Drawing.Point(178, 245);
            this.tb_correoL.Name = "tb_correoL";
            this.tb_correoL.Size = new System.Drawing.Size(178, 20);
            this.tb_correoL.TabIndex = 8;
            this.tb_correoL.TextChanged += new System.EventHandler(this.tb_correoL_TextChanged);
            // 
            // label15
            // 
            this.label15.AutoSize = true;
            this.label15.Location = new System.Drawing.Point(175, 306);
            this.label15.Name = "label15";
            this.label15.Size = new System.Drawing.Size(64, 13);
            this.label15.TabIndex = 5;
            this.label15.Text = "Contraseña:";
            // 
            // label17
            // 
            this.label17.AutoSize = true;
            this.label17.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.label17.Location = new System.Drawing.Point(195, 169);
            this.label17.Name = "label17";
            this.label17.Size = new System.Drawing.Size(127, 20);
            this.label17.TabIndex = 6;
            this.label17.Text = "Inicio de Usuario";
            // 
            // label16
            // 
            this.label16.AutoSize = true;
            this.label16.Location = new System.Drawing.Point(175, 229);
            this.label16.Name = "label16";
            this.label16.Size = new System.Drawing.Size(41, 13);
            this.label16.TabIndex = 6;
            this.label16.Text = "Correo:";
            // 
            // tabPage1
            // 
            this.tabPage1.Controls.Add(this.dateTimePicker1);
            this.tabPage1.Controls.Add(this.tb_telefono);
            this.tabPage1.Controls.Add(this.tb_nomina);
            this.tabPage1.Controls.Add(this.tb_apellidom);
            this.tabPage1.Controls.Add(this.tb_apellidop);
            this.tabPage1.Controls.Add(this.tb_nombre);
            this.tabPage1.Controls.Add(this.tb_contrasena);
            this.tabPage1.Controls.Add(this.tb_correo);
            this.tabPage1.Controls.Add(this.tb_rfc);
            this.tabPage1.Controls.Add(this.btn_crear);
            this.tabPage1.Controls.Add(this.rb_operador);
            this.tabPage1.Controls.Add(this.rb_admin);
            this.tabPage1.Controls.Add(this.groupBox1);
            this.tabPage1.Controls.Add(this.label14);
            this.tabPage1.Controls.Add(this.label13);
            this.tabPage1.Controls.Add(this.label12);
            this.tabPage1.Controls.Add(this.label11);
            this.tabPage1.Controls.Add(this.label5);
            this.tabPage1.Controls.Add(this.label6);
            this.tabPage1.Controls.Add(this.label4);
            this.tabPage1.Controls.Add(this.label3);
            this.tabPage1.Controls.Add(this.label2);
            this.tabPage1.Controls.Add(this.label1);
            this.tabPage1.Location = new System.Drawing.Point(4, 22);
            this.tabPage1.Name = "tabPage1";
            this.tabPage1.Padding = new System.Windows.Forms.Padding(3, 3, 3, 3);
            this.tabPage1.Size = new System.Drawing.Size(574, 599);
            this.tabPage1.TabIndex = 0;
            this.tabPage1.Text = "Create User";
            this.tabPage1.UseVisualStyleBackColor = true;
            // 
            // dateTimePicker1
            // 
            this.dateTimePicker1.Location = new System.Drawing.Point(37, 249);
            this.dateTimePicker1.Name = "dateTimePicker1";
            this.dateTimePicker1.Size = new System.Drawing.Size(196, 20);
            this.dateTimePicker1.TabIndex = 5;
            // 
            // tb_telefono
            // 
            this.tb_telefono.Location = new System.Drawing.Point(37, 345);
            this.tb_telefono.Name = "tb_telefono";
            this.tb_telefono.Size = new System.Drawing.Size(162, 20);
            this.tb_telefono.TabIndex = 4;
            // 
            // tb_nomina
            // 
            this.tb_nomina.Location = new System.Drawing.Point(37, 298);
            this.tb_nomina.Name = "tb_nomina";
            this.tb_nomina.Size = new System.Drawing.Size(162, 20);
            this.tb_nomina.TabIndex = 4;
            // 
            // tb_apellidom
            // 
            this.tb_apellidom.Location = new System.Drawing.Point(39, 200);
            this.tb_apellidom.Name = "tb_apellidom";
            this.tb_apellidom.Size = new System.Drawing.Size(162, 20);
            this.tb_apellidom.TabIndex = 4;
            // 
            // tb_apellidop
            // 
            this.tb_apellidop.Location = new System.Drawing.Point(37, 150);
            this.tb_apellidop.Name = "tb_apellidop";
            this.tb_apellidop.Size = new System.Drawing.Size(162, 20);
            this.tb_apellidop.TabIndex = 4;
            // 
            // tb_nombre
            // 
            this.tb_nombre.Location = new System.Drawing.Point(37, 102);
            this.tb_nombre.Name = "tb_nombre";
            this.tb_nombre.Size = new System.Drawing.Size(162, 20);
            this.tb_nombre.TabIndex = 4;
            // 
            // tb_contrasena
            // 
            this.tb_contrasena.Location = new System.Drawing.Point(345, 255);
            this.tb_contrasena.Name = "tb_contrasena";
            this.tb_contrasena.Size = new System.Drawing.Size(178, 20);
            this.tb_contrasena.TabIndex = 4;
            this.tb_contrasena.UseSystemPasswordChar = true;
            // 
            // tb_correo
            // 
            this.tb_correo.Location = new System.Drawing.Point(345, 205);
            this.tb_correo.Name = "tb_correo";
            this.tb_correo.Size = new System.Drawing.Size(178, 20);
            this.tb_correo.TabIndex = 4;
            // 
            // tb_rfc
            // 
            this.tb_rfc.Location = new System.Drawing.Point(37, 58);
            this.tb_rfc.Name = "tb_rfc";
            this.tb_rfc.Size = new System.Drawing.Size(162, 20);
            this.tb_rfc.TabIndex = 4;
            // 
            // btn_crear
            // 
            this.btn_crear.Location = new System.Drawing.Point(439, 536);
            this.btn_crear.Name = "btn_crear";
            this.btn_crear.Size = new System.Drawing.Size(97, 40);
            this.btn_crear.TabIndex = 3;
            this.btn_crear.Text = "Crear";
            this.btn_crear.UseVisualStyleBackColor = true;
            this.btn_crear.Click += new System.EventHandler(this.btn_crear_Click);
            // 
            // rb_operador
            // 
            this.rb_operador.AutoSize = true;
            this.rb_operador.Location = new System.Drawing.Point(431, 334);
            this.rb_operador.Name = "rb_operador";
            this.rb_operador.Size = new System.Drawing.Size(69, 17);
            this.rb_operador.TabIndex = 2;
            this.rb_operador.TabStop = true;
            this.rb_operador.Text = "Operador";
            this.rb_operador.UseVisualStyleBackColor = true;
            // 
            // rb_admin
            // 
            this.rb_admin.AutoSize = true;
            this.rb_admin.Location = new System.Drawing.Point(345, 334);
            this.rb_admin.Name = "rb_admin";
            this.rb_admin.Size = new System.Drawing.Size(54, 17);
            this.rb_admin.TabIndex = 2;
            this.rb_admin.TabStop = true;
            this.rb_admin.Text = "Admin";
            this.rb_admin.UseVisualStyleBackColor = true;
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.tb_pais);
            this.groupBox1.Controls.Add(this.tb_estado);
            this.groupBox1.Controls.Add(this.tb_ciudad);
            this.groupBox1.Controls.Add(this.tb_domicilio);
            this.groupBox1.Controls.Add(this.label10);
            this.groupBox1.Controls.Add(this.label9);
            this.groupBox1.Controls.Add(this.label8);
            this.groupBox1.Controls.Add(this.label7);
            this.groupBox1.Location = new System.Drawing.Point(19, 390);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(292, 192);
            this.groupBox1.TabIndex = 1;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Ubicación";
            // 
            // tb_pais
            // 
            this.tb_pais.Location = new System.Drawing.Point(9, 162);
            this.tb_pais.Name = "tb_pais";
            this.tb_pais.Size = new System.Drawing.Size(266, 20);
            this.tb_pais.TabIndex = 4;
            // 
            // tb_estado
            // 
            this.tb_estado.Location = new System.Drawing.Point(9, 123);
            this.tb_estado.Name = "tb_estado";
            this.tb_estado.Size = new System.Drawing.Size(266, 20);
            this.tb_estado.TabIndex = 4;
            // 
            // tb_ciudad
            // 
            this.tb_ciudad.Location = new System.Drawing.Point(9, 81);
            this.tb_ciudad.Name = "tb_ciudad";
            this.tb_ciudad.Size = new System.Drawing.Size(266, 20);
            this.tb_ciudad.TabIndex = 4;
            // 
            // tb_domicilio
            // 
            this.tb_domicilio.Location = new System.Drawing.Point(9, 41);
            this.tb_domicilio.Name = "tb_domicilio";
            this.tb_domicilio.Size = new System.Drawing.Size(266, 20);
            this.tb_domicilio.TabIndex = 4;
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(6, 146);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(32, 13);
            this.label10.TabIndex = 0;
            this.label10.Text = "País:";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(6, 108);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(43, 13);
            this.label9.TabIndex = 0;
            this.label9.Text = "Estado:";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(6, 67);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(43, 13);
            this.label8.TabIndex = 0;
            this.label8.Text = "Ciudad:";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(6, 26);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(52, 13);
            this.label7.TabIndex = 0;
            this.label7.Text = "Domicilio:";
            // 
            // label14
            // 
            this.label14.AutoSize = true;
            this.label14.Location = new System.Drawing.Point(342, 305);
            this.label14.Name = "label14";
            this.label14.Size = new System.Drawing.Size(85, 13);
            this.label14.TabIndex = 0;
            this.label14.Text = "Tipo de Usuario:";
            // 
            // label13
            // 
            this.label13.AutoSize = true;
            this.label13.Location = new System.Drawing.Point(342, 239);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(64, 13);
            this.label13.TabIndex = 0;
            this.label13.Text = "Contraseña:";
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Location = new System.Drawing.Point(342, 189);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(41, 13);
            this.label12.TabIndex = 0;
            this.label12.Text = "Correo:";
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Location = new System.Drawing.Point(36, 329);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(52, 13);
            this.label11.TabIndex = 0;
            this.label11.Text = "Telefono:";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(36, 282);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(101, 13);
            this.label5.TabIndex = 0;
            this.label5.Text = "Numero de Nomina:";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(36, 233);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(111, 13);
            this.label6.TabIndex = 0;
            this.label6.Text = "Fecha de Nacimiento:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(36, 184);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(89, 13);
            this.label4.TabIndex = 0;
            this.label4.Text = "Apellido Materno:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(36, 134);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(87, 13);
            this.label3.TabIndex = 0;
            this.label3.Text = "Apellido Paterno:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(36, 86);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(47, 13);
            this.label2.TabIndex = 0;
            this.label2.Text = "Nombre:";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(36, 42);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(31, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "RFC:";
            // 
            // Login
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Yellow;
            this.ClientSize = new System.Drawing.Size(607, 641);
            this.Controls.Add(this.log);
            this.Name = "Login";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Login";
            this.Load += new System.EventHandler(this.Login_Load);
            this.log.ResumeLayout(false);
            this.tabPage2.ResumeLayout(false);
            this.tabPage2.PerformLayout();
            this.tabPage1.ResumeLayout(false);
            this.tabPage1.PerformLayout();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TabControl log;
        private System.Windows.Forms.TabPage tabPage1;
        private System.Windows.Forms.TabPage tabPage2;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label13;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.Label label14;
        private System.Windows.Forms.RadioButton rb_operador;
        private System.Windows.Forms.RadioButton rb_admin;
        private System.Windows.Forms.DateTimePicker dateTimePicker1;
        private System.Windows.Forms.TextBox tb_telefono;
        private System.Windows.Forms.TextBox tb_nomina;
        private System.Windows.Forms.TextBox tb_apellidom;
        private System.Windows.Forms.TextBox tb_apellidop;
        private System.Windows.Forms.TextBox tb_nombre;
        private System.Windows.Forms.TextBox tb_contrasena;
        private System.Windows.Forms.TextBox tb_correo;
        private System.Windows.Forms.TextBox tb_rfc;
        private System.Windows.Forms.Button btn_crear;
        private System.Windows.Forms.TextBox tb_pais;
        private System.Windows.Forms.TextBox tb_estado;
        private System.Windows.Forms.TextBox tb_ciudad;
        private System.Windows.Forms.TextBox tb_domicilio;
        private System.Windows.Forms.TextBox tb_contrasenaL;
        private System.Windows.Forms.TextBox tb_correoL;
        private System.Windows.Forms.Label label15;
        private System.Windows.Forms.Label label17;
        private System.Windows.Forms.Label label16;
        private System.Windows.Forms.Button btn_aceptar;
    }
}