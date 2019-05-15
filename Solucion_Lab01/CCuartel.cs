using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Solucion_Lab01
{
    public class CCuartel
    {retirate men
        public string Codigo { get; set; }
        public string NombreCuartel { get; set; }
        public string Direccion { get; set; }
        public string Ciudad { get; set; }
        public List<CSoldado> Soldados { get; set; }
        public CCuartel()
        {
            Soldados = new List<CSoldado>();
        }
    }
}
