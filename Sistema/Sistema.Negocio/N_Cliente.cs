using Sistema.Datos;
using Sistema.Entidad;
using System;
using System.Data;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Sistema.Negocio
{
    public class N_Cliente
    {
        public static string sp_Cliente(string RFC, string nombre, string apellidoP, string apellidoM, 
                                        string domicilio, string correo, double telefono, string referencia,
                                        string fNacimiento, string eCivil, string fRegistro, string regAdim, string Op)
        {
            D_Cliente cliente = new D_Cliente();
            Cliente Obj = new Cliente();
            Obj.RFC = RFC;
            Obj.nombre = nombre;
            Obj.apellidoP = apellidoP;
            Obj.apellidoM = apellidoM;
            Obj.domicilio = domicilio;
            Obj.correo = correo;
            Obj.telefono = telefono;
            Obj.referencia = referencia;
            Obj.fNacimiento = fNacimiento;
            Obj.eCivil = eCivil;
            Obj.fRegistro = fRegistro;
            Obj.regAdim = regAdim;
            Obj.Op = Op;

            return cliente.sp_Cliente(Obj);
        }

        public static DataTable sp_Get_Cliente()
        {
            D_Cliente cliente = new D_Cliente();
            return cliente.sp_Get_Cliente();
        }
    }
}
