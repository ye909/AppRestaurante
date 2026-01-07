using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace UI
{
    public partial class MenuBanderas : Form
    {
        public MenuBanderas()
        {
            InitializeComponent();
        }

        private void label3_Click(object sender, EventArgs e)
        {
            MenuPrincipal menu = new MenuPrincipal();
            menu.Show();
            this.Hide();
        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            MenuPlatosEcuador menuEcuador = new MenuPlatosEcuador();
            verVentanas(menuEcuador);
            
        }

        private void MenuBanderas_Load(object sender, EventArgs e)
        {
            OpcionMenuPlatosPais();
        }

        private void verVentanas(object hijo)
        {
            if (this.PanelControl.Controls.Count > 0)this.PanelControl.Controls.RemoveAt(0);
            {
                Form fh = hijo as Form;
                fh.TopLevel = false;
                fh.Dock = DockStyle.Fill;
                this.PanelControl.Controls.Add(fh);
                this.PanelControl.Tag = fh;
                fh.Show();

            }
        }
        private void OpcionMenuPlatosPais()
        {
            Button[] botonesPlatos = { btnArgentina, btnHonduras, btnGuatemala, btnBrasil, btnEcuador, btnColombia, btnMexico, btnPeru, btnVenezuela };
            PictureBox[] banderasplatos={ pictureBoxArgentina, pictureBoxHonduras, pictureBoxGuatemala, pictureBoxEcuador, pictureBoxBrasil, pictureBoxColombia, pictureBoxMexico, pictureBoxPeru, pictureBoxVenezuela };

            
            }

        private void btnEcuador_Click(object sender, EventArgs e)
        {

        }

        private void btnGuatemala_Click(object sender, EventArgs e)
        {

        }

        private void btnHonduras_Click(object sender, EventArgs e)
        {

        }

        private void btnBrasil_Click(object sender, EventArgs e)
        {

        }

        private void btnVenezuela_Click(object sender, EventArgs e)
        {

        }

        private void btnPeru_Click(object sender, EventArgs e)
        {

        }

        private void btnColombia_Click(object sender, EventArgs e)
        {

        }

        private void btnMexico_Click(object sender, EventArgs e)
        {

        }

        private void btnArgentina_Click(object sender, EventArgs e)
        {

        }
    }
}
