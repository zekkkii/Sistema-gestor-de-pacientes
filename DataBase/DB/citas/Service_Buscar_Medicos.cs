using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataBase.DB.citas
{
    public class Service_Buscar_Medicos
    {
        private SqlConnection connection;

        public Service_Buscar_Medicos(SqlConnection connection)
        {
            this.connection = connection;
        }

        public DataTable listar()
        {

            SqlDataAdapter query =
                new SqlDataAdapter("SELECT id, nombre, apellido, correo, telefono, cedula FROM medicos WHERE cedula = @cedula", connection);

            DataTable data = new DataTable();

            connection.Open();
            query.Fill(data);
            connection.Close();

            return data;

        }
    }
}
