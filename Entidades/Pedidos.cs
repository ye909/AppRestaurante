using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entidades
{
public class Pedidos
    {

   
        public string NumeroMesa { get; set; }
        public string Estado { get; set; }
        public string NombrePlato { get; set; }
        public int Cantidad { get; set; }
        public int Precio { get; set; }
        public DateTime FechaPedido { get; set; }
       public string Observacion { get; set; }
       

    }
}
