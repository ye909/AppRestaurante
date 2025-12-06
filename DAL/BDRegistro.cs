using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;
using System.Configuration;

namespace ConexionBD
{
    public class BDRegistro
    {
        private string conexion = ConfigurationManager.ConnectionStrings["sqlconex"].ConnectionString;
        public DataTable optenerDatosRegistro()
        {
            using (SqlConnection cone = new SqlConnection(conexion))
            {
                SqlDataAdapter cdm = new SqlDataAdapter("SELECT * FROM CitasCabello", cone);
                DataTable dt = new DataTable();
                cdm.Fill(dt);
                return dt;

            }
        }

        public void insertarRegistro()
        {
            using (SqlConnection cone = new SqlConnection(conexion))
            {
                SqlCommand cmd = new SqlCommand("INSERT INTO Registro" +
                    " (Nombre, Apellido, Telefono, Correo, FechaCita, Servicio) VALUES " +
                    "(@Nombre, @Apellido, @Telefono, @Correo, @FechaCita, @Servicio)", cone);

                cmd.Parameters.AddWithValue("@Nombre", "Juan");
                cmd.Parameters.AddWithValue("@Apellido", "Perez");
                cmd.Parameters.AddWithValue("@Telefono", "1234567890");
                cmd.Parameters.AddWithValue("@Correo", "");
                cmd.Parameters.AddWithValue("@FechaCita", DateTime.Now);
                cmd.Parameters.AddWithValue("@Servicio", "Corte de cabello");

                cone.Open();
                cmd.ExecuteNonQuery();



            }
        }
}
}