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
    public class N_Habitacion
    {
        public static string sp_Habitacion(double numCamas, string tipoCama, double preXpersXnoc,
                                       double canXpersXhab, string nivelHab, int frente, string regAdim, string Op)
        {
            D_Habitacion habitacion = new D_Habitacion();
            Habitacion Obj = new Habitacion();
            Obj.numCamas = numCamas;
            Obj.tipoCama = tipoCama;
            Obj.preXpersXnoc = preXpersXnoc;
            Obj.canXpersXhab = canXpersXhab;
            Obj.nivelHab = nivelHab;
            Obj.frente = frente;;
            Obj.regAdim = regAdim;
            Obj.Op = Op;

            return habitacion.sp_Habitacion(Obj);
        }

        public static string sp_Habitacion_UD(int id_habitacion, double numCamas, string tipoCama, double preXpersXnoc,
                                      double canXpersXhab, string nivelHab, int frente, string regAdim, string Op)
        {
            D_Habitacion habitacion = new D_Habitacion();
            Habitacion Obj = new Habitacion();
            Obj.id_habitacion = id_habitacion;
            Obj.numCamas = numCamas;
            Obj.tipoCama = tipoCama;
            Obj.preXpersXnoc = preXpersXnoc;
            Obj.canXpersXhab = canXpersXhab;
            Obj.nivelHab = nivelHab;
            Obj.frente = frente; ;
            Obj.regAdim = regAdim;
            Obj.Op = Op;

            return habitacion.sp_Habitacion(Obj);
        }

        public static DataTable sp_Get_Habitacion()
        {
            D_Habitacion habitacion = new D_Habitacion();
            return habitacion.sp_Get_Habitacion();
        }
    }
}
