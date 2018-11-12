using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Windows.Forms;
using System.IO;
using System.IO.Ports;


namespace ControlEstacionamiento
{
    public partial class ControlGeneral : Form
    {
        SerialPort puertoserial;

        public ControlGeneral()
        {
            InitializeComponent();
            puertoserial = new SerialPort();
            selecciona();
        }

        public void selecciona()
        {
            string[] puertos = SerialPort.GetPortNames();
            Array.Sort(puertos);
            tscmbPuertos.Items.AddRange(puertos);
        }

        private void verificarToolStripMenuItem_Click(object sender, EventArgs e)
        {
            try
            {
                puertoserial.BaudRate =int.Parse( tscmbVelocidad.SelectedItem.ToString());
                puertoserial.PortName = tscmbPuertos.SelectedItem.ToString();

            }
            catch(IOException error)
            {
                MessageBox.Show("Error: " + error.Message);
            }
        }

        private void conectarToolStripMenuItem_Click(object sender, EventArgs e)
        {
            try
            {
                puertoserial.Open();
            }
            catch(IOException error)
            {
                MessageBox.Show("Error: " + error.Message);
            }
        }

        private void encenderLuzToolStripMenuItem_Click(object sender, EventArgs e)
        {
            try
            {
                ControlLuz controlLuz = new ControlLuz(puertoserial, this);
                controlLuz.Show();
            }
            catch(IOException error)
            {
                MessageBox.Show("Error " + error.Message);
            }
            
        }

        private void monitorTemperaturaToolStripMenuItem_Click(object sender, EventArgs e)
        {
            MonitorTemperatura monitor = new MonitorTemperatura(puertoserial, this);
            monitor.Show();
        }
    }
}
