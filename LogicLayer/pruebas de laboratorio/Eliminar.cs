using DataBase.DB.pruebas_de_laboratorio;
using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LogicLayer.pruebas_de_laboratorio
{
    public class Eliminar
    {
        public Service_Eliminar iniciarServicio { get; set; }

        public Eliminar(SqlConnection connection)
        {
            iniciarServicio = new Service_Eliminar(connection);
        }

        public bool eliminar(int id)
        {
            bool fueExitoso = iniciarServicio.eliminar(id);
            if (fueExitoso) return true;
            //si no se borro devuelve false
            return false;
        }
    }
}
