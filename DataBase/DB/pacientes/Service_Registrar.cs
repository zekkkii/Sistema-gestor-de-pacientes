using DataBase.DB.models;
using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataBase.DB.pacientes
{
    public class Service_Registrar
    {
        private SqlConnection connection;

        public Service_Registrar(SqlConnection connection)
        {
            this.connection = connection;
        }

        public bool registrar(Paciente user)
        {

            //inicio el comando a ejecutar, limpio el codigo para evitar injections, paso a funcion execute donde se abre conexion, corre query y cierra conexion. 
            try
            {
                if (verificarUser(user.cedula))
                {
                    connection.Open();

                    SqlCommand query =
                       new SqlCommand("INSERT INTO pacientes(nombre, apellido, telefono, direccion, cedula, fechaNacimiento, fumador, alergias, linkFoto) VALUES(@nombre, @apellido, @telefono, @direccion, @cedula, @fechaNacimiento, @fumador, @alergias, @linkFoto)", connection);
                    query.Parameters.AddWithValue("@nombre", user.nombre);
                    query.Parameters.AddWithValue("@apellido", user.apellido);
                    query.Parameters.AddWithValue("@telefono", user.telefono);
                    query.Parameters.AddWithValue("@direccion", user.direccion);
                    query.Parameters.AddWithValue("@cedula", user.cedula);
                    query.Parameters.AddWithValue("@fechaNacimiento", user.fechaNacimiento);
                    query.Parameters.AddWithValue("@fumador", user.fumador);
                    query.Parameters.AddWithValue("@alergias", user.alergias);
                    query.Parameters.AddWithValue("@linkFoto", user.linkFoto);
     



                    query.ExecuteNonQuery();
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

                SqlCommand verificarusuario = new SqlCommand("SELECT cedula FROM pacientes WHERE cedula = @cedula", connection);
                verificarusuario.Parameters.AddWithValue("@cedula", user);
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
