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
using LogicLayer.pruebas_de_laboratorio;
using Sistema_gestor_de_pacientes.forms.menu_principal;

namespace Sistema_gestor_de_pacientes.forms.pruebas_de_laboratorio
{
    public partial class FrmMantenimientoPruebasLab : Form
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


        public FrmMantenimientoPruebasLab()
        {
            InitializeComponent();
            string connectionString = ConfigurationManager.ConnectionStrings["Default"].ConnectionString;
            connection = new SqlConnection(connectionString);
            iniciarServicioListar = new VerListado(connection);
            VolverAlMenu = new frmMenuPrincipal();
        }

        #region Eventos
        private void FrmMantenimientoPruebasLab_Load(object sender, EventArgs e)
        {
            CargarDgv();
            BtnEditarPrueba.Visible = false;
            BtnEliminarPruebas.Visible = false;
        }
        private void BtnNewCrearPrueba_Click(object sender, EventArgs e)
        {
            LoadFrmCrear();
        }
        private void BtnEditarPrueba_Click(object sender, EventArgs e)
        {
            LoadFrmEditar();
        }
        private void BtnEliminarPruebas_Click(object sender, EventArgs e)
        {
            eliminar();
        }
        private void DgvManteminimientoPruebasLab_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0)
            {
                RepositorioForms.Instancia.IndexSeleccionado = Convert.ToInt32(DgvManteminimientoPruebasLab.Rows[e.RowIndex].Cells[0].Value.ToString());


                BtnEditarPrueba.Visible = true;
                BtnEliminarPruebas.Visible = true;
            }
        }
        private void BtnVolver_Click(object sender, EventArgs e)
        {
            VolverAlMenu.Show();
            this.Close();
        }
        #endregion



        #region Metodos
        public void CargarDgv()
        {
            DataTable data = iniciarServicioListar.listar();
            DgvManteminimientoPruebasLab.DataSource = data;
            DgvManteminimientoPruebasLab.ClearSelection();

        }

        private void eliminar()
        {
            if (RepositorioForms.Instancia.IndexSeleccionado >= 0)
            {

                DialogResult respuesta = MessageBox.Show("Esta seguro que desea eliminar esta Prueba?", "Confirmacion", MessageBoxButtons.OKCancel);

                if (respuesta == DialogResult.OK)
                {

                    bool Confirmado = iniciarServicioEliminar.eliminar(RepositorioForms.Instancia.IndexSeleccionado);
                    if (Confirmado)
                    {
                        MessageBox.Show("Prueba Eliminada Satisfactoriamente", "Notificacion");
                        CargarDgv();

                        RepositorioForms.Instancia.IndexSeleccionado = -1;
                    }
                    else
                    {
                        MessageBox.Show("Aparentemente ocurrio un error la prueba no se ha eliminado", "Notificacion");
                    }
                }
                else
                {
                    DgvManteminimientoPruebasLab.ClearSelection();
                }

            }
            else
            {
                MessageBox.Show("Debes seleccionar una Prueba", "Notificacion");
            }
        }

        private void LoadFrmCrear()
        {
            FrmCrearPruebaLab crearPruebaLab = new FrmCrearPruebaLab();
            crearPruebaLab.Show();
            this.Close();
        }

        private void LoadFrmEditar()
        {
            FrmEditarPruebaLab editarPruebaLab = new FrmEditarPruebaLab();
            editarPruebaLab.Show();
            this.Close();
        }

        #endregion

   
    }
}
