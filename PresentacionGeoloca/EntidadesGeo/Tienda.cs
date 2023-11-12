using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EntidadesGeo
{
    public class Tienda
    {
        public Tienda(int idtienda, string nombre, string direccion)
        {
            Idtienda = idtienda;
            Nombre = nombre;
            Direccion = direccion;
        }

        public int Idtienda { get; set; }
        public string Nombre { get; set; }
        public string Direccion { get; set; }
    }
}
