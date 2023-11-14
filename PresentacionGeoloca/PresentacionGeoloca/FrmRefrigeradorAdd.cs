using ManejajadoresGeo;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using MySql.Data.MySqlClient;
using EntidadesGeo;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;
using System.Data.SqlClient;

namespace PresentacionGeoloca
{
    public partial class FrmRefrigeradorAdd : Form
    {
        private string connectionString = "Server=Localhost;Database=geo;Uid=root;Pwd='';";
        private MySqlConnection connection;
        ManejadoresRefrigerador mr;
        private int idgpsSeleccionado;
        private int idtiendaSeleccionado;
        public FrmRefrigeradorAdd()
        {
            InitializeComponent();
            mr = new ManejadoresRefrigerador();
            connection = new MySqlConnection(connectionString);

            // Cargar datos en el ComboBox al cargar el formulario
            CargarDatosComboBox();
            CargarDatosComboBoxTienda();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.Close();
            Frmtienda frmTienda = (Frmtienda)this.Owner;
            frmTienda.Actualizar();
        }

        private void btnGuardar_Click(object sender, EventArgs e)
        {
            mr.Guardar(new Refrigerador(Frmtienda.refri.Idrefri, int.Parse(txtNSerie.Text), txtCaract.Text, idgpsSeleccionado, idtiendaSeleccionado));
            this.Close();
            Frmtienda frmTienda = (Frmtienda)this.Owner;
            frmTienda.Actualizar();
        }
        //----------------------
        private void CargarDatosComboBox()
        {
            try
            {
                // Abrir la conexión
                connection.Open();

                // Consulta SQL para obtener los nombres y los idgps
                string query = "SELECT idgps, nombre FROM gps";

                using (MySqlCommand command = new MySqlCommand(query, connection))
                {
                    using (MySqlDataReader reader = command.ExecuteReader())
                    {
                        // Limpiar el ComboBox antes de agregar nuevos elementos
                        cmbGPS.Items.Clear();

                        // Lista para almacenar pares de idgps y nombre
                        List<KeyValuePair<int, string>> listaDatos = new List<KeyValuePair<int, string>>();

                        // Iterar a través de los resultados de la consulta
                        while (reader.Read())
                        {
                            // Obtener el idgps y el nombre
                            int idgps = reader.GetInt32(0);
                            string nombre = reader.GetString(1);

                            // Agregar el nombre al ComboBox y asociarlo con el idgps
                            listaDatos.Add(new KeyValuePair<int, string>(idgps, nombre));
                        }

                        // Asignar la lista al ComboBox
                        cmbGPS.DataSource = new BindingSource(listaDatos, null);
                        cmbGPS.DisplayMember = "Value";
                        cmbGPS.ValueMember = "Key";
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Error al cargar datos: {ex.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            finally
            {
                // Cerrar la conexión
                connection.Close();
            }
        }
        private void CargarDatosComboBoxTienda()
        {
            try
            {
                // Abrir la conexión
                connection.Open();

                // Consulta SQL para obtener los nombres y los idtienda
                string query = "SELECT idtienda, nombre FROM tienda";

                using (MySqlCommand command = new MySqlCommand(query, connection))
                {
                    using (MySqlDataReader reader = command.ExecuteReader())
                    {
                        // Limpiar el ComboBox antes de agregar nuevos elementos
                        cmbTienda.Items.Clear();

                        // Lista para almacenar pares de idtienda y nombre
                        List<KeyValuePair<int, string>> listaDatos = new List<KeyValuePair<int, string>>();

                        // Iterar a través de los resultados de la consulta
                        while (reader.Read())
                        {
                            // Obtener el idtienda y el nombre
                            int idtienda = reader.GetInt32(0);
                            string nombre = reader.GetString(1);

                            // Agregar el nombre al ComboBox y asociarlo con el idtienda
                            listaDatos.Add(new KeyValuePair<int, string>(idtienda, nombre));
                        }

                        // Asignar la lista al ComboBox
                        cmbTienda.DataSource = new BindingSource(listaDatos, null);
                        cmbTienda.DisplayMember = "Value";
                        cmbTienda.ValueMember = "Key";
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Error al cargar datos: {ex.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            finally
            {
                // Cerrar la conexión
                connection.Close();
            }
        }


        private void cmbGPS_SelectedIndexChanged(object sender, EventArgs e)
        {
            // Obtener el idgps seleccionado del ComboBox
            idgpsSeleccionado = ((KeyValuePair<int, string>)cmbGPS.SelectedItem).Key;

            // Utilizar el idgps en tu lógica de programa
            // ...
        }

        private void cmbTienda_SelectedIndexChanged(object sender, EventArgs e)
        {
            idtiendaSeleccionado = ((KeyValuePair<int, string>)cmbTienda.SelectedItem).Key;
        }

        //------------------

    }
}
