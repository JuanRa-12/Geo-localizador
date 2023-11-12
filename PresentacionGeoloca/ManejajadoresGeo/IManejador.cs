using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using EntidadesGeo;
using AccesoDatosGeo;
using System.Windows.Forms;

namespace ManejajadoresGeo
{
    public interface IManejador
    {
        void Guardar(dynamic Entidad);
        void Borrar(dynamic Entidad);
        void Mostrar(DataGridView tabla, string filtro);
        void Exportar(DataGridView tabla);
    }
}
