using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Negocio
{
   public class ReservasUser
    {

        ConexionDAL.BDReservasUser data = new ConexionDAL.BDReservasUser();
        public bool insertReserva(Entidades.Rerservas isertdatos)
        {

            return data.insertReservas(isertdatos); 
        }
    }
}
