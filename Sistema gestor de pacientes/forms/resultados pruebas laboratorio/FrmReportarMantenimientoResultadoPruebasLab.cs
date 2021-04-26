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
using  LogicLayer.resultado_pruebas_de_laboratorio;

namespace Sistema_gestor_de_pacientes.forms.resultados_pruebas_laboratorio
{
    public partial class FrmReportarMantenimientoResultadoPruebasLab : Form
    {
        public Llenar_Resultados iniciarServicio { get; set; }
        public SqlConnection connection { get; set; }
        public FrmReportarMantenimientoResultadoPruebasLab retornar { get; set; }


        public FrmReportarMantenimientoResultadoPruebasLab()
        {
            InitializeComponent();
            string connectionString = ConfigurationManager.ConnectionStrings["Default"].ConnectionString;
            connection = new SqlConnection(connectionString);
            iniciarServicio = new Llenar_Resultados(connection);
            retornar = new FrmReportarMantenimientoResultadoPruebasLab();

        }
        #region evento
        private void BtnFinalizar_Click(object sender, EventArgs e)
        {
            GuardarDatos();
        }
        #endregion

        #region metodo

        private void GuardarDatos()
        {

            bool guardar = iniciarServicio.llenar(RepositorioForms.Instancia.IndexSeleccionado, richTextBox1.Text);

            if (guardar)
            {
                MessageBox.Show("Reporte creado Satisfactoriamente", "Notificacion");
                retornar.Show();

                RepositorioForms.Instancia.IndexSeleccionado = -1;
                this.Close();
            }
            else
            {
                MessageBox.Show("Al parecer existe ya un usuario con este nombre...\npruebe con otro", "Notificacion");
            }
        }
        #endregion
    }
}
