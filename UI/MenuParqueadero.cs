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
    public partial class MenuParqueadero : Form
    {
        public MenuParqueadero()
        {
            InitializeComponent();
        }

        private void label8_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            

        }

        private void btnReserva2_Click(object sender, EventArgs e)
        {
            abrirVentanaReserva();
        }

        private void MenuParqueadero_Load(object sender, EventArgs e)
        {

        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void btnReserva4_Click(object sender, EventArgs e)
        {
            abrirVentanaReserva();
        }

        private void btnReserva3_Click(object sender, EventArgs e)
        {
            abrirVentanaReserva();
        }

        private void btnReserva1_Click(object sender, EventArgs e)
        {
            abrirVentanaReserva();
           
        }

        private void abrirVentanaReserva()
        {
            UI.ReservaParqueadero abrirVentanaParqueadero = new UI.ReservaParqueadero();
            abrirVentanaParqueadero.ShowDialog();
        }
    }
}
