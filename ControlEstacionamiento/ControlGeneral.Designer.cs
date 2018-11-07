namespace ControlEstacionamiento
{
    partial class ControlGeneral
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.archivoToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.abrirToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.guardarToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.salirToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.conexiónToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.velocidadToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.puertosToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.verificarToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripMenuItem1 = new System.Windows.Forms.ToolStripSeparator();
            this.conectarToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.desconectarToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.tscmbVelocidad = new System.Windows.Forms.ToolStripComboBox();
            this.tscmbPuertos = new System.Windows.Forms.ToolStripComboBox();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // menuStrip1
            // 
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.archivoToolStripMenuItem,
            this.conexiónToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(751, 24);
            this.menuStrip1.TabIndex = 0;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // archivoToolStripMenuItem
            // 
            this.archivoToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.abrirToolStripMenuItem,
            this.guardarToolStripMenuItem,
            this.salirToolStripMenuItem});
            this.archivoToolStripMenuItem.Name = "archivoToolStripMenuItem";
            this.archivoToolStripMenuItem.Size = new System.Drawing.Size(60, 20);
            this.archivoToolStripMenuItem.Text = "Archivo";
            // 
            // abrirToolStripMenuItem
            // 
            this.abrirToolStripMenuItem.Name = "abrirToolStripMenuItem";
            this.abrirToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.abrirToolStripMenuItem.Text = "Abrir";
            // 
            // guardarToolStripMenuItem
            // 
            this.guardarToolStripMenuItem.Name = "guardarToolStripMenuItem";
            this.guardarToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.guardarToolStripMenuItem.Text = "Guardar";
            // 
            // salirToolStripMenuItem
            // 
            this.salirToolStripMenuItem.Name = "salirToolStripMenuItem";
            this.salirToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.salirToolStripMenuItem.Text = "Salir";
            // 
            // conexiónToolStripMenuItem
            // 
            this.conexiónToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.velocidadToolStripMenuItem,
            this.puertosToolStripMenuItem,
            this.verificarToolStripMenuItem,
            this.toolStripMenuItem1,
            this.conectarToolStripMenuItem,
            this.desconectarToolStripMenuItem});
            this.conexiónToolStripMenuItem.Name = "conexiónToolStripMenuItem";
            this.conexiónToolStripMenuItem.Size = new System.Drawing.Size(69, 20);
            this.conexiónToolStripMenuItem.Text = "Conexión";
            // 
            // velocidadToolStripMenuItem
            // 
            this.velocidadToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.tscmbVelocidad});
            this.velocidadToolStripMenuItem.Name = "velocidadToolStripMenuItem";
            this.velocidadToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.velocidadToolStripMenuItem.Text = "Velocidad";
            // 
            // puertosToolStripMenuItem
            // 
            this.puertosToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.tscmbPuertos});
            this.puertosToolStripMenuItem.Name = "puertosToolStripMenuItem";
            this.puertosToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.puertosToolStripMenuItem.Text = "Puertos";
            // 
            // verificarToolStripMenuItem
            // 
            this.verificarToolStripMenuItem.Name = "verificarToolStripMenuItem";
            this.verificarToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.verificarToolStripMenuItem.Text = "Verificar";
            this.verificarToolStripMenuItem.Click += new System.EventHandler(this.verificarToolStripMenuItem_Click);
            // 
            // toolStripMenuItem1
            // 
            this.toolStripMenuItem1.Name = "toolStripMenuItem1";
            this.toolStripMenuItem1.Size = new System.Drawing.Size(177, 6);
            // 
            // conectarToolStripMenuItem
            // 
            this.conectarToolStripMenuItem.Name = "conectarToolStripMenuItem";
            this.conectarToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.conectarToolStripMenuItem.Text = "Conectar";
            this.conectarToolStripMenuItem.Click += new System.EventHandler(this.conectarToolStripMenuItem_Click);
            // 
            // desconectarToolStripMenuItem
            // 
            this.desconectarToolStripMenuItem.Name = "desconectarToolStripMenuItem";
            this.desconectarToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.desconectarToolStripMenuItem.Text = "Desconectar";
            // 
            // tscmbVelocidad
            // 
            this.tscmbVelocidad.Items.AddRange(new object[] {
            "2400",
            "4800",
            "9600",
            "19200",
            "38400"});
            this.tscmbVelocidad.Name = "tscmbVelocidad";
            this.tscmbVelocidad.Size = new System.Drawing.Size(121, 23);
            // 
            // tscmbPuertos
            // 
            this.tscmbPuertos.Name = "tscmbPuertos";
            this.tscmbPuertos.Size = new System.Drawing.Size(121, 23);
            // 
            // ControlGeneral
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(751, 252);
            this.Controls.Add(this.menuStrip1);
            this.IsMdiContainer = true;
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "ControlGeneral";
            this.Text = "ControlGeneral";
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem archivoToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem abrirToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem guardarToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem salirToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem conexiónToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem velocidadToolStripMenuItem;
        private System.Windows.Forms.ToolStripComboBox tscmbVelocidad;
        private System.Windows.Forms.ToolStripMenuItem puertosToolStripMenuItem;
        private System.Windows.Forms.ToolStripComboBox tscmbPuertos;
        private System.Windows.Forms.ToolStripMenuItem verificarToolStripMenuItem;
        private System.Windows.Forms.ToolStripSeparator toolStripMenuItem1;
        private System.Windows.Forms.ToolStripMenuItem conectarToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem desconectarToolStripMenuItem;
    }
}