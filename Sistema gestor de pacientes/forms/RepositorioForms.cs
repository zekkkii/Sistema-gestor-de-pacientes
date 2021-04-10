using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Sistema_gestor_de_pacientes.forms.credenciales;

namespace Sistema_gestor_de_pacientes.forms
{
    public class RepositorioForms
    {
        public static RepositorioForms Instacia {get; set;} = new RepositorioForms();

        public frmLogin login = new frmLogin();

    }
}
