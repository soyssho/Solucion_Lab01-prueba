using System;f this project for you to commit your proposed changes to. Submitting a change to this file will write it to a new branch in your fork, so you
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks  ;

namespace Solucion_Lab01
{
    public class CCuartel
    {public string gg{get;set;}
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
