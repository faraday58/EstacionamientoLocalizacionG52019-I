using System;
using System.ComponentModel;
using System.Drawing;
using System.Windows.Forms;
using System.IO.Ports;
namespace ControlEstacionamiento
{
    public partial class ControlLuz : Form
    {
        SerialPort puertoserial;
        bool boton = false;
        public ControlLuz(SerialPort puertoserial, ControlGeneral control)
        {
            InitializeComponent();
            this.puertoserial = puertoserial;
            this.MdiParent = control;
        }

        private void btnPrendeApaga_Click(object sender, EventArgs e)
        {
            if( !boton)
            {
                puertoserial.Write("e");
                ptbFoco.BackColor = Color.Yellow;
                boton = true;
            }
            else
            {
                puertoserial.Write("a");
                ptbFoco.BackColor = Color.Black;
                boton = false;
            }

        }
    }
}
