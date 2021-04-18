using DataBase.DB.citas;
using System;
using DataBase.DB.models;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LogicLayer.citas
{
    public class Cambiar_Estado_Cita_Completada
    {
        public Service_Cambiar_Estado_Cita_Completada iniciarServicio { get; set; }

        public Cambiar_Estado_Cita_Completada(SqlConnection connection)
        {
            iniciarServicio = new Service_Cambiar_Estado_Cita_Completada(connection);
        }

        public bool editar(int id)
        {
            bool fueExitoso = iniciarServicio.cambiar(id);
            if (fueExitoso) return true;
            //si no se borro devuelve false
            return false;
        }
    }
}
