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
    public partial class MensajeReservas : Form
    {
        private string resivirNombre;
        public MensajeReservas(string textomensaje)
        {
            InitializeComponent();
            this.resivirNombre = textomensaje;
           
        }

        private void MensajeReservas_Load(object sender, EventArgs e)
        {
            lbnombre.Text = "Hola "+ resivirNombre;
            ocultarventana();


        }        

        private async Task ocultarventana()
        {
            await Task.Delay(3000);

          
            this.Hide();
       
        }
  
    

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void label3_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
