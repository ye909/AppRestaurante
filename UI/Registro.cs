using Negocio;
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
            // 2. Validar que el email no esté vacío
            if (string.IsNullOrEmpty(txtEmail.Text) || string.IsNullOrEmpty(txtContraseña.Text))
            {
                MessageBox.Show("Por favor ingrese un email", "Error",
                              MessageBoxButtons.OK, MessageBoxIcon.Error);
                txtEmail.Focus();
                return;
            }
          
           


            Entidades.Registro registro = new Entidades.Registro();
              registro.Nombres = txtNombres.Text;
                registro.Apellidos= txtApellidos.Text;
                registro.Telefono= txtTelefono.Text;
                registro.Email= txtEmail.Text;
                registro.Contraseña= txtContraseña.Text;
                registro.Direccion= txtDireccion.Text;
            registro.Genero = txtGenero.Text;
            registro.FechaRegistro = txtFechaRegistro.Value;


           Negocio.InfoRegistro infoRegistro = new Negocio.InfoRegistro();
          


            bool resultado = infoRegistro.InsertarRegistro(registro);

            // 5. Mostrar mensaje según resultado
            if (resultado)
            {
                MessageBox.Show("Su cuenta ha sido creada con éxito.");
                this.Close();
            }
            else
            {
                MessageBox.Show("No se pudo crear la cuenta. Intente nuevamente.");
            }

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

        private void ImgOjoAbierto_Click(object sender, EventArgs e)
        {

     

            txtContraseña.UseSystemPasswordChar = true;
            ImgOjoCerado.Visible = true;

        }

        private void ImgOjoCerado_Click(object sender, EventArgs e)
        {

            txtContraseña.UseSystemPasswordChar = false;
            txtContraseña.PasswordChar = '*';
            ImgOjoCerado.Visible = false;

       

        }
        private void txtContraseña_TextChanged(object sender, EventArgs e)
        {
           
        }

        private void linkLabel1_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            Loguin loguin = new Loguin();
            loguin.Show();
            this.Hide();
        }
    }
}
