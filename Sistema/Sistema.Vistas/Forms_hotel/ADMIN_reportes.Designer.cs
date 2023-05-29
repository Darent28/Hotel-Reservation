
namespace Sistema.Vistas.Forms_hotel
{
    partial class ADMIN_reportes
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(ADMIN_reportes));
            this.tabControl1 = new System.Windows.Forms.TabControl();
            this.tabPage1 = new System.Windows.Forms.TabPage();
            this.datetimepicker1 = new System.Windows.Forms.DateTimePicker();
            this.cbpais = new System.Windows.Forms.ComboBox();
            this.cbCiudad = new System.Windows.Forms.ComboBox();
            this.cbhotel = new System.Windows.Forms.ComboBox();
            this.checkBoxTodos1 = new System.Windows.Forms.CheckBox();
            this.dataGridFiltroH = new System.Windows.Forms.DataGridView();
            this.btnAplicarFH = new System.Windows.Forms.Button();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.tabPage2 = new System.Windows.Forms.TabPage();
            this.cbpais2 = new System.Windows.Forms.ComboBox();
            this.cbciudad2 = new System.Windows.Forms.ComboBox();
            this.cbhotel2 = new System.Windows.Forms.ComboBox();
            this.dateTimePicker2 = new System.Windows.Forms.DateTimePicker();
            this.checkBoxTodos = new System.Windows.Forms.CheckBox();
            this.dataGridVentas = new System.Windows.Forms.DataGridView();
            this.btnVentas = new System.Windows.Forms.Button();
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.tabPage3 = new System.Windows.Forms.TabPage();
            this.dateTimePicker3 = new System.Windows.Forms.DateTimePicker();
            this.dataGridClientes = new System.Windows.Forms.DataGridView();
            this.checkAños = new System.Windows.Forms.CheckBox();
            this.dataGridHistorial = new System.Windows.Forms.DataGridView();
            this.btnAplicarFClientes = new System.Windows.Forms.Button();
            this.textcliente = new System.Windows.Forms.TextBox();
            this.label13 = new System.Windows.Forms.Label();
            this.label14 = new System.Windows.Forms.Label();
            this.label15 = new System.Windows.Forms.Label();
            this.tabControl1.SuspendLayout();
            this.tabPage1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridFiltroH)).BeginInit();
            this.tabPage2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridVentas)).BeginInit();
            this.tabPage3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridClientes)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridHistorial)).BeginInit();
            this.SuspendLayout();
            // 
            // tabControl1
            // 
            this.tabControl1.Controls.Add(this.tabPage1);
            this.tabControl1.Controls.Add(this.tabPage2);
            this.tabControl1.Controls.Add(this.tabPage3);
            this.tabControl1.Location = new System.Drawing.Point(28, 27);
            this.tabControl1.Name = "tabControl1";
            this.tabControl1.SelectedIndex = 0;
            this.tabControl1.Size = new System.Drawing.Size(740, 537);
            this.tabControl1.TabIndex = 0;
            // 
            // tabPage1
            // 
            this.tabPage1.BackColor = System.Drawing.Color.Gold;
            this.tabPage1.Controls.Add(this.datetimepicker1);
            this.tabPage1.Controls.Add(this.cbpais);
            this.tabPage1.Controls.Add(this.cbCiudad);
            this.tabPage1.Controls.Add(this.cbhotel);
            this.tabPage1.Controls.Add(this.checkBoxTodos1);
            this.tabPage1.Controls.Add(this.dataGridFiltroH);
            this.tabPage1.Controls.Add(this.btnAplicarFH);
            this.tabPage1.Controls.Add(this.label5);
            this.tabPage1.Controls.Add(this.label4);
            this.tabPage1.Controls.Add(this.label3);
            this.tabPage1.Controls.Add(this.label2);
            this.tabPage1.Controls.Add(this.label1);
            this.tabPage1.Location = new System.Drawing.Point(4, 29);
            this.tabPage1.Name = "tabPage1";
            this.tabPage1.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage1.Size = new System.Drawing.Size(732, 504);
            this.tabPage1.TabIndex = 0;
            this.tabPage1.Text = "Ocupación por hotel";
            this.tabPage1.Click += new System.EventHandler(this.tabPage1_Click);
            // 
            // datetimepicker1
            // 
            this.datetimepicker1.CustomFormat = "yyyy";
            this.datetimepicker1.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.datetimepicker1.Location = new System.Drawing.Point(172, 162);
            this.datetimepicker1.Name = "datetimepicker1";
            this.datetimepicker1.ShowUpDown = true;
            this.datetimepicker1.Size = new System.Drawing.Size(122, 27);
            this.datetimepicker1.TabIndex = 89;
            this.datetimepicker1.ValueChanged += new System.EventHandler(this.datetimepicker1_ValueChanged);
            // 
            // cbpais
            // 
            this.cbpais.FormattingEnabled = true;
            this.cbpais.Location = new System.Drawing.Point(172, 121);
            this.cbpais.Name = "cbpais";
            this.cbpais.Size = new System.Drawing.Size(122, 28);
            this.cbpais.TabIndex = 24;
            // 
            // cbCiudad
            // 
            this.cbCiudad.FormattingEnabled = true;
            this.cbCiudad.Location = new System.Drawing.Point(467, 121);
            this.cbCiudad.Name = "cbCiudad";
            this.cbCiudad.Size = new System.Drawing.Size(114, 28);
            this.cbCiudad.TabIndex = 24;
            // 
            // cbhotel
            // 
            this.cbhotel.FormattingEnabled = true;
            this.cbhotel.Location = new System.Drawing.Point(467, 160);
            this.cbhotel.Name = "cbhotel";
            this.cbhotel.Size = new System.Drawing.Size(114, 28);
            this.cbhotel.TabIndex = 24;
            // 
            // checkBoxTodos1
            // 
            this.checkBoxTodos1.AutoSize = true;
            this.checkBoxTodos1.ForeColor = System.Drawing.Color.Black;
            this.checkBoxTodos1.Location = new System.Drawing.Point(592, 166);
            this.checkBoxTodos1.Name = "checkBoxTodos1";
            this.checkBoxTodos1.Size = new System.Drawing.Size(71, 24);
            this.checkBoxTodos1.TabIndex = 23;
            this.checkBoxTodos1.Text = "Todos";
            this.checkBoxTodos1.UseVisualStyleBackColor = true;
            this.checkBoxTodos1.CheckedChanged += new System.EventHandler(this.checkBoxTodos1_CheckedChanged);
            // 
            // dataGridFiltroH
            // 
            this.dataGridFiltroH.AllowUserToAddRows = false;
            this.dataGridFiltroH.AllowUserToDeleteRows = false;
            this.dataGridFiltroH.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridFiltroH.Location = new System.Drawing.Point(81, 274);
            this.dataGridFiltroH.Name = "dataGridFiltroH";
            this.dataGridFiltroH.ReadOnly = true;
            this.dataGridFiltroH.RowHeadersWidth = 51;
            this.dataGridFiltroH.RowTemplate.Height = 24;
            this.dataGridFiltroH.Size = new System.Drawing.Size(579, 186);
            this.dataGridFiltroH.TabIndex = 10;
            this.dataGridFiltroH.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridFiltroH_CellContentClick);
            // 
            // btnAplicarFH
            // 
            this.btnAplicarFH.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.btnAplicarFH.Location = new System.Drawing.Point(305, 217);
            this.btnAplicarFH.Name = "btnAplicarFH";
            this.btnAplicarFH.Size = new System.Drawing.Size(136, 33);
            this.btnAplicarFH.TabIndex = 9;
            this.btnAplicarFH.Text = "Aplicar";
            this.btnAplicarFH.UseVisualStyleBackColor = false;
            this.btnAplicarFH.Click += new System.EventHandler(this.btnAplicarFH_Click);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.ForeColor = System.Drawing.Color.Black;
            this.label5.Location = new System.Drawing.Point(392, 167);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(49, 20);
            this.label5.TabIndex = 4;
            this.label5.Text = "Hotel:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.ForeColor = System.Drawing.Color.Black;
            this.label4.Location = new System.Drawing.Point(380, 124);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(59, 20);
            this.label4.TabIndex = 3;
            this.label4.Text = "Ciudad:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.ForeColor = System.Drawing.Color.Black;
            this.label3.Location = new System.Drawing.Point(117, 167);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(39, 20);
            this.label3.TabIndex = 2;
            this.label3.Text = "Año:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.ForeColor = System.Drawing.Color.Black;
            this.label2.Location = new System.Drawing.Point(119, 124);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(37, 20);
            this.label2.TabIndex = 1;
            this.label2.Text = "País:";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.ForeColor = System.Drawing.Color.Black;
            this.label1.Location = new System.Drawing.Point(90, 43);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(538, 40);
            this.label1.TabIndex = 0;
            this.label1.Text = "Esta pantalla es para consultar datos de ocupación por hotel. Coloque los filtros" +
    "\r\npara mostrar los datos.\r\n";
            // 
            // tabPage2
            // 
            this.tabPage2.BackColor = System.Drawing.Color.Gold;
            this.tabPage2.Controls.Add(this.cbpais2);
            this.tabPage2.Controls.Add(this.cbciudad2);
            this.tabPage2.Controls.Add(this.cbhotel2);
            this.tabPage2.Controls.Add(this.dateTimePicker2);
            this.tabPage2.Controls.Add(this.checkBoxTodos);
            this.tabPage2.Controls.Add(this.dataGridVentas);
            this.tabPage2.Controls.Add(this.btnVentas);
            this.tabPage2.Controls.Add(this.label6);
            this.tabPage2.Controls.Add(this.label7);
            this.tabPage2.Controls.Add(this.label8);
            this.tabPage2.Controls.Add(this.label9);
            this.tabPage2.Controls.Add(this.label10);
            this.tabPage2.Location = new System.Drawing.Point(4, 29);
            this.tabPage2.Name = "tabPage2";
            this.tabPage2.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage2.Size = new System.Drawing.Size(732, 504);
            this.tabPage2.TabIndex = 1;
            this.tabPage2.Text = "Ventas";
            // 
            // cbpais2
            // 
            this.cbpais2.FormattingEnabled = true;
            this.cbpais2.Location = new System.Drawing.Point(154, 124);
            this.cbpais2.Name = "cbpais2";
            this.cbpais2.Size = new System.Drawing.Size(122, 28);
            this.cbpais2.TabIndex = 91;
            // 
            // cbciudad2
            // 
            this.cbciudad2.FormattingEnabled = true;
            this.cbciudad2.Location = new System.Drawing.Point(448, 124);
            this.cbciudad2.Name = "cbciudad2";
            this.cbciudad2.Size = new System.Drawing.Size(114, 28);
            this.cbciudad2.TabIndex = 92;
            // 
            // cbhotel2
            // 
            this.cbhotel2.FormattingEnabled = true;
            this.cbhotel2.Location = new System.Drawing.Point(448, 163);
            this.cbhotel2.Name = "cbhotel2";
            this.cbhotel2.Size = new System.Drawing.Size(114, 28);
            this.cbhotel2.TabIndex = 93;
            // 
            // dateTimePicker2
            // 
            this.dateTimePicker2.CustomFormat = "yyyy";
            this.dateTimePicker2.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dateTimePicker2.Location = new System.Drawing.Point(154, 165);
            this.dateTimePicker2.Name = "dateTimePicker2";
            this.dateTimePicker2.ShowUpDown = true;
            this.dateTimePicker2.Size = new System.Drawing.Size(122, 27);
            this.dateTimePicker2.TabIndex = 90;
            // 
            // checkBoxTodos
            // 
            this.checkBoxTodos.AutoSize = true;
            this.checkBoxTodos.ForeColor = System.Drawing.Color.Black;
            this.checkBoxTodos.Location = new System.Drawing.Point(588, 170);
            this.checkBoxTodos.Name = "checkBoxTodos";
            this.checkBoxTodos.Size = new System.Drawing.Size(71, 24);
            this.checkBoxTodos.TabIndex = 22;
            this.checkBoxTodos.Text = "Todos";
            this.checkBoxTodos.UseVisualStyleBackColor = true;
            this.checkBoxTodos.CheckedChanged += new System.EventHandler(this.checkBoxTodos_CheckedChanged);
            // 
            // dataGridVentas
            // 
            this.dataGridVentas.AllowUserToAddRows = false;
            this.dataGridVentas.AllowUserToDeleteRows = false;
            this.dataGridVentas.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridVentas.Location = new System.Drawing.Point(77, 276);
            this.dataGridVentas.Name = "dataGridVentas";
            this.dataGridVentas.ReadOnly = true;
            this.dataGridVentas.RowHeadersWidth = 51;
            this.dataGridVentas.RowTemplate.Height = 24;
            this.dataGridVentas.Size = new System.Drawing.Size(579, 186);
            this.dataGridVentas.TabIndex = 21;
            // 
            // btnVentas
            // 
            this.btnVentas.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.btnVentas.Location = new System.Drawing.Point(300, 216);
            this.btnVentas.Name = "btnVentas";
            this.btnVentas.Size = new System.Drawing.Size(139, 33);
            this.btnVentas.TabIndex = 20;
            this.btnVentas.Text = "Aplicar";
            this.btnVentas.UseVisualStyleBackColor = false;
            this.btnVentas.Click += new System.EventHandler(this.btnVentas_Click);
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.ForeColor = System.Drawing.Color.Black;
            this.label6.Location = new System.Drawing.Point(389, 170);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(49, 20);
            this.label6.TabIndex = 15;
            this.label6.Text = "Hotel:";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.ForeColor = System.Drawing.Color.Black;
            this.label7.Location = new System.Drawing.Point(378, 127);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(59, 20);
            this.label7.TabIndex = 14;
            this.label7.Text = "Ciudad:";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.ForeColor = System.Drawing.Color.Black;
            this.label8.Location = new System.Drawing.Point(115, 170);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(39, 20);
            this.label8.TabIndex = 13;
            this.label8.Text = "Año:";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.ForeColor = System.Drawing.Color.Black;
            this.label9.Location = new System.Drawing.Point(116, 127);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(37, 20);
            this.label9.TabIndex = 12;
            this.label9.Text = "País:";
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.ForeColor = System.Drawing.Color.Black;
            this.label10.Location = new System.Drawing.Point(115, 45);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(468, 40);
            this.label10.TabIndex = 11;
            this.label10.Text = "Esta pantalla es para consultar datos de las ventas. Coloque los filtros\r\npara mo" +
    "strar los datos.\r\n";
            // 
            // tabPage3
            // 
            this.tabPage3.BackColor = System.Drawing.Color.Gold;
            this.tabPage3.Controls.Add(this.dateTimePicker3);
            this.tabPage3.Controls.Add(this.dataGridClientes);
            this.tabPage3.Controls.Add(this.checkAños);
            this.tabPage3.Controls.Add(this.dataGridHistorial);
            this.tabPage3.Controls.Add(this.btnAplicarFClientes);
            this.tabPage3.Controls.Add(this.textcliente);
            this.tabPage3.Controls.Add(this.label13);
            this.tabPage3.Controls.Add(this.label14);
            this.tabPage3.Controls.Add(this.label15);
            this.tabPage3.Location = new System.Drawing.Point(4, 29);
            this.tabPage3.Name = "tabPage3";
            this.tabPage3.Size = new System.Drawing.Size(732, 504);
            this.tabPage3.TabIndex = 2;
            this.tabPage3.Text = "Historial del cliente";
            // 
            // dateTimePicker3
            // 
            this.dateTimePicker3.CustomFormat = "yyyy";
            this.dateTimePicker3.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dateTimePicker3.Location = new System.Drawing.Point(528, 228);
            this.dateTimePicker3.Name = "dateTimePicker3";
            this.dateTimePicker3.ShowUpDown = true;
            this.dateTimePicker3.Size = new System.Drawing.Size(122, 27);
            this.dateTimePicker3.TabIndex = 90;
            // 
            // dataGridClientes
            // 
            this.dataGridClientes.AllowUserToAddRows = false;
            this.dataGridClientes.AllowUserToDeleteRows = false;
            this.dataGridClientes.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridClientes.Location = new System.Drawing.Point(80, 73);
            this.dataGridClientes.Name = "dataGridClientes";
            this.dataGridClientes.ReadOnly = true;
            this.dataGridClientes.RowHeadersWidth = 51;
            this.dataGridClientes.RowTemplate.Height = 24;
            this.dataGridClientes.Size = new System.Drawing.Size(570, 123);
            this.dataGridClientes.TabIndex = 35;
            this.dataGridClientes.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridClientes_CellClick);
            // 
            // checkAños
            // 
            this.checkAños.AutoSize = true;
            this.checkAños.ForeColor = System.Drawing.Color.Black;
            this.checkAños.Location = new System.Drawing.Point(545, 203);
            this.checkAños.Name = "checkAños";
            this.checkAños.Size = new System.Drawing.Size(129, 24);
            this.checkAños.TabIndex = 34;
            this.checkAños.Text = "Todos los años";
            this.checkAños.UseVisualStyleBackColor = true;
            this.checkAños.CheckedChanged += new System.EventHandler(this.checkAños_CheckedChanged);
            // 
            // dataGridHistorial
            // 
            this.dataGridHistorial.AllowUserToAddRows = false;
            this.dataGridHistorial.AllowUserToDeleteRows = false;
            this.dataGridHistorial.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridHistorial.Location = new System.Drawing.Point(80, 270);
            this.dataGridHistorial.Name = "dataGridHistorial";
            this.dataGridHistorial.ReadOnly = true;
            this.dataGridHistorial.RowHeadersWidth = 51;
            this.dataGridHistorial.RowTemplate.Height = 24;
            this.dataGridHistorial.Size = new System.Drawing.Size(570, 185);
            this.dataGridHistorial.TabIndex = 33;
            // 
            // btnAplicarFClientes
            // 
            this.btnAplicarFClientes.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.btnAplicarFClientes.Location = new System.Drawing.Point(289, 461);
            this.btnAplicarFClientes.Name = "btnAplicarFClientes";
            this.btnAplicarFClientes.Size = new System.Drawing.Size(146, 33);
            this.btnAplicarFClientes.TabIndex = 32;
            this.btnAplicarFClientes.Text = "Aplicar";
            this.btnAplicarFClientes.UseVisualStyleBackColor = false;
            this.btnAplicarFClientes.Click += new System.EventHandler(this.btnAplicarFClientes_Click);
            // 
            // textcliente
            // 
            this.textcliente.Enabled = false;
            this.textcliente.Location = new System.Drawing.Point(152, 228);
            this.textcliente.Name = "textcliente";
            this.textcliente.Size = new System.Drawing.Size(122, 27);
            this.textcliente.TabIndex = 28;
            // 
            // label13
            // 
            this.label13.AutoSize = true;
            this.label13.ForeColor = System.Drawing.Color.Black;
            this.label13.Location = new System.Drawing.Point(444, 229);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(79, 20);
            this.label13.TabIndex = 25;
            this.label13.Text = "Mes y año:";
            // 
            // label14
            // 
            this.label14.AutoSize = true;
            this.label14.ForeColor = System.Drawing.Color.Black;
            this.label14.Location = new System.Drawing.Point(87, 230);
            this.label14.Name = "label14";
            this.label14.Size = new System.Drawing.Size(58, 20);
            this.label14.TabIndex = 24;
            this.label14.Text = "Cliente:";
            // 
            // label15
            // 
            this.label15.AutoSize = true;
            this.label15.ForeColor = System.Drawing.Color.Black;
            this.label15.Location = new System.Drawing.Point(92, 23);
            this.label15.Name = "label15";
            this.label15.Size = new System.Drawing.Size(522, 40);
            this.label15.TabIndex = 23;
            this.label15.Text = "Esta pantalla es para consultar el historial del cliente. Coloque los filtros\r\npa" +
    "ra mostrar los datos. El cliente lo puede buscar por apellidos, RFC o correo.\r\n";
            // 
            // ADMIN_reportes
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.BackColor = System.Drawing.Color.DimGray;
            this.ClientSize = new System.Drawing.Size(800, 589);
            this.Controls.Add(this.tabControl1);
            this.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.Name = "ADMIN_reportes";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Reportes";
            this.Load += new System.EventHandler(this.ADMIN_reportes_Load);
            this.tabControl1.ResumeLayout(false);
            this.tabPage1.ResumeLayout(false);
            this.tabPage1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridFiltroH)).EndInit();
            this.tabPage2.ResumeLayout(false);
            this.tabPage2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridVentas)).EndInit();
            this.tabPage3.ResumeLayout(false);
            this.tabPage3.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridClientes)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridHistorial)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TabControl tabControl1;
        private System.Windows.Forms.TabPage tabPage1;
        private System.Windows.Forms.DataGridView dataGridFiltroH;
        private System.Windows.Forms.Button btnAplicarFH;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TabPage tabPage2;
        private System.Windows.Forms.TabPage tabPage3;
        private System.Windows.Forms.CheckBox checkBoxTodos1;
        private System.Windows.Forms.CheckBox checkBoxTodos;
        private System.Windows.Forms.DataGridView dataGridVentas;
        private System.Windows.Forms.Button btnVentas;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.DataGridView dataGridClientes;
        private System.Windows.Forms.CheckBox checkAños;
        private System.Windows.Forms.DataGridView dataGridHistorial;
        private System.Windows.Forms.Button btnAplicarFClientes;
        private System.Windows.Forms.TextBox textcliente;
        private System.Windows.Forms.Label label13;
        private System.Windows.Forms.Label label14;
        private System.Windows.Forms.Label label15;
        private System.Windows.Forms.ComboBox cbpais;
        private System.Windows.Forms.ComboBox cbCiudad;
        private System.Windows.Forms.ComboBox cbhotel;
        private System.Windows.Forms.DateTimePicker datetimepicker1;
        private System.Windows.Forms.ComboBox cbpais2;
        private System.Windows.Forms.ComboBox cbciudad2;
        private System.Windows.Forms.ComboBox cbhotel2;
        private System.Windows.Forms.DateTimePicker dateTimePicker2;
        private System.Windows.Forms.DateTimePicker dateTimePicker3;
    }
}