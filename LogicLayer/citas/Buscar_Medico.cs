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
    public class Buscar_Medico
    {
        public Service_Buscar_Medicos iniciarServicio { get; set; }

        public Buscar_Medico(SqlConnection connection)
        {
            iniciarServicio = new Service_Buscar_Medicos(connection);
        }

        public DataTable listar(string cedula)
        {
            // se llama a la DB y se cargan los datos obtenidos en un datable que luego se carga al datagrid            
            DataTable data = iniciarServicio.listar(cedula);
            return data;
        }
    }
}
