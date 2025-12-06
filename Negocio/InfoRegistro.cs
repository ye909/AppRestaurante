
using Entidades;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Conexion;
using Entidades;

namespace Negocio
{
    public class InfoRegistro
    {
      Conexion.Registro datosRegistro = new Conexion.Registro();

        public DataTable optenerDatos()
        {
        return datosRegistro.optenrdatosRegistro();
                     
        }
        public void insertarRegistro(Entidades.Registro items)
        {
            datosRegistro.insertarRegistro(items);
        }

        public bool inicioLoguin(Entidades.Registro logi)
        {
           return datosRegistro.ValidarLogin(logi);
        }
    }
}
