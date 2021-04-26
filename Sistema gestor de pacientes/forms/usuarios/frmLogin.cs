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
using Sistema_gestor_de_pacientes.forms.menu_principal;


namespace Sistema_gestor_de_pacientes.forms.usuarios
{
    public partial class frmLogin : Form
    {
        public Login iniciarServicio { get; set; }
        public SqlConnection connection { get; set; }


        public frmLogin()
        {
            InitializeComponent();
            string connectionString = ConfigurationManager.ConnectionStrings["Default"].ConnectionString;
            connection = new SqlConnection(connectionString);
            iniciarServicio = new Login(connection);

        }

        #region Eventos
        private void frmLogin_Load(object sender, EventArgs e)
        {
            LimpiarTxts();
        }

        private void BtnIniciarSesion_Click(object sender, EventArgs e)
        {
          if (TxtUsuario.Text != "" && TxtContraseña.Text != "")
            {
                IniciarSesion();
            }
            else
            {
                MessageBox.Show("Debes completar todos los campos");
            }
        }
        #endregion


        #region Metodos
        private void IniciarSesion()
        {
            Usuario Persona = new Usuario(null, null, null,  TxtUsuario.Text,  TxtContraseña.Text, 0);

             bool data = iniciarServicio.login(Persona);

            if (data) 
            {
                frmMenuPrincipal menuPrincipal = new frmMenuPrincipal();
                menuPrincipal.Show();
                this.Hide();
            }
            else 
            {
                MessageBox.Show("Si es tu primera vez iniciando sesion, crea una cuenta\no utiliza la cuenta por defecto", "Datos incorrectos");
            }

        }

        private void LimpiarTxts()
        {
            TxtContraseña.Clear();
            TxtUsuario.Clear();
        }

        #endregion

    
    }
}
