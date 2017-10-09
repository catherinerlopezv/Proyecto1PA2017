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
            this.label5 = new System.Windows.Forms.Label();
            this.dvgPrestamosLey = new System.Windows.Forms.DataGridView();
            this.dgvPrestamosReglamento = new System.Windows.Forms.DataGridView();
            ((System.ComponentModel.ISupportInitialize)(this.dvgLeyes)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dvgReglamentos)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dvgPrestamosLey)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvPrestamosReglamento)).BeginInit();
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
            this.button1.BackColor = System.Drawing.Color.Gold;
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
            this.dvgLeyes.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dvgLeyes.Location = new System.Drawing.Point(30, 53);
            this.dvgLeyes.Name = "dvgLeyes";
            this.dvgLeyes.Size = new System.Drawing.Size(594, 150);
            this.dvgLeyes.TabIndex = 4;
            this.dvgLeyes.SelectionChanged += new System.EventHandler(this.dvgLeyes_SelectionChanged);
            // 
            // dvgReglamentos
            // 
            this.dvgReglamentos.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dvgReglamentos.Location = new System.Drawing.Point(30, 303);
            this.dvgReglamentos.Name = "dvgReglamentos";
            this.dvgReglamentos.Size = new System.Drawing.Size(594, 150);
            this.dvgReglamentos.TabIndex = 9;
            this.dvgReglamentos.SelectionChanged += new System.EventHandler(this.dvgReglamentos_SelectionChanged);
            // 
            // button2
            // 
            this.button2.BackColor = System.Drawing.Color.Gold;
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
            this.button3.Location = new System.Drawing.Point(496, 209);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(128, 23);
            this.button3.TabIndex = 10;
            this.button3.Text = "Prestar Ley (Lote)";
            this.button3.UseVisualStyleBackColor = true;
            this.button3.Click += new System.EventHandler(this.button3_Click);
            // 
            // button4
            // 
            this.button4.Location = new System.Drawing.Point(496, 459);
            this.button4.Name = "button4";
            this.button4.Size = new System.Drawing.Size(128, 23);
            this.button4.TabIndex = 11;
            this.button4.Text = "Prestar Reglamento";
            this.button4.UseVisualStyleBackColor = true;
            this.button4.Click += new System.EventHandler(this.button4_Click);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(762, 9);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(98, 24);
            this.label5.TabIndex = 12;
            this.label5.Text = "Prestamos";
            // 
            // dvgPrestamosLey
            // 
            this.dvgPrestamosLey.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dvgPrestamosLey.Location = new System.Drawing.Point(810, 53);
            this.dvgPrestamosLey.Name = "dvgPrestamosLey";
            this.dvgPrestamosLey.Size = new System.Drawing.Size(433, 150);
            this.dvgPrestamosLey.TabIndex = 13;
            this.dvgPrestamosLey.SelectionChanged += new System.EventHandler(this.dvgPrestamosLey_SelectionChanged);
            // 
            // dgvPrestamosReglamento
            // 
            this.dgvPrestamosReglamento.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvPrestamosReglamento.Location = new System.Drawing.Point(810, 250);
            this.dgvPrestamosReglamento.Name = "dgvPrestamosReglamento";
            this.dgvPrestamosReglamento.Size = new System.Drawing.Size(433, 150);
            this.dgvPrestamosReglamento.TabIndex = 14;
            this.dgvPrestamosReglamento.SelectionChanged += new System.EventHandler(this.dgvPrestamosReglamento_SelectionChanged);
            // 
            // PrestamoFrm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1298, 576);
            this.Controls.Add(this.dgvPrestamosReglamento);
            this.Controls.Add(this.dvgPrestamosLey);
            this.Controls.Add(this.label5);
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
            ((System.ComponentModel.ISupportInitialize)(this.dvgPrestamosLey)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvPrestamosReglamento)).EndInit();
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
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.DataGridView dvgPrestamosLey;
        private System.Windows.Forms.DataGridView dgvPrestamosReglamento;
    }
}