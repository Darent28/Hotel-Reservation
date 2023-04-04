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

namespace Sistema.Vistas
{
    public partial class Login : Form
    {
        public Login()
        {
            InitializeComponent();
        }

        private void Login_Load(object sender, EventArgs e)
        {
            tb_rfc.Clear();
            tb_nombre.Clear();
            tb_apellidop.Clear();
            tb_apellidom.Clear();
            tb_nomina.Clear();
            tb_domicilio.Clear();
            tb_domicilio.Clear();
            tb_domicilio.Clear();
            tb_domicilio.Clear();
            tb_ciudad.Clear();
            tb_estado.Clear();
            tb_pais.Clear();
            tb_telefono.Clear();
            tb_correo.Clear();
            tb_contrasena.Clear();
        }

        private void btn_crear_Click(object sender, EventArgs e)
        {
            string RFC = tb_rfc.Text;
            string nombre = tb_nombre.Text;
            string apellidoP = tb_apellidop.Text;
            string apellidoM = tb_apellidom.Text;
            string nomina = tb_nomina.Text;
            string fnacimiento = dateTimePicker1.Text;
            string domicilio = tb_domicilio.Text;
            string ciudad = tb_ciudad.Text;
            string estado = tb_estado.Text;
            string pais = tb_pais.Text;
            string telefono = tb_telefono.Text;
            bool admin = rb_admin.Checked;
            bool operador = rb_operador.Checked;
            string correo = tb_correo.Text;
            string contrasena = tb_contrasena.Text;
            int tipo = 0;


            if (RFC.CompareTo("") == 0 || nombre.CompareTo("") == 0 || apellidoP.CompareTo("") == 0 || apellidoM.CompareTo("") == 0 ||
                nomina.CompareTo("") == 0 || fnacimiento.CompareTo("") == 0 || domicilio.CompareTo("") == 0 || ciudad.CompareTo("") == 0 ||
                estado.CompareTo("") == 0 || pais.CompareTo("") == 0 || telefono.CompareTo("") == 0 || correo.CompareTo("") == 0 ||
                contrasena.CompareTo("") == 0)
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
                                                       fnacimiento, domicilio, ciudad, estado, pais,
                                                       double.Parse(telefono), tipo, correo, contrasena, "I");

                if (respuesta.Equals("OK"))
                {
                    MessageBox.Show("Nuevo Usuario Agregado", "Informacion", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    Login frm = new Login();
                    frm.Show();
                    this.Hide();
                }
                else
                {
                    MessageBox.Show(respuesta, "Informacion", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }

            }
           

           

        }

        private void btn_aceptar_Click(object sender, EventArgs e)
        {

            string correo = tb_correoL.Text;
            string contra = tb_contrasenaL.Text;
            //string clave = .DataSource;



            if (correo.CompareTo("") == 0 || contra.CompareTo("") == 0)
            {
                MessageBox.Show("faltan llenar campos");
            }

            else
            {
                DataTable table = new DataTable();
                table = N_Usuario.sp_Login_Usuario(correo);

                //RegistroEmpleado who = new RegistroEmpleado();
                //who.registeredBy.Text = correo;


                if (table.Rows.Count == 0)//usuario no existe
                {
                    MessageBox.Show("Usuario inexistente");
                }
                else
                {
                    string user_contra = Convert.ToString(table.Rows[0][0]);//contraseña
                    string RFC = Convert.ToString(table.Rows[0][1]);

                    if (user_contra.CompareTo(contra) == 0)
                    {
                        MessageBox.Show("Todo esta bien y ingresar seccion");
                        Inicio frm = new Inicio(RFC);
                        frm.Show();
                        this.Hide();
                    }
                    else
                    {
                        MessageBox.Show("Contraseña incorrecta xd");
                    }
                }
            }
        }

        private void tb_correoL_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
