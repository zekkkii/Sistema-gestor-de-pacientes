using DataBase.DB.models;
using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataBase.DB.pruebas_de_laboratorio
{
    public class Service_Editar
    {
        private SqlConnection connection;

        public Service_Editar(SqlConnection connection)
        {
            this.connection = connection;
        }

        public bool editar(int id,PruebaLaboratorio user)
        {
            try
            {
                connection.Open();

                SqlCommand query = new SqlCommand("UPDATE pruebas_laboratorio SET nombre = @nombre WHERE id = @id", connection);
                query.Parameters.AddWithValue("@nombre", user.nombre);
                query.Parameters.AddWithValue("@id", id);

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
