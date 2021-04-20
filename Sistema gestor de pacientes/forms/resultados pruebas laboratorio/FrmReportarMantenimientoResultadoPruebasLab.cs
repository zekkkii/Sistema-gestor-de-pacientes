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
        public Servicio iniciarServicio { get; set; }
        public SqlConnection connection { get; set; }


        public FrmReportarMantenimientoResultadoPruebasLab()
        {
            InitializeComponent();
            string connectionString = ConfigurationManager.ConnectionStrings["Default"].ConnectionString;
            connection = new SqlConnection(connectionString);
            iniciarServicio = new Servicio(connection);

        }

        private void FrmReportarMantenimientoResultadoPruebasLab_Load(object sender, EventArgs e)
        {

        }
    }
}
