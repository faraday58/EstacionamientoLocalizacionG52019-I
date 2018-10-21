namespace ControlEstacionamiento
{
    partial class Form1
    {
        /// <summary>
        /// Variable del diseñador necesaria.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Limpiar los recursos que se estén usando.
        /// </summary>
        /// <param name="disposing">true si los recursos administrados se deben desechar; false en caso contrario.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Código generado por el Diseñador de Windows Forms

        /// <summary>
        /// Método necesario para admitir el Diseñador. No se puede modificar
        /// el contenido de este método con el editor de código.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            this.ptbVehiculo = new System.Windows.Forms.PictureBox();
            this.dgvVehiculos = new System.Windows.Forms.DataGridView();
            this.columnaPlacas = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.columnaHoraEntrada = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.columnaHoraSalida = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.columnaDetalles = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.tiempoEstacionamiento = new System.Windows.Forms.Timer(this.components);
            this.lbTiempo = new System.Windows.Forms.Label();
            this.errorProv1 = new System.Windows.Forms.ErrorProvider(this.components);
            this.panelCroquis = new System.Windows.Forms.Panel();
            ((System.ComponentModel.ISupportInitialize)(this.ptbVehiculo)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvVehiculos)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.errorProv1)).BeginInit();
            this.SuspendLayout();
            // 
            // ptbVehiculo
            // 
            this.ptbVehiculo.Image = global::ControlEstacionamiento.Properties.Resources.coche3;
            this.ptbVehiculo.Location = new System.Drawing.Point(12, 57);
            this.ptbVehiculo.Name = "ptbVehiculo";
            this.ptbVehiculo.Size = new System.Drawing.Size(61, 35);
            this.ptbVehiculo.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.ptbVehiculo.TabIndex = 0;
            this.ptbVehiculo.TabStop = false;
            // 
            // dgvVehiculos
            // 
            this.dgvVehiculos.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvVehiculos.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.columnaPlacas,
            this.columnaHoraEntrada,
            this.columnaHoraSalida,
            this.columnaDetalles});
            this.dgvVehiculos.Location = new System.Drawing.Point(427, 123);
            this.dgvVehiculos.Name = "dgvVehiculos";
            this.dgvVehiculos.Size = new System.Drawing.Size(443, 150);
            this.dgvVehiculos.StandardTab = true;
            this.dgvVehiculos.TabIndex = 10;
            this.dgvVehiculos.RowHeaderMouseDoubleClick += new System.Windows.Forms.DataGridViewCellMouseEventHandler(this.dgvVehiculos_RowHeaderMouseDoubleClick);
            // 
            // columnaPlacas
            // 
            this.columnaPlacas.Frozen = true;
            this.columnaPlacas.HeaderText = "Placas";
            this.columnaPlacas.Name = "columnaPlacas";
            // 
            // columnaHoraEntrada
            // 
            this.columnaHoraEntrada.Frozen = true;
            this.columnaHoraEntrada.HeaderText = "HoraEntrada";
            this.columnaHoraEntrada.Name = "columnaHoraEntrada";
            // 
            // columnaHoraSalida
            // 
            this.columnaHoraSalida.Frozen = true;
            this.columnaHoraSalida.HeaderText = "HoraSalida";
            this.columnaHoraSalida.Name = "columnaHoraSalida";
            // 
            // columnaDetalles
            // 
            this.columnaDetalles.Frozen = true;
            this.columnaDetalles.HeaderText = "Detalles";
            this.columnaDetalles.Name = "columnaDetalles";
            // 
            // tiempoEstacionamiento
            // 
            this.tiempoEstacionamiento.Interval = 1000;
            this.tiempoEstacionamiento.Tick += new System.EventHandler(this.tiempoEstacionamiento_Tick);
            // 
            // lbTiempo
            // 
            this.lbTiempo.AutoSize = true;
            this.lbTiempo.Location = new System.Drawing.Point(570, 57);
            this.lbTiempo.Name = "lbTiempo";
            this.lbTiempo.Size = new System.Drawing.Size(35, 13);
            this.lbTiempo.TabIndex = 2;
            this.lbTiempo.Text = "label1";
            // 
            // errorProv1
            // 
            this.errorProv1.ContainerControl = this;
            // 
            // panelCroquis
            // 
            this.panelCroquis.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.panelCroquis.ForeColor = System.Drawing.Color.Maroon;
            this.panelCroquis.Location = new System.Drawing.Point(79, 27);
            this.panelCroquis.Name = "panelCroquis";
            this.panelCroquis.Size = new System.Drawing.Size(298, 231);
            this.panelCroquis.TabIndex = 1;
            this.panelCroquis.TabStop = true;
            this.panelCroquis.PreviewKeyDown += new System.Windows.Forms.PreviewKeyDownEventHandler(this.panelCroquis_PreviewKeyDown);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(913, 296);
            this.Controls.Add(this.ptbVehiculo);
            this.Controls.Add(this.panelCroquis);
            this.Controls.Add(this.lbTiempo);
            this.Controls.Add(this.dgvVehiculos);
            this.Name = "Form1";
            this.Text = "Form1";
            ((System.ComponentModel.ISupportInitialize)(this.ptbVehiculo)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvVehiculos)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.errorProv1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox ptbVehiculo;
        private System.Windows.Forms.DataGridView dgvVehiculos;
        private System.Windows.Forms.DataGridViewTextBoxColumn columnaPlacas;
        private System.Windows.Forms.DataGridViewTextBoxColumn columnaHoraEntrada;
        private System.Windows.Forms.DataGridViewTextBoxColumn columnaHoraSalida;
        private System.Windows.Forms.DataGridViewTextBoxColumn columnaDetalles;
        private System.Windows.Forms.Timer tiempoEstacionamiento;
        private System.Windows.Forms.Label lbTiempo;
        private System.Windows.Forms.ErrorProvider errorProv1;
        private System.Windows.Forms.Panel panelCroquis;
    }
}

