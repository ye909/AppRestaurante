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

namespace UI
{
    public partial class Loguin : Form
    {
        public Loguin()
        {
            InitializeComponent();
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
            if (txtContraseña.Text == "1" && txtEmail.Text == "alex")
            {
                txtMensaje.Visible = true;
                txtMensaje.Text = "Inicio de sesión exitoso";
                txtMensaje.ForeColor = Color.ForestGreen;
                conteoMensajeInicio();
            }else if (txtContraseña.Text == "12" && txtEmail.Text == "yesid")
            {
                txtMensaje.Text = "Inicio de sesión exitoso";
                txtMensaje.ForeColor = Color.ForestGreen;
                conteoMensajeInicio();

            }
            else if (txtContraseña.Text == "123" && txtEmail.Text == "andres")
            {
                txtMensaje.Text = "Inicio de sesión exitoso";
                txtMensaje.ForeColor = Color.ForestGreen;
                conteoMensajeInicio();

            }
            else
            {
                txtMensaje.Visible = true;
                txtMensaje.Text = "Por favor ingrese todos los datos";
                txtMensaje.ForeColor = Color.Red;
                conteoMensajeError();
            }


        }
        private async void conteoMensajeInicio()
        {
           
            await Task.Delay(2600);
            MenuAdministrativo menuAdministrativo = new MenuAdministrativo();
            menuAdministrativo.Show();
            this.Hide();

            
        }
        private async void conteoMensajeError()
        {
            await Task.Delay(2000);
            txtMensaje.Text = "";
        }

        private void label6_Click(object sender, EventArgs e)
        {
            Registro registro = new Registro();
            registro.Show();
            this.Hide();
        }
    }
}
