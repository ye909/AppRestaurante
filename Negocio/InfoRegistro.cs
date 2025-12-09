
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
     
            private Conexion.Registro datosRegistro = new Conexion.Registro();

            public DataTable ObtenerDatos()
            {
               
                    return datosRegistro.optenrdatosRegistro();
                
               
            }

            public bool InsertarRegistro(Entidades.Registro items)
            {
           
            return datosRegistro.InsertarRegistro(items);
                
            }

            public bool InicioLogin(Entidades.Registro logi)
            {
                // Validaciones
                if (string.IsNullOrWhiteSpace(logi.Email))
                    throw new Exception("El email es requerido");

                if (string.IsNullOrWhiteSpace(logi.Contraseña))
                    throw new Exception("La contraseña es requerida");

                try
                {
                    return datosRegistro.ValidarLogin(logi);
                }
                catch (Exception ex)
                {
                    throw new Exception("Error al validar login: " + ex.Message, ex);
                }
            }

           
        

            public bool ActualizarRegistro(Entidades.Registro items)
            {
                if (string.IsNullOrWhiteSpace(items.Email))
                    throw new Exception("El email es requerido");

                try
                {
                    return datosRegistro.ActualizarRegistro(items);
                }
                catch (Exception ex)
                {
                    throw new Exception("Error al actualizar registro: " + ex.Message, ex);
                }
            }
        }
}