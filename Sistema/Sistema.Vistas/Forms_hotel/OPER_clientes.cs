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
    public partial class OPER_clientes : Form
    {
        public OPER_clientes()
        {
            InitializeComponent();
        }

        private void timerClientes_Tick(object sender, EventArgs e)
        {
            horas.Text = DateTime.Now.ToShortTimeString();
            fechas.Text = DateTime.Now.ToLongDateString();
        }
    }
}
