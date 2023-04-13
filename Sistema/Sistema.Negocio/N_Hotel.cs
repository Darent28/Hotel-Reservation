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
    public class N_Hotel
    {

        public static string sp_Hotel(string nombreH, string ubicacion, string domicilioH,
                                       double numPiso, double canHabitacion, bool zonaTuris, bool servicioAdi, bool frentePlaya,
                                       bool salonEventos, string fechaReg, string fechaInicioOp, string regAdim, string Op)
        {
            D_Hotel hotel = new D_Hotel();
            Hotel Obj = new Hotel();
            Obj.nombreH = nombreH;
            Obj.ubicacion = ubicacion;
            Obj.domicilioH = domicilioH;
            Obj.numPiso = numPiso;
            Obj.canHabitacion = canHabitacion;
            Obj.zonaTuris = zonaTuris;
            Obj.servicioAdi = servicioAdi;
            Obj.frentePlaya = frentePlaya;
            Obj.salonEventos = salonEventos;
            Obj.fechaReg = fechaReg;
            Obj.fechaInicioOp = fechaInicioOp;
            Obj.regAdim = regAdim;
            Obj.Op = Op;

            return hotel.sp_Hotel(Obj);
        }

        public static string sp_Hotel_UD(int id_hotel, string nombreH, string ubicacion, string domicilioH,
                                       double numPiso, double canHabitacion, bool zonaTuris, bool servicioAdi, bool frentePlaya,
                                       bool salonEventos, string fechaReg, string fechaInicioOp, string regAdim, string Op)
        {
            D_Hotel hotel = new D_Hotel();
            Hotel Obj = new Hotel();
            Obj.id_hotel = id_hotel;
            Obj.nombreH = nombreH;
            Obj.ubicacion = ubicacion;
            Obj.domicilioH = domicilioH;
            Obj.numPiso = numPiso;
            Obj.canHabitacion = canHabitacion;
            Obj.zonaTuris = zonaTuris;
            Obj.servicioAdi = servicioAdi;
            Obj.frentePlaya = frentePlaya;
            Obj.salonEventos = salonEventos;
            Obj.fechaReg = fechaReg;
            Obj.fechaInicioOp = fechaInicioOp;
            Obj.regAdim = regAdim;
            Obj.Op = Op;

            return hotel.sp_Hotel(Obj);
        }

        public static DataTable sp_Get_Hotel()
        {
            D_Hotel hotel = new D_Hotel();
            return hotel.sp_Get_Hotel();
        }
    }
}
