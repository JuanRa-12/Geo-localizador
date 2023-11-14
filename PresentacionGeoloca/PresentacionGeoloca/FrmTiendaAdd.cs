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
using AccesoDatosGeo;
using ManejajadoresGeo;

namespace PresentacionGeoloca
{
    public partial class FrmTiendaAdd : Form
    {
        ManejadoresTienda mt;
        public FrmTiendaAdd()
        {
            InitializeComponent();
            mt = new ManejadoresTienda();
        }

       

        private void btnGuardar_Click(object sender, EventArgs e)
        {
            try
            {
                mt.Guardar(new Tienda(txtNombre.Text, txtDireccion.Text));
                this.Close();
            }
            catch (Exception)
            {

                MessageBox.Show("No funciono");
            }
            
        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void FrmTiendaAdd_Load(object sender, EventArgs e)
        {

        }
    }
}
