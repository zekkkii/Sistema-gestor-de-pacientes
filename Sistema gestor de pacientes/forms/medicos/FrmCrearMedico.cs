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
    public partial class FrmCrearMedico : Form
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

        public FrmMantenimientoMedicos actualizar { get; set; } 

        
        public FrmCrearMedico()
        {
            InitializeComponent();
            string connectionString = ConfigurationManager.ConnectionStrings["Default"].ConnectionString;
            connection = new SqlConnection(connectionString);
            iniciarServicio = new Registro(connection);
            actualizar = new FrmMantenimientoMedicos();
        }
        #region Eventos
        private void FrmCrearMedico_Load(object sender, EventArgs e)
        {

            
        }
        private void BtnNewCrearMedico_Click(object sender, EventArgs e)
        {
            //Aqui falta verificar que el Picture box no este vacio
            if (TxtNewNombreMedico.Text != "" && TxtNewApellidoMedico.Text != "" &&
                   TxtNewCorreoMedico.Text != "" && TxtNewTelefonoMedico.Text != "" &&
                   TxtNewCedulaMedico.Text != "")
            {

                CrearMedico();


            }
            else { MessageBox.Show("Debes rellenar Todos los campos", "Notificacion"); }
        }
        private void BtnNewSubirFotoMedico_Click(object sender, EventArgs e)
        {
            AñadirImagen();
        }
        private void btnVolver_Click(object sender, EventArgs e)
        {
            actualizar.Show();
            this.Close();
        }
        #endregion

        #region Metodos
        private void CrearMedico()
        {
                        //Aqui falta verificar que el Picture box no este vacio
            Medico medico = new Medico
            (
                TxtNewNombreMedico.Text,
                TxtNewApellidoMedico.Text,
                TxtNewCorreoMedico.Text,
                TxtNewTelefonoMedico.Text,
                TxtNewCedulaMedico.Text,
                PbxNewSubirFotoMedico.Text
            );



            bool confirmacion = iniciarServicio.registro(medico);

            if (confirmacion)
            {
                MessageBox.Show("Medico creado Satisfactoriamente", "Notificacion");
                actualizar.CargarDgv();
                actualizar.Show();
                this.Close();
            }
            else
            {
                MessageBox.Show("Debe asegurarse de Completar todos los campos (Incluyendo la foto)","Notificacion");
                //MessageBox.Show("Al parecer existe ya un usuario con este nombre...\npruebe con otro", "Notificacion");
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

                PbxNewSubirFotoMedico.ImageLocation = imgLink;
            }
        }

        #endregion

  
    }
}
