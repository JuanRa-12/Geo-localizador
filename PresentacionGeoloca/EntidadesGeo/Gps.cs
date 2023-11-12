using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EntidadesGeo
{
    public class Gps
    {
        public Gps(int idgps, float latitud, float longitud, int fkidrefri)
        {
            Idgps = idgps;
            Latitud = latitud;
            Longitud = longitud;
            Fkidrefri = fkidrefri;
        }

        public int Idgps { get; set; }
        public float Latitud { get; set; }
        public float Longitud { get; set; }
        public int Fkidrefri { get; set; }
    }
}
