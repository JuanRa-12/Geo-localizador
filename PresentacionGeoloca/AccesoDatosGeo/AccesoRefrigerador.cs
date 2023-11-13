using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ConectarBd;

namespace AccesoDatosGeo
{
    public class AccesoRefrigerador : IEntidades
    {
        Base b = new Base("Localhost", "root", "", "geo", 3306);
        public void Borrar(dynamic Entidad)
        {
            //throw new NotImplementedException();
        }

        public void Guardar(dynamic Entidad)
        {
            b.comando(string.Format("call InsertarRefrigerador('{0}','{1}','{2}','{3}'", Entidad.Nuserie, Entidad.Caract, Entidad.GPS, Entidad.Fkidtienda));
        }

        public DataSet Mostrar(string filtro)
        {
            return b.Obtener
                (string.Format("call showRefrigerador('%')",
                filtro), "refrigerador");
                //(string.Format("call showRefrigerador('%{0}%')",
                //filtro), "refrigerador");     se comento este filtro ya que no era necesario
        }
    }
}
