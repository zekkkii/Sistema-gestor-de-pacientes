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
    public partial class FrmDetallesCitas : Form
    {
        public Registro iniciarServicio { get; set; }
        public SqlConnection connection { get; set; }

        public FrmDetallesCitas()
        {
            InitializeComponent();

            string connectionString = ConfigurationManager.ConnectionStrings["Default"].ConnectionString;
            connection = new SqlConnection(connectionString);
            iniciarServicio = new Registro(connection);
        }

        private void FrmDetallesCitas_Load(object sender, EventArgs e)
        {

        }
    }
}
