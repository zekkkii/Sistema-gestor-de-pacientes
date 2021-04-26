﻿using System;
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
using LogicLayer.citas;


namespace Sistema_gestor_de_pacientes.forms.citas
{
    public partial class FrmListadoPacientes : Form
    {
        public VerListado_Pacientes iniciarServicio { get; set; }
        public SqlConnection connection { get; set; }

        public FrmListadoPacientes()
        {
            InitializeComponent();
            string connectionString = ConfigurationManager.ConnectionStrings["Default"].ConnectionString;
            connection = new SqlConnection(connectionString);
            iniciarServicio = new VerListado_Pacientes(connection);
        }

        private void FrmListadoPacientes_Load(object sender, EventArgs e)
        {

        }
    }
}