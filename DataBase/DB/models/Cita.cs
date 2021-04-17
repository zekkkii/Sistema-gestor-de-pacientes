using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataBase.DB.models
{
    public class Cita
    {
        public int idPaciente { get; set; }
        public int idDoctor { get; set; }
        public string fechaCita { get; set; }
        public string horaCita { get; set; }
        public string causaCita { get; set; }
       
       
        public Cita(int idPaciente, int idDoctor, string fechaCita, string horaCita, string causaCita, string estadoCita)
        {
            this.idPaciente = idPaciente;
            this.idDoctor = idDoctor;
            this.fechaCita = fechaCita;
            this.horaCita = horaCita;
            this.causaCita = causaCita;
            
        }
    }
}
