namespace Proyectro
{
    partial class PrestamoFrm
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
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.filtroLeyes = new System.Windows.Forms.TextBox();
            this.button1 = new System.Windows.Forms.Button();
            this.dvgLeyes = new System.Windows.Forms.DataGridView();
            this.dvgReglamentos = new System.Windows.Forms.DataGridView();
            this.button2 = new System.Windows.Forms.Button();
            this.filtroReglamentos = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.button3 = new System.Windows.Forms.Button();
            this.button4 = new System.Windows.Forms.Button();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.historialPrestamos = new System.Windows.Forms.RadioButton();
            this.informeXgrupo = new System.Windows.Forms.RadioButton();
            this.informeXley = new System.Windows.Forms.RadioButton();
            this.label7 = new System.Windows.Forms.Label();
            this.button7 = new System.Windows.Forms.Button();
            this.numeroLeyoGrupo = new System.Windows.Forms.NumericUpDown();
            this.button6 = new System.Windows.Forms.Button();
            this.button5 = new System.Windows.Forms.Button();
            this.label6 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.dgvPrestamosReglamento = new System.Windows.Forms.DataGridView();
            this.dvgPrestamosLey = new System.Windows.Forms.DataGridView();
            ((System.ComponentModel.ISupportInitialize)(this.dvgLeyes)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dvgReglamentos)).BeginInit();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numeroLeyoGrupo)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvPrestamosReglamento)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dvgPrestamosLey)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(12, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(51, 20);
            this.label1.TabIndex = 0;
            this.label1.Text = "Leyes";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(27, 33);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(90, 13);
            this.label2.TabIndex = 1;
            this.label2.Text = "Buscar por Titulo:";
            this.label2.Click += new System.EventHandler(this.label2_Click);
            // 
            // filtroLeyes
            // 
            this.filtroLeyes.Location = new System.Drawing.Point(123, 27);
            this.filtroLeyes.Name = "filtroLeyes";
            this.filtroLeyes.Size = new System.Drawing.Size(409, 20);
            this.filtroLeyes.TabIndex = 2;
            // 
            // button1
            // 
            this.button1.BackColor = System.Drawing.Color.LightSkyBlue;
            this.button1.ForeColor = System.Drawing.Color.Black;
            this.button1.Location = new System.Drawing.Point(538, 23);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(75, 23);
            this.button1.TabIndex = 3;
            this.button1.Text = "Buscar";
            this.button1.UseVisualStyleBackColor = false;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // dvgLeyes
            // 
            this.dvgLeyes.AllowUserToAddRows = false;
            this.dvgLeyes.AllowUserToDeleteRows = false;
            this.dvgLeyes.AllowUserToResizeRows = false;
            this.dvgLeyes.BackgroundColor = System.Drawing.SystemColors.ButtonFace;
            this.dvgLeyes.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.Single;
            this.dvgLeyes.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dvgLeyes.EditMode = System.Windows.Forms.DataGridViewEditMode.EditProgrammatically;
            this.dvgLeyes.Location = new System.Drawing.Point(30, 53);
            this.dvgLeyes.MultiSelect = false;
            this.dvgLeyes.Name = "dvgLeyes";
            this.dvgLeyes.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dvgLeyes.Size = new System.Drawing.Size(594, 150);
            this.dvgLeyes.TabIndex = 4;
            this.dvgLeyes.SelectionChanged += new System.EventHandler(this.dvgLeyes_SelectionChanged);
            // 
            // dvgReglamentos
            // 
            this.dvgReglamentos.AllowUserToAddRows = false;
            this.dvgReglamentos.AllowUserToDeleteRows = false;
            this.dvgReglamentos.AllowUserToResizeRows = false;
            this.dvgReglamentos.BackgroundColor = System.Drawing.SystemColors.ButtonFace;
            this.dvgReglamentos.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.Single;
            this.dvgReglamentos.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dvgReglamentos.EditMode = System.Windows.Forms.DataGridViewEditMode.EditProgrammatically;
            this.dvgReglamentos.Location = new System.Drawing.Point(30, 303);
            this.dvgReglamentos.MultiSelect = false;
            this.dvgReglamentos.Name = "dvgReglamentos";
            this.dvgReglamentos.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dvgReglamentos.Size = new System.Drawing.Size(594, 150);
            this.dvgReglamentos.TabIndex = 9;
            this.dvgReglamentos.SelectionChanged += new System.EventHandler(this.dvgReglamentos_SelectionChanged);
            // 
            // button2
            // 
            this.button2.BackColor = System.Drawing.Color.LightSkyBlue;
            this.button2.ForeColor = System.Drawing.Color.Black;
            this.button2.Location = new System.Drawing.Point(538, 273);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(75, 23);
            this.button2.TabIndex = 8;
            this.button2.Text = "Buscar";
            this.button2.UseVisualStyleBackColor = false;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // filtroReglamentos
            // 
            this.filtroReglamentos.Location = new System.Drawing.Point(123, 277);
            this.filtroReglamentos.Name = "filtroReglamentos";
            this.filtroReglamentos.Size = new System.Drawing.Size(409, 20);
            this.filtroReglamentos.TabIndex = 7;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(27, 283);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(90, 13);
            this.label3.TabIndex = 6;
            this.label3.Text = "Buscar por Titulo:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(12, 259);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(104, 20);
            this.label4.TabIndex = 5;
            this.label4.Text = "Reglamentos";
            // 
            // button3
            // 
            this.button3.BackColor = System.Drawing.Color.Gold;
            this.button3.Location = new System.Drawing.Point(496, 209);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(128, 23);
            this.button3.TabIndex = 10;
            this.button3.Text = "Prestar Ley (Lote)";
            this.button3.UseVisualStyleBackColor = false;
            this.button3.Click += new System.EventHandler(this.button3_Click);
            // 
            // button4
            // 
            this.button4.BackColor = System.Drawing.Color.Gold;
            this.button4.Location = new System.Drawing.Point(496, 459);
            this.button4.Name = "button4";
            this.button4.Size = new System.Drawing.Size(128, 23);
            this.button4.TabIndex = 11;
            this.button4.Text = "Prestar Reglamento";
            this.button4.UseVisualStyleBackColor = false;
            this.button4.Click += new System.EventHandler(this.button4_Click);
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.historialPrestamos);
            this.groupBox1.Controls.Add(this.informeXgrupo);
            this.groupBox1.Controls.Add(this.informeXley);
            this.groupBox1.Controls.Add(this.label7);
            this.groupBox1.Controls.Add(this.button7);
            this.groupBox1.Controls.Add(this.numeroLeyoGrupo);
            this.groupBox1.Controls.Add(this.button6);
            this.groupBox1.Controls.Add(this.button5);
            this.groupBox1.Controls.Add(this.label6);
            this.groupBox1.Controls.Add(this.label5);
            this.groupBox1.Controls.Add(this.dgvPrestamosReglamento);
            this.groupBox1.Controls.Add(this.dvgPrestamosLey);
            this.groupBox1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox1.Location = new System.Drawing.Point(667, 12);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(452, 488);
            this.groupBox1.TabIndex = 15;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Listado de Prestamos";
            // 
            // historialPrestamos
            // 
            this.historialPrestamos.AutoSize = true;
            this.historialPrestamos.Checked = true;
            this.historialPrestamos.Location = new System.Drawing.Point(55, 51);
            this.historialPrestamos.Name = "historialPrestamos";
            this.historialPrestamos.Size = new System.Drawing.Size(164, 24);
            this.historialPrestamos.TabIndex = 28;
            this.historialPrestamos.TabStop = true;
            this.historialPrestamos.Text = "Historial Prestamos";
            this.historialPrestamos.UseVisualStyleBackColor = true;
            // 
            // informeXgrupo
            // 
            this.informeXgrupo.AutoSize = true;
            this.informeXgrupo.Location = new System.Drawing.Point(225, 59);
            this.informeXgrupo.Name = "informeXgrupo";
            this.informeXgrupo.Size = new System.Drawing.Size(85, 24);
            this.informeXgrupo.TabIndex = 27;
            this.informeXgrupo.TabStop = true;
            this.informeXgrupo.Text = "# Grupo";
            this.informeXgrupo.UseVisualStyleBackColor = true;
            // 
            // informeXley
            // 
            this.informeXley.AutoSize = true;
            this.informeXley.Location = new System.Drawing.Point(225, 37);
            this.informeXley.Name = "informeXley";
            this.informeXley.Size = new System.Drawing.Size(65, 24);
            this.informeXley.TabIndex = 26;
            this.informeXley.TabStop = true;
            this.informeXley.Text = "# Ley";
            this.informeXley.UseVisualStyleBackColor = true;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(215, 15);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(95, 20);
            this.label7.TabIndex = 25;
            this.label7.Text = "Informe por:";
            // 
            // button7
            // 
            this.button7.BackColor = System.Drawing.Color.DeepSkyBlue;
            this.button7.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button7.Location = new System.Drawing.Point(381, 53);
            this.button7.Name = "button7";
            this.button7.Size = new System.Drawing.Size(57, 23);
            this.button7.TabIndex = 24;
            this.button7.Text = "Buscar";
            this.button7.UseVisualStyleBackColor = false;
            this.button7.Click += new System.EventHandler(this.button7_Click);
            // 
            // numeroLeyoGrupo
            // 
            this.numeroLeyoGrupo.Location = new System.Drawing.Point(319, 53);
            this.numeroLeyoGrupo.Name = "numeroLeyoGrupo";
            this.numeroLeyoGrupo.Size = new System.Drawing.Size(56, 26);
            this.numeroLeyoGrupo.TabIndex = 21;
            // 
            // button6
            // 
            this.button6.BackColor = System.Drawing.Color.LimeGreen;
            this.button6.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button6.Location = new System.Drawing.Point(259, 447);
            this.button6.Name = "button6";
            this.button6.Size = new System.Drawing.Size(153, 23);
            this.button6.TabIndex = 19;
            this.button6.Text = "Devolver Reglamento";
            this.button6.UseVisualStyleBackColor = false;
            this.button6.Click += new System.EventHandler(this.button6_Click);
            // 
            // button5
            // 
            this.button5.BackColor = System.Drawing.Color.LimeGreen;
            this.button5.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button5.Location = new System.Drawing.Point(259, 257);
            this.button5.Name = "button5";
            this.button5.Size = new System.Drawing.Size(153, 23);
            this.button5.TabIndex = 18;
            this.button5.Text = "Devolver Ley";
            this.button5.UseVisualStyleBackColor = false;
            this.button5.Click += new System.EventHandler(this.button5_Click);
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(7, 271);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(104, 20);
            this.label6.TabIndex = 17;
            this.label6.Text = "Reglamentos";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(6, 78);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(51, 20);
            this.label5.TabIndex = 16;
            this.label5.Text = "Leyes";
            // 
            // dgvPrestamosReglamento
            // 
            this.dgvPrestamosReglamento.AllowUserToAddRows = false;
            this.dgvPrestamosReglamento.AllowUserToDeleteRows = false;
            this.dgvPrestamosReglamento.AllowUserToResizeRows = false;
            this.dgvPrestamosReglamento.BackgroundColor = System.Drawing.SystemColors.ButtonFace;
            this.dgvPrestamosReglamento.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.Single;
            this.dgvPrestamosReglamento.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvPrestamosReglamento.EditMode = System.Windows.Forms.DataGridViewEditMode.EditProgrammatically;
            this.dgvPrestamosReglamento.Location = new System.Drawing.Point(6, 291);
            this.dgvPrestamosReglamento.MultiSelect = false;
            this.dgvPrestamosReglamento.Name = "dgvPrestamosReglamento";
            this.dgvPrestamosReglamento.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvPrestamosReglamento.Size = new System.Drawing.Size(433, 150);
            this.dgvPrestamosReglamento.TabIndex = 15;
            this.dgvPrestamosReglamento.SelectionChanged += new System.EventHandler(this.dgvPrestamosReglamento_SelectionChanged_1);
            // 
            // dvgPrestamosLey
            // 
            this.dvgPrestamosLey.AllowUserToAddRows = false;
            this.dvgPrestamosLey.AllowUserToDeleteRows = false;
            this.dvgPrestamosLey.AllowUserToResizeRows = false;
            this.dvgPrestamosLey.BackgroundColor = System.Drawing.SystemColors.ButtonFace;
            this.dvgPrestamosLey.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.Single;
            this.dvgPrestamosLey.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dvgPrestamosLey.EditMode = System.Windows.Forms.DataGridViewEditMode.EditProgrammatically;
            this.dvgPrestamosLey.Location = new System.Drawing.Point(6, 101);
            this.dvgPrestamosLey.MultiSelect = false;
            this.dvgPrestamosLey.Name = "dvgPrestamosLey";
            this.dvgPrestamosLey.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dvgPrestamosLey.Size = new System.Drawing.Size(433, 150);
            this.dvgPrestamosLey.TabIndex = 14;
            this.dvgPrestamosLey.SelectionChanged += new System.EventHandler(this.dvgPrestamosLey_SelectionChanged_1);
            // 
            // PrestamoFrm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1144, 576);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.button4);
            this.Controls.Add(this.button3);
            this.Controls.Add(this.dvgReglamentos);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.filtroReglamentos);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.dvgLeyes);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.filtroLeyes);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "PrestamoFrm";
            this.Text = "PrestamoFrm";
            this.Load += new System.EventHandler(this.PrestamoFrm_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dvgLeyes)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dvgReglamentos)).EndInit();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numeroLeyoGrupo)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvPrestamosReglamento)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dvgPrestamosLey)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox filtroLeyes;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.DataGridView dvgLeyes;
        private System.Windows.Forms.DataGridView dvgReglamentos;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.TextBox filtroReglamentos;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.Button button4;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.DataGridView dgvPrestamosReglamento;
        private System.Windows.Forms.DataGridView dvgPrestamosLey;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Button button6;
        private System.Windows.Forms.Button button5;
        private System.Windows.Forms.NumericUpDown numeroLeyoGrupo;
        private System.Windows.Forms.Button button7;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.RadioButton informeXgrupo;
        private System.Windows.Forms.RadioButton informeXley;
        private System.Windows.Forms.RadioButton historialPrestamos;
    }
}