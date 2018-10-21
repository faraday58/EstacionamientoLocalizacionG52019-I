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
        byte imagen;
        public Form1()
        {
            InitializeComponent();

            filaVehiculos = new Queue<Vehiculo>();
        }

        private void dgvVehiculos_RowHeaderMouseDoubleClick(object sender, DataGridViewCellMouseEventArgs e)
        {
            try
            {
                string placas = dgvVehiculos.Rows[e.RowIndex].Cells[0].Value.ToString();
                string horaEntrada = dgvVehiculos.Rows[e.RowIndex].Cells[1].Value.ToString();
                string horaSalida = dgvVehiculos.Rows[e.RowIndex].Cells[2].Value.ToString();
                string detalles = dgvVehiculos.Rows[e.RowIndex].Cells[3].Value.ToString();
                
                vehiculo = new Vehiculo(placas, horaEntrada, horaSalida, detalles);

                filaVehiculos.Enqueue(vehiculo);

                MessageBox.Show("EL CLIENTE SE HA AGREGADO");
                errorProv1.Clear();
                tiempoEstacionamiento.Start();
                Random random = new Random();
                imagen = (byte)random.Next(1, 4);

               
                switch ( imagen )
                {
                    case 1:
                        ptbVehiculo.Image = global::ControlEstacionamiento.Properties.Resources.coche1;
                        break;
                    case 2:
                        ptbVehiculo.Image = global::ControlEstacionamiento.Properties.Resources.coche2;
                        break;
                    case 3:
                        ptbVehiculo.Image = global::ControlEstacionamiento.Properties.Resources.coche3;
                        break;
                }

                do
                {
                    ptbVehiculo.Location = new Point(ptbVehiculo.Location.X + 1, ptbVehiculo.Location.Y);
                    Refresh();
                } while (ptbVehiculo.Location.X < 82);
                

            }
            catch(ApplicationException error)
            {
                errorProv1.SetError(dgvVehiculos, error.Message);
            }
            catch(FormatException error)
            {
                errorProv1.SetError(dgvVehiculos, error.Message);
            }
            catch(NullReferenceException error)
            {
                errorProv1.SetError(dgvVehiculos, error.Message);
            }
            
        }
        int i = 0;
        int aux = 0;
        private void tiempoEstacionamiento_Tick(object sender, EventArgs e)
        {
            i++;
            lbTiempo.Text = i.ToString() + " s";
            if( i > 5 )
            {
                if (filaVehiculos.Count > 0)
                {
                    if (aux < dgvVehiculos.Rows.Count)
                    {
                        vehiculo = filaVehiculos.Dequeue();
                        if (dgvVehiculos.Rows[aux].Cells[0].Value.ToString() == vehiculo.Placas)
                        {
                            dgvVehiculos.Rows[aux++].Selected = true;
                        }
                    }

                }
                else
                {
                    tiempoEstacionamiento.Stop();
                    panelCroquis.Focus();
                }
                
                
                

                               

            }

        }

        

        private void panelCroquis_PreviewKeyDown(object sender, PreviewKeyDownEventArgs e)
        {
            dgvVehiculos.Enabled = false;
           
           
            if (ptbVehiculo.Location.X >= 82)
            {
                if (e.KeyCode == Keys.Down)
                {
                    panelCroquis.Focus();
                    ptbVehiculo.Location = new Point(ptbVehiculo.Location.X, ptbVehiculo.Location.Y + 1);
                    
                }
                if (e.KeyCode == Keys.Up)
                {
                    panelCroquis.Focus();
                    ptbVehiculo.Location = new Point(ptbVehiculo.Location.X, ptbVehiculo.Location.Y - 1);
                    
                }
                if (e.KeyCode == Keys.Right)
                {
                    panelCroquis.Focus();
                    ptbVehiculo.Location = new Point(ptbVehiculo.Location.X + 1, ptbVehiculo.Location.Y);
                    
                }
                if (e.KeyCode == Keys.Left)
                {
                    panelCroquis.Focus();
                    ptbVehiculo.Location = new Point(ptbVehiculo.Location.X - 1, ptbVehiculo.Location.Y);
                    
                }
            }

        }
    }
}
