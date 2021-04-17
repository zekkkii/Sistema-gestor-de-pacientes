using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataBase.DB.citas
{
    public class Service_Cambiar_Estado_Resultados_Prueba
    {
        private SqlConnection connection;

        public Service_Cambiar_Estado_Resultados_Prueba(SqlConnection connection)
        {
            this.connection = connection;
        }

        public bool guardarResultados(int id, string resultados)
        {
            try
            {
                connection.Open();

                SqlCommand query =
                   new SqlCommand("UPDATE resultados_pruebas_laboratorio SET resultados = @resultados, estado = 'completado' where id = @id", connection);
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
