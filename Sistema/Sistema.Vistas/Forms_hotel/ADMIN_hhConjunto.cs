using Sistema.Negocio;
using System;
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
    public partial class ADMIN_hhConjunto : Form
    {
        private string rfc = "";
        private string nombre = "";

        public bool mostrarHab = false;

        public ADMIN_hhConjunto(string RFC, string NOMBRE)
        {
            InitializeComponent();
            this.rfc = RFC;
            this.nombre = NOMBRE;
        }

        private void timer1_Tick_1(object sender, EventArgs e)
        {
            horas.Text = DateTime.Now.ToShortTimeString();
            fechas.Text = DateTime.Now.ToLongDateString();
        }

        private void label12_Click(object sender, EventArgs e)
        {

        }

        private void dataGridUsers_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void btnVerUsers_Click(object sender, EventArgs e)
        {
            if (mostrarHab == false)
            {
                mostrarHab = true;

            }
            else
            {
                mostrarHab = false;
                dataGridUsers.DataSource = null;
            }

            ADMIN_hhConjunto_Load(sender, e);
        }

        private void btnEditarUsers_Click(object sender, EventArgs e)
        {
            string ID = textHHID.Text;
            string habitacion = comboBoxHabitacion.Text;
            string hotel = comboBoxHotel.Text;
            string tipohab = textTipoHab.Text;
            string caract = textcaracteristicas.Text;
            string amenidades = textAmenidades.Text;

            if (ID.CompareTo("") == 0 || habitacion.CompareTo("") == 0 || hotel.CompareTo("") == 0 || tipohab.CompareTo("") == 0
               || caract.CompareTo("") == 0 || amenidades.CompareTo("") == 0)
            {
                MessageBox.Show("Favor de llenar todos los campos.", "Informacion", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else
            {
                string respuesta = N_HabitacionHotel.sp_HabitacionHotel_CRUD(int.Parse(ID), int.Parse(habitacion), int.Parse(hotel), tipohab, caract, amenidades, "U");

                if (respuesta.Equals("OK"))
                {
                    MessageBox.Show("Conjunto Actualizado", "Informacion", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    ADMIN_hhConjunto_Load(sender, e);
                }
                else
                {
                    MessageBox.Show(respuesta, "Informacion", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    ADMIN_hhConjunto_Load(sender, e);
                }
            }

        }

        private void btnElimUsers_Click(object sender, EventArgs e)
        {
            string ID = textHHID.Text;
            string habitacion = comboBoxHabitacion.Text;
            string hotel = comboBoxHotel.Text;
            string tipohab = textTipoHab.Text;
            string caract = textcaracteristicas.Text;
            string amenidades = textAmenidades.Text;

            if (ID.CompareTo("") == 0 || habitacion.CompareTo("") == 0 || hotel.CompareTo("") == 0 || tipohab.CompareTo("") == 0
               || caract.CompareTo("") == 0 || amenidades.CompareTo("") == 0)
            {
                MessageBox.Show("Favor de llenar todos los campos.", "Informacion", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else
            {
                DialogResult Opcion;
                Opcion = MessageBox.Show("Deseas eliminar el conjunto con el ID:" + " " + ID.ToString() + "?", "Atencion", MessageBoxButtons.OKCancel, MessageBoxIcon.Question);

                if (Opcion == DialogResult.OK)
                {
                    string respuesta = N_HabitacionHotel.sp_HabitacionHotel_CRUD(int.Parse(ID), int.Parse(habitacion), int.Parse(hotel), tipohab, caract, amenidades, "D");

                    if (respuesta.Equals("OK"))
                    {
                        MessageBox.Show("Conjunto Eliminado", "Informacion", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        ADMIN_hhConjunto_Load(sender, e);
                    }
                    else
                    {
                        MessageBox.Show(respuesta, "Informacion", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        ADMIN_hhConjunto_Load(sender, e);
                    }
                }
                
            }
        }

        private void ADMIN_hhConjunto_Load(object sender, EventArgs e)
        {
            label4.Text = nombre;

            comboBoxHabitacion.ResetText();
            comboBoxHabitacion.DataSource = N_Habitacion.sp_Get_Habitacion();
            comboBoxHabitacion.ValueMember = "ID";
            comboBoxHabitacion.DisplayMember = "ID";
            comboBoxHabitacion.SelectedIndexChanged += comboBoxHabitacion_SelectedIndexChanged_1;

            comboBoxHotel.ResetText();
            comboBoxHotel.DataSource = N_Hotel.sp_Get_Hotel();
            comboBoxHotel.ValueMember = "ID";
            comboBoxHotel.DisplayMember = "ID";
            comboBoxHotel.SelectedIndexChanged += comboBoxHotel_SelectedIndexChanged;

            textTipoHab.Clear();
            textcaracteristicas.Clear();
            textAmenidades.Clear();
            textHHID.Clear();

            if (mostrarHab == true)
            {
                try
                {
                    dataGridUsers.DataSource = N_HabitacionHotel.sp_Get_HabitacionHotel();
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message + ex.StackTrace);
                }
            }
        }

        private void comboBoxHabitacion_SelectedIndexChanged_1(object sender, EventArgs e)
        {

            DataRowView filaSeleccionada = (DataRowView)comboBoxHabitacion.SelectedItem;
            textNivelHab.Text = filaSeleccionada["Nivel de Habitacion"].ToString();
        }

        private void comboBoxHotel_SelectedIndexChanged(object sender, EventArgs e)
        {
            DataRowView filaSeleccionada = (DataRowView)comboBoxHotel.SelectedItem;
            textNomHotel.Text = filaSeleccionada["Nombre del hotel"].ToString();
        }

        private void btnRegistrarH_Click(object sender, EventArgs e)
        {
            string ID = textHHID.Text;
            string habitacion = comboBoxHabitacion.Text;
            string hotel = comboBoxHotel.Text;
            string tipohab = textTipoHab.Text;
            string caract = textcaracteristicas.Text;
            string amenidades = textAmenidades.Text;

            if (habitacion.CompareTo("") == 0 || hotel.CompareTo("") == 0 || tipohab.CompareTo("") == 0
               || caract.CompareTo("") == 0 || amenidades.CompareTo("") == 0)
            {
                MessageBox.Show("Favor de llenar todos los campos.", "Informacion", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else
            {
                string respuesta = N_HabitacionHotel.sp_HabitacionHotel(int.Parse(habitacion), int.Parse(hotel), tipohab, caract, amenidades, "I");

                if (respuesta.Equals("OK"))
                {
                    MessageBox.Show("Nuevo Conjunto Agregada", "Informacion", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    ADMIN_hhConjunto_Load(sender, e);
                }
                else
                {
                    MessageBox.Show(respuesta, "Informacion", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    ADMIN_hhConjunto_Load(sender, e);
                }
            }
        }

    
    }
}
