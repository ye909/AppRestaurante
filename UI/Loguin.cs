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
using UI.Administracion;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.ListView;

namespace UI
{
    public partial class Loguin : Form
    {
        // Variable que guarda una instancia de la clase de negocio
        private InfoRegistro negocioRegistro;
        public Loguin()
        {
            InitializeComponent();
            // Inicializar la instancia de la clase de negocio
            negocioRegistro = new InfoRegistro();
        }

        private void label3_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void label5_Click(object sender, EventArgs e)
        {
            RestableserContraseña restableser = new RestableserContraseña();
            restableser.Show();
        }

        private void  btnInicioLoguin_Click(object sender, EventArgs e)
        {

            // Validar campos vacíos

            if (string.IsNullOrWhiteSpace(txtEmail.Text) || string.IsNullOrWhiteSpace(txtContraseña.Text))
            {
               conteoMensajeError();
                return;
            }

          
            Entidades.Registro loginInfo = new Entidades.Registro
                {
                    Email = txtEmail.Text.Trim(),
                    Contraseña = txtContraseña.Text.Trim(),
             
                };



            // Validar credenciales
            bool loginExitoso = negocioRegistro.InicioLogin(loginInfo);

            if (loginExitoso)
            {

                string mensaje = $"     Bienvenido a\nAfroTech Solution";
            
                MessageBox.Show(mensaje);
            }
           

            string autenticacion = txtEmail.Text;   

            switch (autenticacion)
            {
                case "alexYesid711@gmail.com":
                    // Abrir menú principal
                    
                    MenuAdministrativo menuAdministrativo = new MenuAdministrativo();
                    menuAdministrativo.Show();
                    this.Hide();
                    break;

                case "a":

                    // Abrir menú principal
                    
                   MenuMesas menuplatos = new MenuMesas();
                    menuplatos.Show();
                    this.Hide();
                    break;
                    default:
                   
                    break;

            }


            }
            
            private async void conteoMensajeError()
        {
            await Task.Delay(200);
            txtMensaje.Visible = true;
              txtMensaje.Text = "Por favor ingrese email y contraseña";
              txtMensaje.ForeColor = Color.Red;

            await Task.Delay(2000);
            txtContraseña.Text="";
            txtEmail.Text = "";
            txtMensaje.Visible = false;

        }

        private void label6_Click(object sender, EventArgs e)
        {
            Registro registro = new Registro();
            registro.Show();
            this.Hide();
        }

        private void ImgOjoCerado_Click(object sender, EventArgs e)
        {
            txtContraseña.UseSystemPasswordChar = false;
            txtContraseña.PasswordChar = '*';
            ImgOjoCerado.Visible = false;
        }

        private void ImgOjoAbierto_Click(object sender, EventArgs e)
        {

            txtContraseña.UseSystemPasswordChar = true;
            ImgOjoCerado.Visible = true;
        }
    }
}
