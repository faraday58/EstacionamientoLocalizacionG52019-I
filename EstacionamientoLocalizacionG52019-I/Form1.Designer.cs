﻿namespace EstacionamientoLocalizacionG52019_I
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
            this.gmcPosicionEstacionamiento = new GMap.NET.WindowsForms.GMapControl();
            this.label1 = new System.Windows.Forms.Label();
            this.txtbNombre = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.txtbDireccion = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.txtbLatitud = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.txtbLongitud = new System.Windows.Forms.TextBox();
            this.lstbNombre = new System.Windows.Forms.ListBox();
            this.btnAgregar = new System.Windows.Forms.Button();
            this.btnEliminar = new System.Windows.Forms.Button();
            this.contMenuLista = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.ControlDeLista = new System.Windows.Forms.ToolStripMenuItem();
            this.buscarToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.contMenuLista.SuspendLayout();
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
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(492, 42);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(44, 13);
            this.label1.TabIndex = 1;
            this.label1.Text = "Nombre";
            // 
            // txtbNombre
            // 
            this.txtbNombre.Location = new System.Drawing.Point(557, 39);
            this.txtbNombre.Name = "txtbNombre";
            this.txtbNombre.Size = new System.Drawing.Size(100, 20);
            this.txtbNombre.TabIndex = 2;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(492, 89);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(52, 13);
            this.label2.TabIndex = 1;
            this.label2.Text = "Dirección";
            // 
            // txtbDireccion
            // 
            this.txtbDireccion.Location = new System.Drawing.Point(557, 82);
            this.txtbDireccion.Name = "txtbDireccion";
            this.txtbDireccion.Size = new System.Drawing.Size(100, 20);
            this.txtbDireccion.TabIndex = 2;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(497, 127);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(39, 13);
            this.label3.TabIndex = 1;
            this.label3.Text = "Latitud";
            // 
            // txtbLatitud
            // 
            this.txtbLatitud.Location = new System.Drawing.Point(557, 120);
            this.txtbLatitud.Name = "txtbLatitud";
            this.txtbLatitud.Size = new System.Drawing.Size(100, 20);
            this.txtbLatitud.TabIndex = 2;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(492, 170);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(48, 13);
            this.label4.TabIndex = 1;
            this.label4.Text = "Longitud";
            // 
            // txtbLongitud
            // 
            this.txtbLongitud.Location = new System.Drawing.Point(557, 167);
            this.txtbLongitud.Name = "txtbLongitud";
            this.txtbLongitud.Size = new System.Drawing.Size(100, 20);
            this.txtbLongitud.TabIndex = 2;
            // 
            // lstbNombre
            // 
            this.lstbNombre.ContextMenuStrip = this.contMenuLista;
            this.lstbNombre.FormattingEnabled = true;
            this.lstbNombre.Location = new System.Drawing.Point(557, 217);
            this.lstbNombre.Name = "lstbNombre";
            this.lstbNombre.Size = new System.Drawing.Size(102, 173);
            this.lstbNombre.TabIndex = 3;
            // 
            // btnAgregar
            // 
            this.btnAgregar.Location = new System.Drawing.Point(669, 63);
            this.btnAgregar.Name = "btnAgregar";
            this.btnAgregar.Size = new System.Drawing.Size(90, 27);
            this.btnAgregar.TabIndex = 4;
            this.btnAgregar.Text = "Agregar";
            this.btnAgregar.UseVisualStyleBackColor = true;
            this.btnAgregar.Click += new System.EventHandler(this.btnAgregar_Click);
            // 
            // btnEliminar
            // 
            this.btnEliminar.Location = new System.Drawing.Point(669, 113);
            this.btnEliminar.Name = "btnEliminar";
            this.btnEliminar.Size = new System.Drawing.Size(90, 27);
            this.btnEliminar.TabIndex = 4;
            this.btnEliminar.Text = "Eliminar";
            this.btnEliminar.UseVisualStyleBackColor = true;
            this.btnEliminar.Click += new System.EventHandler(this.btnEliminar_Click);
            // 
            // contMenuLista
            // 
            this.contMenuLista.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.ControlDeLista,
            this.buscarToolStripMenuItem});
            this.contMenuLista.Name = "contMenuLista";
            this.contMenuLista.Size = new System.Drawing.Size(118, 48);
            // 
            // ControlDeLista
            // 
            this.ControlDeLista.Name = "ControlDeLista";
            this.ControlDeLista.Size = new System.Drawing.Size(117, 22);
            this.ControlDeLista.Text = "Ordenar";
            // 
            // buscarToolStripMenuItem
            // 
            this.buscarToolStripMenuItem.Name = "buscarToolStripMenuItem";
            this.buscarToolStripMenuItem.Size = new System.Drawing.Size(117, 22);
            this.buscarToolStripMenuItem.Text = "Buscar";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.btnEliminar);
            this.Controls.Add(this.btnAgregar);
            this.Controls.Add(this.lstbNombre);
            this.Controls.Add(this.txtbLongitud);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.txtbLatitud);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.txtbDireccion);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.txtbNombre);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.gmcPosicionEstacionamiento);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.contMenuLista.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private GMap.NET.WindowsForms.GMapControl gmcPosicionEstacionamiento;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtbNombre;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txtbDireccion;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox txtbLatitud;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox txtbLongitud;
        private System.Windows.Forms.ListBox lstbNombre;
        private System.Windows.Forms.Button btnAgregar;
        private System.Windows.Forms.Button btnEliminar;
        private System.Windows.Forms.ContextMenuStrip contMenuLista;
        private System.Windows.Forms.ToolStripMenuItem ControlDeLista;
        private System.Windows.Forms.ToolStripMenuItem buscarToolStripMenuItem;
    }
}

