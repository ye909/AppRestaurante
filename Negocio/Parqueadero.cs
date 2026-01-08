using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Negocio
{
  public class Parqueadero
    {
        ConexionDAL.BDParqueadero capturarDatos= new ConexionDAL.BDParqueadero();


        public DataTable verificarDatos()
        {
        return capturarDatos.verReservasPaqueadero();
        }

        public bool insertarDatos(Entidades.ReservaParqueadero items)
        {
            return capturarDatos.insertDatosReserva(items);
        }
    }
}
