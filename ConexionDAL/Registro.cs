using Entidades;
using System;
using System.Collections.Generic;
using System.Configuration;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Conexion
{
    public class Registro
    {
        private string linkconexion = ConfigurationManager.ConnectionStrings["sqlconex"].ConnectionString;

        public  DataTable optenrdatosRegistro()
        {
            using (SqlConnection conexion = new SqlConnection(linkconexion))
            {
              SqlDataAdapter datos = new SqlDataAdapter("Select * From Registro", conexion);
               
                DataTable tabla = new DataTable();
                datos.Fill(tabla);
                return tabla;
            }
        }
        public bool InsertarRegistro(Entidades.Registro items)
        {
          
                using (SqlConnection conexion = new SqlConnection(linkconexion))
                {
                    string query = @"INSERT INTO Registro(Nombres, Apellidos, Direccion, Telefono, Genero, Email, Contrasena, FechaRegistro) 
                                     VALUES(@Nombres, @Apellidos, @Direccion, @Telefono, @Genero, @Email, @Contrasena, @FechaRegistro)";

                    SqlCommand cmd = new SqlCommand(query, conexion);
                    cmd.Parameters.AddWithValue("@Nombres", items.Nombres);
                    cmd.Parameters.AddWithValue("@Apellidos", items.Apellidos);
                    cmd.Parameters.AddWithValue("@Direccion", items.Direccion);
                    cmd.Parameters.AddWithValue("@Telefono", items.Telefono);
                    cmd.Parameters.AddWithValue("@Genero", items.Genero);
                    cmd.Parameters.AddWithValue("@Email", items.Email);
                    cmd.Parameters.AddWithValue("@Contrasena", items.Contraseña);
                    cmd.Parameters.AddWithValue("@FechaRegistro", DateTime.Now);


                    conexion.Open();
                int DT = cmd.ExecuteNonQuery();
                return  DT > 0;
            }
        }
        public bool ValidarLogin(Entidades.Registro logi)
        {
            using (SqlConnection conexion = new SqlConnection(linkconexion))
            {

                string query = "SELECT COUNT(*) FROM Registro WHERE Email = @Email AND Contrasena = @Contrasena";
        SqlCommand cmd = new SqlCommand(query, conexion);
        cmd.Parameters.AddWithValue("@Email", logi.Email);
                cmd.Parameters.AddWithValue("@Contrasena", logi.Contraseña);

                conexion.Open();
                int count = Convert.ToInt32(cmd.ExecuteScalar());
                return count > 0;
            }
     }
        public bool ActualizarRegistro(Entidades.Registro items)
        {
            using (SqlConnection conexion = new SqlConnection(linkconexion))
            {
                string query = @"UPDATE Registro SET 
                                Nombres = @Nombres, 
                                Apellidos = @Apellidos, 
                                Direccion = @Direccion, 
                                Telefono = @Telefono, 
                                Genero = @Genero, 
                                Contrasena = @Contrasena 
                                WHERE Email = @Email";

                SqlCommand cmd = new SqlCommand(query, conexion);
                cmd.Parameters.AddWithValue("@Nombres", items.Nombres);
                cmd.Parameters.AddWithValue("@Apellidos", items.Apellidos);
                cmd.Parameters.AddWithValue("@Direccion", items.Direccion);
                cmd.Parameters.AddWithValue("@Telefono", items.Telefono);
                cmd.Parameters.AddWithValue("@Genero", items.Genero);
                cmd.Parameters.AddWithValue("@Contrasena", items.Contraseña);
                cmd.Parameters.AddWithValue("@Email", items.Email);

                conexion.Open();
                int rowsAffected = cmd.ExecuteNonQuery();
                return rowsAffected > 0;
            }
        }

    }
}
