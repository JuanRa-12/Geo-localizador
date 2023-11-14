using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EntidadesGeo
{
    public class Tienda
    {
        public Tienda( string nombre, string direccion)
        {
            Nombre = nombre;
            Direccion = direccion;
        }

        public string Nombre { get; set; }
        public string Direccion { get; set; }
    }
}
