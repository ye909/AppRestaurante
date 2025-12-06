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
            if (txtNombres.Text != "")
            {
                MessageBox.Show("Su cuenta asido creada con éxito.");
                this.Close();
            }
            else
            {
                MessageBox.Show("Campos en blanco");
                return;
             
            }
          
            Entidades.Registro registro = new Entidades.Registro();
              registro.Nombres = txtNombres.Text;
                registro.Apellidos= txtApellidos.Text;
                registro.Telefono= txtTelefono.Text;
                registro.Email= txtEmail.Text;
                registro.Contraseña= txtContraseña.Text;
                registro.Direccion= txtDireccion.Text;
            //registro.genero = comboBox1.Text;
            //registro.FechaRegistro = dateTimePicker1.Value;

     
           
        }

        private void label9_Click(object sender, EventArgs e)
        {

        }

        private void label3_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void label2_Click(object sender, EventArgs e)
        {

        }
    }
}
