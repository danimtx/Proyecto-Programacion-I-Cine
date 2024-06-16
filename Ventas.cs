using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProyectoCine
{
    public class Ventas
    {
        // boleto / venta
        public int codigo { get; set; }
        public string Peliculas { get; set; }
        public string usuario { get; set; }
        public string cantidadBoletos { get; set; }
        public float Total { get; set; }
        public string departamento { get; set; }
        public string fecha { get; set; }
        public string hora { get; set; }
        public string sala { get; set; }
        public string butaca { get; set; }
    }
}
