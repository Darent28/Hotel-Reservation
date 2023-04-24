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
    public partial class OPER_clientes : Form
    {
        private string rfc = "";
        private string nombre = "";

        bool mostrarCli = false;

        public OPER_clientes(string RFC, string NOMBRE)
        {
            InitializeComponent();
            this.rfc = RFC;
            this.nombre = NOMBRE;
        }

        private void timerClientes_Tick(object sender, EventArgs e)
        {
            horas.Text = DateTime.Now.ToShortTimeString();
            fechas.Text = DateTime.Now.ToLongDateString();
        }

        private void btnRegistrarClientes_Click(object sender, EventArgs e)
        {
            string rfc = textID_user.Text;
            string nombre = textNombres.Text;
            string apellidop = textApeP.Text;
            string apellidom = textApeM.Text;
            string domicilio = textDomicilio.Text;
            string correo = textCorreo.Text;
            string telefono = textCelular.Text;
            string referencia = textReferencia.Text;
            string fnacimiento = dateTimeFechaNaci.Text;
            string eCivil = comboBoxCivil.Text;
            string fRegistro = dateTimeFechaReg.Text;
            string regAdim = label16.Text;

            if (rfc.CompareTo("") == 0 || nombre.CompareTo("") == 0 || apellidop.CompareTo("") == 0 || apellidom.CompareTo("") == 0 ||
               domicilio.CompareTo("") == 0 || correo.CompareTo("") == 0 || telefono.CompareTo("") == 0 || referencia.CompareTo("") == 0 ||
               fnacimiento.CompareTo("") == 0 || eCivil.CompareTo("") == 0 || fRegistro.CompareTo("") == 0)
            {
                MessageBox.Show("Favor de llenar todos los campos.", "Informacion", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else
            {


                string respuesta = N_Cliente.sp_Cliente(rfc, nombre, apellidop, apellidom, domicilio, correo,
                                                       double.Parse(telefono), referencia, fnacimiento, eCivil, fRegistro, 
                                                       regAdim, "I");

                if (respuesta.Equals("OK"))
                {
                    MessageBox.Show("Nuevo Cliente Agregado", "Informacion", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    OPER_clientes_Load(sender, e);
                }
                else
                {
                    MessageBox.Show(respuesta, "Informacion", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    OPER_clientes_Load(sender, e);
                }

            }

        }

        private void OPER_clientes_Load(object sender, EventArgs e)
        {
            label16.Text = rfc;
            label4.Text = nombre;

            textID_user.Clear();
            textNombres.Clear();
            textApeP.Clear();
            textApeM.Clear();
            textDomicilio.Clear();
            textCorreo.Clear();
            textCelular.Clear();
            textReferencia.Clear();
            dateTimeFechaNaci.ResetText();

            comboBoxCivil.Items.Clear();
            comboBoxCivil.Items.Add("Soltero/a");
            comboBoxCivil.Items.Add("Casado/a");
            comboBoxCivil.Items.Add("Unión libre");

            SetDoubleBuffered(dataGridClientes);

            if (mostrarCli == true)
            {
                try
                {
                    dataGridClientes.DataSource = N_Cliente.sp_Get_Cliente();
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

        private void dataGridClientes_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (dataGridClientes.RowCount < 1)
            {
                return;
            }
            else
            {

                textID_user.Text = dataGridClientes.CurrentRow.Cells[0].Value.ToString();
                textNombres.Text = dataGridClientes.CurrentRow.Cells[1].Value.ToString();
                textApeP.Text = dataGridClientes.CurrentRow.Cells[2].Value.ToString();
                textApeM.Text = dataGridClientes.CurrentRow.Cells[3].Value.ToString();
                textDomicilio.Text = dataGridClientes.CurrentRow.Cells[4].Value.ToString();
                textCorreo.Text = dataGridClientes.CurrentRow.Cells[5].Value.ToString();
                textCelular.Text = dataGridClientes.CurrentRow.Cells[6].Value.ToString();
                textReferencia.Text = dataGridClientes.CurrentRow.Cells[7].Value.ToString();
                dateTimeFechaNaci.Text = dataGridClientes.CurrentRow.Cells[8].Value.ToString();
                comboBoxCivil.Text = dataGridClientes.CurrentRow.Cells[9].Value.ToString();

            }
        }

        private void btnVerClientes_Click(object sender, EventArgs e)
        {
            if (mostrarCli == false)
            {
                mostrarCli = true;

            }
            else
            {
                mostrarCli = false;
                dataGridClientes.DataSource = null;
            }

            OPER_clientes_Load(sender, e);
        }

        private void btnEditarClientes_Click(object sender, EventArgs e)
        {
            string rfc = textID_user.Text;
            string nombre = textNombres.Text;
            string apellidop = textApeP.Text;
            string apellidom = textApeM.Text;
            string domicilio = textDomicilio.Text;
            string correo = textCorreo.Text;
            string telefono = textCelular.Text;
            string referencia = textReferencia.Text;
            string fnacimiento = dateTimeFechaNaci.Text;
            string eCivil = comboBoxCivil.Text;
            string fRegistro = dateTimeFechaReg.Text;
            string regAdim = label16.Text;

            if (rfc.CompareTo("") == 0 || nombre.CompareTo("") == 0 || apellidop.CompareTo("") == 0 || apellidom.CompareTo("") == 0 ||
               domicilio.CompareTo("") == 0 || correo.CompareTo("") == 0 || telefono.CompareTo("") == 0 || referencia.CompareTo("") == 0 ||
               fnacimiento.CompareTo("") == 0 || eCivil.CompareTo("") == 0 || fRegistro.CompareTo("") == 0)
            {
                MessageBox.Show("Favor de llenar todos los campos.", "Informacion", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else
            {


                string respuesta = N_Cliente.sp_Cliente(rfc, nombre, apellidop, apellidom, domicilio, correo,
                                                       double.Parse(telefono), referencia, fnacimiento, eCivil, fRegistro, regAdim, "U");

                if (respuesta.Equals("OK"))
                {
                    MessageBox.Show("Cliente Editado", "Informacion", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    OPER_clientes_Load(sender, e);
                }
                else
                {
                    MessageBox.Show(respuesta, "Informacion", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    OPER_clientes_Load(sender, e);
                }

            }
        }

        private void btnElimClientes_Click(object sender, EventArgs e)
        {
            string rfc = textID_user.Text;
            string nombre = textNombres.Text;
            string apellidop = textApeP.Text;
            string apellidom = textApeM.Text;
            string domicilio = textDomicilio.Text;
            string correo = textCorreo.Text;
            string telefono = textCelular.Text;
            string referencia = textReferencia.Text;
            string fnacimiento = dateTimeFechaNaci.Text;
            string eCivil = comboBoxCivil.Text;
            string fRegistro = dateTimeFechaReg.Text;
            string regAdim = label16.Text;

            if (rfc.CompareTo("") == 0 || nombre.CompareTo("") == 0 || apellidop.CompareTo("") == 0 || apellidom.CompareTo("") == 0 ||
               domicilio.CompareTo("") == 0 || correo.CompareTo("") == 0 || telefono.CompareTo("") == 0 || referencia.CompareTo("") == 0 ||
               fnacimiento.CompareTo("") == 0 || eCivil.CompareTo("") == 0 || fRegistro.CompareTo("") == 0)
            {
                MessageBox.Show("Favor de llenar todos los campos.", "Informacion", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else
            {

                DialogResult Opcion;
                Opcion = MessageBox.Show("Deseas eliminar al cliente con el RFC: " + "[" + rfc.ToString() + "]" + "?", "Atencion", MessageBoxButtons.OKCancel, MessageBoxIcon.Question);

                if (Opcion == DialogResult.OK)
                {
                    string respuesta = N_Cliente.sp_Cliente(rfc, nombre, apellidop, apellidom, domicilio, correo,
                                                       double.Parse(telefono), referencia, fnacimiento, eCivil, fRegistro, regAdim, "U");

                    if (respuesta.Equals("OK"))
                    {
                        MessageBox.Show("Cliente Eliminado", "Informacion", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        OPER_clientes_Load(sender, e);
                    }
                    else
                    {
                        MessageBox.Show(respuesta, "Informacion", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        OPER_clientes_Load(sender, e);
                    }
                }
                 

            }
        }
    }
}
