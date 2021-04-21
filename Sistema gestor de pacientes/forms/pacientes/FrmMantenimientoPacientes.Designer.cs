
namespace Sistema_gestor_de_pacientes.forms.pacientes
{
    partial class FrmMantenimientoPacientes
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.LblMantenimientoPaciente = new System.Windows.Forms.Label();
            this.tableLayoutPanel1 = new System.Windows.Forms.TableLayoutPanel();
            this.tableLayoutPanel2 = new System.Windows.Forms.TableLayoutPanel();
            this.DgvMantenimientoPaciente = new System.Windows.Forms.DataGridView();
            this.BtnCrearPaciente = new System.Windows.Forms.Button();
            this.tableLayoutPanel3 = new System.Windows.Forms.TableLayoutPanel();
            this.BtnEliminarPaciente = new System.Windows.Forms.Button();
            this.BtnEditarPaciente = new System.Windows.Forms.Button();
            this.tableLayoutPanel1.SuspendLayout();
            this.tableLayoutPanel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.DgvMantenimientoPaciente)).BeginInit();
            this.tableLayoutPanel3.SuspendLayout();
            this.SuspendLayout();
            // 
            // LblMantenimientoPaciente
            // 
            this.LblMantenimientoPaciente.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.LblMantenimientoPaciente.AutoSize = true;
            this.LblMantenimientoPaciente.Font = new System.Drawing.Font("Neozoic Trial", 21.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LblMantenimientoPaciente.ForeColor = System.Drawing.Color.Teal;
            this.LblMantenimientoPaciente.Location = new System.Drawing.Point(3, 18);
            this.LblMantenimientoPaciente.Name = "LblMantenimientoPaciente";
            this.LblMantenimientoPaciente.Size = new System.Drawing.Size(382, 35);
            this.LblMantenimientoPaciente.TabIndex = 0;
            this.LblMantenimientoPaciente.Text = "Mantenimiento de Pacientes";
            this.LblMantenimientoPaciente.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // tableLayoutPanel1
            // 
            this.tableLayoutPanel1.BackColor = System.Drawing.Color.Transparent;
            this.tableLayoutPanel1.ColumnCount = 2;
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 49.25F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50.75F));
            this.tableLayoutPanel1.Controls.Add(this.tableLayoutPanel2, 0, 0);
            this.tableLayoutPanel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel1.Location = new System.Drawing.Point(0, 0);
            this.tableLayoutPanel1.Name = "tableLayoutPanel1";
            this.tableLayoutPanel1.RowCount = 2;
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel1.Size = new System.Drawing.Size(800, 450);
            this.tableLayoutPanel1.TabIndex = 1;
            // 
            // tableLayoutPanel2
            // 
            this.tableLayoutPanel2.ColumnCount = 1;
            this.tableLayoutPanel2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel2.Controls.Add(this.LblMantenimientoPaciente, 0, 0);
            this.tableLayoutPanel2.Controls.Add(this.DgvMantenimientoPaciente, 0, 2);
            this.tableLayoutPanel2.Controls.Add(this.BtnCrearPaciente, 0, 1);
            this.tableLayoutPanel2.Controls.Add(this.tableLayoutPanel3, 0, 3);
            this.tableLayoutPanel2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel2.Location = new System.Drawing.Point(3, 3);
            this.tableLayoutPanel2.Name = "tableLayoutPanel2";
            this.tableLayoutPanel2.RowCount = 4;
            this.tableLayoutPanel1.SetRowSpan(this.tableLayoutPanel2, 2);
            this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 57.6087F));
            this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 42.3913F));
            this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 287F));
            this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 64F));
            this.tableLayoutPanel2.Size = new System.Drawing.Size(388, 444);
            this.tableLayoutPanel2.TabIndex = 0;
            // 
            // DgvMantenimientoPaciente
            // 
            this.DgvMantenimientoPaciente.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.DgvMantenimientoPaciente.Dock = System.Windows.Forms.DockStyle.Fill;
            this.DgvMantenimientoPaciente.Location = new System.Drawing.Point(3, 95);
            this.DgvMantenimientoPaciente.Name = "DgvMantenimientoPaciente";
            this.DgvMantenimientoPaciente.Size = new System.Drawing.Size(382, 281);
            this.DgvMantenimientoPaciente.TabIndex = 1;
            // 
            // BtnCrearPaciente
            // 
            this.BtnCrearPaciente.Anchor = System.Windows.Forms.AnchorStyles.Bottom;
            this.BtnCrearPaciente.Font = new System.Drawing.Font("Gadugi", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BtnCrearPaciente.Location = new System.Drawing.Point(87, 66);
            this.BtnCrearPaciente.Name = "BtnCrearPaciente";
            this.BtnCrearPaciente.Size = new System.Drawing.Size(213, 23);
            this.BtnCrearPaciente.TabIndex = 2;
            this.BtnCrearPaciente.Text = "Crear Nuevo Paciente";
            this.BtnCrearPaciente.UseVisualStyleBackColor = true;
            // 
            // tableLayoutPanel3
            // 
            this.tableLayoutPanel3.ColumnCount = 2;
            this.tableLayoutPanel3.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel3.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel3.Controls.Add(this.BtnEliminarPaciente, 1, 0);
            this.tableLayoutPanel3.Controls.Add(this.BtnEditarPaciente, 0, 0);
            this.tableLayoutPanel3.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel3.Location = new System.Drawing.Point(3, 382);
            this.tableLayoutPanel3.Name = "tableLayoutPanel3";
            this.tableLayoutPanel3.RowCount = 2;
            this.tableLayoutPanel3.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel3.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel3.Size = new System.Drawing.Size(382, 59);
            this.tableLayoutPanel3.TabIndex = 3;
            // 
            // BtnEliminarPaciente
            // 
            this.BtnEliminarPaciente.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left)));
            this.BtnEliminarPaciente.Font = new System.Drawing.Font("Gadugi", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BtnEliminarPaciente.Location = new System.Drawing.Point(194, 3);
            this.BtnEliminarPaciente.Name = "BtnEliminarPaciente";
            this.BtnEliminarPaciente.Size = new System.Drawing.Size(112, 23);
            this.BtnEliminarPaciente.TabIndex = 1;
            this.BtnEliminarPaciente.Text = "Eliminar Paciente";
            this.BtnEliminarPaciente.UseVisualStyleBackColor = true;
            // 
            // BtnEditarPaciente
            // 
            this.BtnEditarPaciente.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.BtnEditarPaciente.Font = new System.Drawing.Font("Gadugi", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BtnEditarPaciente.Location = new System.Drawing.Point(74, 3);
            this.BtnEditarPaciente.Name = "BtnEditarPaciente";
            this.BtnEditarPaciente.Size = new System.Drawing.Size(114, 23);
            this.BtnEditarPaciente.TabIndex = 0;
            this.BtnEditarPaciente.Text = "Editar Paciente";
            this.BtnEditarPaciente.UseVisualStyleBackColor = true;
            // 
            // FrmMantenimientoPacientes
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::Sistema_gestor_de_pacientes.Properties.Resources.ProgramacionMC;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.tableLayoutPanel1);
            this.Name = "FrmMantenimientoPacientes";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.FrmMantenimientoPacientes_Load);
            this.tableLayoutPanel1.ResumeLayout(false);
            this.tableLayoutPanel2.ResumeLayout(false);
            this.tableLayoutPanel2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.DgvMantenimientoPaciente)).EndInit();
            this.tableLayoutPanel3.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Label LblMantenimientoPaciente;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel1;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel2;
        private System.Windows.Forms.DataGridView DgvMantenimientoPaciente;
        private System.Windows.Forms.Button BtnCrearPaciente;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel3;
        private System.Windows.Forms.Button BtnEliminarPaciente;
        private System.Windows.Forms.Button BtnEditarPaciente;
    }
}