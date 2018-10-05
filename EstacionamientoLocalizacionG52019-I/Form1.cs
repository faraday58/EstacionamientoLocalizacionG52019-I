using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using GMap.NET;
using GMap.NET.MapProviders;
using GMap.NET.WindowsForms;
using GMap.NET.WindowsForms.Markers;

namespace EstacionamientoLocalizacionG52019_I
{
    public partial class Form1 : Form
    {


        double LatInicial = 19.3188;
        double LongInicial = -99.1843;

        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)

        {
            gmcPosicionEstacionamiento.DragButton = MouseButtons.Left;
            gmcPosicionEstacionamiento.CanDragMap = true;
            gmcPosicionEstacionamiento.MapProvider = GMapProviders.GoogleMap;
            gmcPosicionEstacionamiento.Position = new GMap.NET.PointLatLng(LatInicial, LongInicial);
            gmcPosicionEstacionamiento.MinZoom = 0;
            gmcPosicionEstacionamiento.MaxZoom = 24;
            gmcPosicionEstacionamiento.Zoom = 9;
            gmcPosicionEstacionamiento.AutoScroll = true;
        }
    }
}
