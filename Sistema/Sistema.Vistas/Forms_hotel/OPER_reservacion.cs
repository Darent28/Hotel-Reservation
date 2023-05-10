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
    public partial class OPER_reservacion : Form
    {

        private string rfc = "";
        private string nombre = "";

        string Codigo = "";

        public OPER_reservacion(string RFC, string NOMBRE)
        {
            InitializeComponent();
            this.rfc = RFC;
            this.nombre = NOMBRE;
        }

        private void timerReser_Tick(object sender, EventArgs e)
        {
            hora.Text = DateTime.Now.ToShortTimeString();
            fecha.Text = DateTime.Now.ToLongDateString();
        }

        private void OPER_reservacion_Load(object sender, EventArgs e)
        {
            textcodigo.Clear();
            Codigo = Guid.NewGuid().ToString("n").Substring(0, 9);
            textcodigo.AppendText(Codigo);

            cbMpago.Items.Clear();
            cbMpago.Items.Add("Tarjeta de credito");
            cbMpago.Items.Add("Tarjeta de debito");
            cbMpago.Items.Add("Deposito");
            cbMpago.Items.Add("Transferencia");

            labelrfc.Text = rfc;


            numericCanHab.ResetText();
            numericPrecio.ResetText();
            textAnticipo.Clear();

            SetDoubleBuffered(dgvCiudad);

            try
            {
                dgvCliente.DataSource = N_Reservacion.sp_Get_ClienteR(textCliente.Text);
                dgvCiudad.DataSource = N_Reservacion.sp_Get_CiudadR(textCiudad.Text);

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

        private void pictureBox2_Click(object sender, EventArgs e)
        {

        }

        private void textCliente_TextChanged(object sender, EventArgs e)
        {
            dgvCliente.DataSource = N_Reservacion.sp_Get_ClienteR(textCliente.Text);

            string dato = textCliente.Text;

            if (dato.CompareTo("") == 0)
            {
                OPER_reservacion_Load(sender, e);
            }
        }

        private void textCiudad_TextChanged(object sender, EventArgs e)
        {
            dgvCiudad.DataSource = N_Reservacion.sp_Get_CiudadR(textCiudad.Text);

            string dato = textCiudad.Text;

            if (dato.CompareTo("") == 0)
            {
                OPER_reservacion_Load(sender, e);
            }
        }

        private void dgvCliente_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (dgvCliente.RowCount < 1)
            {
                return;
            }
            else
            {
                textClienteRFC.Text = dgvCliente.CurrentRow.Cells[0].Value.ToString();

            }
        }

        private void dgvCiudad_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (dgvCiudad.RowCount < 1)
            {
                return;
            }
            else
            {
                textIDCiudad.Text = dgvCiudad.CurrentRow.Cells[0].Value.ToString();

            }
        }

        private void btnReservar_Click(object sender, EventArgs e)
        {
            string codigo = textcodigo.Text;
            string RFC = textClienteRFC.Text;
            string IDCiudad = textIDCiudad.Text;
            string canhab = numericCanHab.Text;
            string canper = numericPrecio.Text;
            string finicio = dtpInicio.Text;
            string ffinal = dtpFinal.Text;
            string freg = dtpRegistro.Text;
            string anticipo = textAnticipo.Text;
            string metodopago = cbMpago.Text;
            string esadmin = labelrfc.Text;


            if (codigo.CompareTo("") == 0 || RFC.CompareTo("") == 0 || IDCiudad.CompareTo("") == 0 || canhab.CompareTo("") == 0 ||
                canper.CompareTo("") == 0 || anticipo.CompareTo("") == 0)
            {
                MessageBox.Show("Favor de llenar todos los campos.", "Informacion", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else
            {

                string respuesta = N_Reservacion.sp_Reservacion(codigo, freg, finicio, ffinal, double.Parse(canper),
                                                       float.Parse(anticipo), metodopago, esadmin,
                                                       RFC, int.Parse(IDCiudad), "I");

                if (respuesta.Equals("OK"))
                {
                    MessageBox.Show("Reservación creada", "Informacion", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    OPER_reservacion_Load(sender, e);
                }
                else
                {
                    MessageBox.Show(respuesta, "Informacion", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    OPER_reservacion_Load(sender, e);
                }
            }
        }
    }
}
