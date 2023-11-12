using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using EntidadesGeo;

namespace AccesoDatosGeo
{
    public interface IEntidades
    {
        void Guardar(dynamic Entidad);
        void Borrar(dynamic Entidad);
        DataSet Mostrar(string filtro);
    }
}
