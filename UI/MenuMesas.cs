using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
//using System.Reflection.Emit; // ¡Este es el problema! para usar " label " en el arreglo
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms; 

namespace UI
{
    public partial class MenuMesas : Form
    {

        private int mesaSeleccionada = -1; // Para guardar el número de mesa
        public MenuMesas()
        {
            InitializeComponent();
        }

        private void Menuplatos_Load(object sender, EventArgs e)
        {
            ListasMesas();
        }
        public void  ListasMesas()
        {
            // Array de Labels del formulario

            Label[] labelsNumeroMesa = { LbMesa1, LbMesa2, LbMesa3, LbMesa4 , LbMesa5, LbMesa6 , LbMesa7, LbMesa8 };
       
            string[] nombresMesas = { "Mesa 1", "Mesa 2", "Mesa 3", "Mesa 4","Mesa 5", "Mesa 6", "Mesa 7", "Mesa 8" };

            //Label[] labelsEstadoMesa = { LbEstado1, LbEstado2, LbEstado3, LbEstado4, LbEstado5, LbEstado6, LbEstado7, LbEstado8 };
            //string[] estado = { "Libre", "Ocupada", "Reservada" ,"En espera"};

            for (int i = 0; i < labelsNumeroMesa.Length ; i++)
            {
                labelsNumeroMesa[i].Text = nombresMesas[i];

              


                //string estadoMesa = "";
                //switch (estadoMesa)
                //{
                //    case "Libre":
                //        labelsEstadoMesa[i].ForeColor = Color.Green;
                //        break;
                //    case "Ocupada":
                //        labelsEstadoMesa[i].ForeColor = Color.Red;
                //        break;
                //    case "Reservada":
                //        labelsEstadoMesa[i].ForeColor = Color.Orange;
                //        break;
                //    default:
                //        labelsEstadoMesa[i].ForeColor = Color.Blue;
                //        break;
                //}
            }
        }

        private void label3_Click(object sender, EventArgs e)
        {

        }
    }
}
