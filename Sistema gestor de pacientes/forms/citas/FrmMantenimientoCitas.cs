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
using LogicLayer.citas;
using Sistema_gestor_de_pacientes.forms.menu_principal;

namespace Sistema_gestor_de_pacientes.forms.citas
{
    public partial class FrmMantenimientoCitas : Form
    {
        public VerListado iniciarServicioListar { get; set; }
        public SqlConnection connection { get; set; }

        public frmMenuPrincipal VolverAlMenu { get; set; }

        public FrmMantenimientoCitas()
        {
            InitializeComponent();
            string connectionString = ConfigurationManager.ConnectionStrings["Default"].ConnectionString;
            connection = new SqlConnection(connectionString);
            iniciarServicioListar = new VerListado(connection);
            VolverAlMenu = new frmMenuPrincipal();
        }

        #region Eventos
        private void FrmMantenimientoCitas_Load(object sender, EventArgs e)
        {
            CargarDgv();

            BtnEliminarCita.Visible = false;
            BtnConsultar.Visible = false;
            BtnConsultarResultados.Visible = false;
            BtnVerResultados.Visible = false;
        }
        private void BtnNewCrearCita_Click(object sender, EventArgs e)
        {
            LoadFrmCrear();
        }
        private void DgvMantenimientoCitas_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0)
            {
                RepositorioForms.Instancia.IndexSeleccionado = Convert.ToInt32(DgvMantenimientoCitas.Rows[e.RowIndex].Cells[0].Value.ToString());


                BtnEliminarCita.Visible = true;
            }

        }
        private void BtnVolver_Click(object sender, EventArgs e)
        {
            VolverAlMenu.Show();
            this.Close();
        }
        #endregion



        #region Metodos
        public void CargarDgv()
        {
            DataTable data = iniciarServicioListar.listar();
            DgvMantenimientoCitas.DataSource = data;
            DgvMantenimientoCitas.ClearSelection();
        }

        private void eliminar()
        {

        }

        private void LoadFrmCrear()
        {

            FrmListadoPacientes listadoPacientes = new FrmListadoPacientes();
            listadoPacientes.Show();
            this.Close();

        }

        #endregion

       
    }
}
