
namespace Sistema_gestor_de_pacientes.forms.citas
{
    partial class FrmMantenimientoCitas
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
            this.DgvMantenimientoCitas = new System.Windows.Forms.DataGridView();
            this.tableLayoutPanel2 = new System.Windows.Forms.TableLayoutPanel();
            this.LblMantenimientoCitar = new System.Windows.Forms.Label();
            this.BtnNewCrearCita = new System.Windows.Forms.Button();
            this.BtnEliminarCita = new System.Windows.Forms.Button();
            this.tableLayoutPanel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.DgvMantenimientoCitas)).BeginInit();
            this.tableLayoutPanel2.SuspendLayout();
            this.SuspendLayout();
            // 
            // tableLayoutPanel1
            // 
            this.tableLayoutPanel1.BackColor = System.Drawing.Color.Transparent;
            this.tableLayoutPanel1.ColumnCount = 3;
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 3.125F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 45.125F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 51.75F));
            this.tableLayoutPanel1.Controls.Add(this.BtnEliminarCita, 1, 2);
            this.tableLayoutPanel1.Controls.Add(this.DgvMantenimientoCitas, 1, 1);
            this.tableLayoutPanel1.Controls.Add(this.tableLayoutPanel2, 0, 0);
            this.tableLayoutPanel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel1.Location = new System.Drawing.Point(0, 0);
            this.tableLayoutPanel1.Name = "tableLayoutPanel1";
            this.tableLayoutPanel1.RowCount = 3;
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 20F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 62.88889F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 17.33333F));
            this.tableLayoutPanel1.Size = new System.Drawing.Size(800, 450);
            this.tableLayoutPanel1.TabIndex = 0;
            // 
            // DgvMantenimientoCitas
            // 
            this.DgvMantenimientoCitas.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.DgvMantenimientoCitas.Dock = System.Windows.Forms.DockStyle.Fill;
            this.DgvMantenimientoCitas.Location = new System.Drawing.Point(28, 92);
            this.DgvMantenimientoCitas.Name = "DgvMantenimientoCitas";
            this.DgvMantenimientoCitas.Size = new System.Drawing.Size(355, 276);
            this.DgvMantenimientoCitas.TabIndex = 0;
            // 
            // tableLayoutPanel2
            // 
            this.tableLayoutPanel2.ColumnCount = 2;
            this.tableLayoutPanel1.SetColumnSpan(this.tableLayoutPanel2, 2);
            this.tableLayoutPanel2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 6.052631F));
            this.tableLayoutPanel2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 93.94736F));
            this.tableLayoutPanel2.Controls.Add(this.LblMantenimientoCitar, 1, 0);
            this.tableLayoutPanel2.Controls.Add(this.BtnNewCrearCita, 1, 1);
            this.tableLayoutPanel2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel2.Location = new System.Drawing.Point(3, 3);
            this.tableLayoutPanel2.Name = "tableLayoutPanel2";
            this.tableLayoutPanel2.RowCount = 2;
            this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel2.Size = new System.Drawing.Size(380, 83);
            this.tableLayoutPanel2.TabIndex = 1;
            // 
            // LblMantenimientoCitar
            // 
            this.LblMantenimientoCitar.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.LblMantenimientoCitar.AutoSize = true;
            this.LblMantenimientoCitar.Font = new System.Drawing.Font("Neozoic Trial", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LblMantenimientoCitar.ForeColor = System.Drawing.Color.Teal;
            this.LblMantenimientoCitar.Location = new System.Drawing.Point(25, 4);
            this.LblMantenimientoCitar.Name = "LblMantenimientoCitar";
            this.LblMantenimientoCitar.Size = new System.Drawing.Size(352, 33);
            this.LblMantenimientoCitar.TabIndex = 0;
            this.LblMantenimientoCitar.Text = "Mantenimiento de Citas";
            this.LblMantenimientoCitar.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // BtnNewCrearCita
            // 
            this.BtnNewCrearCita.Anchor = System.Windows.Forms.AnchorStyles.Bottom;
            this.BtnNewCrearCita.Font = new System.Drawing.Font("Gadugi", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BtnNewCrearCita.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.BtnNewCrearCita.Image = global::Sistema_gestor_de_pacientes.Properties.Resources.Fondo_9_Gio;
            this.BtnNewCrearCita.Location = new System.Drawing.Point(74, 53);
            this.BtnNewCrearCita.Name = "BtnNewCrearCita";
            this.BtnNewCrearCita.Size = new System.Drawing.Size(253, 27);
            this.BtnNewCrearCita.TabIndex = 1;
            this.BtnNewCrearCita.Text = "Crear cita";
            this.BtnNewCrearCita.UseVisualStyleBackColor = true;
            // 
            // BtnEliminarCita
            // 
            this.BtnEliminarCita.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.BtnEliminarCita.Font = new System.Drawing.Font("Gadugi", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BtnEliminarCita.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.BtnEliminarCita.Image = global::Sistema_gestor_de_pacientes.Properties.Resources.Fondo_9_Gio;
            this.BtnEliminarCita.Location = new System.Drawing.Point(79, 374);
            this.BtnEliminarCita.Name = "BtnEliminarCita";
            this.BtnEliminarCita.Size = new System.Drawing.Size(253, 27);
            this.BtnEliminarCita.TabIndex = 2;
            this.BtnEliminarCita.Text = "Eliminar cita";
            this.BtnEliminarCita.UseVisualStyleBackColor = true;
            // 
            // FrmMantenimientoCitas
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::Sistema_gestor_de_pacientes.Properties.Resources.ProgramacionMC;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.tableLayoutPanel1);
            this.Name = "FrmMantenimientoCitas";
            this.Text = "Mantenimiento Citas";
            this.tableLayoutPanel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.DgvMantenimientoCitas)).EndInit();
            this.tableLayoutPanel2.ResumeLayout(false);
            this.tableLayoutPanel2.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel1;
        private System.Windows.Forms.Button BtnEliminarCita;
        private System.Windows.Forms.DataGridView DgvMantenimientoCitas;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel2;
        private System.Windows.Forms.Label LblMantenimientoCitar;
        private System.Windows.Forms.Button BtnNewCrearCita;
    }
}