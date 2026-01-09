using System;
using System.Windows.Forms;

namespace UI
{
    public partial class ReservaParqueadero : Form
    {
        public ReservaParqueadero()
        {
            InitializeComponent();
        }

        private void label8_Click(object sender, EventArgs e)
        {

        }

        private void label4_Click(object sender, EventArgs e)
        {

        }

        private void label3_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnReservaAqui_Click(object sender, EventArgs e)
        {
            // Validar campos
            if (string.IsNullOrEmpty(txtNombres.Text) || string.IsNullOrEmpty(txtApellidos.Text) ||
                cbTipo.SelectedIndex == 0) // Validar que no sea "Selecione Parqueadero"
            {
                MessageBox.Show("Los campos no pueden estar en blanco y debe seleccionar un tipo de parqueadero");
                return;


          
             
            }
            else
            {
                this.Hide();
            }
            // Capturar datos del ComboBox
            string tipoParqueadero = cbTipo.SelectedItem.ToString();
            MessageBox.Show("Reserva realizada para: " + tipoParqueadero);

        }
    

        private void ReservaParqueadero_Load(object sender, EventArgs e)
        {
            opcionTipoParqueadero();
        }

        private void opcionTipoParqueadero()
        {
            cbTipo.Items.Add("Selecione Parqueadero");
            cbTipo.Items.Add("Moto");
            cbTipo.Items.Add("Carro");
            cbTipo.Items.Add("Bicicleta");
            cbTipo.Items.Add("Patineta Electrica");
            cbTipo.SelectedIndex = 0;
        }
    }
}
