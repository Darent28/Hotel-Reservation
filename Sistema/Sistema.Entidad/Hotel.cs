using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Sistema.Entidad
{
    public class Hotel
    {
        public int id_hotel { get; set; }
        public string nombreH { get; set; }
        public string ubicacion { get; set; }
        public string domicilioH { get; set; }
        public double numPiso { get; set; }
        public double canHabitacion { get; set; }
        public bool zonaTuris { get; set; }
        public bool servicioAdi { get; set; }
        public bool frentePlaya { get; set; }
        public bool salonEventos { get; set; }
        public string fechaReg { get; set; }
        public string fechaInicioOp { get; set; }
        public string regAdim { get; set; }
        public string Op { get; set; }

    }
}
