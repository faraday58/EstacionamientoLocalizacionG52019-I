namespace ControlEstacionamiento
{
    partial class ControlLuz
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
            this.btnPrendeApaga = new System.Windows.Forms.Button();
            this.ptbFoco = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.ptbFoco)).BeginInit();
            this.SuspendLayout();
            // 
            // btnPrendeApaga
            // 
            this.btnPrendeApaga.Location = new System.Drawing.Point(205, 54);
            this.btnPrendeApaga.Name = "btnPrendeApaga";
            this.btnPrendeApaga.Size = new System.Drawing.Size(79, 58);
            this.btnPrendeApaga.TabIndex = 1;
            this.btnPrendeApaga.Text = "On/Off";
            this.btnPrendeApaga.UseVisualStyleBackColor = true;
            this.btnPrendeApaga.Click += new System.EventHandler(this.btnPrendeApaga_Click);
            // 
            // ptbFoco
            // 
            this.ptbFoco.Image = global::ControlEstacionamiento.Properties.Resources.foco;
            this.ptbFoco.Location = new System.Drawing.Point(35, 34);
            this.ptbFoco.Name = "ptbFoco";
            this.ptbFoco.Size = new System.Drawing.Size(103, 98);
            this.ptbFoco.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.ptbFoco.TabIndex = 0;
            this.ptbFoco.TabStop = false;
            // 
            // ControlLuz
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(410, 222);
            this.Controls.Add(this.btnPrendeApaga);
            this.Controls.Add(this.ptbFoco);
            this.Name = "ControlLuz";
            this.Text = "ControlLuz";
            ((System.ComponentModel.ISupportInitialize)(this.ptbFoco)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.PictureBox ptbFoco;
        private System.Windows.Forms.Button btnPrendeApaga;
    }
}