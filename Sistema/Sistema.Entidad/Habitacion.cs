using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Sistema.Entidad
{
    public class Habitacion
    {
        public int id_habitacion { get; set; }
        public double numCamas { get; set; }
        public string tipoCama { get; set; }
        public double preXpersXnoc { get; set; }
        public double canXpersXhab { get; set; }
        public string nivelHab { get; set; }
        public int frente { get; set; }
        public string regAdim { get; set; }
        public string Op { get; set; }
    }
}
