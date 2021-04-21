
namespace Sistema_gestor_de_pacientes.forms.citas
{
    partial class FrmListadoDePruebasPendienteConsulta
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
            this.LblListadoDePruebasLab = new System.Windows.Forms.Label();
            this.DgvListadoPruebasLab = new System.Windows.Forms.DataGridView();
            this.BtnRealizarPruebas = new System.Windows.Forms.Button();
            this.tableLayoutPanel1.SuspendLayout();
            this.tableLayoutPanel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.DgvListadoPruebasLab)).BeginInit();
            this.SuspendLayout();
            // 
            // tableLayoutPanel1
            // 
            this.tableLayoutPanel1.BackColor = System.Drawing.Color.Transparent;
            this.tableLayoutPanel1.ColumnCount = 3;
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 33.33333F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 33.33333F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 33.33333F));
            this.tableLayoutPanel1.Controls.Add(this.tableLayoutPanel2, 0, 0);
            this.tableLayoutPanel1.Controls.Add(this.DgvListadoPruebasLab, 1, 1);
            this.tableLayoutPanel1.Controls.Add(this.BtnRealizarPruebas, 1, 2);
            this.tableLayoutPanel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel1.Location = new System.Drawing.Point(0, 0);
            this.tableLayoutPanel1.Name = "tableLayoutPanel1";
            this.tableLayoutPanel1.RowCount = 3;
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 11.33333F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 68F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 20.88889F));
            this.tableLayoutPanel1.Size = new System.Drawing.Size(800, 450);
            this.tableLayoutPanel1.TabIndex = 0;
            // 
            // tableLayoutPanel2
            // 
            this.tableLayoutPanel2.ColumnCount = 1;
            this.tableLayoutPanel1.SetColumnSpan(this.tableLayoutPanel2, 3);
            this.tableLayoutPanel2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            this.tableLayoutPanel2.Controls.Add(this.LblListadoDePruebasLab, 0, 0);
            this.tableLayoutPanel2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel2.Location = new System.Drawing.Point(3, 3);
            this.tableLayoutPanel2.Name = "tableLayoutPanel2";
            this.tableLayoutPanel2.RowCount = 1;
            this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 44F));
            this.tableLayoutPanel2.Size = new System.Drawing.Size(794, 44);
            this.tableLayoutPanel2.TabIndex = 0;
            // 
            // LblListadoDePruebasLab
            // 
            this.LblListadoDePruebasLab.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.LblListadoDePruebasLab.AutoSize = true;
            this.LblListadoDePruebasLab.Font = new System.Drawing.Font("Neozoic Trial", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LblListadoDePruebasLab.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.LblListadoDePruebasLab.Location = new System.Drawing.Point(3, 7);
            this.LblListadoDePruebasLab.Name = "LblListadoDePruebasLab";
            this.LblListadoDePruebasLab.Size = new System.Drawing.Size(788, 29);
            this.LblListadoDePruebasLab.TabIndex = 0;
            this.LblListadoDePruebasLab.Text = "Listado de Pruebas de Laboratorio";
            this.LblListadoDePruebasLab.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // DgvListadoPruebasLab
            // 
            this.DgvListadoPruebasLab.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.DgvListadoPruebasLab.Dock = System.Windows.Forms.DockStyle.Fill;
            this.DgvListadoPruebasLab.Location = new System.Drawing.Point(269, 53);
            this.DgvListadoPruebasLab.Name = "DgvListadoPruebasLab";
            this.DgvListadoPruebasLab.Size = new System.Drawing.Size(260, 299);
            this.DgvListadoPruebasLab.TabIndex = 1;
            // 
            // BtnRealizarPruebas
            // 
            this.BtnRealizarPruebas.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.BtnRealizarPruebas.Font = new System.Drawing.Font("Gadugi", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BtnRealizarPruebas.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.BtnRealizarPruebas.Image = global::Sistema_gestor_de_pacientes.Properties.Resources.Fondo_9_Gio;
            this.BtnRealizarPruebas.Location = new System.Drawing.Point(269, 358);
            this.BtnRealizarPruebas.Name = "BtnRealizarPruebas";
            this.BtnRealizarPruebas.Size = new System.Drawing.Size(260, 27);
            this.BtnRealizarPruebas.TabIndex = 2;
            this.BtnRealizarPruebas.Text = "Realizar Pruebas";
            this.BtnRealizarPruebas.UseVisualStyleBackColor = true;
            // 
            // FrmListadoDePruebasPendienteConsulta
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::Sistema_gestor_de_pacientes.Properties.Resources.background;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.tableLayoutPanel1);
            this.Name = "FrmListadoDePruebasPendienteConsulta";
            this.Text = "FrmListadoDePruebasLab";
            this.Load += new System.EventHandler(this.FrmListadoDePruebasPendienteConsulta_Load);
            this.tableLayoutPanel1.ResumeLayout(false);
            this.tableLayoutPanel2.ResumeLayout(false);
            this.tableLayoutPanel2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.DgvListadoPruebasLab)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel1;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel2;
        private System.Windows.Forms.DataGridView DgvListadoPruebasLab;
        private System.Windows.Forms.Label LblListadoDePruebasLab;
        private System.Windows.Forms.Button BtnRealizarPruebas;
    }
}