using DataBase.DB.models;
using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataBase.DB.citas
{
    public class Service_Registrar_Resultados_Puebas
    {
        private SqlConnection connection;

        public Service_Registrar_Resultados_Puebas(SqlConnection connection)
        {
            this.connection = connection;
        }

        public bool registrar(int idCita, RespuestaPruebaLaboratorio data)
        {

            //inicio el comando a ejecutar, limpio el codigo para evitar injections, paso a funcion execute donde se abre conexion, corre query y cierra conexion. 
            try
            {              
                    connection.Open();

                    SqlCommand query =
                       new SqlCommand("INSERT INTO resultados_pruebas_laboratorio(idPaciente, idCita, idPrueba_lab, idDoctor, resultados, estado)	values(@idPaciente, @idCita, @idPrueba_lab, @idDoctor, @resultados, 'pendiente')", connection);
                    query.Parameters.AddWithValue("@idPaciente", data.idPaciente);
                    query.Parameters.AddWithValue("@cedula", data.cedula);
                    query.Parameters.AddWithValue("@idPrueba_lab", data.idPrueba_lab);
                    query.Parameters.AddWithValue("@resultados", data.resultados);

                SqlCommand actualizarEstadoCita = new SqlCommand("UPDATE citas SET estadoCita = 'pendiente de resultados' WHERE id =@id", connection);
                actualizarEstadoCita.Parameters.AddWithValue("@id", idCita);

                query.ExecuteNonQuery();
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
