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
    public partial class FrmListadoMedicos : Form
    {
        public VerListado_Medicos iniciarServicioListar { get; set; }
        public SqlConnection connection { get; set; }

        public Buscar_Medico buscar { get; set; } 

        public FrmListadoMedicos()
        {
            InitializeComponent();
            string connectionString = ConfigurationManager.ConnectionStrings["Default"].ConnectionString;
            connection = new SqlConnection(connectionString);
            iniciarServicioListar = new VerListado_Medicos(connection);
            buscar = new Buscar_Medico(connection);
        }

        #region Eventos
        private void FrmListadoMedicos_Load(object sender, EventArgs e)
        {
            CargarDgv();

            BtnSiguientePaso.Visible = false;
        }
        private void BtnSiguientePaso_Click(object sender, EventArgs e)
        {
            LoadFrmCrear();
        }
        private void DgvListadoMedicos_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            RepositorioForms.Instancia.IndexSeleccionado = Convert.ToInt32(DgvListadoMedicos.Rows[e.RowIndex].Cells[0].Value.ToString());

            BtnSiguientePaso.Visible = true;
        }

        private void BtnBuscarListadoMedicos_Click(object sender, EventArgs e)
        {
            if (TxtBuscarListadoMedicos.Text != "")
            {
                BusquedaFiltrada(TxtBuscarListadoMedicos.Text);
            }
            else
            {
                MessageBox.Show("Debe pasar parametros para hacer la busqueda...");
            }
        }
        #endregion



        #region Metodos
        //Este metodo llama al sigte Frm
        private void LoadFrmCrear()
        {
            FrmDetallesCitas detallesCitas = new FrmDetallesCitas();
            detallesCitas.Show();
            this.Close();
        }

        public void CargarDgv()
        {
            DataTable data = iniciarServicioListar.listar();
            DgvListadoMedicos.DataSource = data;
            DgvListadoMedicos.ClearSelection();
        }

        public void BusquedaFiltrada(string datos)
        {
            DataTable data = buscar.listar(datos);
            DgvListadoMedicos.DataSource = data;
            DgvListadoMedicos.ClearSelection();
        }

        #endregion
    }

}
