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
   public class BDReservasUser
    {
     
        private string linkconexion = ConfigurationManager.ConnectionStrings["sqlconex"].ConnectionString;
        public DataTable VerReservas()
        {
            using (SqlConnection cone = new SqlConnection(linkconexion))
            {
                SqlDataAdapter datos = new SqlDataAdapter("SELECT * FROM Reservas",cone);
                DataTable tabla = new DataTable();
                datos.Fill(tabla);
                return tabla;


            }
          
        }

        public bool insertReservas(Entidades.Rerservas items)
        {
            using (SqlConnection con =new SqlConnection(linkconexion))
            {
              
                SqlCommand cmd = new SqlCommand("INSERT INTO Reservas (Nombre,Cantidad,Telefono,Descripcion,Fecha,Hora,Paqueadero,Pago)" +
                    " VALUES (@Nombre,@Cantidad,@Telefono,@Descripcion,@Fecha,@Hora,@Paqueadero,@Pago)",con);
                cmd.Parameters.AddWithValue("@Nombre", items.Nombre);
                cmd.Parameters.AddWithValue("@Cantidad", items.Cantidad);
                cmd.Parameters.AddWithValue("@Telefono", items.Telefono);
                cmd.Parameters.AddWithValue("@Descripcion", items.Descripcion);
                cmd.Parameters.AddWithValue("@Fecha", items.Fecha);
                cmd.Parameters.AddWithValue("@Hora", items.Hora);
                cmd.Parameters.AddWithValue("@Paqueadero", items.Parqueadero);
                cmd.Parameters.AddWithValue("@Pago", items.Pago);

                con.Open();
                int capturardatos = cmd.ExecuteNonQuery();
                return capturardatos > 0;

              



            }
        }

    }
}
