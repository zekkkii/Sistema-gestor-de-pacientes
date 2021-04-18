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
        public string fechaHoraCita { get; set; }
        public string causaCita { get; set; }
       
       
        public Cita(int idPaciente, int idDoctor, string fechaHoraCita, string causaCita)
        {
            this.idPaciente = idPaciente;
            this.idDoctor = idDoctor;
            this.fechaHoraCita = fechaHoraCita;
            this.causaCita = causaCita;
            
        }
    }
}
