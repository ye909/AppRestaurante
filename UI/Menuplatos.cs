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
    public partial class Menuplatos : Form
    {
        public Menuplatos()
        {
            InitializeComponent();
        }
        
        List<string> platosSeleccionados = new List<string>();

        private void logicaBtn()
        {
            Button[] botonesPlatos = { btnAgregar1, btnAgregar2 };
          
            for (int i = 0; i < botonesPlatos.Length; i++)
            {
                platosSeleccionados.Add(botonesPlatos[i].Text);

            }
            MessageBox.Show(string.Join("\n", platosSeleccionados), "Platos Seleccionados");
        }

        private void btnAgregar1_Click(object sender, EventArgs e)
        {
            logicaBtn();


        }

        private void Menuplatos_Load(object sender, EventArgs e)
        {

        }

        private void btnAgregar2_Click(object sender, EventArgs e)
        {
            logicaBtn();
        }
    }
}
