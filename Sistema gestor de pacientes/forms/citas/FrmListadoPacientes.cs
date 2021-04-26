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


namespace Sistema_gestor_de_pacientes.forms.citas
{
    public partial class FrmListadoPacientes : Form
    {
        public VerListado_Pacientes iniciarServicioListar { get; set; }
        public SqlConnection connection { get; set; }

        public Buscar_Paciente buscar { get; set; }

        public FrmListadoPacientes()
        {
            InitializeComponent();
            string connectionString = ConfigurationManager.ConnectionStrings["Default"].ConnectionString;
            connection = new SqlConnection(connectionString);
            iniciarServicioListar = new VerListado_Pacientes(connection);
            buscar = new Buscar_Paciente(connection);
        }
        #region Eventos
        private void FrmListadoPacientes_Load(object sender, EventArgs e)
        {
            CargarDgv();
            BtnSiguientePaso.Visible = false;
        }

        private void BtnSiguientePaso_Click(object sender, EventArgs e)
        {
            LoadFrmCrear();
        }
        private void DgvListadoPacientes_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0)
            {
                RepositorioForms.Instancia.IndexSeleccionado = Convert.ToInt32(DgvListadoPacientes.Rows[e.RowIndex].Cells[0].Value.ToString());

                BtnSiguientePaso.Visible = true;
             
            }
        }
        private void BtnBuscarListadoPacientes_Click(object sender, EventArgs e)
        {
            if (TxtListadoPacientes.Text != "")
            {
                BusquedaFiltrada(TxtListadoPacientes.Text);
            }
            else
            {
                MessageBox.Show("Debe pasar parametros para hacer la busqueda...");
            }
        }
        #endregion



        #region Metodos
        private void LoadFrmCrear()
        {
            FrmListadoMedicos listadoMedicos = new FrmListadoMedicos();
            listadoMedicos.Show();
            this.Close();
        }

        public void CargarDgv()
        {
            DataTable data = iniciarServicioListar.listar();
            DgvListadoPacientes.DataSource = data;
            DgvListadoPacientes.ClearSelection();
        }

        public void BusquedaFiltrada(string datos)
        {
            DataTable data = buscar.listar(datos);
            DgvListadoPacientes.DataSource = data;
            DgvListadoPacientes.ClearSelection();
        }
        #endregion

    }
}
