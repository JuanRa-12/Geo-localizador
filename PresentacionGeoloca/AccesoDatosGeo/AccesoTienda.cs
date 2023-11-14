using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using EntidadesGeo;
using MySql.Data.MySqlClient;
using System.IO;
using System.Security.Cryptography.X509Certificates;
using ConectarBd;

namespace AccesoDatosGeo
{
    public class AccesoTienda : IEntidades
    {
        Base b = new Base("Localhost", "root", "", "geo", 3306);
        public void Borrar(dynamic Entidad)
        {
            //b.comando(String.Format("call deletePais({0})",
            //    Entidad.Ncorrelativo));
        }

        public void Guardar(dynamic Entidad)
        {
            b.comando(string.Format("call InsertarTienda('{0}','{1}')", Entidad.Nombre, Entidad.Direccion));
        }

        public DataSet Mostrar(string filtro)
        {
            return b.Obtener
                (string.Format("call showTienda('%{0}%')",
                filtro), "tienda");
        }
    }
}
