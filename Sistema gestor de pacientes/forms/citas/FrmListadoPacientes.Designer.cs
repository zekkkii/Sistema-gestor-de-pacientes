
namespace Sistema_gestor_de_pacientes.forms.citas
{
    partial class FrmListadoPacientes
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
            this.DgvListadoPacientes = new System.Windows.Forms.DataGridView();
            this.flowLayoutPanel1 = new System.Windows.Forms.FlowLayoutPanel();
            this.TxtListadoPacientes = new System.Windows.Forms.TextBox();
            this.BtnBuscarListadoPacientes = new System.Windows.Forms.Button();
            this.BtnSiguientePaso = new System.Windows.Forms.Button();
            this.tableLayoutPanel3 = new System.Windows.Forms.TableLayoutPanel();
            this.LblListadoPacientes = new System.Windows.Forms.Label();
            this.tableLayoutPanel1.SuspendLayout();
            this.tableLayoutPanel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.DgvListadoPacientes)).BeginInit();
            this.flowLayoutPanel1.SuspendLayout();
            this.tableLayoutPanel3.SuspendLayout();
            this.SuspendLayout();
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
            this.tableLayoutPanel1.TabIndex = 0;
            // 
            // tableLayoutPanel2
            // 
            this.tableLayoutPanel2.ColumnCount = 1;
            this.tableLayoutPanel2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            this.tableLayoutPanel2.Controls.Add(this.DgvListadoPacientes, 0, 1);
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
            // DgvListadoPacientes
            // 
            this.DgvListadoPacientes.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.DgvListadoPacientes.Dock = System.Windows.Forms.DockStyle.Fill;
            this.DgvListadoPacientes.Location = new System.Drawing.Point(3, 36);
            this.DgvListadoPacientes.Name = "DgvListadoPacientes";
            this.DgvListadoPacientes.Size = new System.Drawing.Size(254, 265);
            this.DgvListadoPacientes.TabIndex = 0;
            this.DgvListadoPacientes.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.DgvListadoPacientes_CellContentClick);
            // 
            // flowLayoutPanel1
            // 
            this.flowLayoutPanel1.Controls.Add(this.TxtListadoPacientes);
            this.flowLayoutPanel1.Controls.Add(this.BtnBuscarListadoPacientes);
            this.flowLayoutPanel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.flowLayoutPanel1.Location = new System.Drawing.Point(3, 3);
            this.flowLayoutPanel1.Name = "flowLayoutPanel1";
            this.flowLayoutPanel1.Size = new System.Drawing.Size(254, 27);
            this.flowLayoutPanel1.TabIndex = 1;
            // 
            // TxtListadoPacientes
            // 
            this.TxtListadoPacientes.Location = new System.Drawing.Point(3, 3);
            this.TxtListadoPacientes.Name = "TxtListadoPacientes";
            this.TxtListadoPacientes.Size = new System.Drawing.Size(211, 20);
            this.TxtListadoPacientes.TabIndex = 0;
            // 
            // BtnBuscarListadoPacientes
            // 
            this.BtnBuscarListadoPacientes.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.BtnBuscarListadoPacientes.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BtnBuscarListadoPacientes.Location = new System.Drawing.Point(220, 3);
            this.BtnBuscarListadoPacientes.Name = "BtnBuscarListadoPacientes";
            this.BtnBuscarListadoPacientes.Size = new System.Drawing.Size(29, 23);
            this.BtnBuscarListadoPacientes.TabIndex = 1;
            this.BtnBuscarListadoPacientes.Text = "🔎";
            this.BtnBuscarListadoPacientes.UseVisualStyleBackColor = true;
            this.BtnBuscarListadoPacientes.Click += new System.EventHandler(this.BtnBuscarListadoPacientes_Click);
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
            this.BtnSiguientePaso.Click += new System.EventHandler(this.BtnSiguientePaso_Click);
            // 
            // tableLayoutPanel3
            // 
            this.tableLayoutPanel3.ColumnCount = 1;
            this.tableLayoutPanel1.SetColumnSpan(this.tableLayoutPanel3, 3);
            this.tableLayoutPanel3.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel3.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            this.tableLayoutPanel3.Controls.Add(this.LblListadoPacientes, 0, 0);
            this.tableLayoutPanel3.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel3.Location = new System.Drawing.Point(3, 3);
            this.tableLayoutPanel3.Name = "tableLayoutPanel3";
            this.tableLayoutPanel3.RowCount = 2;
            this.tableLayoutPanel3.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 71.73913F));
            this.tableLayoutPanel3.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 28.26087F));
            this.tableLayoutPanel3.Size = new System.Drawing.Size(794, 46);
            this.tableLayoutPanel3.TabIndex = 1;
            // 
            // LblListadoPacientes
            // 
            this.LblListadoPacientes.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.LblListadoPacientes.AutoSize = true;
            this.LblListadoPacientes.Font = new System.Drawing.Font("Neozoic Trial", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LblListadoPacientes.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.LblListadoPacientes.Location = new System.Drawing.Point(3, 0);
            this.LblListadoPacientes.Name = "LblListadoPacientes";
            this.LblListadoPacientes.Size = new System.Drawing.Size(788, 32);
            this.LblListadoPacientes.TabIndex = 0;
            this.LblListadoPacientes.Text = "Listado Pacientes";
            this.LblListadoPacientes.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // FrmListadoPacientes
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::Sistema_gestor_de_pacientes.Properties.Resources.background;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.tableLayoutPanel1);
            this.Name = "FrmListadoPacientes";
            this.Text = "FrmListadoPacientes";
            this.Load += new System.EventHandler(this.FrmListadoPacientes_Load);
            this.tableLayoutPanel1.ResumeLayout(false);
            this.tableLayoutPanel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.DgvListadoPacientes)).EndInit();
            this.flowLayoutPanel1.ResumeLayout(false);
            this.flowLayoutPanel1.PerformLayout();
            this.tableLayoutPanel3.ResumeLayout(false);
            this.tableLayoutPanel3.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel1;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel2;
        private System.Windows.Forms.DataGridView DgvListadoPacientes;
        private System.Windows.Forms.FlowLayoutPanel flowLayoutPanel1;
        private System.Windows.Forms.TextBox TxtListadoPacientes;
        private System.Windows.Forms.Button BtnBuscarListadoPacientes;
        private System.Windows.Forms.Button BtnSiguientePaso;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel3;
        private System.Windows.Forms.Label LblListadoPacientes;
    }
}