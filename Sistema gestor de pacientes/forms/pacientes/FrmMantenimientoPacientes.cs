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
using LogicLayer.pacientes;

namespace Sistema_gestor_de_pacientes.forms.pacientes
{
    public partial class FrmMantenimientoPacientes : Form
    {
        public VerListado iniciarServicio { get; set; }
        public SqlConnection connection { get; set; }


        public FrmMantenimientoPacientes()
        {
            InitializeComponent();
            string connectionString = ConfigurationManager.ConnectionStrings["Default"].ConnectionString;
            connection = new SqlConnection(connectionString);
            iniciarServicio = new VerListado(connection);

        }

        private void FrmMantenimientoPacientes_Load(object sender, EventArgs e)
        {

        }
    }
}
