namespace UI.Administracion
{
    partial class InfoReservas
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(InfoReservas));
            this.btnRoles = new System.Windows.Forms.Button();
            this.panelControl = new System.Windows.Forms.Panel();
            this.ImagenFondo = new System.Windows.Forms.PictureBox();
            this.panel4 = new System.Windows.Forms.Panel();
            this.label4 = new System.Windows.Forms.Label();
            this.btnPersonal = new System.Windows.Forms.Button();
            this.btnReserva = new System.Windows.Forms.Button();
            this.btnInventario = new System.Windows.Forms.Button();
            this.panel3 = new System.Windows.Forms.Panel();
            this.panelControl.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.ImagenFondo)).BeginInit();
            this.panel4.SuspendLayout();
            this.SuspendLayout();
            // 
            // btnRoles
            // 
            this.btnRoles.BackColor = System.Drawing.Color.DarkMagenta;
            this.btnRoles.Cursor = System.Windows.Forms.Cursors.Arrow;
            this.btnRoles.FlatAppearance.BorderSize = 0;
            this.btnRoles.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnRoles.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnRoles.ForeColor = System.Drawing.Color.White;
            this.btnRoles.Location = new System.Drawing.Point(0, 214);
            this.btnRoles.Name = "btnRoles";
            this.btnRoles.Size = new System.Drawing.Size(203, 53);
            this.btnRoles.TabIndex = 18;
            this.btnRoles.Text = "Roles";
            this.btnRoles.UseVisualStyleBackColor = false;
            this.btnRoles.Click += new System.EventHandler(this.btnRoles_Click);
            // 
            // panelControl
            // 
            this.panelControl.Controls.Add(this.ImagenFondo);
            this.panelControl.Location = new System.Drawing.Point(206, 39);
            this.panelControl.Name = "panelControl";
            this.panelControl.Size = new System.Drawing.Size(1037, 590);
            this.panelControl.TabIndex = 19;
            // 
            // ImagenFondo
            // 
            this.ImagenFondo.Image = ((System.Drawing.Image)(resources.GetObject("ImagenFondo.Image")));
            this.ImagenFondo.Location = new System.Drawing.Point(-1, 3);
            this.ImagenFondo.Name = "ImagenFondo";
            this.ImagenFondo.Size = new System.Drawing.Size(1035, 571);
            this.ImagenFondo.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.ImagenFondo.TabIndex = 0;
            this.ImagenFondo.TabStop = false;
            // 
            // panel4
            // 
            this.panel4.BackColor = System.Drawing.Color.OrangeRed;
            this.panel4.Controls.Add(this.label4);
            this.panel4.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel4.Location = new System.Drawing.Point(0, 0);
            this.panel4.Margin = new System.Windows.Forms.Padding(6);
            this.panel4.Name = "panel4";
            this.panel4.Size = new System.Drawing.Size(1243, 38);
            this.panel4.TabIndex = 20;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Dock = System.Windows.Forms.DockStyle.Right;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.ForeColor = System.Drawing.Color.White;
            this.label4.Location = new System.Drawing.Point(1218, 0);
            this.label4.Margin = new System.Windows.Forms.Padding(6, 0, 6, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(25, 29);
            this.label4.TabIndex = 10;
            this.label4.Text = "x";
            this.label4.Click += new System.EventHandler(this.label4_Click);
            // 
            // btnPersonal
            // 
            this.btnPersonal.BackColor = System.Drawing.Color.DarkMagenta;
            this.btnPersonal.Cursor = System.Windows.Forms.Cursors.Arrow;
            this.btnPersonal.FlatAppearance.BorderSize = 0;
            this.btnPersonal.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnPersonal.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnPersonal.ForeColor = System.Drawing.Color.White;
            this.btnPersonal.Location = new System.Drawing.Point(0, 38);
            this.btnPersonal.Name = "btnPersonal";
            this.btnPersonal.Size = new System.Drawing.Size(203, 53);
            this.btnPersonal.TabIndex = 21;
            this.btnPersonal.Text = "Personal";
            this.btnPersonal.UseVisualStyleBackColor = false;
            this.btnPersonal.Click += new System.EventHandler(this.btnPersonal_Click);
            // 
            // btnReserva
            // 
            this.btnReserva.BackColor = System.Drawing.Color.DarkMagenta;
            this.btnReserva.Cursor = System.Windows.Forms.Cursors.Arrow;
            this.btnReserva.FlatAppearance.BorderSize = 0;
            this.btnReserva.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnReserva.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnReserva.ForeColor = System.Drawing.Color.White;
            this.btnReserva.Location = new System.Drawing.Point(0, 96);
            this.btnReserva.Name = "btnReserva";
            this.btnReserva.Size = new System.Drawing.Size(203, 53);
            this.btnReserva.TabIndex = 22;
            this.btnReserva.Text = "Reservas";
            this.btnReserva.UseVisualStyleBackColor = false;
            this.btnReserva.Click += new System.EventHandler(this.btnReserva_Click);
            // 
            // btnInventario
            // 
            this.btnInventario.BackColor = System.Drawing.Color.DarkMagenta;
            this.btnInventario.Cursor = System.Windows.Forms.Cursors.Arrow;
            this.btnInventario.FlatAppearance.BorderSize = 0;
            this.btnInventario.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnInventario.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnInventario.ForeColor = System.Drawing.Color.White;
            this.btnInventario.Location = new System.Drawing.Point(0, 155);
            this.btnInventario.Name = "btnInventario";
            this.btnInventario.Size = new System.Drawing.Size(203, 53);
            this.btnInventario.TabIndex = 23;
            this.btnInventario.Text = "Inventario";
            this.btnInventario.UseVisualStyleBackColor = false;
            this.btnInventario.Click += new System.EventHandler(this.btnInventario_Click);
            // 
            // panel3
            // 
            this.panel3.BackColor = System.Drawing.Color.OrangeRed;
            this.panel3.Location = new System.Drawing.Point(1, 33);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(202, 596);
            this.panel3.TabIndex = 24;
            // 
            // InfoReservas
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1243, 641);
            this.Controls.Add(this.btnInventario);
            this.Controls.Add(this.btnReserva);
            this.Controls.Add(this.btnPersonal);
            this.Controls.Add(this.panel4);
            this.Controls.Add(this.panelControl);
            this.Controls.Add(this.btnRoles);
            this.Controls.Add(this.panel3);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "InfoReservas";
            this.Text = "InfoReservas";
            this.Load += new System.EventHandler(this.InfoReservas_Load);
            this.panelControl.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.ImagenFondo)).EndInit();
            this.panel4.ResumeLayout(false);
            this.panel4.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.Button btnRoles;
        private System.Windows.Forms.Panel panelControl;
        private System.Windows.Forms.Panel panel4;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Button btnPersonal;
        private System.Windows.Forms.Button btnReserva;
        private System.Windows.Forms.Button btnInventario;
        private System.Windows.Forms.PictureBox ImagenFondo;
        private System.Windows.Forms.Panel panel3;
    }
}