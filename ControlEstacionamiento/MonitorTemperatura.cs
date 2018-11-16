using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Windows.Forms;
using System.IO;
using System.IO.Ports;
using iTextSharp.text;
using iTextSharp.text.pdf;

namespace ControlEstacionamiento
{
    public partial class MonitorTemperatura : Form
    {

        SerialPort serialPort;
        byte temperatura;
        int tiempo;

        public MonitorTemperatura(SerialPort serialPort, ControlGeneral controlGeneral)
        {
            InitializeComponent();
            this.serialPort = serialPort;
            this.MdiParent = controlGeneral;
            controlGeneral.guardarToolStripMenuItem.Click += new System.EventHandler(this.guardarToolStripMenuItem_Click);
        }
        private void guardarToolStripMenuItem_Click(object sender, EventArgs e)
        {
            
        }
        private void timerTemperatura_Tick(object sender, EventArgs e)
        {
            temperatura =(byte)serialPort.ReadByte();
            chtGrafica.Series[0].Points.AddXY(tiempo++, temperatura);

        }

        private void graficarToolStripMenuItem_Click(object sender, EventArgs e)
        {
            timerTemperatura.Start();
        }

        private void detenerToolStripMenuItem_Click(object sender, EventArgs e)
        {
            timerTemperatura.Stop();
        }
    }
}
