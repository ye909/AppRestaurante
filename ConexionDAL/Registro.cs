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

        public void insertarRegistro(Entidades.Registro items)
        {
            using (SqlConnection conexion = new SqlConnection(linkconexion))
            {
                SqlCommand cmd = new SqlCommand("insert into Registro(Nombres,Apellidos,Direccion,Telefono,Genero,FechaRegistro,Contrasena)" +
                    "VALUES(@Nombres,@Apellidos,@Direccion,@Telefono,@Genero,@FechaRegistro,@Contrasena)");
                cmd.Parameters.AddWithValue("@Nombres",items.Nombres);
                cmd.Parameters.AddWithValue("@Apellidos", items.Apellidos);
                cmd.Parameters.AddWithValue("@Direccion", items.Direccion);
                cmd.Parameters.AddWithValue("@Telefono", items.Telefono);
                cmd.Parameters.AddWithValue("@Genero", items.genero); 
                     cmd.Parameters.AddWithValue("@FechaRegistro", items.FechaRegistro);
                //cmd.Parameters.AddWithValue("@FechaRegistro", DateTime.Now);
                cmd.Parameters.AddWithValue("@Contrasena", items.Contraseña);



                conexion.Open();
                cmd.ExecuteNonQuery();
            }
        }
 
        public void ActualizarRegistro(Entidades.Registro items)
        {
            using (SqlConnection conexion = new SqlConnection(linkconexion))
            {
                SqlCommand cmd = new SqlCommand("Update Registro set Nombres=@Nombres, Apellidos=@Apellidos, Direccion=@Direccion, Telefono=@Telefono, Genero=@Genero, FechaRegistro=@FechaRegistro, Contrasena=@Contrasena where Email=@Email");
                cmd.Parameters.AddWithValue("@Nombres", items.Nombres);
                cmd.Parameters.AddWithValue("@Apellidos", items.Apellidos);
                cmd.Parameters.AddWithValue("@Direccion", items.Direccion);
                cmd.Parameters.AddWithValue("@Telefono", items.Telefono);
                cmd.Parameters.AddWithValue("@Genero", items.genero);
                cmd.Parameters.AddWithValue("@FechaRegistro", items.FechaRegistro);
                cmd.Parameters.AddWithValue("@Contrasena", items.Contraseña);
                cmd.Parameters.AddWithValue("@Email", items.Email);
                conexion.Open();
                cmd.ExecuteNonQuery();
            }
        }
        // MÉTODO PARA VALIDAR LOGIN
        public bool ValidarLogin(Entidades.Registro logi)
        {
            using (SqlConnection conexion = new SqlConnection(linkconexion))
            {
                SqlCommand cmd = new SqlCommand(
                    "SELECT COUNT(*) FROM Registro WHERE Email = @Email AND Contrasena = @Contrasena",
                    conexion);

                cmd.Parameters.AddWithValue("@Email", logi.Email);
                cmd.Parameters.AddWithValue("@Contrasena", logi.Contraseña);

                conexion.Open();
                int count = (int)cmd.ExecuteScalar();

                return count > 0;
            }
        }

    }
}
