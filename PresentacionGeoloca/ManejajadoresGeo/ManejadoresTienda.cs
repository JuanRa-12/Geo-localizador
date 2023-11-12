using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using EntidadesGeo;
using AccesoDatosGeo;
using System.Windows.Forms;
using Crud;
using System.Drawing;

namespace ManejajadoresGeo
{
    public class ManejadoresTienda : IManejador
    {
        AccesoTienda at = new AccesoTienda();
        Grafico g = new Grafico();
        public void Borrar(dynamic Entidad)
        {
            throw new NotImplementedException();
        }

        public void Exportar(DataGridView tabla)
        {
            throw new NotImplementedException();
        }

        public void Guardar(dynamic Entidad)
        {
            at.Guardar(Entidad);
            g.Mensaje("Pais Guardado", "!Atencion",
                MessageBoxIcon.Information);
        }

        public void Mostrar(DataGridView tabla, string filtro)
        {
            tabla.Columns.Clear();
            tabla.RowTemplate.Height = 30;
            tabla.DataSource = at.Mostrar(filtro).Tables["tienda"];
            tabla.Columns.Insert(3, g.Boton(
                "Editar", Color.Green));
            tabla.Columns.Insert(4, g.Boton("Borrar", Color.Red));
            tabla.Columns[0].Visible = false;
        }
    }
}
