using DataBase.DB.models;
using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataBase.DB.pacientes
{
    public class Service_Editar
    {
        private SqlConnection connection;

        public Service_Editar(SqlConnection connection)
        {
            this.connection = connection;
        }

        public bool editar(int id,Paciente user)
        {
            try
            {
                connection.Open();

                SqlCommand query = new SqlCommand("UPDATE pacientes SET nombre = @nombre, apellido = @apellido, telefono = @telefono, direccion = @direccion, cedula = @cedula, fechaNacimiento = @fechaNacimiento, fumador = @fumador, alergias = @alergias, linkFoto = @linkFoto WHERE id = @id", connection);
                query.Parameters.AddWithValue("@nombre", user.nombre);
                query.Parameters.AddWithValue("@apellido", user.apellido);
                query.Parameters.AddWithValue("@telefono", user.telefono);
                query.Parameters.AddWithValue("@direccion", user.direccion);
                query.Parameters.AddWithValue("@cedula", user.cedula);
                query.Parameters.AddWithValue("@fechaNacimiento", user.fechaNacimiento);
                query.Parameters.AddWithValue("@fumador", user.fumador);
                query.Parameters.AddWithValue("@alergias", user.alergias);
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
