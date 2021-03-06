using System;
using DataBase.DB.usuarios;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;

namespace LogicLayer.usuarios
{
    public class VerListado
    {
        public Service_Listar iniciarServicio { get; set; }

        public VerListado(SqlConnection connection)
        {
            iniciarServicio = new Service_Listar(connection);
        }

        public DataTable listar()
        {
            // se llama a la DB y se cargan los datos obtenidos en un datable que luego se carga al datagrid            
            DataTable data = iniciarServicio.listar();
            return data;
        }
    }
}
