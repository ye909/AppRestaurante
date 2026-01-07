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
    public partial class Reservas : Form
    {

        //private Entidades.Rerservas NombreUser;
        public Reservas()
        {
            InitializeComponent();
        }
    
     

        private void label3_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void dateTimePicker1_ValueChanged(object sender, EventArgs e)
        {

        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {

        }

        private void btnReservas_Click(object sender, EventArgs e)
        {
  
            
            // falta la validacion de los campos 
            if ( string.IsNullOrEmpty(txtNombreUser.Text) && string.IsNullOrEmpty( txtCantidaPersonas.Text))
            {
                MessageBox.Show("Los campos no pueden estar vacidos"); 
                return;
            }
            else
            {
                
               

                // envio el nombre de la persona de la reserva
                MensajeReservas mensaje = new MensajeReservas(txtNombreUser.Text);
                mensaje.ShowDialog();

                this.Close();
            }

            //int cantidad;
            //if (int.TryParse(txtCantidaPersonas.Text, out cantidad))
            //{
            //    MessageBox.Show("Los");
            //}
         
            Entidades.Rerservas vaidarReservas= new Entidades.Rerservas();
            vaidarReservas.Nombre = txtNombreUser.Text;
            vaidarReservas.Telefono = txtTelefono.Text;
            vaidarReservas.Descripcion = txtDescripcion.Text;
            vaidarReservas.Parqueadero = cbParqueadero.Text;
            vaidarReservas.Pago = txtPago.Text;
            vaidarReservas.Fecha = dtFecha.Value;
           // vaidarReservas.Cantidad = Convert.ToInt32(txtCantidaPersonas.Text);


            Negocio.ReservasUser datosReservas = new Negocio.ReservasUser();




            bool resul = datosReservas.insertReserva(vaidarReservas);


            if (resul)
            {
                MessageBox.Show("ok");
            }
            else
            {
                MessageBox.Show("no");
            }
        }

        private void opcionParqueadero()
        {
        
        
            cbParqueadero.Items.Add("Selecione el parqueadero");
            cbParqueadero.Items.Add("Carro");
            cbParqueadero.Items.Add("Moto");
            cbParqueadero.Items.Add("Cicla");
            cbParqueadero.SelectedIndex = 0;
        }

        private void Reservas_Load(object sender, EventArgs e)
        {
           opcionParqueadero();
        }
    }
}
