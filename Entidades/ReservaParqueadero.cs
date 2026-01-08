using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entidades
{
public class ReservaParqueadero:Rerservas
    {

        public string Nombres { get; set; }
         public string Apellidos { get; set; }
        public string Modelo { get; set; }
         public string Praca { get; set; }
         public string Color { get; set; }
         public string Tipo { get; set; }

        public void verdatosReservas()
        {
            this.Cantidad = Cantidad;
            this.Telefono = Telefono;
            this.Descripcion = Descripcion;
            this.Fecha = Fecha;


        }
        //public void verdatosReservas(string Telefono, string Descripcion, DateTime Fecha)
        //{
        //    this.Cantidad = Cantidad;
        //    this.Telefono = Telefono;
        //    this.Descripcion = Descripcion;
        //    this.Fecha = Fecha;


        //}
    }
  


}
