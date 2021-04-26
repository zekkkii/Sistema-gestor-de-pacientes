using DataBase.DB.resultados_pruebas_de_laboratorio;
using System;
using DataBase.DB.models;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LogicLayer.resultado_pruebas_de_laboratorio
{
    public class Llenar_Resultados
    {
        public Service_Llenar_resultados iniciarServicio { get; set; }

        public Llenar_Resultados(SqlConnection connection)
        {
            iniciarServicio = new Service_Llenar_resultados(connection);
        }

        public bool llenar(int id, string dataResultados)
        {
            bool fueExitoso = iniciarServicio.llenar(id, dataResultados);
            if (fueExitoso) return true;
            //si no se borro devuelve false
            return false;
        }
    }
}
