using DataBase.DB.models;
using DataBase.DB.usuarios;
using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LogicLayer.usuarios
{
    public class Verificar_tipo_User
    {
        public Service_Verificar_Tipo_User iniciarServicio { get; set; }

        public Verificar_tipo_User(SqlConnection connection)
        {
            iniciarServicio = new Service_Verificar_Tipo_User(connection);
        }

        public int verificar(Usuario user)
        {
            int tipoUser = iniciarServicio.verificar(user);
            
            return tipoUser;
        }
    }
}
