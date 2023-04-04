using Sistema.Datos;
using Sistema.Entidad;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Sistema.Negocio
{
    public class N_Usuario
    {

        public static string sp_Usuario(string RFC, string nombre, string apellidop, string apellidom,
                                        double nomina, string fnacimiento, string domicilio, string ciudad,
                                        string estado, string pais, double telefono, int esadmin,
                                        string correo, string contrasena, string Op)
        {
            D_Usuario usuario = new D_Usuario();
            Usuario Obj = new Usuario();
            Obj.RFC = RFC;
            Obj.nombre = nombre;
            Obj.apellidop = apellidop;
            Obj.apellidom = apellidom;
            Obj.nomina = nomina;
            Obj.fnacimiento = fnacimiento;
            Obj.domicilio = domicilio;
            Obj.ciudad = ciudad;
            Obj.estado = estado;
            Obj.pais = pais;
            Obj.telefono = telefono;
            Obj.esadmin = esadmin;
            Obj.correo = correo;
            Obj.contrasena = contrasena;
            Obj.Op = Op;

            return usuario.sp_Usuario(Obj);
        }

        public static DataTable sp_Login_Usuario(string correo)
        {
            D_Usuario usuario = new D_Usuario();
            return usuario.sp_Login_Usuario(correo);
        }

        public static DataTable sp_Get_Usuario()
        {
            D_Usuario usuario = new D_Usuario();
            return usuario.sp_Get_Usuario();
        }
    }
}
