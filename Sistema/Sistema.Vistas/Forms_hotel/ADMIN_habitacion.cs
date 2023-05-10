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
    public partial class ADMIN_habitacion : Form
    {
        private string rfc = "";
        private string nombre = "";

        public bool mostrarHab = false;

        public ADMIN_habitacion(string RFC, string NOMBRE)
        {
            InitializeComponent();
            this.rfc = RFC;
            this.nombre = NOMBRE;
        }

        private void tiempo_Tick(object sender, EventArgs e)
        {
            horas.Text = DateTime.Now.ToShortTimeString();
            fechas.Text = DateTime.Now.ToLongDateString();
        }

        private void label12_Click(object sender, EventArgs e)
        {

        }

        private void btnRegistrarH_Click(object sender, EventArgs e)
        {
            string numCamas = numericPisos.Text;
            string tipoCamas = comboBoxTipos.Text;
            string precioNoche = numericPrecio.Text;
            string numPersonas = numericPersonas.Text;
            string nivelHabitacion = comboBoxNivel.Text;
            string regAdmin = rfc;
            int frente = 0;
            bool fJardin = radioJardin.Checked;
            bool fPlaya = radioPlaya.Checked;
            bool fPiscina = radioPiscina.Checked;

         

            if (numCamas.CompareTo("") == 0 || tipoCamas.CompareTo("") == 0 || precioNoche.CompareTo("") == 0 
                || numPersonas.CompareTo("") == 0 || nivelHabitacion.CompareTo("") == 0)
            {
                MessageBox.Show("Favor de llenar todos los campos.", "Informacion", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else
            {
                if (fJardin == true)
                {
                    frente = 0;

                }
                else if (fPlaya == true)
                {
                    frente = 1;
                }
                else if (fPiscina == true)
                {
                    frente = 2;
                }
                else
                {
                    MessageBox.Show("Favor de llenar el apartado vistas.", "Informacion", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }

                string respuesta = N_Habitacion.sp_Habitacion(double.Parse(numCamas), tipoCamas, double.Parse(precioNoche), double.Parse(numPersonas), nivelHabitacion,
                                                              frente, regAdmin, "I");

                if (respuesta.Equals("OK"))
                {
                    MessageBox.Show("Nueva Habitacion Agregada", "Informacion", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    ADMIN_habitacion_Load(sender, e);
                }
                else
                {
                    MessageBox.Show(respuesta, "Informacion", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    ADMIN_habitacion_Load(sender, e);
                }

            }
        }

        private void ADMIN_habitacion_Load(object sender, EventArgs e)
        {
            label4.Text = nombre;

            comboBoxTipos.Items.Clear();
            comboBoxTipos.Items.Add("Cama individual");
            comboBoxTipos.Items.Add("Cama de matrimonio");
            comboBoxTipos.Items.Add("Queen Size");
            comboBoxTipos.Items.Add("King Size");

            comboBoxNivel.Items.Clear();
            comboBoxNivel.Items.Add("Habitacion chica");
            comboBoxNivel.Items.Add("Habitacion mediana");
            comboBoxNivel.Items.Add("Habitacion grande");

            numericPisos.ResetText();
            numericPrecio.ResetText();
            numericPersonas.ResetText();
            textHabitacionID.Clear();

            radioJardin.Checked = false;
            radioPlaya.Checked = false;
            radioPiscina.Checked = false;

            SetDoubleBuffered(dataGridHabitaciones);

            if (mostrarHab == true)
            {
                try
                {
                    dataGridHabitaciones.DataSource = N_Habitacion.sp_Get_Habitacion();
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message + ex.StackTrace);
                }
            }

        }

        public static void SetDoubleBuffered(Control control)
        {
            typeof(Control).InvokeMember("DoubleBuffered",
                BindingFlags.SetProperty | BindingFlags.Instance | BindingFlags.NonPublic,
                null, control, new object[] { true });
        }

        private void btnEditarHb_Click(object sender, EventArgs e)
        {
            string ID = textHabitacionID.Text;
            string numCamas = numericPisos.Text;
            string tipoCamas = comboBoxTipos.Text;
            string precioNoche = numericPrecio.Text;
            string numPersonas = numericPersonas.Text;
            string nivelHabitacion = comboBoxNivel.Text;
            string regAdmin = rfc;
            int frente = 0;
            bool fJardin = radioJardin.Checked;
            bool fPlaya = radioPlaya.Checked;
            bool fPiscina = radioPiscina.Checked;

            if (fJardin == true)
            {
                frente = 0;

            }
            else if (fPlaya == true)
            {
                frente = 1;
            }
            else if (fPiscina == true)
            {
                frente = 2;
            }
            else
            {
                MessageBox.Show("Favor de llenar el apartado vistas.", "Informacion", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

            if (numCamas.CompareTo("") == 0 || tipoCamas.CompareTo("") == 0 || precioNoche.CompareTo("") == 0
                || numPersonas.CompareTo("") == 0 || nivelHabitacion.CompareTo("") == 0)
            {
                MessageBox.Show("Favor de llenar todos los campos.", "Informacion", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else
            {

                string respuesta = N_Habitacion.sp_Habitacion_UD(int.Parse(ID), double.Parse(numCamas), tipoCamas, double.Parse(precioNoche), double.Parse(numPersonas), nivelHabitacion,
                                                              frente, regAdmin, "U");

                if (respuesta.Equals("OK"))
                {
                    MessageBox.Show("Habitacion Actualizada", "Informacion", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    ADMIN_habitacion_Load(sender, e);
                }
                else
                {
                    MessageBox.Show(respuesta, "Informacion", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    ADMIN_habitacion_Load(sender, e);
                }

            }
        }

        private void btnElimHB_Click(object sender, EventArgs e)
        {
            string ID = textHabitacionID.Text;
            string numCamas = numericPisos.Text;
            string tipoCamas = comboBoxTipos.Text;
            string precioNoche = numericPrecio.Text;
            string numPersonas = numericPersonas.Text;
            string nivelHabitacion = comboBoxNivel.Text;
            string regAdmin = rfc;
            int frente = 0;
            bool fJardin = radioJardin.Checked;
            bool fPlaya = radioPlaya.Checked;
            bool fPiscina = radioPiscina.Checked;


            if (numCamas.CompareTo("") == 0 || tipoCamas.CompareTo("") == 0 || precioNoche.CompareTo("") == 0
                || numPersonas.CompareTo("") == 0 || nivelHabitacion.CompareTo("") == 0)
            {
                MessageBox.Show("Favor de llenar todos los campos.", "Informacion", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else
            {
                DialogResult Opcion;
                Opcion = MessageBox.Show("Deseas eliminar la Habitación con el ID:" + " " + ID.ToString() + "?", "Atencion", MessageBoxButtons.OKCancel, MessageBoxIcon.Question);

                if (Opcion == DialogResult.OK)
                {

                    string respuesta = N_Habitacion.sp_Habitacion_UD(int.Parse(ID), double.Parse(numCamas), tipoCamas, double.Parse(precioNoche), double.Parse(numPersonas), nivelHabitacion,
                                                              frente, regAdmin, "D");

                    if (respuesta.Equals("OK"))
                    {
                        MessageBox.Show("Habitacion Eliminada", "Informacion", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        ADMIN_habitacion_Load(sender, e);
                    }
                    else
                    {
                        MessageBox.Show(respuesta, "Informacion", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        ADMIN_habitacion_Load(sender, e);
                    }
                }

            }
        }

        private void dataGridHabitaciones_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (dataGridHabitaciones.RowCount < 1)
            {
                return;
            }
            else
            {
                textHabitacionID.Text = dataGridHabitaciones.CurrentRow.Cells[1].Value.ToString();
                numericPisos.Text = dataGridHabitaciones.CurrentRow.Cells[2].Value.ToString();
                comboBoxTipos.Text = dataGridHabitaciones.CurrentRow.Cells[3].Value.ToString();
                numericPrecio.Text = dataGridHabitaciones.CurrentRow.Cells[4].Value.ToString();
                numericPersonas.Text = dataGridHabitaciones.CurrentRow.Cells[5].Value.ToString();
                comboBoxNivel.Text = dataGridHabitaciones.CurrentRow.Cells[6].Value.ToString();
            }
        }

     
        private void btnVerHabitaciones_Click(object sender, EventArgs e)
        {
            if (mostrarHab == false)
            {
                mostrarHab = true;

            }
            else
            {
                mostrarHab = false;
                dataGridHabitaciones.DataSource = null;
            }

            ADMIN_habitacion_Load(sender, e);
        }

      
    }
}
