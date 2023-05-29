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
    public partial class InicioSesion : Form
    {


        public InicioSesion()
        {
            InitializeComponent();
        }

        private void InicioSesion_Load(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
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


                if (table.Rows.Count == 0 || table == null)//usuario no existe
                {
                    MessageBox.Show("Usuario inexistente");
                }
                else
                {
                    string user_contra = Convert.ToString(table.Rows[0][0]);//contraseña
                    string RFC = Convert.ToString(table.Rows[0][1]);
                    string NomCompleto = Convert.ToString(table.Rows[0][2]);
                    string tipoUsu = Convert.ToString(table.Rows[0][3]);

                    if (user_contra.CompareTo(contra) == 0)
                    {
                        if (tipoUsu == "1")
                        {
                            MessageBox.Show("Ingresando sección como: Administrador");
                            Forms_hotel.ADMIN_principal frm = new Forms_hotel.ADMIN_principal(RFC, NomCompleto);
                            frm.Show();
                            this.Hide();

                        }
                        else if (tipoUsu == "0")
                        {
                            MessageBox.Show("Ingresando sección como: Operador");
                            Forms_hotel.OPER_principal frm = new Forms_hotel.OPER_principal(RFC, NomCompleto);
                            frm.Show();
                            this.Hide();
                        }


                    }
                    else
                    {
                        MessageBox.Show("Contraseña incorrecta");
                    }
                }
            }
        }

        private void tb_correoL_TextChanged(object sender, EventArgs e)
        {

        }

        private void tabPage2_Click(object sender, EventArgs e)
        {

        }
        //if (checkBox1.Checked)
        //{
        //    ADMIN_principal paginaAD_P = new ADMIN_principal();
        //    paginaAD_P.Show();
        //}
        //else
        //{
        //    OPER_principal pagina_op = new OPER_principal();
        //    pagina_op.Show();
        //}
    }
    
}
