
namespace Sistema_gestor_de_pacientes.forms.pruebas_de_laboratorio
{
    partial class FrmMantenimientoPruebasLab
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
            this.tableLayoutPanel1 = new System.Windows.Forms.TableLayoutPanel();
            this.tableLayoutPanel2 = new System.Windows.Forms.TableLayoutPanel();
            this.LblMantenimientoPruebasLab = new System.Windows.Forms.Label();
            this.BtnNewCrearPrueba = new System.Windows.Forms.Button();
            this.tableLayoutPanel3 = new System.Windows.Forms.TableLayoutPanel();
            this.BtnEditarPrueba = new System.Windows.Forms.Button();
            this.BtnEliminarPruebas = new System.Windows.Forms.Button();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.tableLayoutPanel1.SuspendLayout();
            this.tableLayoutPanel2.SuspendLayout();
            this.tableLayoutPanel3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // tableLayoutPanel1
            // 
            this.tableLayoutPanel1.BackColor = System.Drawing.Color.Transparent;
            this.tableLayoutPanel1.ColumnCount = 3;
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 4.125F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 45.25F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50.625F));
            this.tableLayoutPanel1.Controls.Add(this.tableLayoutPanel2, 0, 0);
            this.tableLayoutPanel1.Controls.Add(this.tableLayoutPanel3, 1, 2);
            this.tableLayoutPanel1.Controls.Add(this.dataGridView1, 1, 1);
            this.tableLayoutPanel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel1.Location = new System.Drawing.Point(0, 0);
            this.tableLayoutPanel1.Name = "tableLayoutPanel1";
            this.tableLayoutPanel1.RowCount = 3;
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 19.77778F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 65.77778F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 14.22222F));
            this.tableLayoutPanel1.Size = new System.Drawing.Size(800, 450);
            this.tableLayoutPanel1.TabIndex = 0;
            // 
            // tableLayoutPanel2
            // 
            this.tableLayoutPanel2.ColumnCount = 2;
            this.tableLayoutPanel1.SetColumnSpan(this.tableLayoutPanel2, 2);
            this.tableLayoutPanel2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 7.969151F));
            this.tableLayoutPanel2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 92.03085F));
            this.tableLayoutPanel2.Controls.Add(this.LblMantenimientoPruebasLab, 1, 0);
            this.tableLayoutPanel2.Controls.Add(this.BtnNewCrearPrueba, 1, 1);
            this.tableLayoutPanel2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel2.Location = new System.Drawing.Point(3, 3);
            this.tableLayoutPanel2.Name = "tableLayoutPanel2";
            this.tableLayoutPanel2.RowCount = 2;
            this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 30F));
            this.tableLayoutPanel2.Size = new System.Drawing.Size(389, 83);
            this.tableLayoutPanel2.TabIndex = 0;
            // 
            // LblMantenimientoPruebasLab
            // 
            this.LblMantenimientoPruebasLab.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.LblMantenimientoPruebasLab.AutoSize = true;
            this.LblMantenimientoPruebasLab.Font = new System.Drawing.Font("Neozoic Trial", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LblMantenimientoPruebasLab.ForeColor = System.Drawing.Color.Teal;
            this.LblMantenimientoPruebasLab.Location = new System.Drawing.Point(33, 0);
            this.LblMantenimientoPruebasLab.Name = "LblMantenimientoPruebasLab";
            this.LblMantenimientoPruebasLab.Size = new System.Drawing.Size(353, 52);
            this.LblMantenimientoPruebasLab.TabIndex = 0;
            this.LblMantenimientoPruebasLab.Text = "Mantenimiento de Pruebas \r\nde Laboratorio";
            this.LblMantenimientoPruebasLab.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // BtnNewCrearPrueba
            // 
            this.BtnNewCrearPrueba.Anchor = System.Windows.Forms.AnchorStyles.Bottom;
            this.BtnNewCrearPrueba.Font = new System.Drawing.Font("Gadugi", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BtnNewCrearPrueba.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.BtnNewCrearPrueba.Image = global::Sistema_gestor_de_pacientes.Properties.Resources.Fondo_9_Gio;
            this.BtnNewCrearPrueba.ImageAlign = System.Drawing.ContentAlignment.TopCenter;
            this.BtnNewCrearPrueba.Location = new System.Drawing.Point(133, 56);
            this.BtnNewCrearPrueba.Name = "BtnNewCrearPrueba";
            this.BtnNewCrearPrueba.Size = new System.Drawing.Size(152, 24);
            this.BtnNewCrearPrueba.TabIndex = 1;
            this.BtnNewCrearPrueba.Text = "Crear Prueba";
            this.BtnNewCrearPrueba.UseVisualStyleBackColor = true;
            // 
            // tableLayoutPanel3
            // 
            this.tableLayoutPanel3.ColumnCount = 2;
            this.tableLayoutPanel3.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel3.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel3.Controls.Add(this.BtnEditarPrueba, 1, 0);
            this.tableLayoutPanel3.Controls.Add(this.BtnEliminarPruebas, 0, 0);
            this.tableLayoutPanel3.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel3.Location = new System.Drawing.Point(36, 388);
            this.tableLayoutPanel3.Name = "tableLayoutPanel3";
            this.tableLayoutPanel3.RowCount = 2;
            this.tableLayoutPanel3.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 52.54237F));
            this.tableLayoutPanel3.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 47.45763F));
            this.tableLayoutPanel3.Size = new System.Drawing.Size(356, 59);
            this.tableLayoutPanel3.TabIndex = 1;
            // 
            // BtnEditarPrueba
            // 
            this.BtnEditarPrueba.Font = new System.Drawing.Font("Gadugi", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BtnEditarPrueba.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.BtnEditarPrueba.Image = global::Sistema_gestor_de_pacientes.Properties.Resources.Fondo_9_Gio;
            this.BtnEditarPrueba.Location = new System.Drawing.Point(181, 3);
            this.BtnEditarPrueba.Name = "BtnEditarPrueba";
            this.BtnEditarPrueba.Size = new System.Drawing.Size(110, 25);
            this.BtnEditarPrueba.TabIndex = 1;
            this.BtnEditarPrueba.Text = "Editar Prueba";
            this.BtnEditarPrueba.UseVisualStyleBackColor = true;
            // 
            // BtnEliminarPruebas
            // 
            this.BtnEliminarPruebas.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.BtnEliminarPruebas.Font = new System.Drawing.Font("Gadugi", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BtnEliminarPruebas.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.BtnEliminarPruebas.Image = global::Sistema_gestor_de_pacientes.Properties.Resources.Fondo_9_Gio;
            this.BtnEliminarPruebas.Location = new System.Drawing.Point(65, 3);
            this.BtnEliminarPruebas.Name = "BtnEliminarPruebas";
            this.BtnEliminarPruebas.Size = new System.Drawing.Size(110, 25);
            this.BtnEliminarPruebas.TabIndex = 0;
            this.BtnEliminarPruebas.Text = "Eliminar Prueba";
            this.BtnEliminarPruebas.UseVisualStyleBackColor = true;
            // 
            // dataGridView1
            // 
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dataGridView1.Location = new System.Drawing.Point(36, 92);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.Size = new System.Drawing.Size(356, 290);
            this.dataGridView1.TabIndex = 2;
            // 
            // FrmMantenimientoPruebasLab
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::Sistema_gestor_de_pacientes.Properties.Resources.ProgramacionMC;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.tableLayoutPanel1);
            this.Name = "FrmMantenimientoPruebasLab";
            this.Text = "Mantenimiento Pruebas Laboratorio";
            this.Load += new System.EventHandler(this.FrmMantenimientoPruebasLab_Load);
            this.tableLayoutPanel1.ResumeLayout(false);
            this.tableLayoutPanel2.ResumeLayout(false);
            this.tableLayoutPanel2.PerformLayout();
            this.tableLayoutPanel3.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel1;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel2;
        private System.Windows.Forms.Label LblMantenimientoPruebasLab;
        private System.Windows.Forms.Button BtnNewCrearPrueba;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel3;
        private System.Windows.Forms.Button BtnEditarPrueba;
        private System.Windows.Forms.Button BtnEliminarPruebas;
        private System.Windows.Forms.DataGridView dataGridView1;
    }
}