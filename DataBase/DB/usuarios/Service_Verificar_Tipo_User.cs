using DataBase.DB.models;
using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataBase.DB.usuarios
{
    public class Service_Verificar_Tipo_User
    {

        private SqlConnection connection;

        public Service_Verificar_Tipo_User(SqlConnection connection)
        {
            this.connection = connection;
        }

        public int verificar(Usuario user)
        {

            try
            {
                connection.Open();

                SqlCommand finduser =
                    new SqlCommand("SELECT tipoUsuario FROM usuarios WHERE usuario = @usuario  AND user_password =@password", connection);
                finduser.Parameters.AddWithValue("@usuario", user.usuario);
                finduser.Parameters.AddWithValue("@password", user.password);

                SqlDataReader reader = finduser.ExecuteReader();

                double datos = -1 ;

                while (reader.Read())
                {
                    datos = reader.GetDouble(0);
                }

                reader.Close();
                reader.Dispose();

                connection.Close();
                return (int)datos;
            }
            catch
            {
                return -1;
            }


        }
    }
}
