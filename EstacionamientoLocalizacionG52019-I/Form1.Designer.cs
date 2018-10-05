namespace EstacionamientoLocalizacionG52019_I
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
            this.gmcPosicionEstacionamiento = new GMap.NET.WindowsForms.GMapControl();
            this.SuspendLayout();
            // 
            // gmcPosicionEstacionamiento
            // 
            this.gmcPosicionEstacionamiento.Bearing = 0F;
            this.gmcPosicionEstacionamiento.CanDragMap = true;
            this.gmcPosicionEstacionamiento.EmptyTileColor = System.Drawing.Color.Navy;
            this.gmcPosicionEstacionamiento.GrayScaleMode = false;
            this.gmcPosicionEstacionamiento.HelperLineOption = GMap.NET.WindowsForms.HelperLineOptions.DontShow;
            this.gmcPosicionEstacionamiento.LevelsKeepInMemmory = 5;
            this.gmcPosicionEstacionamiento.Location = new System.Drawing.Point(37, 35);
            this.gmcPosicionEstacionamiento.MarkersEnabled = true;
            this.gmcPosicionEstacionamiento.MaxZoom = 2;
            this.gmcPosicionEstacionamiento.MinZoom = 2;
            this.gmcPosicionEstacionamiento.MouseWheelZoomEnabled = true;
            this.gmcPosicionEstacionamiento.MouseWheelZoomType = GMap.NET.MouseWheelZoomType.MousePositionAndCenter;
            this.gmcPosicionEstacionamiento.Name = "gmcPosicionEstacionamiento";
            this.gmcPosicionEstacionamiento.NegativeMode = false;
            this.gmcPosicionEstacionamiento.PolygonsEnabled = true;
            this.gmcPosicionEstacionamiento.RetryLoadTile = 0;
            this.gmcPosicionEstacionamiento.RoutesEnabled = true;
            this.gmcPosicionEstacionamiento.ScaleMode = GMap.NET.WindowsForms.ScaleModes.Integer;
            this.gmcPosicionEstacionamiento.SelectedAreaFillColor = System.Drawing.Color.FromArgb(((int)(((byte)(33)))), ((int)(((byte)(65)))), ((int)(((byte)(105)))), ((int)(((byte)(225)))));
            this.gmcPosicionEstacionamiento.ShowTileGridLines = false;
            this.gmcPosicionEstacionamiento.Size = new System.Drawing.Size(421, 315);
            this.gmcPosicionEstacionamiento.TabIndex = 0;
            this.gmcPosicionEstacionamiento.Zoom = 0D;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.gmcPosicionEstacionamiento);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);

        }

        #endregion

        private GMap.NET.WindowsForms.GMapControl gmcPosicionEstacionamiento;
    }
}

