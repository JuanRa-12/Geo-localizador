using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EntidadesGeo
{
    public class Refrigerador
    {
        public Refrigerador(int idrefri, int nuserie, string caract, int fkidgps, int fkidtienda)
        {
            Idrefri = idrefri;
            Nuserie = nuserie;
            Caract = caract;
            Fkidgps = fkidgps;
            Fkidtienda = fkidtienda;
        }

        public int Idrefri { get; set; }
        public int Nuserie { get; set; }
        public string Caract { get; set; }
        public int Fkidgps { get; set; }
        public int Fkidtienda { get; set; }
    }
}
