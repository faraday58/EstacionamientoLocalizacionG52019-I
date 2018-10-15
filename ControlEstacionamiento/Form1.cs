using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Windows.Forms;
using Vehiculos;

namespace ControlEstacionamiento
{
    public partial class Form1 : Form
    {
        Queue<Vehiculo> filaVehiculos;
        Vehiculo vehiculo;
        public Form1()
        {
            InitializeComponent();

            filaVehiculos = new Queue<Vehiculo>();
        }

        private void dgvVehiculos_RowHeaderMouseDoubleClick(object sender, DataGridViewCellMouseEventArgs e)
        {
            string placas = dgvVehiculos.Rows[e.RowIndex].Cells[0].Value.ToString();
            string horaEntrada = dgvVehiculos.Rows[e.RowIndex].Cells[1].Value.ToString();
            string horaSalida = dgvVehiculos.Rows[e.RowIndex].Cells[2].Value.ToString();
            string detalles = dgvVehiculos.Rows[e.RowIndex].Cells[3].Value.ToString();
            vehiculo = new Vehiculo(placas, horaEntrada, horaSalida, detalles);

            filaVehiculos.Enqueue(vehiculo);

            MessageBox.Show("EL CLIENTE SE HA AGREGADO");
        }
    }
}
