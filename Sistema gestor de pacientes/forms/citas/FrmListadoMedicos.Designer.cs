
namespace Sistema_gestor_de_pacientes.forms.citas
{
    partial class FrmListadoMedicos
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
            this.LblListadoMedicos = new System.Windows.Forms.Label();
            this.tableLayoutPanel1 = new System.Windows.Forms.TableLayoutPanel();
            this.tableLayoutPanel2 = new System.Windows.Forms.TableLayoutPanel();
            this.DgvListadoMedicos = new System.Windows.Forms.DataGridView();
            this.flowLayoutPanel1 = new System.Windows.Forms.FlowLayoutPanel();
            this.TxtBuscarListadoMedicos = new System.Windows.Forms.TextBox();
            this.BtnBuscarListadoMedicos = new System.Windows.Forms.Button();
            this.BtnSiguientePaso = new System.Windows.Forms.Button();
            this.tableLayoutPanel3 = new System.Windows.Forms.TableLayoutPanel();
            this.tableLayoutPanel1.SuspendLayout();
            this.tableLayoutPanel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.DgvListadoMedicos)).BeginInit();
            this.flowLayoutPanel1.SuspendLayout();
            this.tableLayoutPanel3.SuspendLayout();
            this.SuspendLayout();
            // 
            // LblListadoMedicos
            // 
            this.LblListadoMedicos.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.LblListadoMedicos.AutoSize = true;
            this.LblListadoMedicos.Font = new System.Drawing.Font("Neozoic Trial", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LblListadoMedicos.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.LblListadoMedicos.Location = new System.Drawing.Point(3, 0);
            this.LblListadoMedicos.Name = "LblListadoMedicos";
            this.LblListadoMedicos.Size = new System.Drawing.Size(788, 32);
            this.LblListadoMedicos.TabIndex = 0;
            this.LblListadoMedicos.Text = "Listado Medicos";
            this.LblListadoMedicos.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // tableLayoutPanel1
            // 
            this.tableLayoutPanel1.BackColor = System.Drawing.Color.Transparent;
            this.tableLayoutPanel1.ColumnCount = 3;
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 33.33333F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 33.33333F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 33.33333F));
            this.tableLayoutPanel1.Controls.Add(this.tableLayoutPanel2, 1, 1);
            this.tableLayoutPanel1.Controls.Add(this.tableLayoutPanel3, 0, 0);
            this.tableLayoutPanel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel1.Location = new System.Drawing.Point(0, 0);
            this.tableLayoutPanel1.Name = "tableLayoutPanel1";
            this.tableLayoutPanel1.RowCount = 3;
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 11.77778F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 76F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 12.44444F));
            this.tableLayoutPanel1.Size = new System.Drawing.Size(800, 450);
            this.tableLayoutPanel1.TabIndex = 1;
            // 
            // tableLayoutPanel2
            // 
            this.tableLayoutPanel2.ColumnCount = 1;
            this.tableLayoutPanel2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            this.tableLayoutPanel2.Controls.Add(this.DgvListadoMedicos, 0, 1);
            this.tableLayoutPanel2.Controls.Add(this.flowLayoutPanel1, 0, 0);
            this.tableLayoutPanel2.Controls.Add(this.BtnSiguientePaso, 0, 2);
            this.tableLayoutPanel2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel2.Location = new System.Drawing.Point(269, 55);
            this.tableLayoutPanel2.Name = "tableLayoutPanel2";
            this.tableLayoutPanel2.RowCount = 3;
            this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 10.85526F));
            this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 89.14474F));
            this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 30F));
            this.tableLayoutPanel2.Size = new System.Drawing.Size(260, 335);
            this.tableLayoutPanel2.TabIndex = 0;
            // 
            // DgvListadoMedicos
            // 
            this.DgvListadoMedicos.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.DgvListadoMedicos.Dock = System.Windows.Forms.DockStyle.Fill;
            this.DgvListadoMedicos.Location = new System.Drawing.Point(3, 36);
            this.DgvListadoMedicos.Name = "DgvListadoMedicos";
            this.DgvListadoMedicos.Size = new System.Drawing.Size(254, 265);
            this.DgvListadoMedicos.TabIndex = 0;
            // 
            // flowLayoutPanel1
            // 
            this.flowLayoutPanel1.Controls.Add(this.TxtBuscarListadoMedicos);
            this.flowLayoutPanel1.Controls.Add(this.BtnBuscarListadoMedicos);
            this.flowLayoutPanel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.flowLayoutPanel1.Location = new System.Drawing.Point(3, 3);
            this.flowLayoutPanel1.Name = "flowLayoutPanel1";
            this.flowLayoutPanel1.Size = new System.Drawing.Size(254, 27);
            this.flowLayoutPanel1.TabIndex = 1;
            // 
            // TxtBuscarListadoMedicos
            // 
            this.TxtBuscarListadoMedicos.Location = new System.Drawing.Point(3, 3);
            this.TxtBuscarListadoMedicos.Name = "TxtBuscarListadoMedicos";
            this.TxtBuscarListadoMedicos.Size = new System.Drawing.Size(211, 20);
            this.TxtBuscarListadoMedicos.TabIndex = 0;
            // 
            // BtnBuscarListadoMedicos
            // 
            this.BtnBuscarListadoMedicos.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.BtnBuscarListadoMedicos.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BtnBuscarListadoMedicos.Location = new System.Drawing.Point(220, 3);
            this.BtnBuscarListadoMedicos.Name = "BtnBuscarListadoMedicos";
            this.BtnBuscarListadoMedicos.Size = new System.Drawing.Size(29, 23);
            this.BtnBuscarListadoMedicos.TabIndex = 1;
            this.BtnBuscarListadoMedicos.Text = "🔎";
            this.BtnBuscarListadoMedicos.UseVisualStyleBackColor = true;
            // 
            // BtnSiguientePaso
            // 
            this.BtnSiguientePaso.Dock = System.Windows.Forms.DockStyle.Fill;
            this.BtnSiguientePaso.Font = new System.Drawing.Font("Gadugi", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BtnSiguientePaso.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.BtnSiguientePaso.Image = global::Sistema_gestor_de_pacientes.Properties.Resources.Fondo_9_Gio;
            this.BtnSiguientePaso.Location = new System.Drawing.Point(3, 307);
            this.BtnSiguientePaso.Name = "BtnSiguientePaso";
            this.BtnSiguientePaso.Size = new System.Drawing.Size(254, 25);
            this.BtnSiguientePaso.TabIndex = 2;
            this.BtnSiguientePaso.Text = "Siguiente Paso";
            this.BtnSiguientePaso.UseVisualStyleBackColor = true;
            // 
            // tableLayoutPanel3
            // 
            this.tableLayoutPanel3.ColumnCount = 1;
            this.tableLayoutPanel1.SetColumnSpan(this.tableLayoutPanel3, 3);
            this.tableLayoutPanel3.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel3.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            this.tableLayoutPanel3.Controls.Add(this.LblListadoMedicos, 0, 0);
            this.tableLayoutPanel3.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel3.Location = new System.Drawing.Point(3, 3);
            this.tableLayoutPanel3.Name = "tableLayoutPanel3";
            this.tableLayoutPanel3.RowCount = 2;
            this.tableLayoutPanel3.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 71.73913F));
            this.tableLayoutPanel3.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 28.26087F));
            this.tableLayoutPanel3.Size = new System.Drawing.Size(794, 46);
            this.tableLayoutPanel3.TabIndex = 1;
            // 
            // FrmListadoMedicos
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::Sistema_gestor_de_pacientes.Properties.Resources.background;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.tableLayoutPanel1);
            this.Name = "FrmListadoMedicos";
            this.Text = "FrmListadoMedicos";
            this.Load += new System.EventHandler(this.FrmListadoMedicos_Load);
            this.tableLayoutPanel1.ResumeLayout(false);
            this.tableLayoutPanel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.DgvListadoMedicos)).EndInit();
            this.flowLayoutPanel1.ResumeLayout(false);
            this.flowLayoutPanel1.PerformLayout();
            this.tableLayoutPanel3.ResumeLayout(false);
            this.tableLayoutPanel3.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Label LblListadoMedicos;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel1;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel2;
        private System.Windows.Forms.DataGridView DgvListadoMedicos;
        private System.Windows.Forms.FlowLayoutPanel flowLayoutPanel1;
        private System.Windows.Forms.TextBox TxtBuscarListadoMedicos;
        private System.Windows.Forms.Button BtnBuscarListadoMedicos;
        private System.Windows.Forms.Button BtnSiguientePaso;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel3;
    }
}