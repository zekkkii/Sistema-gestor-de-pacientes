using DataBase.DB.credenciales;
using DataBase.DB.models;
using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LogicLayer.usuarios
{
    public class Login
    {
       
        public Service_Login iniciarServicio { get; set; }

        public Login(SqlConnection connection)
        {
            iniciarServicio = new Service_Login(connection);
        }

        public bool login(Usuario usuarioPassword)
        {
            
            Usuario datos = iniciarServicio.login(usuarioPassword);

            if (usuarioPassword.usuario == datos.usuario)
            {
                if (usuarioPassword.password == datos.password)
                {
                    //datos encontrados e iguales
                    return true;
                }
            }

            return false;
        }
    }
}
