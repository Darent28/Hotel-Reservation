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
    public partial class OPER_principal : Form
    {
        private string rfc = "";
        private string nombre = "";

        public OPER_principal(string RFC, string NOMBRE)
        {
            InitializeComponent();
            this.rfc = RFC;
            this.nombre = NOMBRE;
        }

        private void timerOP_Tick(object sender, EventArgs e)
        {
            hora.Text = DateTime.Now.ToShortTimeString();
            fecha.Text = DateTime.Now.ToLongDateString();
        }

        private void registrarClienteToolStripMenuItem_Click(object sender, EventArgs e)
        {
            OPER_clientes paginaClientes = new OPER_clientes(rfc, nombre);
            paginaClientes.Show();
        }

        private void registrarReservaciónToolStripMenuItem_Click(object sender, EventArgs e)
        {
            OPER_reservacion paginaREsrv = new OPER_reservacion(rfc, nombre);
            paginaREsrv.Show();
        }

        private void OPER_principal_Load(object sender, EventArgs e)
        {
            nombreAd.Text = nombre;
            si.Checked = false;
            no.Checked = false;
            textcheckin.Clear();

            try
            {
                dgvReser.DataSource = N_Reservacion.sp_Get_Reservacion();
                dgvCheckin.DataSource = N_Checkin.sp_Get_Checkin(); 
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message + ex.StackTrace);
            }
        }

        private void cerrarSeciónToolStripMenuItem_Click(object sender, EventArgs e)
        {
            DialogResult Opcion;
            Opcion = MessageBox.Show("Seguro que desea Cerrar Seción", "Atencion", MessageBoxButtons.OKCancel, MessageBoxIcon.Question);

            if (Opcion == DialogResult.OK)
            {
                Forms_hotel.InicioSesion frm = new Forms_hotel.InicioSesion();
                frm.Show();
                this.Hide();
            }
        }

        private void dgvReser_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (dgvReser.RowCount < 1)
            {
                return;
            }
            else
            {
                textcheckin.Text = dgvReser.CurrentRow.Cells[0].Value.ToString();

            }
        }

        private void textcheckin_TextChanged(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            string checkin = textcheckin.Text;
            bool siasis = si.Checked;
            bool noasis = no.Checked;
            int asistio = 0;


            if (checkin.CompareTo("") == 0)
            { 
                MessageBox.Show("Favor de poner el codigo del checkin.", "Informacion", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else
            {

                if (siasis == true)
                {
                    asistio = 0;
                }
                else if (noasis == true)
                {
                    asistio = 1;
                }
                else
                {
                    MessageBox.Show("Favor de llenar el apartado Asistio.", "Informacion", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }

                string respuesta = N_Checkin.sp_Checkin(asistio, checkin);

                    if (respuesta.Equals("OK"))
                    {
                        MessageBox.Show("Reservacion reembolsada", "Informacion", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        OPER_principal_Load(sender, e);
                    }
                    else
                    {
                        MessageBox.Show(respuesta, "Informacion", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        OPER_principal_Load(sender, e);
                    }

            }

        }

        private void dgvCheckin_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (dgvCheckin.RowCount < 1)
            {
                return;
            }
            else
            {
                textcheckin.Text = dgvCheckin.CurrentRow.Cells[2].Value.ToString();

            }
        }
    }
}
