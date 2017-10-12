namespace Proyectro
{
    partial class UsuariosFrm
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
            this.dataSet1 = new System.Data.DataSet();
            this.dgvParlamentarios = new System.Windows.Forms.DataGridView();
            this.usuario = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.clave = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.nombre = new System.Windows.Forms.TextBox();
            this.nuevoParlamentario = new System.Windows.Forms.Button();
            this.modificarParlamentario = new System.Windows.Forms.Button();
            this.eliminarParlamentario = new System.Windows.Forms.Button();
            this.grabarParlamentario = new System.Windows.Forms.Button();
            this.cancelarParlamentario = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.dgvAsesores = new System.Windows.Forms.DataGridView();
            this.nombreAsesor = new System.Windows.Forms.TextBox();
            this.claveAsesor = new System.Windows.Forms.TextBox();
            this.usuarioAsesor = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.cancelarAsesor = new System.Windows.Forms.Button();
            this.grabarAsesor = new System.Windows.Forms.Button();
            this.eliminarAsesor = new System.Windows.Forms.Button();
            this.editarAsesor = new System.Windows.Forms.Button();
            this.nuevoAsesor = new System.Windows.Forms.Button();
            this.label8 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.dataSet1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvParlamentarios)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvAsesores)).BeginInit();
            this.SuspendLayout();
            // 
            // dataSet1
            // 
            this.dataSet1.DataSetName = "NewDataSet";
            // 
            // dgvParlamentarios
            // 
            this.dgvParlamentarios.AllowUserToAddRows = false;
            this.dgvParlamentarios.AllowUserToDeleteRows = false;
            this.dgvParlamentarios.AllowUserToOrderColumns = true;
            this.dgvParlamentarios.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvParlamentarios.EditMode = System.Windows.Forms.DataGridViewEditMode.EditProgrammatically;
            this.dgvParlamentarios.Location = new System.Drawing.Point(351, 12);
            this.dgvParlamentarios.MultiSelect = false;
            this.dgvParlamentarios.Name = "dgvParlamentarios";
            this.dgvParlamentarios.ReadOnly = true;
            this.dgvParlamentarios.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvParlamentarios.Size = new System.Drawing.Size(687, 178);
            this.dgvParlamentarios.TabIndex = 0;
            this.dgvParlamentarios.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvParlamentarios_CellContentClick);
            this.dgvParlamentarios.SelectionChanged += new System.EventHandler(this.dgvParlamentarios_SelectionChanged);
            // 
            // usuario
            // 
            this.usuario.Enabled = false;
            this.usuario.Location = new System.Drawing.Point(67, 67);
            this.usuario.MaxLength = 5;
            this.usuario.Name = "usuario";
            this.usuario.Size = new System.Drawing.Size(100, 20);
            this.usuario.TabIndex = 2;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(12, 70);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(46, 13);
            this.label2.TabIndex = 4;
            this.label2.Text = "Usuario:";
            this.label2.Click += new System.EventHandler(this.label2_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(12, 96);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(37, 13);
            this.label3.TabIndex = 6;
            this.label3.Text = "Clave:";
            // 
            // clave
            // 
            this.clave.Enabled = false;
            this.clave.Location = new System.Drawing.Point(67, 93);
            this.clave.MaxLength = 5;
            this.clave.Name = "clave";
            this.clave.Size = new System.Drawing.Size(99, 20);
            this.clave.TabIndex = 3;
            this.clave.UseSystemPasswordChar = true;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(12, 41);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(47, 13);
            this.label4.TabIndex = 8;
            this.label4.Text = "Nombre:";
            // 
            // nombre
            // 
            this.nombre.Enabled = false;
            this.nombre.Location = new System.Drawing.Point(67, 38);
            this.nombre.MaxLength = 50;
            this.nombre.Name = "nombre";
            this.nombre.Size = new System.Drawing.Size(258, 20);
            this.nombre.TabIndex = 1;
            // 
            // nuevoParlamentario
            // 
            this.nuevoParlamentario.BackColor = System.Drawing.SystemColors.Highlight;
            this.nuevoParlamentario.Location = new System.Drawing.Point(67, 138);
            this.nuevoParlamentario.Name = "nuevoParlamentario";
            this.nuevoParlamentario.Size = new System.Drawing.Size(75, 23);
            this.nuevoParlamentario.TabIndex = 4;
            this.nuevoParlamentario.Text = "Nuevo";
            this.nuevoParlamentario.UseVisualStyleBackColor = false;
            this.nuevoParlamentario.Click += new System.EventHandler(this.nuevoParlamentario_Click);
            // 
            // modificarParlamentario
            // 
            this.modificarParlamentario.BackColor = System.Drawing.Color.Yellow;
            this.modificarParlamentario.Location = new System.Drawing.Point(148, 138);
            this.modificarParlamentario.Name = "modificarParlamentario";
            this.modificarParlamentario.Size = new System.Drawing.Size(75, 23);
            this.modificarParlamentario.TabIndex = 9;
            this.modificarParlamentario.Text = "Editar";
            this.modificarParlamentario.UseVisualStyleBackColor = false;
            this.modificarParlamentario.Click += new System.EventHandler(this.modificarParlamentario_Click);
            // 
            // eliminarParlamentario
            // 
            this.eliminarParlamentario.BackColor = System.Drawing.Color.Red;
            this.eliminarParlamentario.Location = new System.Drawing.Point(229, 138);
            this.eliminarParlamentario.Name = "eliminarParlamentario";
            this.eliminarParlamentario.Size = new System.Drawing.Size(75, 23);
            this.eliminarParlamentario.TabIndex = 10;
            this.eliminarParlamentario.Text = "Eliminar";
            this.eliminarParlamentario.UseVisualStyleBackColor = false;
            this.eliminarParlamentario.Click += new System.EventHandler(this.eliminarParlamentario_Click);
            // 
            // grabarParlamentario
            // 
            this.grabarParlamentario.BackColor = System.Drawing.Color.Green;
            this.grabarParlamentario.Location = new System.Drawing.Point(107, 167);
            this.grabarParlamentario.Name = "grabarParlamentario";
            this.grabarParlamentario.Size = new System.Drawing.Size(75, 23);
            this.grabarParlamentario.TabIndex = 11;
            this.grabarParlamentario.Text = "Grabar";
            this.grabarParlamentario.UseVisualStyleBackColor = false;
            this.grabarParlamentario.Visible = false;
            this.grabarParlamentario.Click += new System.EventHandler(this.grabarParlamentario_Click);
            // 
            // cancelarParlamentario
            // 
            this.cancelarParlamentario.BackColor = System.Drawing.Color.Red;
            this.cancelarParlamentario.Location = new System.Drawing.Point(188, 167);
            this.cancelarParlamentario.Name = "cancelarParlamentario";
            this.cancelarParlamentario.Size = new System.Drawing.Size(75, 23);
            this.cancelarParlamentario.TabIndex = 12;
            this.cancelarParlamentario.Text = "Cancelar";
            this.cancelarParlamentario.UseVisualStyleBackColor = false;
            this.cancelarParlamentario.Visible = false;
            this.cancelarParlamentario.Click += new System.EventHandler(this.cancelarParlamentario_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.ForeColor = System.Drawing.SystemColors.HotTrack;
            this.label1.Location = new System.Drawing.Point(15, 12);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(76, 13);
            this.label1.TabIndex = 13;
            this.label1.Text = "Parlamentarios";
            this.label1.Click += new System.EventHandler(this.label1_Click_1);
            // 
            // dgvAsesores
            // 
            this.dgvAsesores.AllowUserToAddRows = false;
            this.dgvAsesores.AllowUserToDeleteRows = false;
            this.dgvAsesores.AllowUserToOrderColumns = true;
            this.dgvAsesores.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvAsesores.EditMode = System.Windows.Forms.DataGridViewEditMode.EditProgrammatically;
            this.dgvAsesores.Location = new System.Drawing.Point(351, 260);
            this.dgvAsesores.MultiSelect = false;
            this.dgvAsesores.Name = "dgvAsesores";
            this.dgvAsesores.ReadOnly = true;
            this.dgvAsesores.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvAsesores.Size = new System.Drawing.Size(687, 178);
            this.dgvAsesores.TabIndex = 14;
            this.dgvAsesores.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvAsesores_CellContentClick);
            this.dgvAsesores.SelectionChanged += new System.EventHandler(this.dgvAsesores_SelectionChanged);
            // 
            // nombreAsesor
            // 
            this.nombreAsesor.Enabled = false;
            this.nombreAsesor.Location = new System.Drawing.Point(67, 293);
            this.nombreAsesor.MaxLength = 50;
            this.nombreAsesor.Name = "nombreAsesor";
            this.nombreAsesor.Size = new System.Drawing.Size(258, 20);
            this.nombreAsesor.TabIndex = 15;
            // 
            // claveAsesor
            // 
            this.claveAsesor.Enabled = false;
            this.claveAsesor.Location = new System.Drawing.Point(67, 348);
            this.claveAsesor.MaxLength = 5;
            this.claveAsesor.Name = "claveAsesor";
            this.claveAsesor.Size = new System.Drawing.Size(99, 20);
            this.claveAsesor.TabIndex = 17;
            this.claveAsesor.UseSystemPasswordChar = true;
            // 
            // usuarioAsesor
            // 
            this.usuarioAsesor.Enabled = false;
            this.usuarioAsesor.Location = new System.Drawing.Point(67, 322);
            this.usuarioAsesor.MaxLength = 5;
            this.usuarioAsesor.Name = "usuarioAsesor";
            this.usuarioAsesor.Size = new System.Drawing.Size(100, 20);
            this.usuarioAsesor.TabIndex = 16;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(11, 296);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(47, 13);
            this.label5.TabIndex = 20;
            this.label5.Text = "Nombre:";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(11, 351);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(37, 13);
            this.label6.TabIndex = 19;
            this.label6.Text = "Clave:";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(11, 325);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(46, 13);
            this.label7.TabIndex = 18;
            this.label7.Text = "Usuario:";
            // 
            // cancelarAsesor
            // 
            this.cancelarAsesor.BackColor = System.Drawing.Color.Red;
            this.cancelarAsesor.Location = new System.Drawing.Point(188, 417);
            this.cancelarAsesor.Name = "cancelarAsesor";
            this.cancelarAsesor.Size = new System.Drawing.Size(75, 23);
            this.cancelarAsesor.TabIndex = 25;
            this.cancelarAsesor.Text = "Cancelar";
            this.cancelarAsesor.UseVisualStyleBackColor = false;
            this.cancelarAsesor.Visible = false;
            this.cancelarAsesor.Click += new System.EventHandler(this.cancelarAsesor_Click);
            // 
            // grabarAsesor
            // 
            this.grabarAsesor.BackColor = System.Drawing.Color.Green;
            this.grabarAsesor.Location = new System.Drawing.Point(107, 417);
            this.grabarAsesor.Name = "grabarAsesor";
            this.grabarAsesor.Size = new System.Drawing.Size(75, 23);
            this.grabarAsesor.TabIndex = 24;
            this.grabarAsesor.Text = "Grabar";
            this.grabarAsesor.UseVisualStyleBackColor = false;
            this.grabarAsesor.Visible = false;
            this.grabarAsesor.Click += new System.EventHandler(this.grabarAsesor_Click);
            // 
            // eliminarAsesor
            // 
            this.eliminarAsesor.BackColor = System.Drawing.Color.Red;
            this.eliminarAsesor.Location = new System.Drawing.Point(229, 388);
            this.eliminarAsesor.Name = "eliminarAsesor";
            this.eliminarAsesor.Size = new System.Drawing.Size(75, 23);
            this.eliminarAsesor.TabIndex = 23;
            this.eliminarAsesor.Text = "Eliminar";
            this.eliminarAsesor.UseVisualStyleBackColor = false;
            this.eliminarAsesor.Click += new System.EventHandler(this.eliminarAsesor_Click);
            // 
            // editarAsesor
            // 
            this.editarAsesor.BackColor = System.Drawing.Color.Yellow;
            this.editarAsesor.Location = new System.Drawing.Point(148, 388);
            this.editarAsesor.Name = "editarAsesor";
            this.editarAsesor.Size = new System.Drawing.Size(75, 23);
            this.editarAsesor.TabIndex = 22;
            this.editarAsesor.Text = "Editar";
            this.editarAsesor.UseVisualStyleBackColor = false;
            this.editarAsesor.Click += new System.EventHandler(this.editarAsesor_Click);
            // 
            // nuevoAsesor
            // 
            this.nuevoAsesor.BackColor = System.Drawing.SystemColors.Highlight;
            this.nuevoAsesor.Location = new System.Drawing.Point(67, 388);
            this.nuevoAsesor.Name = "nuevoAsesor";
            this.nuevoAsesor.Size = new System.Drawing.Size(75, 23);
            this.nuevoAsesor.TabIndex = 21;
            this.nuevoAsesor.Text = "Nuevo";
            this.nuevoAsesor.UseVisualStyleBackColor = false;
            this.nuevoAsesor.Click += new System.EventHandler(this.nuevoAsesor_Click);
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.ForeColor = System.Drawing.SystemColors.HotTrack;
            this.label8.Location = new System.Drawing.Point(15, 247);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(50, 13);
            this.label8.TabIndex = 26;
            this.label8.Text = "Asesores";
            // 
            // UsuariosFrm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1059, 450);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.cancelarAsesor);
            this.Controls.Add(this.grabarAsesor);
            this.Controls.Add(this.eliminarAsesor);
            this.Controls.Add(this.editarAsesor);
            this.Controls.Add(this.nuevoAsesor);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.nombreAsesor);
            this.Controls.Add(this.claveAsesor);
            this.Controls.Add(this.usuarioAsesor);
            this.Controls.Add(this.dgvAsesores);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.cancelarParlamentario);
            this.Controls.Add(this.grabarParlamentario);
            this.Controls.Add(this.eliminarParlamentario);
            this.Controls.Add(this.modificarParlamentario);
            this.Controls.Add(this.nuevoParlamentario);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.nombre);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.clave);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.usuario);
            this.Controls.Add(this.dgvParlamentarios);
            this.Name = "UsuariosFrm";
            this.Text = "Usuarios";
            this.Load += new System.EventHandler(this.UsuariosFrm_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataSet1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvParlamentarios)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvAsesores)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Data.DataSet dataSet1;
        private System.Windows.Forms.DataGridView dgvParlamentarios;
        private System.Windows.Forms.TextBox usuario;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox clave;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox nombre;
        private System.Windows.Forms.Button nuevoParlamentario;
        private System.Windows.Forms.Button modificarParlamentario;
        private System.Windows.Forms.Button eliminarParlamentario;
        private System.Windows.Forms.Button grabarParlamentario;
        private System.Windows.Forms.Button cancelarParlamentario;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.DataGridView dgvAsesores;
        private System.Windows.Forms.TextBox nombreAsesor;
        private System.Windows.Forms.TextBox claveAsesor;
        private System.Windows.Forms.TextBox usuarioAsesor;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Button cancelarAsesor;
        private System.Windows.Forms.Button grabarAsesor;
        private System.Windows.Forms.Button eliminarAsesor;
        private System.Windows.Forms.Button editarAsesor;
        private System.Windows.Forms.Button nuevoAsesor;
        private System.Windows.Forms.Label label8;
    }
}