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
    public class N_HabitacionHotel
    {
        public static string sp_HabitacionHotel(int id_habitacion, int id_hotel, string tipoHab,
                                    string caract, string amenidades, string Op)
        {
            D_HH hh = new D_HH();
            HabitacionHotel Obj = new HabitacionHotel();
            Obj.id_habitacion = id_habitacion;
            Obj.id_hotel = id_hotel;
            Obj.tipoHab = tipoHab;
            Obj.caract = caract;
            Obj.amenidades = amenidades;
            Obj.Op = Op;

            return hh.sp_HabitacionHotel(Obj);
        }

        public static string sp_HabitacionHotel_CRUD(int id_HH, int id_habitacion, int id_hotel, string tipoHab,
                                  string caract, string amenidades, string Op)
        {
            D_HH hh = new D_HH();
            HabitacionHotel Obj = new HabitacionHotel();
            Obj.id_HH = id_HH;
            Obj.id_habitacion = id_habitacion;
            Obj.id_hotel = id_hotel;
            Obj.tipoHab = tipoHab;
            Obj.caract = caract;
            Obj.amenidades = amenidades;
            Obj.Op = Op;

            return hh.sp_HabitacionHotel(Obj);
        }

        public static DataTable sp_Get_HabitacionHotel()
        {
            D_HH hh = new D_HH();
            return hh.sp_Get_HabitacionHotel();
        }
    }
}
