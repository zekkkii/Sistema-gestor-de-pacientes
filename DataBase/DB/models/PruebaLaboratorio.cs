using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataBase.DB.models
{
    public class PruebaLaboratorio
    {
        public string nombre { get; set; }
        public int idPaciente { get; set; }
        public string cedulaPaciente { get; set; }

        public PruebaLaboratorio(string nombre, int idPaciente, string cedulaPaciente)
        {
            this.nombre = nombre;
            this.idPaciente = idPaciente;
            this.cedulaPaciente = cedulaPaciente;
        }
    }
}
