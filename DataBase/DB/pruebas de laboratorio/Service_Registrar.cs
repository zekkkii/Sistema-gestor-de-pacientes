using DataBase.DB.models;
using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataBase.DB.pruebas_de_laboratorio
{
    public class Service_Registrar
    {
        private SqlConnection connection;

        public Service_Registrar(SqlConnection connection)
        {
            this.connection = connection;
        }

        public bool registrar(PruebaLaboratorio user)
        {

            //inicio el comando a ejecutar, limpio el codigo para evitar injections, paso a funcion execute donde se abre conexion, corre query y cierra conexion. 
            try
            {
                if (verificarUser(user.nombre))
                {
                    connection.Open();

                    SqlCommand query =
                       new SqlCommand("INSERT INTO pruebas_laboratorio(nombre) VALUES(@nombre)", connection);
                    query.Parameters.AddWithValue("@nombre", user.nombre);
                    


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

                SqlCommand verificarusuario = new SqlCommand("SELECT nombre FROM pruebas_laboratorio WHERE nombre = @nombre", connection);
                verificarusuario.Parameters.AddWithValue("@nombre", user);
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
