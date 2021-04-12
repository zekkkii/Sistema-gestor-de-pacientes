using DataBase.DB.models;
using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataBase.DB.credenciales
{
    public class Loguear
    {
       
        private SqlConnection connection;

        public Loguear(SqlConnection connection)
        {
            this.connection = connection;
        }

        public Usuario login(Usuario user)
        {

            try
            {
                connection.Open();

                SqlCommand finduser =
                    new SqlCommand("SELECT usuario, user_password FROM usuarios WHERE usuario = @usuario  AND user_password =@password", connection);
                finduser.Parameters.AddWithValue("@usuario", user.usuario);
                finduser.Parameters.AddWithValue("@password", user.password);

                SqlDataReader reader = finduser.ExecuteReader();

                Usuario datos = new Usuario(null, null, null,null, null, 0);

                while (reader.Read())
                {
                    datos.usuario = reader.IsDBNull(0) ? null : reader.GetString(0);
                    datos.password = reader.IsDBNull(1) ? null : reader.GetString(1);
                }

                reader.Close();
                reader.Dispose();

                connection.Close();
                return datos;
            }
            catch
            {
                return new Usuario(null, null, null, null, null, 0);
            }
        }
        

    }
}
