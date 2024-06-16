using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProyectoCine
{
    public class Facturas
    {
        public int codigo { get; set; }
        public string fecha { get; set; }
        public string ci { get; set; }
        public string señores { get; set; }
        public string pelicula { get; set; }
        public string cantidad { get; set; }
        public float Punitario { get; set; }
        public string total { get; set; }
    }
}
