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
    public partial class MenuPrincipal : Form
    {
        public MenuPrincipal()
        {
            InitializeComponent();
        }

        private void btnReservas_Click(object sender, EventArgs e)
        {
            Reservas reservas = new Reservas();
            reservas.Show();
        }

        private void label3_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void MenuPrincipal_Load(object sender, EventArgs e)
        {
            labelTransparentes();
        }

        private void labelTransparentes()
        {
            label1.Parent = pictureBox1;
            label1.BackColor = Color.Transparent;
            label2.Parent = pictureBox1;
            label2.BackColor = Color.Transparent;
        }

        private void btnRegistro_Click(object sender, EventArgs e)
        {
            this.Hide();
            Registro registro = new Registro();
            registro.Show();

        }

        private void btnInicio_Click(object sender, EventArgs e)
        {
            Loguin loguin = new Loguin();
            loguin.Show();
            this.Hide();
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {

        }

        private void btnMenu_Click(object sender, EventArgs e)
        {
            this.Hide();
            MenuBanderas banderas = new MenuBanderas();
            banderas.Show();
            this.Hide();
        }

        private void btnContacto_Click(object sender, EventArgs e)
        {
            this.Hide();
            Contacto contacto = new Contacto();
            contacto.Show();
            this.Hide();
        }
    }
}
