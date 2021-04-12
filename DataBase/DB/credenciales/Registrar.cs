using DataBase.DB.models;
using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataBase.DB.credenciales
{
    public class Registrar
    {
        private SqlConnection connection;

        public Registrar(SqlConnection connection)
        {
            this.connection = connection;
        }

        public bool registrar(Usuario user)
        {

            //inicio el comando a ejecutar, limpio el codigo para evitar injections, paso a funcion execute donde se abre conexion, corre query y cierra conexion. 
            try
            {
                if (verificarUser(user.usuario))
                {
                    connection.Open();

                    SqlCommand introducirUser =
                       new SqlCommand("INSERT INTO usuarios(nombre, apellido, usuario, user_password) values(@nombre, @apellido, @usuario, @password)", connection);
                    introducirUser.Parameters.AddWithValue("@nombre", user.nombre);
                    introducirUser.Parameters.AddWithValue("@apellido", user.apellido);
                    introducirUser.Parameters.AddWithValue("@usuario", user.usuario);
                    introducirUser.Parameters.AddWithValue("@password", user.password);


                    introducirUser.ExecuteNonQuery();
                    connection.Close();
                    return true;
                }

                return false;
            }
            catch
            {
                return false;
            }
        }


        public bool verificarUser(string user)
        {
            try
            {
                connection.Open();

                SqlCommand verificarusuario = new SqlCommand("SELECT usuario FROM usuarios WHERE usuario = @usuario", connection);
                verificarusuario.Parameters.AddWithValue("@usuario", user);
                SqlDataReader reader = verificarusuario.ExecuteReader();

                while (reader.Read())
                {
                    if ((string)reader.GetValue(0) == user)
                    {
                        // si retorna false quiere decir que  existe el usuario y no se puede crear otro igual
                        reader.Close();
                        reader.Dispose();
                        connection.Close();
                        return false;

                    }
                }
                // si retorna true quiere decir que no existe el usuario  y se puede crear este
                reader.Close();
                reader.Dispose();
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
