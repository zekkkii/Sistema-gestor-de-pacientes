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
    public class VerListado_Pruebas_Laboratorio
    {
        public Service_Listar_Pruebas_Laboratorio iniciarServicio { get; set; }

        public VerListado_Pruebas_Laboratorio(SqlConnection connection)
        {
            iniciarServicio = new Service_Listar_Pruebas_Laboratorio(connection);
        }

        public DataTable listar()
        {
            // se llama a la DB y se cargan los datos obtenidos en un datable que luego se carga al datagrid            
            DataTable data = iniciarServicio.listar();
            return data;
        }
    }
}
