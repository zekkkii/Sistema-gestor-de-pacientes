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
using LogicLayer.usuarios;

namespace Sistema_gestor_de_pacientes.forms.usuarios
{
    public partial class FrmEditarUsuario : Form
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

        public Editar iniciarServicio { get; set; }
        public SqlConnection connection { get; set; }

        public FrmMantenimientoUsuario actualizar { get; set; }


        public FrmEditarUsuario()
        {
            InitializeComponent();
            string connectionString = ConfigurationManager.ConnectionStrings["Default"].ConnectionString;
            connection = new SqlConnection(connectionString);
            iniciarServicio = new Editar(connection);
            actualizar = new FrmMantenimientoUsuario();
        }

        #region Eventos
        private void FrmEditarUsuario_Load(object sender, EventArgs e)
        {
            LoadCbxTipoUsuario();
            actualizar.CargarDgv();
        }

        private void BtnEditUsuario_Click(object sender, EventArgs e)
        {

        }
        #endregion



        #region Metodos
        public void editar()
        {
            if (RepositorioForms.Instancia.IndexSeleccionado >= 0)
            {

                ComboBox_Tipo_Usuario tipoUsuario = CbxEditTipoUsuario.SelectedItem as ComboBox_Tipo_Usuario;
                Usuario usuario = new Usuario
                (
                    TxtEditNombre.Text,
                    TxtEditApellidoUsuario.Text,
                    TxtEditCorreoUsuario.Text,
                    TxtEditNombreUsuario.Text,
                    TxtEditContraseña.Text,
                    tipoUsuario.Value
                );

                bool Confirmado = iniciarServicio.editar(RepositorioForms.Instancia.IndexSeleccionado,usuario);
                    if (Confirmado)
                    {
                        MessageBox.Show("Usuario Editado Satisfactoriamente", "Notificacion");
                        actualizar.CargarDgv();
                        actualizar.Show();

                        RepositorioForms.Instancia.IndexSeleccionado = -1;
                    }

            }
            else
            {
                MessageBox.Show("Debes seleccionar un Usuario", "Notificacion");
            }
        }

        private void LoadCbxTipoUsuario()
        {
            ComboBox_Tipo_Usuario Tipo_Admin = new ComboBox_Tipo_Usuario
            {
                Text = "Administrador",
                Value = 0
            };

            ComboBox_Tipo_Usuario Tipo_Medico = new ComboBox_Tipo_Usuario
            {
                Text = "Medico",
                Value = 1
            };

            CbxEditTipoUsuario.Items.Add(Tipo_Admin);
            CbxEditTipoUsuario.Items.Add(Tipo_Medico);
            CbxEditTipoUsuario.SelectedItem = Tipo_Admin;
        }
        #endregion

     
    }
}
