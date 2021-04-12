using DataBase.DB.credenciales;
using DataBase.DB.models;
using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LogicLayer.credenciales
{
    public class Registro
    {
        public Registrar iniciarServicio { get; set; }

        public Registro(SqlConnection connection)
        {
            iniciarServicio = new Registrar(connection);
        }


        public bool registro(Usuario user)
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
