using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataBase.DB.models
{
    public class RespuestaPruebaLaboratorio
    {
        public int idPaciente { get; set; }
        public string cedula { get; set; }
        public int idPrueba_lab { get; set; }
        public string resultados { get; set; }
      


        public RespuestaPruebaLaboratorio(int idPaciente, string cedula, int idPrueba_lab, string resultados)
        {
            this.idPaciente = idPaciente;
            this.cedula = cedula;
            this.idPrueba_lab = idPrueba_lab;
            this.resultados = resultados;
          
        }
    }
}
