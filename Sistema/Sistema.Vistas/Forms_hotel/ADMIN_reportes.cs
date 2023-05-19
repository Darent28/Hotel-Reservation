using Sistema.Negocio;
using System;
using System.Reflection;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Sistema.Vistas.Forms_hotel
{
    public partial class ADMIN_reportes : Form
    {

        private string rfc = "";
        private string nombre = "";

        public ADMIN_reportes(string RFC, string NOMBRE)
        {
            InitializeComponent();
            this.rfc = RFC;
            this.nombre = NOMBRE;

        }

        private void dataGridFiltroH_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void btnAplicarFH_Click(object sender, EventArgs e)
        {
    
            string hotel = cbhotel.Text;
            string ciudad = cbCiudad.Text;
            string pais = cbpais.Text;
            string fecha = datetimepicker1.Text;
            bool todos = checkBoxTodos1.Checked;

            if (todos == true)
            {
                dataGridFiltroH.DataSource = N_Reportes.sp_Get_Rhotelall(pais, ciudad, fecha);
         
            }
            else
            {
                dataGridFiltroH.DataSource = N_Reportes.sp_Get_Rhotel(pais, ciudad, hotel, fecha);

            }

        }

        private void tabPage1_Click(object sender, EventArgs e)
        {

        }

        private void ADMIN_reportes_Load(object sender, EventArgs e)
        {
            cbhotel.ResetText();
            cbhotel.DataSource = N_Hotel.sp_Get_Hotel();
            cbhotel.ValueMember = "Nombre del hotel";
            cbhotel.DisplayMember = "Nombre del hotel";

            cbCiudad.ResetText();
            cbCiudad.DataSource = N_Hotel.sp_Get_Hotel();
            cbCiudad.ValueMember = "Domicilio";
            cbCiudad.DisplayMember = "Domicilio";

            cbpais.ResetText();
            cbpais.DataSource = N_Hotel.sp_Get_Hotel();
            cbpais.ValueMember = "Ubicacion";
            cbpais.DisplayMember = "Ubicacion";

            cbhotel2.ResetText();
            cbhotel2.DataSource = N_Hotel.sp_Get_Hotel();
            cbhotel2.ValueMember = "Nombre del hotel";
            cbhotel2.DisplayMember = "Nombre del hotel";

            cbciudad2.ResetText();
            cbciudad2.DataSource = N_Hotel.sp_Get_Hotel();
            cbciudad2.ValueMember = "Domicilio";
            cbciudad2.DisplayMember = "Domicilio";

            cbpais2.ResetText();
            cbpais2.DataSource = N_Hotel.sp_Get_Hotel();
            cbpais2.ValueMember = "Ubicacion";
            cbpais2.DisplayMember = "Ubicacion";

            SetDoubleBuffered(dataGridFiltroH); 
            SetDoubleBuffered(dataGridVentas);
            SetDoubleBuffered(dataGridClientes);
            SetDoubleBuffered(dataGridHistorial); 

            checkBoxTodos.Checked = false;
            checkBoxTodos1.Checked = false;
            checkAños.Checked = false;

            textcliente.Clear();


            try
            {
                dataGridClientes.DataSource = N_Cliente.sp_Get_Cliente();

            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message + ex.StackTrace);
            }
        }

        public static void SetDoubleBuffered(Control control)
        {
            typeof(Control).InvokeMember("DoubleBuffered",
                BindingFlags.SetProperty | BindingFlags.Instance | BindingFlags.NonPublic,
                null, control, new object[] { true });
        }


        private void datetimepicker1_ValueChanged(object sender, EventArgs e)
        {

        }

        private void btnVentas_Click(object sender, EventArgs e)
        {
            string hotel = cbhotel2.Text;
            string ciudad = cbciudad2.Text;
            string pais = cbpais2.Text;
            string fecha = dateTimePicker2.Text;
            bool todos = checkBoxTodos.Checked;

            if (todos == true)
            {
                dataGridVentas.DataSource = N_Reportes.sp_Get_Rventasall(pais, ciudad, fecha);

            }
            else
            {
                dataGridVentas.DataSource = N_Reportes.sp_Get_Rventas(pais, ciudad, hotel, fecha);

            }
        }

        private void checkBoxTodos_CheckedChanged(object sender, EventArgs e)
        {
            if (checkBoxTodos.Checked == true)
            {
                cbhotel2.Enabled = false;
            }
            else
            {
                cbhotel2.Enabled = true;
            }
        }

        private void checkBoxTodos1_CheckedChanged(object sender, EventArgs e)
        {
            if (checkBoxTodos1.Checked == true)
            {
                cbhotel.Enabled = false ;
            }
            else
            {
                cbhotel.Enabled = true;
            }
        }

        private void checkAños_CheckedChanged(object sender, EventArgs e)
        {
            if (checkAños.Checked == true)
            {
                dateTimePicker3.Enabled = false;
            }
            else
            {
                dateTimePicker3.Enabled = true;
            }
        }

        private void dataGridClientes_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (dataGridClientes.RowCount < 1)
            {
                return;
            }
            else
            {
                textcliente.Text = dataGridClientes.CurrentRow.Cells[1].Value.ToString();
            }
        }

        private void btnAplicarFClientes_Click(object sender, EventArgs e)
        { 
            string cliente = textcliente.Text;
            string fecha = dateTimePicker3.Text;
            bool todos = checkAños.Checked;

            if (todos == true)
            {
                dataGridHistorial.DataSource = N_Reportes.sp_Get_Rclienteall(cliente);
           
            }
            else
            {
                dataGridHistorial.DataSource = N_Reportes.sp_Get_Rcliente(cliente, fecha);
          
            }
        }
    }
}
