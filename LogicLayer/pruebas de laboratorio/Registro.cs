using DataBase.DB.pruebas_de_laboratorio;
using DataBase.DB.models;
using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LogicLayer.pruebas_de_laboratorio
{
    public class Registro
    {
        public Service_Registrar iniciarServicio { get; set; }

        public Registro(SqlConnection connection)
        {
            iniciarServicio = new Service_Registrar(connection);
        }


        public bool registro(PruebaLaboratorio user)
        {
            bool registrar = iniciarServicio.registrar(user);

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
