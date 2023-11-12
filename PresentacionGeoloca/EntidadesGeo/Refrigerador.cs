using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EntidadesGeo
{
    public class Refrigerador
    {
        public Refrigerador(int idrefri, int nuserie, string caract, string gPS, int fkidtienda)
        {
            Idrefri = idrefri;
            Nuserie = nuserie;
            Caract = caract;
            GPS = gPS;
            Fkidtienda = fkidtienda;
        }

        public int Idrefri { get; set; }
        public int Nuserie { get; set; }
        public string Caract { get; set; }
        public string GPS { get; set; }
        public int Fkidtienda { get; set; }
    }
}
