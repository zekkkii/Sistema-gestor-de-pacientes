using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataBase.DB.citas
{
    public class Service_Listar_Pruebas_Laboratorio
    {
        private SqlConnection connection;

        public Service_Listar_Pruebas_Laboratorio(SqlConnection connection)
        {
            this.connection = connection;
        }

        public DataTable listar()
        {

            SqlDataAdapter query =
                new SqlDataAdapter("SELECT * FROM pruebas_laboratorio", connection);

            DataTable data = new DataTable();

            connection.Open();
            query.Fill(data);
            connection.Close();

            return data;

        }
    }
}
