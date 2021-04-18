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
    public class Registro
    {
        public Service_Registrar iniciarServicio { get; set; }

        public Registro(SqlConnection connection)
        {
            iniciarServicio = new Service_Registrar(connection);
        }


        public bool registro(Cita cita)
        {
            bool registrar = iniciarServicio.registrar(cita);

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
