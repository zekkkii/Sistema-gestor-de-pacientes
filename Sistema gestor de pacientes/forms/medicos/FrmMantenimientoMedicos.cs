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
using Sistema_gestor_de_pacientes.forms.menu_principal;

namespace Sistema_gestor_de_pacientes.forms.medicos
{
    public partial class FrmMantenimientoMedicos : Form
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


        public VerListado iniciarServicioListar { get; set; }
        public SqlConnection connection { get; set; }

        public Eliminar iniciarServicioEliminar { get; set; }

        public frmMenuPrincipal VolverAlMenu { get; set; }


        public FrmMantenimientoMedicos()
        {
            InitializeComponent();
            string connectionString = ConfigurationManager.ConnectionStrings["Default"].ConnectionString;
            connection = new SqlConnection(connectionString);
            iniciarServicioListar = new VerListado(connection);
            iniciarServicioEliminar = new Eliminar(connection);
            VolverAlMenu = new frmMenuPrincipal();
        }
        #region Eventos
        private void FrmMantenimientoMedicos_Load(object sender, EventArgs e)
        {
            CargarDgv();
            BtnEditarMedico.Visible = false;
            BtnEliminarMedico.Visible = false;
        }
        private void BtnCrearMedico_Click(object sender, EventArgs e)
        {
            LoadFrmCrear();
        }
        private void BtnEditarMedico_Click(object sender, EventArgs e)
        {
            LoadFrmEditar();
        }
        private void BtnEliminarMedico_Click(object sender, EventArgs e)
        {
            eliminar();
        }
        private void DgvMantenimientoMedicos_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0)
            {
                RepositorioForms.Instancia.IndexSeleccionado = Convert.ToInt32(DgvMantenimientoMedicos.Rows[e.RowIndex].Cells[0].Value.ToString());


                BtnEditarMedico.Visible = true;
                BtnEliminarMedico.Visible = true;
            }
        }
        private void BtnVolver_Click(object sender, EventArgs e)
        {
            VolverAlMenu.Show();
            this.Close();
        }
        #endregion



        #region Metodos

        private void eliminar()
        {
            if (RepositorioForms.Instancia.IndexSeleccionado >= 0)
            {

                DialogResult respuesta = MessageBox.Show("Esta seguro que desea eliminar este Medico?", "Confirmacion", MessageBoxButtons.OKCancel);

                if (respuesta == DialogResult.OK)
                {

                    bool Confirmado = iniciarServicioEliminar.eliminar(RepositorioForms.Instancia.IndexSeleccionado);
                    if (Confirmado)
                    {
                        MessageBox.Show("Medico Eliminado Satisfactoriamente", "Notificacion");
                        CargarDgv();

                        RepositorioForms.Instancia.IndexSeleccionado = -1;
                    }
                    else
                    {
                        MessageBox.Show("Aparentemente ocurrio un error Medico no eliminado", "Notificacion");
                    }
                }
                else
                {
                    DgvMantenimientoMedicos.ClearSelection();
                }

            }
            else
            {
                MessageBox.Show("Debes seleccionar un Medico", "Notificacion");
            }
        }
     
        public void CargarDgv()
        {
            DataTable data = iniciarServicioListar.listar();
            DgvMantenimientoMedicos.DataSource = data;
            DgvMantenimientoMedicos.ClearSelection();
        }

        private void LoadFrmCrear()
        {
            FrmCrearMedico crearMedico = new FrmCrearMedico();
            crearMedico.Show();
            this.Close();
        }

        private void LoadFrmEditar()
        {
            FrmEditarMedico editarMedico = new FrmEditarMedico();
            editarMedico.Show();
            this.Close();
        }

        #endregion
    }
}
