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
using LogicLayer.resultado_pruebas_de_laboratorio;
using Sistema_gestor_de_pacientes.forms.menu_principal;

namespace Sistema_gestor_de_pacientes.forms.resultados_pruebas_laboratorio
{
    public partial class FrmMantenimientoResultadoPruebasLab : Form
    {
        public VerListado iniciarServicioListar { get; set; }
        public SqlConnection connection { get; set; }
        public frmMenuPrincipal VolverAlMenu { get; set; }
        public Buscar buscar { get; set; }


        public FrmMantenimientoResultadoPruebasLab()
        {
            InitializeComponent();
            string connectionString = ConfigurationManager.ConnectionStrings["Default"].ConnectionString;
            connection = new SqlConnection(connectionString);
            iniciarServicioListar = new VerListado(connection);
            VolverAlMenu = new frmMenuPrincipal();
            buscar = new Buscar(connection);

        }

        #region eventos


        private void FrmMantenimientoResultadoPruebasLab_Load(object sender, EventArgs e)
        {
            CargarDgv();
            BtnReportarResultadoPruebasLab.Visible = false;
        }

      

        private void BtnReportarResultadoPruebasLab_Click(object sender, EventArgs e)
        {
            LoadFrmCrearResultado();
        }

        private void BtnBuscarMantenimientoResultadoPruebasLab_Click(object sender, EventArgs e)
        {
            if (TxtBuscarMantenimientoResultadoPruebasLab.Text != "")
            {
                BusquedaFiltrada(TxtBuscarMantenimientoResultadoPruebasLab.Text);
            }
            else
            {
                MessageBox.Show("Debe pasar parametros para hacer la busqueda...");
            }
        }

        private void BtnVolver_Click(object sender, EventArgs e)
        {
            VolverAlMenu.Show();
            this.Close();
        }

        private void DgvMantenimientoResultadoPruebasLab_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0)
            {
                RepositorioForms.Instancia.IndexSeleccionado = Convert.ToInt32(DgvMantenimientoResultadoPruebasLab.Rows[e.RowIndex].Cells[0].Value.ToString());

                BtnReportarResultadoPruebasLab.Visible = true;
            }
        }

        #endregion

        #region Metodos
        private void LoadFrmCrearResultado()
        {
            FrmReportarMantenimientoResultadoPruebasLab crearUsuario = new FrmReportarMantenimientoResultadoPruebasLab();
            crearUsuario.Show();
            this.Close();
        }

        public void CargarDgv()
        {
            DataTable data = iniciarServicioListar.listar();
            DgvMantenimientoResultadoPruebasLab.DataSource = data;
            DgvMantenimientoResultadoPruebasLab.ClearSelection();

        }

        public void BusquedaFiltrada(string datos)
        {
            DataTable data = buscar.listar(datos);
            DgvMantenimientoResultadoPruebasLab.DataSource = data;
            DgvMantenimientoResultadoPruebasLab.ClearSelection();
        }

        #endregion

    }
}
