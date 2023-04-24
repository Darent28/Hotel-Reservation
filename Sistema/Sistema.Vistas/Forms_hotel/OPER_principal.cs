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
            OPER_reservacion paginaREsrv = new OPER_reservacion();
            paginaREsrv.Show();
        }

        private void OPER_principal_Load(object sender, EventArgs e)
        {
            nombreAd.Text = nombre;
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
    }
}
