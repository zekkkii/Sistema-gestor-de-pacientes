using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataBase.DB.citas
{
    public class Service_Listar_Resultado_Puebas_paciente
    {
        private SqlConnection connection;

        public Service_Listar_Resultado_Puebas_paciente(SqlConnection connection)
        {
            this.connection = connection;
        }

        public DataTable listar(int id)
        {

            SqlDataAdapter query =
                new SqlDataAdapter("SELECT r.id, p.nombre, p.apellido, p.cedula, pl.nombre, r.resultados, r.estado from resultados_pruebas_laboratorio r " +
                "INNER JOIN pacientes p on r.idPaciente = p.id" +
                "INNER JOIN pruebas_laboratorio pl on r.idPrueba_lab = pl.id" +
                "WHERE r.resultados = 'pendiente' AND r.idPaciente = @id", connection);
            query.SelectCommand.Parameters.AddWithValue("@id", id);

            DataTable data = new DataTable();

            connection.Open();
            query.Fill(data);
            connection.Close();

            return data;

        }
    }
}
