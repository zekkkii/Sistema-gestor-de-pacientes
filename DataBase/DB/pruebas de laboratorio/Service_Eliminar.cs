using DataBase.DB.models;
using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataBase.DB.pruebas_de_laboratorio
{
    public class Service_Eliminar
    {
        private SqlConnection connection;

        public Service_Eliminar(SqlConnection connection)
        {
            this.connection = connection;
        }

        public bool eliminar(int id)
        {
            try
            {             
                    connection.Open();

                    SqlCommand query =
                       new SqlCommand("DELETE FROM pruebas_laboratorio WHERE id = @id", connection);
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
