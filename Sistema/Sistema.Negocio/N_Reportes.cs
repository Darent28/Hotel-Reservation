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
    public class N_Reportes
    {
        public static DataTable sp_Get_Rhotel(string pais, string ciudad, string hotel, string fecha)
        {
            D_Reportes rhotel = new D_Reportes();
            return rhotel.sp_Get_Rhotel(pais, ciudad, hotel, fecha);
        }

        public static DataTable sp_Get_Rhotelall(string pais, string ciudad,string fecha)
        {
            D_Reportes rhotel = new D_Reportes();
            return rhotel.sp_Get_Rhotelall(pais, ciudad, fecha);
        }

        public static DataTable sp_Get_Rventas(string pais, string ciudad, string hotel, string fecha)
        {
            D_Reportes rventas = new D_Reportes();
            return rventas.sp_Get_Rventas(pais, ciudad, hotel, fecha);
        }

        public static DataTable sp_Get_Rventasall(string pais, string ciudad, string fecha)
        {
            D_Reportes rventas = new D_Reportes();
            return rventas.sp_Get_Rventasall(pais, ciudad, fecha);
        }

        public static DataTable sp_Get_Rcliente(string cliente, string fecha)
        {
            D_Reportes rcliente = new D_Reportes();
            return rcliente.sp_Get_Rcliente(cliente, fecha);
        }

        public static DataTable sp_Get_Rclienteall(string cliente)
        {
            D_Reportes rcliente = new D_Reportes();
            return rcliente.sp_Get_Rclienteall(cliente);
        }
    }
}
