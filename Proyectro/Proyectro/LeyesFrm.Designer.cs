namespace Proyectro
{
    partial class LeyesFrm
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
            this.label8 = new System.Windows.Forms.Label();
            this.cancelarReglamento = new System.Windows.Forms.Button();
            this.grabarReglamento = new System.Windows.Forms.Button();
            this.eliminarReglamento = new System.Windows.Forms.Button();
            this.editarReglamento = new System.Windows.Forms.Button();
            this.nuevoReglamento = new System.Windows.Forms.Button();
            this.dgvReglamentos = new System.Windows.Forms.DataGridView();
            this.cancelarLey = new System.Windows.Forms.Button();
            this.grabarLey = new System.Windows.Forms.Button();
            this.eliminarLey = new System.Windows.Forms.Button();
            this.modificarLey = new System.Windows.Forms.Button();
            this.nuevaLey = new System.Windows.Forms.Button();
            this.label4 = new System.Windows.Forms.Label();
            this.titulo = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.dgvLeyes = new System.Windows.Forms.DataGridView();
            this.label1 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.tituloReglamento = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.contenidoReglamento = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.fechaCreacion = new System.Windows.Forms.DateTimePicker();
            this.fechaCreacionReglamento = new System.Windows.Forms.DateTimePicker();
            this.contenido = new System.Windows.Forms.TextBox();
            ((System.ComponentModel.ISupportInitialize)(this.dgvReglamentos)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvLeyes)).BeginInit();
            this.SuspendLayout();
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.ForeColor = System.Drawing.SystemColors.HotTrack;
            this.label8.Location = new System.Drawing.Point(36, 270);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(69, 13);
            this.label8.TabIndex = 78;
            this.label8.Text = "Reglamentos";
            // 
            // cancelarReglamento
            // 
            this.cancelarReglamento.BackColor = System.Drawing.Color.Red;
            this.cancelarReglamento.Location = new System.Drawing.Point(209, 440);
            this.cancelarReglamento.Name = "cancelarReglamento";
            this.cancelarReglamento.Size = new System.Drawing.Size(75, 23);
            this.cancelarReglamento.TabIndex = 77;
            this.cancelarReglamento.Text = "Cancelar";
            this.cancelarReglamento.UseVisualStyleBackColor = false;
            this.cancelarReglamento.Visible = false;
            this.cancelarReglamento.Click += new System.EventHandler(this.cancelarReglamento_Click);
            // 
            // grabarReglamento
            // 
            this.grabarReglamento.BackColor = System.Drawing.Color.Green;
            this.grabarReglamento.Location = new System.Drawing.Point(128, 440);
            this.grabarReglamento.Name = "grabarReglamento";
            this.grabarReglamento.Size = new System.Drawing.Size(75, 23);
            this.grabarReglamento.TabIndex = 76;
            this.grabarReglamento.Text = "Grabar";
            this.grabarReglamento.UseVisualStyleBackColor = false;
            this.grabarReglamento.Visible = false;
            this.grabarReglamento.Click += new System.EventHandler(this.grabarReglamento_Click);
            // 
            // eliminarReglamento
            // 
            this.eliminarReglamento.BackColor = System.Drawing.Color.Red;
            this.eliminarReglamento.Location = new System.Drawing.Point(250, 411);
            this.eliminarReglamento.Name = "eliminarReglamento";
            this.eliminarReglamento.Size = new System.Drawing.Size(75, 23);
            this.eliminarReglamento.TabIndex = 75;
            this.eliminarReglamento.Text = "Eliminar";
            this.eliminarReglamento.UseVisualStyleBackColor = false;
            this.eliminarReglamento.Click += new System.EventHandler(this.eliminarReglamento_Click);
            // 
            // editarReglamento
            // 
            this.editarReglamento.BackColor = System.Drawing.Color.Yellow;
            this.editarReglamento.Location = new System.Drawing.Point(169, 411);
            this.editarReglamento.Name = "editarReglamento";
            this.editarReglamento.Size = new System.Drawing.Size(75, 23);
            this.editarReglamento.TabIndex = 74;
            this.editarReglamento.Text = "Editar";
            this.editarReglamento.UseVisualStyleBackColor = false;
            this.editarReglamento.Click += new System.EventHandler(this.editarReglamento_Click);
            // 
            // nuevoReglamento
            // 
            this.nuevoReglamento.BackColor = System.Drawing.SystemColors.Highlight;
            this.nuevoReglamento.Location = new System.Drawing.Point(88, 411);
            this.nuevoReglamento.Name = "nuevoReglamento";
            this.nuevoReglamento.Size = new System.Drawing.Size(75, 23);
            this.nuevoReglamento.TabIndex = 73;
            this.nuevoReglamento.Text = "Nuevo";
            this.nuevoReglamento.UseVisualStyleBackColor = false;
            this.nuevoReglamento.Click += new System.EventHandler(this.nuevoReglamento_Click);
            // 
            // dgvReglamentos
            // 
            this.dgvReglamentos.AllowUserToAddRows = false;
            this.dgvReglamentos.AllowUserToDeleteRows = false;
            this.dgvReglamentos.AllowUserToOrderColumns = true;
            this.dgvReglamentos.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvReglamentos.EditMode = System.Windows.Forms.DataGridViewEditMode.EditProgrammatically;
            this.dgvReglamentos.Location = new System.Drawing.Point(372, 283);
            this.dgvReglamentos.MultiSelect = false;
            this.dgvReglamentos.Name = "dgvReglamentos";
            this.dgvReglamentos.ReadOnly = true;
            this.dgvReglamentos.Size = new System.Drawing.Size(683, 175);
            this.dgvReglamentos.TabIndex = 66;
            this.dgvReglamentos.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvReglamentos_CellContentClick);
            this.dgvReglamentos.SelectionChanged += new System.EventHandler(this.dgvReglamentos_SelectionChanged);
            // 
            // cancelarLey
            // 
            this.cancelarLey.BackColor = System.Drawing.Color.Red;
            this.cancelarLey.Location = new System.Drawing.Point(209, 190);
            this.cancelarLey.Name = "cancelarLey";
            this.cancelarLey.Size = new System.Drawing.Size(75, 23);
            this.cancelarLey.TabIndex = 64;
            this.cancelarLey.Text = "Cancelar";
            this.cancelarLey.UseVisualStyleBackColor = false;
            this.cancelarLey.Visible = false;
            this.cancelarLey.Click += new System.EventHandler(this.cancelarLey_Click);
            // 
            // grabarLey
            // 
            this.grabarLey.BackColor = System.Drawing.Color.Green;
            this.grabarLey.Location = new System.Drawing.Point(128, 190);
            this.grabarLey.Name = "grabarLey";
            this.grabarLey.Size = new System.Drawing.Size(75, 23);
            this.grabarLey.TabIndex = 63;
            this.grabarLey.Text = "Grabar";
            this.grabarLey.UseVisualStyleBackColor = false;
            this.grabarLey.Visible = false;
            this.grabarLey.Click += new System.EventHandler(this.grabarLey_Click);
            // 
            // eliminarLey
            // 
            this.eliminarLey.BackColor = System.Drawing.Color.Red;
            this.eliminarLey.Location = new System.Drawing.Point(250, 161);
            this.eliminarLey.Name = "eliminarLey";
            this.eliminarLey.Size = new System.Drawing.Size(75, 23);
            this.eliminarLey.TabIndex = 62;
            this.eliminarLey.Text = "Eliminar";
            this.eliminarLey.UseVisualStyleBackColor = false;
            this.eliminarLey.Click += new System.EventHandler(this.eliminarLey_Click);
            // 
            // modificarLey
            // 
            this.modificarLey.BackColor = System.Drawing.Color.Yellow;
            this.modificarLey.Location = new System.Drawing.Point(169, 161);
            this.modificarLey.Name = "modificarLey";
            this.modificarLey.Size = new System.Drawing.Size(75, 23);
            this.modificarLey.TabIndex = 61;
            this.modificarLey.Text = "Editar";
            this.modificarLey.UseVisualStyleBackColor = false;
            this.modificarLey.Click += new System.EventHandler(this.modificarLey_Click);
            // 
            // nuevaLey
            // 
            this.nuevaLey.BackColor = System.Drawing.SystemColors.Highlight;
            this.nuevaLey.Location = new System.Drawing.Point(88, 161);
            this.nuevaLey.Name = "nuevaLey";
            this.nuevaLey.Size = new System.Drawing.Size(75, 23);
            this.nuevaLey.TabIndex = 58;
            this.nuevaLey.Text = "Nuevo";
            this.nuevaLey.UseVisualStyleBackColor = false;
            this.nuevaLey.Click += new System.EventHandler(this.nuevaLey_Click);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(33, 64);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(36, 13);
            this.label4.TabIndex = 60;
            this.label4.Text = "Titulo:";
            // 
            // titulo
            // 
            this.titulo.Enabled = false;
            this.titulo.Location = new System.Drawing.Point(88, 61);
            this.titulo.MaxLength = 50;
            this.titulo.Name = "titulo";
            this.titulo.Size = new System.Drawing.Size(258, 20);
            this.titulo.TabIndex = 54;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(33, 119);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(58, 13);
            this.label3.TabIndex = 59;
            this.label3.Text = "Contenido:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(33, 93);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(40, 13);
            this.label2.TabIndex = 57;
            this.label2.Text = "Fecha:";
            // 
            // dgvLeyes
            // 
            this.dgvLeyes.AllowUserToAddRows = false;
            this.dgvLeyes.AllowUserToDeleteRows = false;
            this.dgvLeyes.AllowUserToOrderColumns = true;
            this.dgvLeyes.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvLeyes.EditMode = System.Windows.Forms.DataGridViewEditMode.EditProgrammatically;
            this.dgvLeyes.Location = new System.Drawing.Point(372, 35);
            this.dgvLeyes.MultiSelect = false;
            this.dgvLeyes.Name = "dgvLeyes";
            this.dgvLeyes.ReadOnly = true;
            this.dgvLeyes.Size = new System.Drawing.Size(687, 178);
            this.dgvLeyes.TabIndex = 53;
            this.dgvLeyes.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvLeyes_CellContentClick);
            this.dgvLeyes.SelectionChanged += new System.EventHandler(this.dgvLeyes_SelectionChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.ForeColor = System.Drawing.SystemColors.HotTrack;
            this.label1.Location = new System.Drawing.Point(32, 22);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(35, 13);
            this.label1.TabIndex = 79;
            this.label1.Text = "Leyes";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(33, 314);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(36, 13);
            this.label5.TabIndex = 85;
            this.label5.Text = "Titulo:";
            // 
            // tituloReglamento
            // 
            this.tituloReglamento.Enabled = false;
            this.tituloReglamento.Location = new System.Drawing.Point(88, 311);
            this.tituloReglamento.MaxLength = 50;
            this.tituloReglamento.Name = "tituloReglamento";
            this.tituloReglamento.Size = new System.Drawing.Size(258, 20);
            this.tituloReglamento.TabIndex = 80;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(33, 369);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(58, 13);
            this.label6.TabIndex = 84;
            this.label6.Text = "Contenido:";
            // 
            // contenidoReglamento
            // 
            this.contenidoReglamento.Enabled = false;
            this.contenidoReglamento.Location = new System.Drawing.Point(88, 369);
            this.contenidoReglamento.MaxLength = 500;
            this.contenidoReglamento.Multiline = true;
            this.contenidoReglamento.Name = "contenidoReglamento";
            this.contenidoReglamento.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.contenidoReglamento.Size = new System.Drawing.Size(258, 36);
            this.contenidoReglamento.TabIndex = 82;
            this.contenidoReglamento.UseSystemPasswordChar = true;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(33, 343);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(40, 13);
            this.label7.TabIndex = 83;
            this.label7.Text = "Fecha:";
            // 
            // fechaCreacion
            // 
            this.fechaCreacion.CustomFormat = "dd/MM/yyyy";
            this.fechaCreacion.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.fechaCreacion.Location = new System.Drawing.Point(88, 91);
            this.fechaCreacion.Name = "fechaCreacion";
            this.fechaCreacion.Size = new System.Drawing.Size(100, 20);
            this.fechaCreacion.TabIndex = 86;
            // 
            // fechaCreacionReglamento
            // 
            this.fechaCreacionReglamento.CustomFormat = "dd/MM/yyyy";
            this.fechaCreacionReglamento.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.fechaCreacionReglamento.Location = new System.Drawing.Point(88, 340);
            this.fechaCreacionReglamento.Name = "fechaCreacionReglamento";
            this.fechaCreacionReglamento.Size = new System.Drawing.Size(100, 20);
            this.fechaCreacionReglamento.TabIndex = 87;
            // 
            // contenido
            // 
            this.contenido.Enabled = false;
            this.contenido.Location = new System.Drawing.Point(88, 119);
            this.contenido.MaxLength = 500;
            this.contenido.Multiline = true;
            this.contenido.Name = "contenido";
            this.contenido.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.contenido.Size = new System.Drawing.Size(258, 36);
            this.contenido.TabIndex = 56;
            this.contenido.UseSystemPasswordChar = true;
            // 
            // LeyesFrm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1208, 563);
            this.Controls.Add(this.fechaCreacionReglamento);
            this.Controls.Add(this.fechaCreacion);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.tituloReglamento);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.contenidoReglamento);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.cancelarReglamento);
            this.Controls.Add(this.grabarReglamento);
            this.Controls.Add(this.eliminarReglamento);
            this.Controls.Add(this.editarReglamento);
            this.Controls.Add(this.nuevoReglamento);
            this.Controls.Add(this.dgvReglamentos);
            this.Controls.Add(this.cancelarLey);
            this.Controls.Add(this.grabarLey);
            this.Controls.Add(this.eliminarLey);
            this.Controls.Add(this.modificarLey);
            this.Controls.Add(this.nuevaLey);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.titulo);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.contenido);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.dgvLeyes);
            this.Name = "LeyesFrm";
            this.Text = "Leyes";
            this.Load += new System.EventHandler(this.Leyes_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvReglamentos)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvLeyes)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Button cancelarReglamento;
        private System.Windows.Forms.Button grabarReglamento;
        private System.Windows.Forms.Button eliminarReglamento;
        private System.Windows.Forms.Button editarReglamento;
        private System.Windows.Forms.Button nuevoReglamento;
        private System.Windows.Forms.DataGridView dgvReglamentos;
        private System.Windows.Forms.Button cancelarLey;
        private System.Windows.Forms.Button grabarLey;
        private System.Windows.Forms.Button eliminarLey;
        private System.Windows.Forms.Button modificarLey;
        private System.Windows.Forms.Button nuevaLey;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox titulo;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.DataGridView dgvLeyes;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox tituloReglamento;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox contenidoReglamento;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.DateTimePicker fechaCreacion;
        private System.Windows.Forms.DateTimePicker fechaCreacionReglamento;
        private System.Windows.Forms.TextBox contenido;
    }
}