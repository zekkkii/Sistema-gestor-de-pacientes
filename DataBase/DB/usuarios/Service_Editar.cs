using DataBase.DB.models;
using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataBase.DB.usuarios
{
    public class Service_Editar
    {
        private SqlConnection connection;

        public Service_Editar(SqlConnection connection)
        {
            this.connection = connection;
        }

        public bool editar(int id,Usuario user)
        {
            try
            {
                connection.Open();

                SqlCommand query = new SqlCommand("UPDATE usuarios " +
                    "SET nombre = @nombre, apellido = @apellido, correo = @correo, usuario = @usuario, user_password = @password, tipoUsuario = @tipoUsuario where id = @id", connection);
                query.Parameters.AddWithValue("@id", id);
                query.Parameters.AddWithValue("@nombre", user.nombre);
                query.Parameters.AddWithValue("@apellido", user.apellido);
                query.Parameters.AddWithValue("@correo", user.apellido);
                query.Parameters.AddWithValue("@usuario", user.usuario);
                query.Parameters.AddWithValue("@password", user.password);
                query.Parameters.AddWithValue("@tipoUsuario", user.tipoUsuario);

                query.ExecuteNonQuery();
                connection.Close();
                return true;
            }
            catch
            {
                return false;
            }
        }

    }
}
