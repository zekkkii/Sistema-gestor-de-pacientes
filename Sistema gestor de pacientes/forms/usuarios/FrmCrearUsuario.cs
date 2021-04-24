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

        }

        #region Eventos
        private void FrmCrearUsuario_Load(object sender, EventArgs e)
        {

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
        #endregion


        #region Metodos

        private void CrearNewUsuario()
        {
            Usuario usuario = new Usuario
            (
                TxtNewNombre.Text,
                TxtNewApellidoUsuario.Text,
                TxtNewCorreoUsuario.Text,
                TxtNewNombreUsuario.Text,
                TxtNewContraseña.Text,
                CbxNewTipoUsuario.Text
            );

            bool confirmacion = iniciarServicio.registro(usuario);

            if (confirmacion)
            {
                MessageBox.Show("Usuario creado Satisfactoriamente", "Notificacion");
                actualizar.CargarDgv();
                actualizar.Show();
            }
            else
            {
                MessageBox.Show("Al parecer existe ya un usuario con este nombre...\npruebe con otro", "Notificacion");
            }
        }


        #endregion

      
    }
}
