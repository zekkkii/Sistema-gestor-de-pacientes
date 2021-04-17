using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataBase.DB.citas
{
    public class Service_Listar
    {
        private SqlConnection connection;

        public Service_Listar(SqlConnection connection)
        {
            this.connection = connection;
        }

        public DataTable listar()
        {
            
            SqlDataAdapter query =
                new SqlDataAdapter("SELECT c.id, p.nombre, p.apellido, m.nombre, c.fechaCita, c.horaCita, c.causaCita, c.estadoCita from citas c" +
                "INNER JOIN pacientes p on c.idPaciente = p.id" +
                "INNER JOIN medicos m on c.idDoctor = m.id", connection);

            DataTable data = new DataTable();

            connection.Open();
            query.Fill(data);
            connection.Close();

            return data;

        }
    }
}
