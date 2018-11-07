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

        }
    }
}
