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
   public class ContactoUser
    {

        private string linkconexion = ConfigurationManager.ConnectionStrings["sqlconex"].ConnectionString;

        public DataTable ObtenerContacto()
        {
          
            using (SqlConnection conexion = new SqlConnection(linkconexion))
            {
                SqlDataAdapter dt = new SqlDataAdapter("select * from Contacto",conexion);
                 DataTable resultado = new DataTable();
                dt.Fill(resultado);
                return resultado;
            }
           
        }


        public bool insertarContacto(Entidades.ContactoUser intems )
        {

            using (SqlConnection cone = new SqlConnection(linkconexion))
            {
                SqlCommand cmd = new SqlCommand("INSERT INTO Contacto (Nombre, Email, Telefono, Region, Descripcion) VALUES (@Nombre, @Email, @Telefono, @Region, @Descripcion)", cone);
                cmd.Parameters.AddWithValue("@Nombre", intems.Nombre);
                cmd.Parameters.AddWithValue("@Email", intems.Email);
                cmd.Parameters.AddWithValue("@Telefono", intems.Telefono);
                cmd.Parameters.AddWithValue("@Region", intems.Region);
                cmd.Parameters.AddWithValue("@Descripcion", intems.Descripcion);
                cone.Open();


                int capturardatos = cmd.ExecuteNonQuery();
                return capturardatos > 0;
            }


        }

    }
}
