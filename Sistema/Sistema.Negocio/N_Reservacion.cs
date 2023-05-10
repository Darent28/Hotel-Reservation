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
    public class N_Reservacion
    {
        public static string sp_Reservacion( string codigo, string fReser, string fInicio, 
                                            string fFin, double canPers, float anticipo,
                                            string mPago, string regAdim, string rfcCliente,
                                            int id_HH, string Op)
        {
            D_Reservacion reservacion = new D_Reservacion();
            Reservacion Obj = new Reservacion();
            Obj.codigo = codigo;
            Obj.fReser = fReser;
            Obj.fInicio = fInicio;
            Obj.fFin = fFin;
            Obj.canPers = canPers;
            Obj.anticipo = anticipo;
            Obj.mPago = mPago;
            Obj.regAdim = regAdim;
            Obj.rfcCliente = rfcCliente;
            Obj.id_HH = id_HH;
            Obj.Op = Op;

            return reservacion.sp_Reservacion(Obj);
        }

        public static string sp_Reembolso(string codigo, string Op)
        {
            D_Reservacion reservacion = new D_Reservacion();
            Reservacion Obj = new Reservacion();
            Obj.codigo = codigo;
            Obj.Op = Op;

            return reservacion.sp_Reservacion(Obj);
        }


        public static DataTable sp_Get_Reservacion()
        {
            D_Reservacion reservacion = new D_Reservacion();
            return reservacion.sp_Get_Reservacion();
        }

        public static DataTable sp_Get_ClienteR(string parametro)
        {
            D_Reservacion reservacion = new D_Reservacion();
            return reservacion.sp_Get_ClienteR(parametro);
        }

        public static DataTable sp_Get_CiudadR(string parametro)
        {
            D_Reservacion reservacion = new D_Reservacion();
            return reservacion.sp_Get_CiudadR(parametro);
        }

    }
}
