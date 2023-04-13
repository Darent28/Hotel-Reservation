using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Sistema.Entidad
{
    public class Usuario
    {
        public string RFC { get; set; }
        public string nombre { get; set; }
        public string apellidop { get; set; }
        public string apellidom { get; set; }
        public double nomina { get; set; }
        public string fnacimiento { get; set; }
        public string domicilio { get; set; }
        public double telefono { get; set; }
        public int esadmin { get; set; }
        public string correo { get; set; }
        public string contrasena { get; set; }
        public string Op { get; set; }
    }
}
