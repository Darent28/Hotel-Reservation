using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Sistema.Entidad
{
    public class HabitacionHotel
    {
        public int id_HH { get; set; }
        public int id_habitacion { get; set; }
        public int id_hotel { get; set; }
        public string tipoHab { get; set; }
        public string caract { get; set; }
        public string amenidades { get; set; }
        public string Op { get; set; }
    }
}
