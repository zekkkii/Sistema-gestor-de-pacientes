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
    public partial class FrmCrearUsuario : Form
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


        public Registro iniciarServicio { get; set; }
        public SqlConnection connection { get; set; }
        public FrmMantenimientoUsuario actualizar { get; set; }


        public FrmCrearUsuario()
        {
            InitializeComponent();
            string connectionString = ConfigurationManager.ConnectionStrings["Default"].ConnectionString;
            connection = new SqlConnection(connectionString);
            iniciarServicio = new Registro(connection);
            actualizar = new FrmMantenimientoUsuario();
        }

        #region Eventos
        private void FrmCrearUsuario_Load(object sender, EventArgs e)
        {
            LoadCbxTipoUsuario();
        }

        private void BtnNewCrearUsuario_Click(object sender, EventArgs e)
        {
            if(TxtNewNombre.Text != "" && TxtNewApellidoUsuario.Text !="" && 
               TxtNewNombreUsuario.Text !="" && TxtNewContraseña.Text !="" && 
               TxtNewConfirmarContraseña.Text !="") 
            {
                if (TxtNewContraseña.Text == TxtNewConfirmarContraseña.Text) 
                {
                    CrearNewUsuario();
                }
                else
                {
                    MessageBox.Show("Las Contraseñas no coinciden", "Notificacion");
                }
            }
            else { MessageBox.Show("Debes rellenar Todos los campos","Notificacion"); }
            
        }
        private void CbxNewTipoUsuario_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void BtnVolver_Click(object sender, EventArgs e)
        {
            actualizar.Show();
            this.Close();
        }
        #endregion

    
        #region Metodos
        private void CrearNewUsuario()
        {
            ComboBox_Tipo_Usuario tipoUsuario = CbxNewTipoUsuario.SelectedItem as ComboBox_Tipo_Usuario;
            Usuario usuario = new Usuario
            (
                TxtNewNombre.Text,
                TxtNewApellidoUsuario.Text,
                TxtNewCorreoUsuario.Text,
                TxtNewNombreUsuario.Text,
                TxtNewContraseña.Text,
                tipoUsuario.Value
            ) ;

           

            bool confirmacion = iniciarServicio.registro(usuario);

            if (confirmacion)
            {
                MessageBox.Show("Usuario creado Satisfactoriamente", "Notificacion");
                actualizar.CargarDgv();
            }
            else
            {
                MessageBox.Show("Al parecer existe ya un usuario con este nombre...\npruebe con otro", "Notificacion");
            }
        }

        private void LoadCbxTipoUsuario()
        {
          

            ComboBox_Tipo_Usuario Tipo_Admin = new ComboBox_Tipo_Usuario 
            { 
                   Text="Administrador",
                   Value = 0
            };

            ComboBox_Tipo_Usuario Tipo_Medico = new ComboBox_Tipo_Usuario
            {
                Text = "Medico",
                Value = 1 
            };

            CbxNewTipoUsuario.Items.Add(Tipo_Admin);
            CbxNewTipoUsuario.Items.Add(Tipo_Medico);
            CbxNewTipoUsuario.SelectedItem = Tipo_Admin;
        }

        #endregion

    }
}
