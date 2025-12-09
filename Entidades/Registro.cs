using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entidades
{
    public class Registro
    {
      


        public int Id { get; set; }
        public string Nombres { get; set; }
        public string Apellidos { get; set; }
        public string Telefono { get; set; }
        public DateTime FechaRegistro { get; set; }
        public string Email { get; set; }
        public string Contraseña { get; set; }
        public string Direccion { get; set; }
        public string Genero { get; set; }
    }
}
