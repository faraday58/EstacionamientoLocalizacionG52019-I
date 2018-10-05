using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Windows.Forms;
using GMap.NET;
using GMap.NET.MapProviders;
using GMap.NET.WindowsForms;
using GMap.NET.WindowsForms.Markers;
using Estacionamientos;

namespace EstacionamientoLocalizacionG52019_I
{
    public partial class Form1 : Form
    {

        List<Estacionamiento> lstEstacionamientos;
        double LatInicial = 19.3188;
        double LongInicial = -99.1843;

        public Form1()
        {
            InitializeComponent();
            lstEstacionamientos = new List<Estacionamiento>();
            lstEstacionamientos.Add(new Estacionamiento("Estadio","Estacionamiento 8",19.330702,-99.190209));
            lstEstacionamientos.Add(new Estacionamiento("Estadio", "Estacionamiento 1", 19.333749, -99.190605));
            lstEstacionamientos.Add(new Estacionamiento("Estadio", "Estacionamiento 2", 19.334037, -99.192527));

        }

        private void Form1_Load(object sender, EventArgs e)

        {
            for (int i = 0; i <lstEstacionamientos.Count; i++ )
            {
                lstbNombre.Items.Add(lstEstacionamientos[i].Nombre);
            }
            gmcPosicionEstacionamiento.DragButton = MouseButtons.Left;
            gmcPosicionEstacionamiento.CanDragMap = true;
            gmcPosicionEstacionamiento.MapProvider = GMapProviders.GoogleMap;
            gmcPosicionEstacionamiento.Position = new GMap.NET.PointLatLng(LatInicial, LongInicial);
            gmcPosicionEstacionamiento.MinZoom = 0;
            gmcPosicionEstacionamiento.MaxZoom = 24;
            gmcPosicionEstacionamiento.Zoom = 9;
            gmcPosicionEstacionamiento.AutoScroll = true;
        }

        private void btnAgregar_Click(object sender, EventArgs e)
        {
            lstEstacionamientos.Add(new Estacionamiento(txtbNombre.Text, txtbDireccion.Text, double.Parse(txtbLatitud.Text), double.Parse(txtbLongitud.Text)));
            lstbNombre.Items.Add(lstEstacionamientos[lstEstacionamientos.Count - 1].Nombre);
        }

        private void btnEliminar_Click(object sender, EventArgs e)
        {
            lstEstacionamientos.RemoveAt(lstbNombre.SelectedIndex);
            lstbNombre.Items.RemoveAt(lstbNombre.SelectedIndex);
        }
    }
}
