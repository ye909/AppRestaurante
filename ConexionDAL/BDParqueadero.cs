using System;
using System.Collections.Generic;
using System.Configuration;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConexionDAL
{
   public class BDParqueadero
    {
        private string linkconexion = ConfigurationManager.ConnectionStrings["sqlconex"].ConnectionString;
        public DataTable verReservasPaqueadero()
        {
            using (SqlConnection con = new SqlConnection(linkconexion))
            {
                SqlDataAdapter datos = new SqlDataAdapter("SELECT * FROM ReservaParqueadero",con);
               DataTable tabla = new DataTable();
                datos.Fill(tabla);
                return tabla;
            }
        }
          
        public bool insertDatosReserva( Entidades.ReservaParqueadero items)
        {
            using (SqlConnection cone = new SqlConnection(linkconexion))
            {
                SqlCommand cmd = new SqlCommand("INSERT INTO ReservaParqueadero (Nombres,Apellidos,Telefono,Fecha,Hora,Tipo,Praca,Modelo,Color,Descripcion)" +
                    " VALUES (@Nombres,@Apellidos,@Telefono,@Fecha,@Hora,@Tipo,@Praca,@Modelo,@Color,@Descripcion)");
                cmd.Parameters.AddWithValue("@",items.Nombres);
                cmd.Parameters.AddWithValue("@", items.Apellidos);
                cmd.Parameters.AddWithValue("@", items.Telefono);
                cmd.Parameters.AddWithValue("@", items.Fecha);
                cmd.Parameters.AddWithValue("@", items.Hora);
                cmd.Parameters.AddWithValue("@", items.Tipo);
                cmd.Parameters.AddWithValue("@", items.Praca);
                cmd.Parameters.AddWithValue("@", items.Modelo);
                cmd.Parameters.AddWithValue("@", items.Color);
                cmd.Parameters.AddWithValue("@", items.Descripcion);
                
            
                int resul = cmd.ExecuteNonQuery();
                return resul > 0;
          
            }
        }
    }
}
