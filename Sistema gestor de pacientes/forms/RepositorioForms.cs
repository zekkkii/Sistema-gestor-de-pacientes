using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Sistema_gestor_de_pacientes.forms.usuarios;
using Sistema_gestor_de_pacientes.forms.pacientes;
using Sistema_gestor_de_pacientes.forms.medicos;
using Sistema_gestor_de_pacientes.forms.citas;
using Sistema_gestor_de_pacientes.forms.pruebas_de_laboratorio;
using Sistema_gestor_de_pacientes.forms.resultados_pruebas_laboratorio;


namespace Sistema_gestor_de_pacientes.forms
{
    public class RepositorioForms
    {
        public static RepositorioForms Instancia {get; set;} = new RepositorioForms();

        public frmLogin login = new frmLogin();

        public int IndexSeleccionado { get; set; }

        public int IndexPacienteSeleccionado { get; set; }

        public int IndexMedicoSeleccionado { get; set; }
    }
}
