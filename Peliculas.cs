using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProyectoCine
{
    public class Peliculas
    {
        public string codigo { get; set; }
        public string nombre { get; set; }
        public string genero { get; set; }
        public string duracion { get; set; }
        public string protagonista { get; set; }
        public string director { get; set; }
        public string imagen { get; set; }
        public bool mostrar { get; set; }
        public float precio { get; set; }
    }
}
