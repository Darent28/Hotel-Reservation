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
    public class N_Checkin
    {
        public static string sp_Checkin( int asistio, string codigo)
        {
            D_Checkin checkin = new D_Checkin();
            Checkin Obj = new Checkin();
            Obj.asistio = asistio;
            Obj.codigo = codigo;
            return checkin.sp_Checkin(Obj);
        }

        public static DataTable sp_Get_Checkin()
        {
            D_Checkin checkin = new D_Checkin();
            return checkin.sp_Get_Checkin();
        }
    }
}
