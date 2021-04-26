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
using Sistema_gestor_de_pacientes.forms.menu_principal;

namespace Sistema_gestor_de_pacientes.forms.pacientes
{
    public partial class FrmMantenimientoPacientes : Form
    {
        public VerListado iniciarServicio { get; set; }
        public SqlConnection connection { get; set; }
        public VerListado iniciarServicioListar { get; set; }
        public Eliminar iniciarServicioEliminar { get; set; }

        public frmMenuPrincipal VolverAlMenu { get; set; }


        public FrmMantenimientoPacientes()
        {
            InitializeComponent();
            string connectionString = ConfigurationManager.ConnectionStrings["Default"].ConnectionString;
            connection = new SqlConnection(connectionString);
            iniciarServicio = new VerListado(connection);
            VolverAlMenu = new frmMenuPrincipal();
            iniciarServicioListar = new VerListado(connection);
            iniciarServicioEliminar = new Eliminar(connection);


        }

        #region Eventos
        private void FrmMantenimientoPacientes_Load(object sender, EventArgs e)
        {
            CargarDgv();
            BtnEditarPaciente.Visible = false;
            BtnEliminarPaciente.Visible = false;
        }


        private void DgvMantenimientoPaciente_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0)
            {
              RepositorioForms.Instancia.IndexSeleccionado = Convert.ToInt32(DgvMantenimientoPaciente.Rows[e.RowIndex].Cells[0].Value.ToString());
                BtnEditarPaciente.Visible = true;
                BtnEliminarPaciente.Visible = true;
            }
        }

        private void BtnEliminarPaciente_Click(object sender, EventArgs e)
        {
            eliminar();
        }

        private void BtnEditarPaciente_Click(object sender, EventArgs e)
        {
            LoadFrmEditarPaciente();
        }

        private void BtnCrearPaciente_Click(object sender, EventArgs e)
        {
            LoadFrmCrearPaciente();
        }
        private void BtnVolver_Click(object sender, EventArgs e)
        {
            VolverAlMenu.Show();
            this.Close();
        }   
     
        #endregion



        #region Metodos
        private void LoadFrmCrearPaciente()
        {
            FrmCrearPaciente crearUsuario = new FrmCrearPaciente();
            crearUsuario.Show();
            this.Close();
        }

        private void LoadFrmEditarPaciente()
        {
            FrmEditarPaciente editarUsuario = new FrmEditarPaciente();
            editarUsuario.Show();
            this.Close();
        }



        public void CargarDgv()
        {
            DataTable data = iniciarServicioListar.listar();
            DgvMantenimientoPaciente.DataSource = data;
            DgvMantenimientoPaciente.ClearSelection();

        }

        public void eliminar()
        {
            if (RepositorioForms.Instancia.IndexSeleccionado >= 0)
            {

                DialogResult respuesta = MessageBox.Show("Esta seguro que desea eliminar este usuario?", "Confirmacion", MessageBoxButtons.OKCancel);

                if (respuesta == DialogResult.OK)
                {

                    bool Confirmado = iniciarServicioEliminar.eliminar(RepositorioForms.Instancia.IndexSeleccionado);
                    if (Confirmado)
                    {
                        MessageBox.Show("Usuario Eliminado Satisfactoriamente", "Notificacion");
                        CargarDgv();

                        RepositorioForms.Instancia.IndexSeleccionado = -1;
                    }
                    else
                    {
                        MessageBox.Show("Aparentemente ocurrio un error Usuario no eliminado", "Notificacion");
                    }
                }
                else
                {
                    DgvMantenimientoPaciente.ClearSelection();
                }

            }
            else
            {
                MessageBox.Show("Debes seleccionar un Usuario", "Notificacion");
            }
        }


        #endregion

       
    }
}
