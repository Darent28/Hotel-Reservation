﻿using Sistema.Negocio;
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

        string ppxn = "";
        string cpxh = "";

        float precio = 0;

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

            comboBox1.Items.Clear();
            comboBox1.Items.Add("Tarjeta de credito");
            comboBox1.Items.Add("Tarjeta de debito");
            comboBox1.Items.Add("Deposito");
            comboBox1.Items.Add("Transferencia");
  
            checkSerusados.Checked = false;
            checkBox1.Checked = false;
            textReserOut.Clear();
            textIDcheckout.Clear();
            textreserF.Clear();
            textBox2.Clear();
            numericDescu.ResetText();
            comboBox1.ResetText();
            textServUsados.Clear();
            textPrecio.Clear();

            textNumfactura.Clear();
            Random rnd = new Random();
            double numero = rnd.Next(10000, 99999);
            string numeroStr = numero.ToString();
            textNumfactura.AppendText(numeroStr);

            try
            {
                dgvReser.DataSource = N_Reservacion.sp_Get_Reservacion();
                dgvCheckin.DataSource = N_Checkin.sp_Get_Checkin();
                dgvFactura.DataSource = N_Checkout.sp_Get_Checkout();
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

                if (noasis == true)
                {
                    asistio = 0;
                }
                else if (siasis == true)
                {
                    asistio = 1;
                }
                else
                {
                    MessageBox.Show("Favor de llenar el apartado Asistio.", "Informacion", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return;
                }

                string respuesta = N_Checkin.sp_Checkin(asistio, checkin);
                if(asistio == 0)
                {
                    if (respuesta.Equals("OK"))
                    {
                        MessageBox.Show("Reservacion Completada", "Informacion", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        OPER_principal_Load(sender, e);
                    }
                    else
                    {
                        MessageBox.Show(respuesta, "Informacion", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        OPER_principal_Load(sender, e);
                    }

                }
                else if (asistio == 1)
                {
                    if (respuesta.Equals("OK"))
                    {
                        MessageBox.Show("Reservacion Reembolsada", "Informacion", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        OPER_principal_Load(sender, e);
                    }
                    else
                    {
                        MessageBox.Show(respuesta, "Informacion", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        OPER_principal_Load(sender, e);
                    }
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
                textReserOut.Text = dgvCheckin.CurrentRow.Cells[2].Value.ToString();
                textIDcheckout.Text = dgvCheckin.CurrentRow.Cells[0].Value.ToString();

            }
        }

        private void txtCargar_Click(object sender, EventArgs e)
        {
            OPER_principal_Load(sender, e);
        }

        private void checkBox1_CheckedChanged(object sender, EventArgs e)
        {
            if(checkBox1.Checked == true)
            {
                dateTimeExt.Enabled = true;
            }
            else
            {
                dateTimeExt.Enabled = false;
            }
           
        }

        private void btnCheck_Click(object sender, EventArgs e)
        {
            string checkin = textIDcheckout.Text;
            int extendio = 0;
            bool siextendio = checkBox1.Checked;
            string extendiodate = dateTimeExt.Text;

            if (checkin.CompareTo("") == 0)
            {
                MessageBox.Show("Favor de poner el codigo del checkin.", "Informacion", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else
            {

                if (siextendio == true)
                {
                    extendio = 1;
                }
                else
                {
                    extendio = 0;
                }


                string respuesta = N_Checkout.sp_Checkout(extendio, int.Parse(checkin), extendiodate);

                    if (respuesta.Equals("OK"))
                    {
                        MessageBox.Show("Checkout Realizado", "Informacion", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        OPER_principal_Load(sender, e);
                    }
                    else
                    {
                        MessageBox.Show(respuesta, "Informacion", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        OPER_principal_Load(sender, e);
                    }


            }


        }

        private void dgvFactura_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (dgvFactura.RowCount < 1)
            {
                return;
            }
            else
            {
                textreserF.Text = dgvFactura.CurrentRow.Cells[4].Value.ToString();
                textBox2.Text = dgvFactura.CurrentRow.Cells[0].Value.ToString();

                foreach (DataGridViewRow row in dgvFactura.Rows)
                {
                    if ( row.Cells["Precio de persona por noche"].Value != null 
                        && row.Cells["Cantidad de persona por habitacion"].Value != null)


                    ppxn = row.Cells["Precio de persona por noche"].Value.ToString();
                    cpxh = row.Cells["Cantidad de persona por habitacion"].Value.ToString();

                }

                float PPXN = float.Parse(ppxn), CPXH = float.Parse(cpxh);

                precio = PPXN * CPXH;

                textPrecio.Text = String.Format("${0:n}", precio);
            }
        }

        private void label10_Click(object sender, EventArgs e)
        {

        }

        private void textServUsados_TextChanged(object sender, EventArgs e)
        {

        }

        private void label14_Click(object sender, EventArgs e)
        {

        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void btnFacturar_Click(object sender, EventArgs e)
        {
            string codigo = textreserF.Text; 
            string IDCheckout = textBox2.Text;
            string descuento = numericDescu.Text;
            string mpago = comboBox1.Text;
            string susados = textServUsados.Text;
            string numfactura = textNumfactura.Text;
            string preciotxt = textPrecio.Text;
            float servadd = 0;
            bool checkSU = checkSerusados.Checked;

            if (susados == "")
            {
                susados = "Servicios extras no utilizados";

            }

            if (checkSU == true)
            {
                servadd = 1000;
            }
            else if (checkSU == false)
            {
                servadd = 0;
            }

            if (codigo.CompareTo("") == 0 || IDCheckout.CompareTo("") == 0 || descuento.CompareTo("") == 0 || mpago.CompareTo("") == 0
                || susados.CompareTo("") == 0 || numfactura.CompareTo("") == 0)
            {
                MessageBox.Show("Favor de llenar los datos.", "Informacion", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else
            {

                string[] totalremove = new string[] { "$" };
                foreach (var c in totalremove)
                {
                    preciotxt = preciotxt.Replace(c, string.Empty);
                }

                float precioHab = float.Parse(preciotxt);
                float descu = float.Parse(descuento);
                float montototal = precioHab - (precioHab * (descu / 100));
                montototal += servadd;

                string respuesta = N_Factura.sp_Factura(double.Parse(numfactura), susados, precioHab, float.Parse(descuento), montototal, servadd, codigo, int.Parse(IDCheckout), "I");

                if (respuesta.Equals("OK"))
                {
                    MessageBox.Show("Factura Realizado", "Informacion", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    OPER_principal_Load(sender, e);
                }
                else
                {
                    MessageBox.Show(respuesta, "Informacion", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    OPER_principal_Load(sender, e);
                }

            }
        }

        private void checkSerusados_CheckedChanged(object sender, EventArgs e)
        {
            if (checkSerusados.Checked == true)
            {
                textServUsados.Enabled = true;
            }
            else
            {
                textServUsados.Enabled = false;
            }
        }

        private void si_CheckedChanged(object sender, EventArgs e)
        {

        }
    }
}
