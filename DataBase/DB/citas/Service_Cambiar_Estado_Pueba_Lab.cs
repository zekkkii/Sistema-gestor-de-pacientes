using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataBase.DB.pacientes
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
                new SqlDataAdapter("SELECT id, nombre, apellido, telefono, direccion,cedula,fechaNacimiento as 'Fecha de nacimiento',fumador, alergias FROM pacientes", connection);

            DataTable data = new DataTable();

            connection.Open();
            query.Fill(data);
            connection.Close();

            return data;

        }
    }
}
