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
using LogicLayer.medicos;

namespace Sistema_gestor_de_pacientes.forms.medicos
{
    public partial class FrmMantenimientoMedicos : Form
    {
        public VerListado iniciarServicioListar { get; set; }
        public SqlConnection connection { get; set; }


        public FrmMantenimientoMedicos()
        {
            InitializeComponent();
            string connectionString = ConfigurationManager.ConnectionStrings["Default"].ConnectionString;
            connection = new SqlConnection(connectionString);
            iniciarServicioListar = new VerListado(connection);

        }
        #region Eventos
        private void FrmMantenimientoMedicos_Load(object sender, EventArgs e)
        {

        }
        private void BtnCrearMedico_Click(object sender, EventArgs e)
        {

        }
        private void BtnEditarMedico_Click(object sender, EventArgs e)
        {

        }
        private void BtnEliminarMedico_Click(object sender, EventArgs e)
        {

        }
        #endregion

        #region Metodos
        private void CrearMedico()
        {

        }

        private void editar()
        {

        }

        private void eliminar()
        {

        }
     
        public void CargarDgv()
        {

        }

        private void LoadFrmCrear()
        {

        }

        private void LoadFrmEditar()
        {

        }

        private void LoadFrmEliminar()
        {

        }
        #endregion

    }
}
