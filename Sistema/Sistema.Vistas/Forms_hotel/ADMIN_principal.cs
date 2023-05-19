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
    public partial class ADMIN_principal : Form
    {

        private string rfc = "";
        private string nombre = "";

        public ADMIN_principal(string RFC, string NOMBRE)
        {
            InitializeComponent();
            this.rfc = RFC;
            this.nombre = NOMBRE;
        }

        private void fechaHora_Tick(object sender, EventArgs e)
        {
            hora.Text = DateTime.Now.ToShortTimeString();
            fecha.Text = DateTime.Now.ToLongDateString();
        }

        private void hotelesToolStripMenuItem_Click(object sender, EventArgs e)
        {
            ADMIN_hoteles paginaRegisHotel = new ADMIN_hoteles(rfc, nombre);
            paginaRegisHotel.Show();
        }

        private void habitacionesToolStripMenuItem_Click(object sender, EventArgs e)
        {
            ADMIN_habitacion paginaRegisHabitacion = new ADMIN_habitacion(rfc, nombre);
            paginaRegisHabitacion.Show();
        }

        private void registroDeUsuariosToolStripMenuItem_Click(object sender, EventArgs e)
        {
            ADMIN_usuarios paginaUsuarios = new ADMIN_usuarios(rfc, nombre);
            paginaUsuarios.Show();          
        }

        private void reportesToolStripMenuItem_Click(object sender, EventArgs e)
        {
            ADMIN_reportes paginaReportes = new ADMIN_reportes(rfc, nombre);
            paginaReportes.Show();
        }

        private void ADMIN_principal_Load(object sender, EventArgs e)
        {
            nombreAd.Text = nombre;

            textReembolso.Clear();

            try
            {
                dgvRegRen.DataSource = N_Reservacion.sp_Get_Reservacion();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message + ex.StackTrace);
            }
        }

        private void cerrarSecionToolStripMenuItem_Click(object sender, EventArgs e)
        {
            DialogResult Opcion;
            Opcion = MessageBox.Show("Seguro que desea Cerrar Sesión", "Atencion", MessageBoxButtons.OKCancel, MessageBoxIcon.Question);

            if (Opcion == DialogResult.OK)
            {
                Forms_hotel.InicioSesion frm = new Forms_hotel.InicioSesion();
                frm.Show();
                this.Hide();
            }
        
        }

        private void conjuntoToolStripMenuItem_Click(object sender, EventArgs e)
        {
            ADMIN_hhConjunto paginaConjunto = new ADMIN_hhConjunto(rfc, nombre);
            paginaConjunto.Show();
        }

        private void dgvRegRen_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (dgvRegRen.RowCount < 1)
            {
                return;
            }
            else
            {
                textReembolso.Text = dgvRegRen.CurrentRow.Cells[0].Value.ToString();

            }
        }

        private void btnReem_Click(object sender, EventArgs e)
        {
            string reembolso = textReembolso.Text;

            if (reembolso.CompareTo("") == 0)
            {
                MessageBox.Show("Favor de poner el codigo que quiere reembolsar.", "Informacion", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else
            {

                DialogResult Opcion;
                Opcion = MessageBox.Show("Deseas Reembolsar la reservacion: " + "[" + reembolso.ToString() + "]" + "?", "Atencion", MessageBoxButtons.OKCancel, MessageBoxIcon.Question);

                if (Opcion == DialogResult.OK)
                {
                    string respuesta = N_Reservacion.sp_Reembolso(reembolso, "U");

                    if (respuesta.Equals("OK"))
                    {
                        MessageBox.Show("Reservacion reembolsada", "Informacion", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        ADMIN_principal_Load(sender, e);
                    }
                    else
                    {
                        MessageBox.Show(respuesta, "Informacion", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        ADMIN_principal_Load(sender, e);
                    }
                }


            }
        }
    }
}
