using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace UI.Administracion
{
    public partial class panelInventario : Form
    {
        public panelInventario()
        {
            InitializeComponent();
        }

        private void dgInventario_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            dgInventarios.MultiSelect = false;
            dgInventarios.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
        }

     

        private void btnDatos_Click(object sender, EventArgs e)
        {
            Negocio.ReservasUser reservasUser = new Negocio.ReservasUser();

            var tipo = reservasUser.verdatosReserva();

            if (tipo != null && tipo.Rows.Count > 0)
            {
                dgInventarios.DataSource = tipo;
                MessageBox.Show("Datos cargados correctamente", "Información",
                                MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            else
            {
                MessageBox.Show("No hay registros disponibles", "Información",
                                MessageBoxButtons.OK, MessageBoxIcon.Information);
                dgInventarios.DataSource = null;
            }

        }
    }
}
