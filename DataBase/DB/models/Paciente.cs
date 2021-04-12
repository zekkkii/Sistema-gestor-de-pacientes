using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataBase.DB.models
{
    public class Paciente
    {

        public string nombre { get; set; }
        public string apellido { get; set; }
        public string telefono { get; set; }
        public string direccion { get; set; }
        public string cedula { get; set; }
        public string fechaNacimiento { get; set; }
        public bool fumador { get; set; }
        public string alergias { get; set; }
        public string linkFoto { get; set; }       
         

        public Paciente(string nombre, string apellido, string telefono, string direccion, string cedula, string fechaNacimiento, bool fumador, string alergias, string linkFoto)
        {
            
            this.nombre = nombre;
            this.apellido = apellido;
            this.telefono = telefono;
            this.direccion = direccion;
            this.cedula = cedula;
            this.fechaNacimiento = fechaNacimiento;
            this.fumador = fumador;
            this.alergias = alergias;
           this.linkFoto = linkFoto;

        }
    }
}
