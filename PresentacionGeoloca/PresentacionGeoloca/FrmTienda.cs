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
using Org.BouncyCastle.Math;

namespace PresentacionGeoloca
{
    public partial class Frmtienda : Form
    {
        ManejadoresRefrigerador mr;
        public static Refrigerador refri = new Refrigerador(0,0,"", "",0);
        int fila = 0, col = 0;
        public Frmtienda()
        {
            InitializeComponent();
            mr = new ManejadoresRefrigerador();
        }

        private void btnRegresar_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void FrmTienda_Load(object sender, EventArgs e)
        {
            Actualizar();
        }

        private void dtgTienda_CellEnter(object sender, DataGridViewCellEventArgs e)
        {
            fila = e.RowIndex;
            col = e.ColumnIndex;
            //pais.Ncorrelativo = int.Parse(dtgPais.Rows[fila]
            refri.Idrefri = int.Parse(dtgRefri.Rows[fila].Cells[0].Value.ToString());
            refri.Nuserie = int.Parse(dtgRefri.Rows[fila].Cells[1].Value.ToString());
            refri.Caract = dtgRefri.Rows[fila].Cells[2].Value.ToString();
            refri.GPS = dtgRefri.Rows[fila].Cells[3].Value.ToString();
            refri.Fkidtienda = int.Parse(dtgRefri.Rows[fila].Cells[4].Value.ToString());
        }

        private void txtBuscar_TextChanged(object sender, EventArgs e)
        {
            Actualizar();
        }

        private void btnInsertarT_Click(object sender, EventArgs e)
        {
            FrmTiendaAdd f2 = new FrmTiendaAdd();
            f2.ShowDialog();
        }

        void Actualizar()
        {
            mr.Mostrar(dtgRefri, txtBuscar.Text);
        }    


    }
}
