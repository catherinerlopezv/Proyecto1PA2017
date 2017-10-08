namespace Proyectro
{
    partial class DocumentoFrm
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
            this.dgvLeyes = new System.Windows.Forms.DataGridView();
            ((System.ComponentModel.ISupportInitialize)(this.dgvLeyes)).BeginInit();
            this.SuspendLayout();
            // 
            // dgvLeyes
            // 
            this.dgvLeyes.AllowUserToAddRows = false;
            this.dgvLeyes.AllowUserToDeleteRows = false;
            this.dgvLeyes.AllowUserToOrderColumns = true;
            this.dgvLeyes.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvLeyes.EditMode = System.Windows.Forms.DataGridViewEditMode.EditProgrammatically;
            this.dgvLeyes.Location = new System.Drawing.Point(361, 3);
            this.dgvLeyes.MultiSelect = false;
            this.dgvLeyes.Name = "dgvLeyes";
            this.dgvLeyes.ReadOnly = true;
            this.dgvLeyes.Size = new System.Drawing.Size(687, 178);
            this.dgvLeyes.TabIndex = 1;
            // 
            // DocumentoFrm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1060, 411);
            this.Controls.Add(this.dgvLeyes);
            this.Name = "DocumentoFrm";
            this.Text = "DocumentoFrm";
            ((System.ComponentModel.ISupportInitialize)(this.dgvLeyes)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView dgvLeyes;
    }
}