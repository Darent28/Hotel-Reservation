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
    public partial class ADMIN_usuarios : Form
    {
        private string rfc = "";
        private string nombre = "";

        public bool mostrarUsu = false;

        public ADMIN_usuarios(string RFC, string NOMBRE)
        {
            InitializeComponent();
            this.rfc = RFC;
            this.nombre = NOMBRE;
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            horas.Text = DateTime.Now.ToShortTimeString();
            fechas.Text = DateTime.Now.ToLongDateString();
        }

        private void label8_Click(object sender, EventArgs e)
        {

        }

        public static void SetDoubleBuffered(Control control)
        {
            typeof(Control).InvokeMember("DoubleBuffered",
                BindingFlags.SetProperty | BindingFlags.Instance | BindingFlags.NonPublic,
                null, control, new object[] { true });
        }


        private void ADMIN_usuarios_Load(object sender, EventArgs e)
        {
            label4.Text = nombre;

            textIRFC.Clear();
            textNombres.Clear();
            textApeP.Clear();
            textApeM.Clear();
            textNumNomina.Clear();
            dateTimeFechaNaci.ResetText();
            textDomicilio.Clear();
            textCelular.Clear();
            textCorreo.Clear();
            textContra.Clear();

            // Llamar a esta función en el evento Load del formulario que contiene el DataGridView
            SetDoubleBuffered(dataGridUsers);

            if (mostrarUsu == true)
            {
                try
                {
                    dataGridUsers.DataSource = N_Usuario.sp_Get_Usuario();
                    dataGridUsers.Columns[6].Visible = false;
                    dataGridUsers.Columns[10].Visible = false;
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message + ex.StackTrace);
                }
            }

        }

        private void btnRegistrarUser_Click(object sender, EventArgs e)
        {
            string RFC = textIRFC.Text;
            string nombre = textNombres.Text;
            string apellidoP = textApeP.Text;
            string apellidoM = textApeM.Text;
            string nomina = textNumNomina.Text;
            string fnacimiento = dateTimeFechaNaci.Text;
            string domicilio = textDomicilio.Text;
            string telefono = textCelular.Text;
            bool admin = radioAdmin.Checked;
            bool operador = radioOperario.Checked;
            string correo = textCorreo.Text;
            string contrasena = textContra.Text;
            int tipo = 0;


            if (RFC.CompareTo("") == 0 || nombre.CompareTo("") == 0 || apellidoP.CompareTo("") == 0 || apellidoM.CompareTo("") == 0 ||
                nomina.CompareTo("") == 0 || fnacimiento.CompareTo("") == 0 || domicilio.CompareTo("") == 0 || telefono.CompareTo("") == 0 || 
                correo.CompareTo("") == 0 || contrasena.CompareTo("") == 0)
            {
                MessageBox.Show("Favor de llenar todos los campos.", "Informacion", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else
            {
                if (admin)
                {
                    tipo = 1;
                }
                else if (operador)
                {
                    tipo = 0;
                }
                else
                {
                    MessageBox.Show("Seleccione un tipo de usuario.", "Informacion", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }

                string respuesta = N_Usuario.sp_Usuario(RFC, nombre, apellidoP, apellidoM, double.Parse(nomina),
                                                       fnacimiento, domicilio, double.Parse(telefono), 
                                                       tipo, correo, contrasena, "I");

                if (respuesta.Equals("OK"))
                {
                    MessageBox.Show("Nuevo Usuario Agregado", "Informacion", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    ADMIN_usuarios_Load(sender, e);
                }
                else
                {
                    MessageBox.Show(respuesta, "Informacion", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    ADMIN_usuarios_Load(sender, e);
                }

            }
        }

        private void btnVerUsers_Click(object sender, EventArgs e)
        {
            if(mostrarUsu == false)
            {
                mostrarUsu = true;

            } else
            {
                mostrarUsu = false;
                dataGridUsers.DataSource = null;
            }

            ADMIN_usuarios_Load(sender, e);

        }

      
      

        private void btnEditarUsers_Click(object sender, EventArgs e)
        {
            string RFC = textIRFC.Text;
            string nombre = textNombres.Text;
            string apellidoP = textApeP.Text;
            string apellidoM = textApeM.Text;
            string nomina = textNumNomina.Text;
            string fnacimiento = dateTimeFechaNaci.Text;
            string domicilio = textDomicilio.Text;
            string telefono = textCelular.Text;
            bool admin = radioAdmin.Checked;
            bool operador = radioOperario.Checked;
            string correo = textCorreo.Text;
            string contrasena = textContra.Text;
            int tipo = 0;


            if (RFC.CompareTo("") == 0 || nombre.CompareTo("") == 0 || apellidoP.CompareTo("") == 0 || apellidoM.CompareTo("") == 0 ||
                nomina.CompareTo("") == 0 || fnacimiento.CompareTo("") == 0 || domicilio.CompareTo("") == 0 || telefono.CompareTo("") == 0 ||
                correo.CompareTo("") == 0 || contrasena.CompareTo("") == 0)
            {
                MessageBox.Show("Favor de llenar todos los campos.", "Informacion", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else
            {
                if (admin)
                {
                    tipo = 1;
                }
                else if (operador)
                {
                    tipo = 0;
                }
                else
                {
                    MessageBox.Show("Seleccione un tipo de usuario.", "Informacion", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }

                string respuesta = N_Usuario.sp_Usuario(RFC, nombre, apellidoP, apellidoM, double.Parse(nomina),
                                                       fnacimiento, domicilio, double.Parse(telefono),
                                                       tipo, correo, contrasena, "U");

                if (respuesta.Equals("OK"))
                {
                    MessageBox.Show("Usuario Acutualizado", "Informacion", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    ADMIN_usuarios_Load(sender, e);
                }
                else
                {
                    MessageBox.Show(respuesta, "Informacion", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    ADMIN_usuarios_Load(sender, e);
                }
            }
        }

        private void dataGridUsers_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (dataGridUsers.RowCount < 1)
            {
                return;
            }
            else
            {
                textIRFC.Text = dataGridUsers.CurrentRow.Cells[1].Value.ToString();
                textNombres.Text = dataGridUsers.CurrentRow.Cells[2].Value.ToString();
                textApeP.Text = dataGridUsers.CurrentRow.Cells[3].Value.ToString(); 
                textApeM.Text = dataGridUsers.CurrentRow.Cells[4].Value.ToString();
                textNumNomina.Text = dataGridUsers.CurrentRow.Cells[5].Value.ToString();
                dateTimeFechaNaci.Text = dataGridUsers.CurrentRow.Cells[6].Value.ToString();
                textDomicilio.Text = dataGridUsers.CurrentRow.Cells[7].Value.ToString();
                textCelular.Text = dataGridUsers.CurrentRow.Cells[8].Value.ToString();
                textCorreo.Text = dataGridUsers.CurrentRow.Cells[9].Value.ToString();
                textContra.Text = dataGridUsers.CurrentRow.Cells[10].Value.ToString();

            }
        }

        private void btnElimUsers_Click(object sender, EventArgs e)
        {
            string RFC = textIRFC.Text;
            string nombre = textNombres.Text;
            string apellidoP = textApeP.Text;
            string apellidoM = textApeM.Text;
            string nomina = textNumNomina.Text;
            string fnacimiento = dateTimeFechaNaci.Text;
            string domicilio = textDomicilio.Text;
            string telefono = textCelular.Text;
            bool admin = radioAdmin.Checked;
            bool operador = radioOperario.Checked;
            string correo = textCorreo.Text;
            string contrasena = textContra.Text;
            int tipo = 0;


            if (RFC.CompareTo("") == 0 || nombre.CompareTo("") == 0 || apellidoP.CompareTo("") == 0 || apellidoM.CompareTo("") == 0 ||
                nomina.CompareTo("") == 0 || fnacimiento.CompareTo("") == 0 || domicilio.CompareTo("") == 0 || telefono.CompareTo("") == 0 ||
                correo.CompareTo("") == 0 || contrasena.CompareTo("") == 0)
            {
                MessageBox.Show("Favor de llenar todos los campos.", "Informacion", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else
            {
                DialogResult Opcion;
                Opcion = MessageBox.Show("Deseas eliminar al Usuario con el RFC:" + "[" + RFC.ToString() + "]" + "?", "Atencion", MessageBoxButtons.OKCancel, MessageBoxIcon.Question);

                if (Opcion == DialogResult.OK)
                {
                    string respuesta = N_Usuario.sp_Usuario(RFC, nombre, apellidoP, apellidoM, double.Parse(nomina),
                                                       fnacimiento, domicilio, double.Parse(telefono),
                                                       tipo, correo, contrasena, "D");

                    if (respuesta.Equals("OK"))
                    {
                        MessageBox.Show("Usuario Eliminado", "Informacion", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        ADMIN_usuarios_Load(sender, e);
                    }
                    else
                    {
                        MessageBox.Show(respuesta, "Informacion", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        ADMIN_usuarios_Load(sender, e);
                    }
                }

            }
        }
    }
}
