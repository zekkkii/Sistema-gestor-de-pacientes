using DataBase.DB.credenciales;
using DataBase.DB.models;
using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LogicLayer.credenciales
{
    public class Login
    {
       
        public Loguear iniciarServicio { get; set; }

        public Login(SqlConnection connection)
        {
            iniciarServicio = new Loguear(connection);
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
