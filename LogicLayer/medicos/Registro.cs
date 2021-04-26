using DataBase.DB.medicos;
using DataBase.DB.models;
using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using LogicLayer.persistenthelper;

namespace LogicLayer.medicos
{
    public class Registro
    {
        public Service_Registrar iniciarServicio { get; set; }
        public Serialize serialize { get; set; }

        public Registro(SqlConnection connection)
        {
            iniciarServicio = new Service_Registrar(connection);
            serialize = new Serialize();
        }


        public bool registro(Medico user)
        {
            string path = serialize.serialize(user.linkFoto,"images", "imgResources" + user.nombre);
            user.linkFoto = path;
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
