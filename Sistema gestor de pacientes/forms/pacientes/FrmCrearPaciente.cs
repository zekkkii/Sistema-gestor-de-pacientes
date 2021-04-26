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
using DataBase.DB.models;
using LogicLayer.pacientes;

namespace Sistema_gestor_de_pacientes.forms.pacientes
{
    public partial class FrmCrearPaciente : Form
    {
        public Registro iniciarServicio { get; set; }
        public SqlConnection connection { get; set; }

        public FrmMantenimientoPacientes actualizar { get; set; }

        //terminar

        public FrmCrearPaciente()
        {
            InitializeComponent();
            string connectionString = ConfigurationManager.ConnectionStrings["Default"].ConnectionString;
            connection = new SqlConnection(connectionString);
            iniciarServicio = new Registro(connection);
            actualizar = new FrmMantenimientoPacientes();
        }

        #region Eventos
        private void FrmCrearPaciente_Load(object sender, EventArgs e)
        {
     
        }

        private void BtnCrearNewPaciente_Click(object sender, EventArgs e)
        {

        }

        private void BtnSubirFotoPaciente_Click(object sender, EventArgs e)
        {
           
        }
        #endregion


        #region Metodos
       
        #endregion
    }
}
