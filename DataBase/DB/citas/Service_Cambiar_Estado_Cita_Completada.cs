using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataBase.DB.citas
{
    public class Service_Cambiar_Estado_Cita_Completada
    {
        private SqlConnection connection;

        public Service_Cambiar_Estado_Cita_Completada(SqlConnection connection)
        {
            this.connection = connection;
        }

        public bool cambiar(int idCita)
        {
            try
            {
                SqlCommand actualizarEstadoCita = new SqlCommand("UPDATE citas SET estadoCita = 'completado' WHERE id =@id", connection);
                actualizarEstadoCita.Parameters.AddWithValue("@id", idCita);

                connection.Open();
                actualizarEstadoCita.ExecuteNonQuery();
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
