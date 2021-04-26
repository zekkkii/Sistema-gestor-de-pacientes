using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Sistema_gestor_de_pacientes
{
    public class ComboBox_Tipo_Usuario
    {

        public string Text { get; set; }

        public int Value { get; set; }

        public override string ToString()
        {
            return Text;
        }

    }
}
