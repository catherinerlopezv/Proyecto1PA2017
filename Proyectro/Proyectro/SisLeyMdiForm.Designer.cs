namespace Proyectro
{
    partial class SisLeyMdiForm
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
            this.panel1 = new System.Windows.Forms.Panel();
            this.label1 = new System.Windows.Forms.Label();
            this.pnlMenu = new System.Windows.Forms.Panel();
            this.OpcionLeyes = new System.Windows.Forms.Button();
            this.OpcionUsuarios = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.doLogin = new System.Windows.Forms.Button();
            this.doLogout = new System.Windows.Forms.Button();
            this.OpcionDevolucion = new System.Windows.Forms.Button();
            this.OpcionPrestamo = new System.Windows.Forms.Button();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.usuarioLabel = new System.Windows.Forms.Label();
            this.grupoLabel = new System.Windows.Forms.Label();
            this.tipoLabel = new System.Windows.Forms.Label();
            this.panel1.SuspendLayout();
            this.pnlMenu.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.tipoLabel);
            this.panel1.Controls.Add(this.grupoLabel);
            this.panel1.Controls.Add(this.usuarioLabel);
            this.panel1.Controls.Add(this.label5);
            this.panel1.Controls.Add(this.label4);
            this.panel1.Controls.Add(this.doLogout);
            this.panel1.Controls.Add(this.doLogin);
            this.panel1.Controls.Add(this.label1);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1255, 45);
            this.panel1.TabIndex = 1;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.SystemColors.HotTrack;
            this.label1.Location = new System.Drawing.Point(89, 13);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(77, 25);
            this.label1.TabIndex = 0;
            this.label1.Text = "SisLey";
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // pnlMenu
            // 
            this.pnlMenu.Controls.Add(this.OpcionDevolucion);
            this.pnlMenu.Controls.Add(this.OpcionPrestamo);
            this.pnlMenu.Controls.Add(this.label3);
            this.pnlMenu.Controls.Add(this.OpcionLeyes);
            this.pnlMenu.Controls.Add(this.OpcionUsuarios);
            this.pnlMenu.Controls.Add(this.label2);
            this.pnlMenu.Dock = System.Windows.Forms.DockStyle.Left;
            this.pnlMenu.Location = new System.Drawing.Point(0, 45);
            this.pnlMenu.Name = "pnlMenu";
            this.pnlMenu.Size = new System.Drawing.Size(157, 518);
            this.pnlMenu.TabIndex = 2;
            // 
            // OpcionLeyes
            // 
            this.OpcionLeyes.Enabled = false;
            this.OpcionLeyes.Location = new System.Drawing.Point(12, 68);
            this.OpcionLeyes.Name = "OpcionLeyes";
            this.OpcionLeyes.Size = new System.Drawing.Size(109, 23);
            this.OpcionLeyes.TabIndex = 2;
            this.OpcionLeyes.Text = "Leyes";
            this.OpcionLeyes.UseVisualStyleBackColor = true;
            this.OpcionLeyes.Click += new System.EventHandler(this.button2_Click);
            // 
            // OpcionUsuarios
            // 
            this.OpcionUsuarios.Enabled = false;
            this.OpcionUsuarios.Location = new System.Drawing.Point(12, 41);
            this.OpcionUsuarios.Name = "OpcionUsuarios";
            this.OpcionUsuarios.Size = new System.Drawing.Size(109, 23);
            this.OpcionUsuarios.TabIndex = 1;
            this.OpcionUsuarios.Text = "Usuarios";
            this.OpcionUsuarios.UseVisualStyleBackColor = true;
            this.OpcionUsuarios.Click += new System.EventHandler(this.button1_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(3, 21);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(110, 16);
            this.label2.TabIndex = 0;
            this.label2.Text = "Administracion";
            this.label2.Click += new System.EventHandler(this.label2_Click);
            // 
            // doLogin
            // 
            this.doLogin.Location = new System.Drawing.Point(1092, 19);
            this.doLogin.Name = "doLogin";
            this.doLogin.Size = new System.Drawing.Size(75, 23);
            this.doLogin.TabIndex = 1;
            this.doLogin.Text = "Login";
            this.doLogin.UseVisualStyleBackColor = true;
            this.doLogin.Click += new System.EventHandler(this.doLogin_Click);
            // 
            // doLogout
            // 
            this.doLogout.Enabled = false;
            this.doLogout.Location = new System.Drawing.Point(1174, 18);
            this.doLogout.Name = "doLogout";
            this.doLogout.Size = new System.Drawing.Size(75, 23);
            this.doLogout.TabIndex = 2;
            this.doLogout.Text = "Logout";
            this.doLogout.UseVisualStyleBackColor = true;
            this.doLogout.Click += new System.EventHandler(this.doLogout_Click);
            // 
            // OpcionDevolucion
            // 
            this.OpcionDevolucion.Enabled = false;
            this.OpcionDevolucion.Location = new System.Drawing.Point(6, 154);
            this.OpcionDevolucion.Name = "OpcionDevolucion";
            this.OpcionDevolucion.Size = new System.Drawing.Size(109, 23);
            this.OpcionDevolucion.TabIndex = 5;
            this.OpcionDevolucion.Text = "Devolucion";
            this.OpcionDevolucion.UseVisualStyleBackColor = true;
            // 
            // OpcionPrestamo
            // 
            this.OpcionPrestamo.Enabled = false;
            this.OpcionPrestamo.Location = new System.Drawing.Point(6, 127);
            this.OpcionPrestamo.Name = "OpcionPrestamo";
            this.OpcionPrestamo.Size = new System.Drawing.Size(109, 23);
            this.OpcionPrestamo.TabIndex = 4;
            this.OpcionPrestamo.Text = "Prestamo";
            this.OpcionPrestamo.UseVisualStyleBackColor = true;
            this.OpcionPrestamo.Click += new System.EventHandler(this.OpcionPrestamo_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(-3, 107);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(78, 16);
            this.label3.TabIndex = 3;
            this.label3.Text = "Biblioteca";
            this.label3.Click += new System.EventHandler(this.label3_Click);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(811, 4);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(43, 13);
            this.label4.TabIndex = 3;
            this.label4.Text = "Usuario";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(950, 4);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(36, 13);
            this.label5.TabIndex = 4;
            this.label5.Text = "Grupo";
            this.label5.Click += new System.EventHandler(this.label5_Click);
            // 
            // usuarioLabel
            // 
            this.usuarioLabel.AutoSize = true;
            this.usuarioLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.usuarioLabel.ForeColor = System.Drawing.Color.Blue;
            this.usuarioLabel.Location = new System.Drawing.Point(814, 24);
            this.usuarioLabel.Name = "usuarioLabel";
            this.usuarioLabel.Size = new System.Drawing.Size(0, 20);
            this.usuarioLabel.TabIndex = 5;
            // 
            // grupoLabel
            // 
            this.grupoLabel.AutoSize = true;
            this.grupoLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.grupoLabel.ForeColor = System.Drawing.Color.Blue;
            this.grupoLabel.Location = new System.Drawing.Point(949, 25);
            this.grupoLabel.Name = "grupoLabel";
            this.grupoLabel.Size = new System.Drawing.Size(0, 20);
            this.grupoLabel.TabIndex = 6;
            // 
            // tipoLabel
            // 
            this.tipoLabel.AutoSize = true;
            this.tipoLabel.ForeColor = System.Drawing.Color.Green;
            this.tipoLabel.Location = new System.Drawing.Point(1015, 4);
            this.tipoLabel.Name = "tipoLabel";
            this.tipoLabel.Size = new System.Drawing.Size(69, 13);
            this.tipoLabel.TabIndex = 7;
            this.tipoLabel.Text = "administrador";
            // 
            // SisLeyMdiForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1255, 563);
            this.Controls.Add(this.pnlMenu);
            this.Controls.Add(this.panel1);
            this.IsMdiContainer = true;
            this.Name = "SisLeyMdiForm";
            this.Text = "SisLey";
            this.Load += new System.EventHandler(this.SisLey_Load);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.pnlMenu.ResumeLayout(false);
            this.pnlMenu.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Panel pnlMenu;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button OpcionUsuarios;
        private System.Windows.Forms.Button OpcionLeyes;
        private System.Windows.Forms.Button doLogin;
        private System.Windows.Forms.Button doLogout;
        private System.Windows.Forms.Button OpcionDevolucion;
        private System.Windows.Forms.Button OpcionPrestamo;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label grupoLabel;
        private System.Windows.Forms.Label usuarioLabel;
        private System.Windows.Forms.Label tipoLabel;
    }
}