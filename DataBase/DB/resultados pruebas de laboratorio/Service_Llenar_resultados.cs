using DataBase.DB.models;
using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataBase.DB.resultados_pruebas_de_laboratorio
{
    public class Service_Llenar_resultados
    {
        private SqlConnection connection;

        public Service_Llenar_resultados(SqlConnection connection)
        {
            this.connection = connection;
        }

        public bool llenar(int id, string resultados)
        {
            try
            {
                connection.Open();

                SqlCommand query = new SqlCommand("UPDATE resultados_pruebas_laboratorio SET resultados = @resultados, estado = 'completado' where id = @id", connection);
                query.Parameters.AddWithValue("@id", id);
                query.Parameters.AddWithValue("@resultados", resultados);


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
