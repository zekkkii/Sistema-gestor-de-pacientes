using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataBase.DB.models
{
    public class Medico
    {
        public string nombre { get; set; }
        public string apellido { get; set; }
        public string correo { get; set; }
        public string telefono { get; set; }
        public string cedula { get; set; }
        public string linkFoto { get; set; }

        public Medico(string nombre, string apellido, string correo, string telefono, string cedula, string linkFoto)
        {
            this.nombre = nombre;
            this.apellido = apellido;
            this.correo = correo;
            this.telefono = telefono;
            this.cedula = cedula;
            this.linkFoto = linkFoto;

        }
    }
}
