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
using LogicLayer.usuarios;


namespace Sistema_gestor_de_pacientes.forms.usuarios
{

    public partial class FrmMantenimientoUsuario : Form
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


        public FrmMantenimientoUsuario()
        {
            InitializeComponent();
            string connectionString = ConfigurationManager.ConnectionStrings["Default"].ConnectionString;
            connection = new SqlConnection(connectionString);
            iniciarServicioListar = new VerListado(connection);
        }

        #region Eventos
        private void FrmMantenimientoUsuario_Load(object sender, EventArgs e)
        {
            CargarDgv();
            BtnEditarUsuario.Visible = false;
            BtnEliminarUsuario.Visible = false;
        }
        private void BtnCrearUsuario_Click(object sender, EventArgs e)
        {
            LoadFrmCrearUsuario();
        }
        private void BtnEliminarUsuario_Click(object sender, EventArgs e)
        {
            eliminar();
        }
        private void BtnEditarUsuario_Click(object sender, EventArgs e)
        {
            LoadFrmEditarUsuario();
        }
        private void DgvMantenimientoUsuario_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0)
            {
                RepositorioForms.Instancia.IndexSeleccionado = Convert.ToInt32(DgvMantenimientoUsuario.Rows[e.RowIndex].Cells[0].Value.ToString());


                BtnEditarUsuario.Visible = true;
                BtnEliminarUsuario.Visible = true;
            }
        }
        #endregion



        #region Metodos
        private void LoadFrmCrearUsuario()
        {
            FrmCrearUsuario crearUsuario = new FrmCrearUsuario();
            crearUsuario.Show();
            this.Close();
        }

        private void LoadFrmEditarUsuario()
        {
            FrmEditarUsuario editarUsuario = new FrmEditarUsuario();
            editarUsuario.Show();
            this.Close();
        }



        public void CargarDgv()
        {
            DataTable data = iniciarServicioListar.listar();
            DgvMantenimientoUsuario.DataSource = data;
            DgvMantenimientoUsuario.ClearSelection();
            
        }

        public void eliminar()
        {
            if(RepositorioForms.Instancia.IndexSeleccionado >= 0)
            {
                int index = RepositorioForms.Instancia.IndexSeleccionado;

                DialogResult respuesta = MessageBox.Show("Esta seguro que desea eliminar este usuario?","Confirmacion", MessageBoxButtons.OKCancel);
                
                if(respuesta == DialogResult.OK)
                {
                   
                    bool Confirmado = iniciarServicioEliminar.eliminar(index);
                    if (Confirmado) 
                    {
                        MessageBox.Show("Usuario Eliminado Satisfactoriamente","Notificacion");
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
                    DgvMantenimientoUsuario.ClearSelection();
                }

            }
            else
            {
                MessageBox.Show("Debes seleccionar un Usuario","Notificacion");
            }
        }
        
#endregion
    }
}
