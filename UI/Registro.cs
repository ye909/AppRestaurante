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
    public partial class Registro : Form
    {
        public Registro()
        {
            InitializeComponent();
        }

        private void btnRegistro_Click(object sender, EventArgs e)
        {
            //validar el boton y los campos para poder enviar el mensaje de exito
            if (txtNombre.Text != "")
            {
                MessageBox.Show("Su cuenta asido creada con éxito.");
                this.Close();
            }
            else
            {
                MessageBox.Show("Campos en blanco");
                return;
             
            }
      
           

        }
    }
}
