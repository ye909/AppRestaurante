using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace UI.Administracion
{
    public partial class InfoReservas : Form
    {
      

        public InfoReservas()
        {
            InitializeComponent();
        }

        private void InfoReservas_Load(object sender, EventArgs e)
        {

           

        }
    

        private void abriformularios(object hijo)
        {
            if (this.panelControl.Controls.Count > 0)
                this.panelControl.Controls.RemoveAt(0);
            Form fh = hijo as Form;
            fh.TopLevel = false;
            fh.Dock = DockStyle.Fill;
            this.panelControl.Controls.Add(fh);
            this.panelControl.Tag = fh;
            fh.Show();
        }
        private void button1_Click(object sender, EventArgs e)
        {
            //Negocio.InfoRegistro infoRegistro = new Negocio.InfoRegistro();

            //var tipo = infoRegistro.optenerDatos();

            // Verificar si el DataTable tiene datos
            //if (tipo != null && tipo.Rows.Count > 0)
            //{
            //    dtgInfoReservas.DataSource = tipo;
            //}
            //else
            //{
                // Opcional: Mostrar mensaje si no hay datos
                //MessageBox.Show("No hay registros disponibles", "Información",
                //                MessageBoxButtons.OK, MessageBoxIcon.Information);

                // Opcional: Limpiar el DataGridView
            //    dtgInfoReservas.DataSource = null;
            //}
        }

        private void dtgInfoReservas_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
           
        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void label14_Click(object sender, EventArgs e)
        {

        }

     
       

     

        private void btnPersonal_Click(object sender, EventArgs e)
        {
            Personal personal = new Personal();
            abriformularios(personal);
            //ImagenFondo.Visible = false;
        }

        private void btnReserva_Click(object sender, EventArgs e)
        {
            panelReservas info = new panelReservas();
            abriformularios(info);
        }

        private void btnInventario_Click(object sender, EventArgs e)
        {

            panelInventario info = new panelInventario();
            abriformularios(info);
        }

        private void btnRoles_Click(object sender, EventArgs e)
        {
            panelRoles info = new panelRoles();
            abriformularios(info);
        }

        private void label4_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
