using DataBase.DB.models;
using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataBase.DB.usuarios
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

                    SqlCommand introducirUser =
                       new SqlCommand("DELETE FROM usuarios WHERE id = @id", connection);
                    introducirUser.Parameters.AddWithValue("@id", id);

                    introducirUser.ExecuteNonQuery();
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
