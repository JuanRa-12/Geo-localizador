using GMap.NET.WindowsForms.Markers;
using GMap.NET.WindowsForms;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using GMap.NET.MapProviders;
using GMap.NET;
using MySql.Data.MySqlClient;

namespace PresentacionGeoloca
{
    public partial class frmMap : Form
    {
        public int NuserieSeleccionado { get; set; }
        public int IdrefriSeleccionado  { get; set; }
        GMarkerGoogle marker;
        GMapOverlay markerOverlay;
        DataTable dt;
        int filaSeleccionada = 0;
        double LatInicial;
        double LngInicial;
        private Timer timer;
        public frmMap()
        {
            InitializeComponent();
        }

        private void frmMap_Load(object sender, EventArgs e)
        {
            // Inicializar el primer temporizador
            Mapas();
            timerGps = new Timer();
            timerGps.Interval = 2000; // 6 segundos
            timerGps.Tick += timerGps_Tick;
            timerGps.Start();



            gMapControl1.MinZoom = 0;
            gMapControl1.MaxZoom = 24;
            gMapControl1.Zoom = 9;
            gMapControl1.AutoScroll = true;

            lblRefri.Text = NuserieSeleccionado.ToString();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.Close();
        }
        private MySqlConnection Conexion;
        public static double lat;
        public static double lon;
        public void Mapas()
        {
            try
            {
                Conexion = new MySqlConnection("server=localhost;user=root;password=;database=geo;");
                var Consultar = new MySqlCommand(string.Format("Select latitud, longitud From gps Where idgps = '{0}'", IdrefriSeleccionado), Conexion);
                //string Consultar = ("EXEC MostrarCaliUser");
                Conexion.Open();
                MySqlDataReader reader2 = Consultar.ExecuteReader();
                if (reader2.Read())
                {
                    double LatInicial = double.Parse(reader2["latitud"].ToString());
                    double LngInicial = double.Parse(reader2["longitud"].ToString());
                    
                    gMapControl1.DragButton = MouseButtons.Left;
                    gMapControl1.CanDragMap = true;
                    gMapControl1.MapProvider = GMapProviders.GoogleMap;
                    gMapControl1.Position = new PointLatLng(LatInicial, LngInicial);


                    //Marcadores

                    markerOverlay = new GMapOverlay("Marcador");
                    marker = new GMarkerGoogle(new PointLatLng(LatInicial, LngInicial), GMarkerGoogleType.green);
                    markerOverlay.Markers.Add(marker);//Agregar primer marcador

                    //Agregamos un tooltip de texto a los marcadores
                    marker.ToolTipMode = MarkerTooltipMode.Always;
                    marker.ToolTipText = string.Format("Ubicacion: \n Latitud:{0} \n Longitud: {1}", LatInicial, LngInicial);

                    //Agregamos el mapa y el marcador al map control
                    gMapControl1.Overlays.Add(markerOverlay);


                }

                Conexion.Close();
            }
            catch (Exception ex)
            {
                Conexion?.Close();
            }
        }

        private void timerGps_Tick(object sender, EventArgs e)
        {
            markerOverlay.Markers.Remove(marker);
            gMapControl1.Overlays.Remove(markerOverlay);
            Mapas();
        }
    }
}
