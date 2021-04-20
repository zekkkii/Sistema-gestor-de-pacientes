using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Configuration;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using LogicLayer.usuarios;

namespace Sistema_gestor_de_pacientes.forms.usuarios
{
    public partial class FrmEditarUsuario : Form
    {
        public Servicio iniciarServicio { get; set; }
        public SqlConnection connection { get; set; }


        public FrmEditarUsuario()
        {
            InitializeComponent();
            string connectionString = ConfigurationManager.ConnectionStrings["Default"].ConnectionString;
            connection = new SqlConnection(connectionString);
            iniciarServicio = new Servicio(connection);

        }

        private void FrmEditarUsuario_Load(object sender, EventArgs e)
        {

        }
    }
}
