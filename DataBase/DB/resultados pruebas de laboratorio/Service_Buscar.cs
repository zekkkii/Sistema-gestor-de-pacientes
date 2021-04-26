using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataBase.DB.resultados_pruebas_de_laboratorio
{
    public class Service_Buscar
    {
        private SqlConnection connection;

        public Service_Buscar(SqlConnection connection)
        {
            this.connection = connection;
        }

        public DataTable listar(string cedula)
        {

            SqlDataAdapter query =
                new SqlDataAdapter("SELECT r.id, p.nombre, p.apellido, p.cedula, pl.nombre, resultados, estado from resultados_pruebas_laboratorio r INNER JOIN pacientes p on r.idPaciente = p.id INNER JOIN pruebas_laboratorio pl on r.idPrueba_lab = pl.id WHERE p.cedula = @cedula", connection);
            query.SelectCommand.Parameters.AddWithValue("@cedula", cedula);

            DataTable data = new DataTable();

            connection.Open();
            query.Fill(data);
            connection.Close();

            return data;

        }
    }
}
