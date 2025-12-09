using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Negocio
{
    public class ContactoUser
    {
        ConexionDAL.ContactoUser contactoUserDAL = new ConexionDAL.ContactoUser();  

        public  DataTable ObtenerContacto()
        {
            return contactoUserDAL.ObtenerContacto();
        }
        public bool insertarContacto(Entidades.ContactoUser intems)
        {
            return contactoUserDAL.insertarContacto(intems);
        }   


    }
}
