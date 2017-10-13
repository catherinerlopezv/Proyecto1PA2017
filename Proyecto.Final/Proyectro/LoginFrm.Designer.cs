namespace Proyectro
{
    partial class LoginFrm
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
            this.usuarioLogin = new System.Windows.Forms.TextBox();
            this.claveLogin = new System.Windows.Forms.TextBox();
            this.Clavelbl = new System.Windows.Forms.Label();
            this.button1 = new System.Windows.Forms.Button();
            this.label3 = new System.Windows.Forms.Label();
            this.errorLogin = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.SystemColors.MenuHighlight;
            this.label1.Location = new System.Drawing.Point(105, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(67, 24);
            this.label1.TabIndex = 0;
            this.label1.Text = "LOGIN";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(49, 70);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(46, 13);
            this.label2.TabIndex = 1;
            this.label2.Text = "Usuario:";
            // 
            // usuarioLogin
            // 
            this.usuarioLogin.Location = new System.Drawing.Point(109, 67);
            this.usuarioLogin.Name = "usuarioLogin";
            this.usuarioLogin.Size = new System.Drawing.Size(100, 20);
            this.usuarioLogin.TabIndex = 2;
            // 
            // claveLogin
            // 
            this.claveLogin.Location = new System.Drawing.Point(109, 104);
            this.claveLogin.Name = "claveLogin";
            this.claveLogin.Size = new System.Drawing.Size(100, 20);
            this.claveLogin.TabIndex = 4;
            // 
            // Clavelbl
            // 
            this.Clavelbl.AutoSize = true;
            this.Clavelbl.Location = new System.Drawing.Point(49, 107);
            this.Clavelbl.Name = "Clavelbl";
            this.Clavelbl.Size = new System.Drawing.Size(37, 13);
            this.Clavelbl.TabIndex = 3;
            this.Clavelbl.Text = "Clave:";
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(88, 147);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(75, 23);
            this.button1.TabIndex = 5;
            this.button1.Text = "Ingresar";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.ForeColor = System.Drawing.Color.DarkGreen;
            this.label3.Location = new System.Drawing.Point(129, 240);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(143, 13);
            this.label3.TabIndex = 6;
            this.label3.Text = "Administrador: admin / admin";
            // 
            // errorLogin
            // 
            this.errorLogin.AutoSize = true;
            this.errorLogin.ForeColor = System.Drawing.Color.Red;
            this.errorLogin.Location = new System.Drawing.Point(20, 183);
            this.errorLogin.Name = "errorLogin";
            this.errorLogin.Size = new System.Drawing.Size(0, 13);
            this.errorLogin.TabIndex = 7;
            // 
            // LoginFrm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(284, 262);
            this.Controls.Add(this.errorLogin);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.claveLogin);
            this.Controls.Add(this.Clavelbl);
            this.Controls.Add(this.usuarioLogin);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "LoginFrm";
            this.Text = "Login";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox usuarioLogin;
        private System.Windows.Forms.TextBox claveLogin;
        private System.Windows.Forms.Label Clavelbl;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label errorLogin;
    }
}