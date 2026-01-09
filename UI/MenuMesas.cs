using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
//using System.Reflection.Emit; // ¡Este es el problema! para usar " label " en el arreglo
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms; 

namespace UI
{
    public partial class MenuMesas : Form
    {

        private int mesaSeleccionada = -1; // Para guardar el número de mesa
        public MenuMesas()
        {
            InitializeComponent();
        }

        private void Menuplatos_Load(object sender, EventArgs e)
        {
           
        }
       

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void label18_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
