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
using LogicLayer.medicos;

namespace Sistema_gestor_de_pacientes.forms.medicos
{
    public partial class FrmEditarMedico : Form
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

        public FrmMantenimientoMedicos actualizar { get; set; }


        public FrmEditarMedico()
        {
            InitializeComponent();
            string connectionString = ConfigurationManager.ConnectionStrings["Default"].ConnectionString;
            connection = new SqlConnection(connectionString);
            iniciarServicio = new Editar(connection);
            actualizar = new FrmMantenimientoMedicos();

        }

        #region Eventos
        private void FrmEditarMedico_Load(object sender, EventArgs e)
        {
            actualizar.CargarDgv();

        }
        private void BtnEditMedico_Click(object sender, EventArgs e)
        { 
            //Aqui falta verificar que el Picture box no este vacio
            if (TxtEditNombreMedico.Text != "" && TxtEditApellidoMedico.Text != "" &&
              TxtEditCorreoMedico.Text != "" && TxtEditTelefonoMedico.Text != "" &&
              TxtEditCedulaMedico.Text != "" && PbxEditSubirFotoMedico.Text != "")
            {
                editar();
            }
            else { MessageBox.Show("Debes rellenar Todos los campos", "Notificacion"); }
        }

        private void BtnEditSubirFotoMedico_Click(object sender, EventArgs e)
        {
            AñadirImagen();
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

                          //Aqui falta verificar que el Picture box no este vacio
                Medico medico = new Medico
                (
                    TxtEditNombreMedico.Text,
                    TxtEditApellidoMedico.Text,
                    TxtEditCorreoMedico.Text,
                    TxtEditTelefonoMedico.Text,
                    TxtEditCedulaMedico.Text,
                    PbxEditSubirFotoMedico.Text
                );

                bool Confirmado = iniciarServicio.editar(RepositorioForms.Instancia.IndexSeleccionado, medico);
                if (Confirmado)
                {
                    MessageBox.Show("Medico Editado Satisfactoriamente", "Notificacion");
                    actualizar.CargarDgv();
                    actualizar.Show();
                    this.Close();

                    RepositorioForms.Instancia.IndexSeleccionado = -1;
                }
            }
            else
            {
                MessageBox.Show("Debes seleccionar un Medico", "Notificacion");
            }
        }

        private void AñadirImagen()
        {
            string imgLink = "";

            OpenFileDialog dialog = new OpenFileDialog();

            dialog.Filter = "jpg files(.*jpg)|*.jpg| PNG files(.*png)|*.png| All Files(*.*)|*.*";

            if (dialog.ShowDialog() == System.Windows.Forms.DialogResult.OK)
            {

                imgLink = dialog.FileName;

                PbxEditSubirFotoMedico.ImageLocation = imgLink;
            }
        }

        #endregion

   
    }
}
