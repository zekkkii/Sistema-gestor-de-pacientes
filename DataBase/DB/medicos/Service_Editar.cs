using DataBase.DB.models;
using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataBase.DB.medicos
{
    public class Service_Editar
    {
        private SqlConnection connection;

        public Service_Editar(SqlConnection connection)
        {
            this.connection = connection;
        }

        public bool editar(int id,Medico user)
        {
            try
            {
                connection.Open();

                SqlCommand query = new SqlCommand("UPDATE medicos SET nombre = @nombre, apellido = @apellido, correo = @correo, telefono = @telefono, cedula = @cedula, linkFoto = @linkFoto where id = @id", connection);
                query.Parameters.AddWithValue("@id", id);
                query.Parameters.AddWithValue("@nombre", user.nombre);
                query.Parameters.AddWithValue("@apellido", user.apellido);
                query.Parameters.AddWithValue("@correo", user.correo);
                query.Parameters.AddWithValue("@telefono", user.telefono);
                query.Parameters.AddWithValue("@cedula", user.cedula);
                query.Parameters.AddWithValue("@linkFoto", user.linkFoto);

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
