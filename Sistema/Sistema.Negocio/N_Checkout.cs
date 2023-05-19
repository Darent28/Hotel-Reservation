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
    public class N_Checkout
    {
        public static string sp_Checkout( int extendio, int id_checkin, string fFinC)
        {
            D_Checkout checkout = new D_Checkout();
            Checkout Obj = new Checkout();
            Obj.extendio = extendio;
            Obj.id_checkin = id_checkin;
            Obj.fFinC = fFinC;
            return checkout.sp_Checkout(Obj);
        }

        public static DataTable sp_Get_Checkout()
        {
            D_Checkout checkout = new D_Checkout();
            return checkout.sp_Get_Checkout();
        }
    }
}
