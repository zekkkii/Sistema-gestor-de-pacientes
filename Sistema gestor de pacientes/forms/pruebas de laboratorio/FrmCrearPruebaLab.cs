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
using Sistema_gestor_de_pacientes.forms.usuarios;

namespace Sistema_gestor_de_pacientes.forms.pruebas_de_laboratorio
{
    public partial class FrmCrearPruebaLab : Form
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

        public FrmMantenimientoPruebasLab actualizar { get; set; }



        public FrmCrearPruebaLab()
        {
            InitializeComponent();
            string connectionString = ConfigurationManager.ConnectionStrings["Default"].ConnectionString;
            connection = new SqlConnection(connectionString);
            iniciarServicio = new Registro(connection);
            actualizar = new FrmMantenimientoPruebasLab();
            
        }
        #region Eventos
        private void FrmCrearPruebaLab_Load(object sender, EventArgs e)
        {

        }

        private void BtnNewCrearPruebaLab_Click(object sender, EventArgs e)
        {
            CrearPrueba();
        }
        private void BtnVolver_Click(object sender, EventArgs e)
        {
            actualizar.Show();
            this.Close();
        }
        #endregion



        #region Metodos
        private void CrearPrueba()
        {

             PruebaLaboratorio prueba = new PruebaLaboratorio
            (
                TxtNewCrearPruebaLab.Text
               
            );

            bool confirmacion = iniciarServicio.registro(prueba);

            if (confirmacion)
            {
                MessageBox.Show("Prueba creada Satisfactoriamente", "Notificacion");
                actualizar.CargarDgv();
                actualizar.Show();
                this.Close();
            }
            else
            {
                MessageBox.Show("Al parecer existe ya una Prueba con este nombre...\npruebe con otro", "Notificacion");
            }
        }
        #endregion
    }
}
