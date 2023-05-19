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
    public class N_Factura
    {
        public static string sp_Factura(double numFactura, string servUsado,
                                        float precio, float descuento, float montoTotal, float servadd,
                                        string cod_reser, int id_checkout, string Op)
        {
            D_Factura factura = new D_Factura();
            Factura Obj = new Factura();
            Obj.numFactura = numFactura;
            Obj.servUsado = servUsado;
            Obj.precio = precio;
            Obj.descuento = descuento;
            Obj.montoTotal = montoTotal;
            Obj.servadd = servadd;
            Obj.cod_reser = cod_reser;
            Obj.id_checkout = id_checkout;
            Obj.Op = Op;

            return factura.sp_Factura(Obj);
        }
    }
}
