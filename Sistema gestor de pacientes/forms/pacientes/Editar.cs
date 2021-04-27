﻿using DataBase.DB.pacientes;
using System;
using DataBase.DB.models;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LogicLayer.pacientes
{
    public class Editar
    {
        public Service_Editar iniciarServicio { get; set; }

        public Editar(SqlConnection connection)
        {
            iniciarServicio = new Service_Editar(connection);
        }

        public bool editar(int id, Paciente user)
        {
            bool fueExitoso = iniciarServicio.editar(id, user);
            if (fueExitoso) return true;
            //si no se borro devuelve false
            return false;
        }
    }
}
