using System;
 using DataBase.DB.resultados_pruebas_de_laboratorio;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;

namespace LogicLayer.resultado_pruebas_de_laboratorio
{
    public class Buscar
    {
        public Service_Buscar iniciarServicio { get; set; }

        public Buscar(SqlConnection connection)
        {
            iniciarServicio = new Service_Buscar(connection);
        }

        public DataTable listar(string cedula)
        {
            // se llama a la DB y se cargan los datos obtenidos en un datable que luego se carga al datagrid            
            DataTable data = iniciarServicio.listar(cedula);
            return data;
        }
    }
}
