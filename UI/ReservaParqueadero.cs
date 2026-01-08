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
    public partial class ReservaParqueadero : Form
    {
        public ReservaParqueadero()
        {
            InitializeComponent();
        }

        private void label8_Click(object sender, EventArgs e)
        {

        }

        private void label4_Click(object sender, EventArgs e)
        {

        }

        private void label3_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnReservaAqui_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(txtNombres.Text) || string.IsNullOrEmpty(txtApellidos.Text))
            {
                MessageBox.Show("Lo siento los campos no puede estar en blanco"); 
                return;
            }
            else
            {
                this.Hide();
             
            }
          
        }
    

        private void ReservaParqueadero_Load(object sender, EventArgs e)
        {
           
        }
    }
}
