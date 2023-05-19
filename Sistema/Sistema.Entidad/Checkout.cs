using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Sistema.Entidad
{
    public class Checkout
    {
        public int id_checkout { get; set; }
        public int extendio { get; set; }
        public string fFinC { get; set; }
        public int id_checkin { get; set; }
    }
}
