using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Sistema.Entidad
{
    public class Reservacion
    {
        public string codigo { get; set; }
        public string fReser { get; set; }
        public string fInicio { get; set; }
        public string fFin { get; set; }
        public double canPers { get; set; }
        public float anticipo { get; set; }
        public string mPago { get; set; }
        public string regAdim { get; set; }
        public string rfcCliente { get; set; }
        public int id_HH { get; set; }
        public string Op { get; set; }

    }
}
