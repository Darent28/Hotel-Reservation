using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Sistema.Entidad
{
    public class Factura
    {
        public double numFactura { get; set; }
        public string servUsado { get; set; }
        public float precio { get; set; }
        public float descuento { get; set; }
        public float montoTotal { get; set; }
        public float servadd { get; set; }
        public string cod_reser { get; set; }
        public int id_checkout { get; set; }
        public string Op { get; set; }

    }
}
