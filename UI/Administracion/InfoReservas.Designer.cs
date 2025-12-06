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
            this.dtgInfoReservas = new System.Windows.Forms.DataGridView();
            this.button1 = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dtgInfoReservas)).BeginInit();
            this.SuspendLayout();
            // 
            // dtgInfoReservas
            // 
            this.dtgInfoReservas.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dtgInfoReservas.Location = new System.Drawing.Point(107, 40);
            this.dtgInfoReservas.Name = "dtgInfoReservas";
            this.dtgInfoReservas.Size = new System.Drawing.Size(547, 190);
            this.dtgInfoReservas.TabIndex = 0;
            this.dtgInfoReservas.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dtgInfoReservas_CellContentClick);
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(358, 292);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(75, 23);
            this.button1.TabIndex = 1;
            this.button1.Text = "btnCargar";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // InfoReservas
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.dtgInfoReservas);
            this.Name = "InfoReservas";
            this.Text = "InfoReservas";
            this.Load += new System.EventHandler(this.InfoReservas_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dtgInfoReservas)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView dtgInfoReservas;
        private System.Windows.Forms.Button button1;
    }
}