using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using EntidadesGeo;
using ManejajadoresGeo;
using AccesoDatosGeo;

namespace PresentacionGeoloca
{
    public partial class FrmTienda : Form
    {
        ManejadoresTienda mt;
        public static Tienda tienda = new Tienda(0, "", "");
        int fila = 0, col = 0;
        public FrmTienda()
        {
            InitializeComponent();
            mt = new ManejadoresTienda();
        }

        private void btnRegresar_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void FrmTienda_Load(object sender, EventArgs e)
        {
            Actualizar();
        }
        void Actualizar()
        {
            mt.Mostrar(dtgTienda, txtBuscar.Text);
        }
    }
}
