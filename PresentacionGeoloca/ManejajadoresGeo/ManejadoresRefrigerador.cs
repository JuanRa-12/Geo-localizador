using System;
using AccesoDatosGeo;
using System.Windows.Forms;
using Crud;

namespace ManejajadoresGeo
{
    public class ManejadoresRefrigerador : IManejador
    {
        AccesoRefrigerador ar = new AccesoRefrigerador();
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
            throw new NotImplementedException();
        }

        public void Mostrar(DataGridView tabla, string filtro)
        {
            tabla.Columns.Clear();
            tabla.RowTemplate.Height = 30;
            tabla.DataSource = ar.Mostrar(filtro).Tables["refrigerador"];
            tabla.Columns[0].Visible = false;
        }
    }
}
