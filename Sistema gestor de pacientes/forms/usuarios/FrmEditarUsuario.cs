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
        }

        #region Eventos
        private void FrmEditarUsuario_Load(object sender, EventArgs e)
        {

        }


        #endregion



        #region Metodos
        public void editar()
        {
            if (RepositorioForms.Instacia.IndexSeleccionado >= 0)
            {
                int index = RepositorioForms.Instacia.IndexSeleccionado;


                    //bool Confirmado = iniciarServicio.editar(index,);
                    //if (Confirmado)
                    //{
                    //    MessageBox.Show("Usuario Editado Satisfactoriamente", "Notificacion");
                    //    actualizar.CargarDgv();
                    //    actualizar.Show();

                    //    RepositorioForms.Instacia.IndexSeleccionado = -1;
                    //}

            }
            else
            {
                MessageBox.Show("Debes seleccionar un Usuario", "Notificacion");
            }
        }

        #endregion
    }
}
