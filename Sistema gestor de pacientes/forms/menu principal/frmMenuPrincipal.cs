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
using Sistema_gestor_de_pacientes.forms.usuarios;
using Sistema_gestor_de_pacientes.forms.citas;
using Sistema_gestor_de_pacientes.forms.medicos;
using Sistema_gestor_de_pacientes.forms.pacientes;
using Sistema_gestor_de_pacientes.forms.pruebas_de_laboratorio;
using Sistema_gestor_de_pacientes.forms.resultados_pruebas_laboratorio;


namespace Sistema_gestor_de_pacientes.forms.menu_principal
{
    public partial class frmMenuPrincipal : Form
    {

        #region desactivar boton cerrar
        private const int CP_NOCLOSE_BUTTON = 0x200;
        protected override CreateParams CreateParams
        {
            get
            {
                CreateParams myCp = base.CreateParams;
                myCp.ClassStyle = myCp.ClassStyle | CP_NOCLOSE_BUTTON;
                return myCp;
            }
        }
        #endregion

        public SqlConnection connection { get; set; }

        public frmMenuPrincipal()
        {
            InitializeComponent();
            string connectionString = ConfigurationManager.ConnectionStrings["Default"].ConnectionString;
            connection = new SqlConnection(connectionString);
        }

        #region Eventos
        private void frmMenuPrincipal_Load(object sender, EventArgs e)
        {
            
        }

        private void BtnMantenimientoUsuarios_Click(object sender, EventArgs e)
        {
            Load_frmUsuarios();
        }

        private void BtnMantenimientoMedicos_Click(object sender, EventArgs e)
        {
            Load_frmMedicos();
        }

        private void BtnMantenimientoPruebasLab_Click(object sender, EventArgs e)
        {
            Load_frmPruebasLab();
        }

        private void BtnMantenimientoPacientes_Click(object sender, EventArgs e)
        {
            Load_frmPacientes();
        }

        private void BtnMantenimientoCitas_Click(object sender, EventArgs e)
        {
            Load_frmCitas();
        }

        private void BtnMantenimientoResultadosPruebasLab_Click(object sender, EventArgs e)
        {
            Load_frmResultadosPruebasLab();
        }
        private void cerrarSesionToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Cerrar_Sesion();
        }
        #endregion



        #region Metodos
        private void Load_frmUsuarios()
        {
            FrmMantenimientoUsuario mantenimientoUsuario = new FrmMantenimientoUsuario();
            mantenimientoUsuario.Show();
            this.Close();
        }


        private void Load_frmPacientes()
        {
            FrmMantenimientoPacientes mantenimientoPacientes = new FrmMantenimientoPacientes();
            mantenimientoPacientes.Show();
            this.Close();
        }

        private void Load_frmMedicos()
        {
            FrmMantenimientoMedicos mantenimientoMedicos = new FrmMantenimientoMedicos();
            mantenimientoMedicos.Show();
            this.Close();
        }

        private void Load_frmPruebasLab()
        {
            FrmMantenimientoPruebasLab mantenimientoPruebasLab = new FrmMantenimientoPruebasLab();
            mantenimientoPruebasLab.Show();
            this.Close();
        }

        private void Load_frmResultadosPruebasLab()
        {
            FrmMantenimientoResultadoPruebasLab mantenimientoResultadoPruebasLab = new FrmMantenimientoResultadoPruebasLab();
            mantenimientoResultadoPruebasLab.Show();
            this.Close();
        }

        private void Load_frmCitas()
        {
            FrmMantenimientoCitas mantenimientoCitas = new FrmMantenimientoCitas();
            mantenimientoCitas.Show();
            this.Close();
        }

        private void Cerrar_Sesion()
        {
            RepositorioForms.Instancia.login.Show();
            this.Close();

        }

        #endregion


    }
}
