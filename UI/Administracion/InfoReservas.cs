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
    public partial class InfoReservas : Form
    {
        public InfoReservas()
        {
            InitializeComponent();
        }

        private void InfoReservas_Load(object sender, EventArgs e)
        {
            
        }

        private void button1_Click(object sender, EventArgs e)
        {
            //Negocio.InfoRegistro infoRegistro = new Negocio.InfoRegistro();

            //var tipo = infoRegistro.optenerDatos();

            // Verificar si el DataTable tiene datos
            //if (tipo != null && tipo.Rows.Count > 0)
            //{
            //    dtgInfoReservas.DataSource = tipo;
            //}
            //else
            //{
                // Opcional: Mostrar mensaje si no hay datos
                //MessageBox.Show("No hay registros disponibles", "Información",
                //                MessageBoxButtons.OK, MessageBoxIcon.Information);

                // Opcional: Limpiar el DataGridView
            //    dtgInfoReservas.DataSource = null;
            //}
        }

        private void dtgInfoReservas_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            dtgInfoReservas.MultiSelect = false;
            dtgInfoReservas.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
        }
    }
}
