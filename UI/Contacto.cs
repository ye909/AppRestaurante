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
    public partial class Contacto : Form
    {
        public Contacto()
        {
            InitializeComponent();
        }

        private void label6_Click(object sender, EventArgs e)
        {

        }

        private void btnEnviar_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(txtNombre.Text) || string.IsNullOrWhiteSpace(txtEmail.Text) ||
                string.IsNullOrWhiteSpace(txtTelefono.Text) ||string.IsNullOrWhiteSpace(txtRegion.Text) ||
                string.IsNullOrWhiteSpace(txtDescripcion.Text))

            {
                MessageBox.Show("Por favor, complete todos los campos antes de enviar el mensaje");
                LimpiarCampos();
                return;
            }

            Entidades.ContactoUser nuevoContacto = new Entidades.ContactoUser
            {
                Nombre = txtNombre.Text,
                Email = txtEmail.Text,
                Telefono = txtTelefono.Text,
                Region = txtRegion.Text,
                Descripcion = txtDescripcion.Text
            };

              Negocio.ContactoUser Negocio = new Negocio.ContactoUser();

            bool exito = Negocio.insertarContacto(nuevoContacto)  ;
            if (exito)
            {
                MessageBox.Show("Su mensaje ha sido enviado con éxito. Nos pondremos en contacto con usted pronto");
                UI.MenuPrincipal menu = new UI.MenuPrincipal();
                menu.Show();
                this.Hide();
               
            }
            else
            {
                MessageBox.Show("Hubo un error al enviar su mensaje. Por favor, inténtelo de nuevo más tarde");
                UI.MenuPrincipal menu = new UI.MenuPrincipal();
                menu.Show();
                this.Hide();
            }

        }
        public void LimpiarCampos()
        {
            txtNombre.Clear();
            txtEmail.Clear();
            txtTelefono.Clear();
            txtRegion.Clear();
            txtDescripcion.Clear();
        }

        private void label3_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
