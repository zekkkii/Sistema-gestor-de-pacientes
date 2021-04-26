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
using LogicLayer.pruebas_de_laboratorio;
using Sistema_gestor_de_pacientes.forms.menu_principal;

namespace Sistema_gestor_de_pacientes.forms.pruebas_de_laboratorio
{
    public partial class FrmEditarPruebaLab : Form
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

        public FrmMantenimientoPruebasLab actualizar { get; set; }



        public FrmEditarPruebaLab()
        {
            InitializeComponent();
            string connectionString = ConfigurationManager.ConnectionStrings["Default"].ConnectionString;
            connection = new SqlConnection(connectionString);
            iniciarServicio = new Editar(connection);
            actualizar = new FrmMantenimientoPruebasLab();
        }
        #region Eventos
        private void FrmEditarPruebaLab_Load(object sender, EventArgs e)
        {
            actualizar.CargarDgv();
        }

        private void BtnEditPruebaLab_Click(object sender, EventArgs e)
        {
            if (TxtEditPruebaLab.Text != "") 
            {
                editar();
            }
            else 
            { 
                MessageBox.Show("Debes llenar todos los campos", "Notificacion"); 
            }
            
        }
        private void BtnVolver_Click(object sender, EventArgs e)
        {
            actualizar.Show();
            this.Close();
        }
        #endregion



        #region Metodos
        private void editar()
        {
            if (RepositorioForms.Instancia.IndexSeleccionado >= 0)
            {
                PruebaLaboratorio prueba = new PruebaLaboratorio
                (
                    TxtEditPruebaLab.Text
                );

                bool Confirmado = iniciarServicio.editar(RepositorioForms.Instancia.IndexSeleccionado, prueba);
                if (Confirmado)
                {
                    MessageBox.Show("Prueba editada Satisfactoriamente", "Notificacion");
                    actualizar.CargarDgv();
                    actualizar.Show();
                    this.Close();

                    RepositorioForms.Instancia.IndexSeleccionado = -1;
                }
            }
            else
            {
                MessageBox.Show("Debes seleccionar una Prueba", "Notificacion");
            }
        }
        #endregion

      
    }
}
