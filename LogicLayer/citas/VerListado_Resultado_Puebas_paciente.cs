using System;
using DataBase.DB.citas;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;

namespace LogicLayer.citas
{
    public class VerListado_Resultado_Puebas_paciente
    {
        public Service_Listar_Resultado_Puebas_paciente iniciarServicio { get; set; }

        public VerListado_Resultado_Puebas_paciente(SqlConnection connection)
        {
            iniciarServicio = new Service_Listar_Resultado_Puebas_paciente(connection);
        }

        public DataTable listar(int id)
        {
            // se llama a la DB y se cargan los datos obtenidos en un datable que luego se carga al datagrid            
            DataTable data = iniciarServicio.listar(id);
            return data;
        }
    }
}
