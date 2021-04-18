using DataBase.DB.models;
using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataBase.DB.citas
{
    public class Service_Registrar
    {
        private SqlConnection connection;

        public Service_Registrar(SqlConnection connection)
        {
            this.connection = connection;
        }

        public bool registrar(Cita user)
        {

            //inicio el comando a ejecutar, limpio el codigo para evitar injections, paso a funcion execute donde se abre conexion, corre query y cierra conexion. 
            try
            {              
                    connection.Open();

                    SqlCommand query =
                       new SqlCommand("INSERT INTO citas(idPaciente, idDoctor, fechaHoraCita, causaCita, estadoCita) VALUES(@idPaciente, @idDoctor, @fechaHoraCita, @causaCita, 'pendiente de consulta')", connection);
                    query.Parameters.AddWithValue("@idPaciente", user.idPaciente);
                    query.Parameters.AddWithValue("@idDoctor", user.idDoctor);
                    query.Parameters.AddWithValue("@fechaHoraCita", user.fechaHoraCita);
                    query.Parameters.AddWithValue("@causaCita", user.causaCita);
                   
          
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
