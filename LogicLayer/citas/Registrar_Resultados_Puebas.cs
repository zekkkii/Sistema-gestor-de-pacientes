using DataBase.DB.citas;
using DataBase.DB.models;
using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LogicLayer.citas
{
    public class Registrar_Resultados_Puebas
    {
        public Service_Registrar_Resultados_Puebas iniciarServicio { get; set; }

        public Registrar_Resultados_Puebas(SqlConnection connection)
        {
            iniciarServicio = new Service_Registrar_Resultados_Puebas(connection);
        }


        public bool registro(int idCita, RespuestaPruebaLaboratorio prueba)
        {
            bool registrar = iniciarServicio.registrar(idCita, prueba);

            if (registrar)
            {
                // se creo el usuario
                return true;
            }
            // no se creo el usuario
            return false;
        }
    }
}
