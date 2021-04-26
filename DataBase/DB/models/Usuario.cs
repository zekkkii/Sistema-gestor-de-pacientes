using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataBase.DB.models
{
    public class Usuario
    {
        public string nombre { get; set; }
        public string apellido { get; set; }
        public string correo { get; set; }
        public string usuario { get; set; }
        public string password { get; set; }
        public int tipoUsuario { get; set; }

        public Usuario(string nombre, string apellido, string correo, string usuario, string password, int tipoUsuario)
        {
            this.nombre = nombre;
            this.apellido = apellido;
            this.correo = correo;
            this.usuario = usuario;
            this.password = password;
            this.tipoUsuario = tipoUsuario;
            
        }

    }
}
