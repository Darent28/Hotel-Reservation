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
    public partial class ADMIN_hoteles : Form
    {
        private string rfc = "";
        private string nombre = "";

        public bool mostrarHot = false;

        public ADMIN_hoteles(string RFC, string NOMBRE)
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

        private void ADMIN_hoteles_Load(object sender, EventArgs e)
        {
             label4.Text = nombre;
             labelRFC.Text = rfc;

            textHotelID.Clear();
            textNombre_hotel.Clear();
            textUbicacion.Clear();
            textDomicilio.Clear();
            numericPisos.ResetText();
            numericHabitaciones.ResetText();
            dateTimeFechaInicioOp.ResetText();
            checkZonaT.Checked = false;
            checkServicios.Checked = false;
            checkPlaya.Checked = false;
            checkEventos.Checked = false;

            SetDoubleBuffered(dataGridHoteles);

            if (mostrarHot == true)
            {
                try
                {
                    dataGridHoteles.DataSource = N_Hotel.sp_Get_Hotel();
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


        private void label7_Click(object sender, EventArgs e)
        {

        }

        private void label10_Click(object sender, EventArgs e)
        {

        }

        private void btnRegistrarH_Click(object sender, EventArgs e)
        {
            string nombreHotel = textNombre_hotel.Text;
            string ubicacion = textUbicacion.Text;
            string domicilio = textDomicilio.Text;
            string numPiso = numericPisos.Text;
            string canHab = numericHabitaciones.Text;
            string fInicioOp = dateTimeFechaInicioOp.Text;
            string fIngreso = dateTimePickerFechaIngreso.Text;
            bool zonaTuri = checkZonaT.Checked;
            bool servicioAdd = checkServicios.Checked;
            bool frentePlaya = checkPlaya.Checked;
            bool solonEventos = checkEventos.Checked;
            string regAdmin = rfc;

            if (nombreHotel.CompareTo("") == 0 || ubicacion.CompareTo("") == 0 || domicilio.CompareTo("") == 0 || numPiso.CompareTo("") == 0 ||
                canHab.CompareTo("") == 0 || fInicioOp.CompareTo("") == 0 || fIngreso.CompareTo("") == 0)
            {
                MessageBox.Show("Favor de llenar todos los campos.", "Informacion", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else
            {

                string respuesta = N_Hotel.sp_Hotel(nombreHotel, ubicacion, domicilio, double.Parse(numPiso), double.Parse(canHab),
                                                    zonaTuri, servicioAdd, frentePlaya, solonEventos, fInicioOp, fIngreso, regAdmin, "I");

                if (respuesta.Equals("OK"))
                {
                    MessageBox.Show("Nuevo Hotel Agregado", "Informacion", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    ADMIN_hoteles_Load(sender, e);
                }
                else
                {
                    MessageBox.Show(respuesta, "Informacion", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    ADMIN_hoteles_Load(sender, e);
                }

            }

        }

        private void dataGridHoteles_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (dataGridHoteles.RowCount < 1)
            {
                return;
            }
            else
            {
                textHotelID.Text = dataGridHoteles.CurrentRow.Cells[1].Value.ToString();
                textNombre_hotel.Text = dataGridHoteles.CurrentRow.Cells[2].Value.ToString();
                textUbicacion.Text = dataGridHoteles.CurrentRow.Cells[3].Value.ToString();
                textDomicilio.Text = dataGridHoteles.CurrentRow.Cells[4].Value.ToString();
                numericPisos.Text = dataGridHoteles.CurrentRow.Cells[5].Value.ToString();
                numericHabitaciones.Text = dataGridHoteles.CurrentRow.Cells[6].Value.ToString();
                dateTimeFechaInicioOp.Text = dataGridHoteles.CurrentRow.Cells[7].Value.ToString();

            }
        }

        private void btnVerHoteles_Click(object sender, EventArgs e)
        {
            if (mostrarHot == false)
            {
                mostrarHot = true;

            }
            else
            {
                mostrarHot = false;
                dataGridHoteles.DataSource = null;
            }

            ADMIN_hoteles_Load(sender, e);
        }

        private void btnEditar_Click(object sender, EventArgs e)
        {
            string ID = textHotelID.Text;
            string nombreHotel = textNombre_hotel.Text;
            string ubicacion = textUbicacion.Text;
            string domicilio = textDomicilio.Text;
            string numPiso = numericPisos.Text;
            string canHab = numericHabitaciones.Text;
            bool zonaTuri = checkZonaT.Checked;
            bool servicioAdd = checkServicios.Checked;
            bool frentePlaya = checkPlaya.Checked;
            bool solonEventos = checkEventos.Checked;

            if (nombreHotel.CompareTo("") == 0 || ubicacion.CompareTo("") == 0 || domicilio.CompareTo("") == 0 || numPiso.CompareTo("") == 0 ||
                canHab.CompareTo("") == 0)
            {
                MessageBox.Show("Favor de llenar todos los campos.", "Informacion", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else
            {

                string respuesta = N_Hotel.sp_Hotel_UD(int.Parse(ID), nombreHotel, ubicacion, domicilio, double.Parse(numPiso), double.Parse(canHab),
                                                    zonaTuri, servicioAdd, frentePlaya, solonEventos, "U");

                if (respuesta.Equals("OK"))
                {
                    MessageBox.Show("Hotel Editado", "Informacion", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    ADMIN_hoteles_Load(sender, e);
                }
                else
                {
                    MessageBox.Show(respuesta, "Informacion", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    ADMIN_hoteles_Load(sender, e);
                }

            }
        }

        private void btnElim_Click(object sender, EventArgs e)
        {
            string ID = textHotelID.Text;
            string nombreHotel = textNombre_hotel.Text;
            string ubicacion = textUbicacion.Text;
            string domicilio = textDomicilio.Text;
            string numPiso = numericPisos.Text;
            string canHab = numericHabitaciones.Text;
            bool zonaTuri = checkZonaT.Checked;
            bool servicioAdd = checkServicios.Checked;
            bool frentePlaya = checkPlaya.Checked;
            bool solonEventos = checkEventos.Checked;

            if (nombreHotel.CompareTo("") == 0 || ubicacion.CompareTo("") == 0 || domicilio.CompareTo("") == 0 || numPiso.CompareTo("") == 0 ||
                canHab.CompareTo("") == 0)
            {
                MessageBox.Show("Favor de llenar todos los campos.", "Informacion", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else
            {
                DialogResult Opcion;
                Opcion = MessageBox.Show("Deseas eliminar el Hotel:" + " " + nombreHotel.ToString() + "?", "Atencion", MessageBoxButtons.OKCancel, MessageBoxIcon.Question);

                if (Opcion == DialogResult.OK)
                {
                    string respuesta = N_Hotel.sp_Hotel_UD(int.Parse(ID), nombreHotel, ubicacion, domicilio, double.Parse(numPiso), double.Parse(canHab),
                                                    zonaTuri, servicioAdd, frentePlaya, solonEventos, "D");

                    if (respuesta.Equals("OK"))
                    {
                        MessageBox.Show("Hotel Editado", "Informacion", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        ADMIN_hoteles_Load(sender, e);
                    }
                    else
                    {
                        MessageBox.Show(respuesta, "Informacion", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        ADMIN_hoteles_Load(sender, e);
                    }

                }

            }
        }
    }
}
