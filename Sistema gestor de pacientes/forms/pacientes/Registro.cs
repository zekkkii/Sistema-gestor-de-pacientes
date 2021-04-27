using DataBase.DB.pacientes;
using DataBase.DB.models;
using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;
using LogicLayer.persistenthelper;

namespace LogicLayer.pacientes
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



        public bool registro(Paciente user)
        {
            string directory = @"Images\Persona\" +4 + "\\";

            string fileName =  Path.GetFileName(user.linkFoto);

            string destination = directory + fileName;

            CreateDirectory(directory);

            File.Copy(user.linkFoto, destination, true);

            user.linkFoto = destination;

            bool registrar = iniciarServicio.registrar(user);

            if (registrar)
            {
                // se creo el usuario
                return true;
            }
            // no se creo el usuario
            return false;
        }

        private void CreateDirectory(string directory)
        {
            if (!Directory.Exists(directory))
            {
                Directory.CreateDirectory(directory);
            }
        }
    }
}
