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
using LogicLayer.pruebas_de_laboratorio;

namespace Sistema_gestor_de_pacientes.forms.pruebas_de_laboratorio
{
    public partial class FrmMantenimientoPruebasLab : Form
    {
        public VerListado iniciarServicio { get; set; }
        public SqlConnection connection { get; set; }


        public FrmMantenimientoPruebasLab()
        {
            InitializeComponent();
            string connectionString = ConfigurationManager.ConnectionStrings["Default"].ConnectionString;
            connection = new SqlConnection(connectionString);
            iniciarServicio = new VerListado(connection);

        }

        private void FrmMantenimientoPruebasLab_Load(object sender, EventArgs e)
        {

        }
    }
}