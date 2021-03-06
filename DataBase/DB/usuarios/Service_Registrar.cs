using DataBase.DB.models;
using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using EmailHandler;

namespace DataBase.DB.usuarios
{
    public class Service_Registrar
    {
        private SqlConnection connection;
        private EmailSender EmailSender;

        public Service_Registrar(SqlConnection connection)
        {
            this.connection = connection;
            EmailSender = new EmailSender();
        }

        public bool registrar(Usuario user)
        {

            //inicio el comando a ejecutar, limpio el codigo para evitar injections, paso a funcion execute donde se abre conexion, corre query y cierra conexion. 
            try
            {
                if (verificarUser(user.usuario))
                {
                    connection.Open();

                    SqlCommand query =
                       new SqlCommand("INSERT INTO usuarios(nombre, apellido, correo, usuario, user_password, tipoUsuario) values(@nombre, @apellido, @correo, @usuario, @password, @tipoUsuario)", connection);
                    query.Parameters.AddWithValue("@nombre", user.nombre);
                    query.Parameters.AddWithValue("@apellido", user.apellido);
                    query.Parameters.AddWithValue("@correo", user.correo);
                    query.Parameters.AddWithValue("@usuario", user.usuario);
                    query.Parameters.AddWithValue("@password", user.password);
                    query.Parameters.AddWithValue("@tipoUsuario", user.tipoUsuario);


                    query.ExecuteNonQuery();
                    connection.Close();

                    EmailSender.sendEmail(user.correo, "Usuario creado en Gestor de pacientes", "Por este medio le notificamos que su usuario se creo" +
                        "correctamente en la plataforma gestor de pacientes. Su usuario es: " + user.usuario); ;
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
