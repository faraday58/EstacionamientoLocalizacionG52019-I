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
            this.ptbCajones = new System.Windows.Forms.PictureBox();
            this.dgvVehiculos = new System.Windows.Forms.DataGridView();
            this.columnaPlacas = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.columnaHoraEntrada = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.columnaHoraSalida = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.columnaDetalles = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.ptbCajones)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvVehiculos)).BeginInit();
            this.SuspendLayout();
            // 
            // ptbCajones
            // 
            this.ptbCajones.Location = new System.Drawing.Point(37, 32);
            this.ptbCajones.Name = "ptbCajones";
            this.ptbCajones.Size = new System.Drawing.Size(333, 325);
            this.ptbCajones.TabIndex = 0;
            this.ptbCajones.TabStop = false;
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
            this.dgvVehiculos.TabIndex = 1;
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
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(913, 450);
            this.Controls.Add(this.dgvVehiculos);
            this.Controls.Add(this.ptbCajones);
            this.Name = "Form1";
            this.Text = "Form1";
            ((System.ComponentModel.ISupportInitialize)(this.ptbCajones)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvVehiculos)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.PictureBox ptbCajones;
        private System.Windows.Forms.DataGridView dgvVehiculos;
        private System.Windows.Forms.DataGridViewTextBoxColumn columnaPlacas;
        private System.Windows.Forms.DataGridViewTextBoxColumn columnaHoraEntrada;
        private System.Windows.Forms.DataGridViewTextBoxColumn columnaHoraSalida;
        private System.Windows.Forms.DataGridViewTextBoxColumn columnaDetalles;
        private System.Windows.Forms.Timer timer1;
    }
}

