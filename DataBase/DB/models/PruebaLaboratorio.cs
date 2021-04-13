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
       

        public PruebaLaboratorio(string nombre)
        {
            this.nombre = nombre;
           
        }
    }
}
