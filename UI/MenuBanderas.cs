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

        }

        private void MenuBanderas_Load(object sender, EventArgs e)
        {
            OpcionMenuPlatosPais();
        }

        private void OpcionMenuPlatosPais()
        {
            Button[] platsolatinos = { btnArgentina, btnBrasil, btnChile, btnColombia, btnMexico, btnPeru, btnVenezuela };

            foreach (Button boton in botones)
            {
                switch (platsolatinos)
                {
                    case btnArgentina:
                        boton.Click += (s, e) =>
                        {
                            MenuPlatosPais menuPlatos = new MenuPlatosPais("Argentina");
                            menuPlatos.Show();
                            this.Hide();
                        };
                        break;
                    case btnBrasil:
                        boton.Click += (s, e) =>
                        {
                            MenuPlatosPais menuPlatos = new MenuPlatosPais("Brasil");
                            menuPlatos.Show();
                            this.Hide();
                        };
                        break;
                    case btnChile:
                        boton.Click += (s, e) =>
                        {
                            MenuPlatosPais menuPlatos = new MenuPlatosPais("Chile");
                            menuPlatos.Show();
                            this.Hide();
                        };
                        break;
                    case btnColombia:
                        boton.Click += (s, e) =>
                        {
                            MenuPlatosPais menuPlatos = new MenuPlatosPais("Colombia");
                            menuPlatos.Show();
                            this.Hide();
                        };
                        break;
                    case btnMexico:
                        boton.Click += (s, e) =>
                        {
                            MenuPlatosPais menuPlatos = new MenuPlatosPais("Mexico");
                            menuPlatos.Show();
                            this.Hide();
                        };
                        break;
                    case btnPeru:
                        boton.Click += (s, e) =>
                        {
                            MenuPlatosPais menuPlatos = new MenuPlatosPais("Peru");
                            menuPlatos.Show();
                            this.Hide();
                        };
                        break;
                    case btnVenezuela:
                        boton.Click += (s, e) =>
                        {
                            MenuPlatosPais menuPlatos = new MenuPlatosPais("Venezuela");
                            menuPlatos.Show();
                            this.Hide();
                        };
                        break;
                }
            }
        }
    }
}
