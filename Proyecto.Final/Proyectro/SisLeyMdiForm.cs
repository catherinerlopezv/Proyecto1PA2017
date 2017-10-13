using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Proyectro
{
    public partial class SisLeyMdiForm : Form
    {

        private SisLey sistema;
        
        public SisLeyMdiForm()
        {
            InitializeComponent();
        }

        
        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void SisLey_Load(object sender, EventArgs e)
        {
            sistema = SisLey.getInstance();
            sistema.initializeData();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            UsuariosFrm newMDIChild = new UsuariosFrm();
            // Set the Parent Form of the Child window.  
            newMDIChild.MdiParent = this;
            // Display the new form.  
            newMDIChild.Show();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            LeyesFrm newMDIChild = new LeyesFrm();
            // Set the Parent Form of the Child window.  
            newMDIChild.MdiParent = this;
            // Display the new form.  
            newMDIChild.Show();
        }

        public void DeshabilitarOpciones()
        {
            OpcionUsuarios.Enabled = false;
            OpcionLeyes.Enabled = false;
            OpcionPrestamo.Enabled = false;
            
        }

        public void HabilitarAdministrador()
        {
            OpcionUsuarios.Enabled = true;
            OpcionLeyes.Enabled = true;
        }

        public void HabilitarPrestamo()
        {
            OpcionPrestamo.Enabled = true;
            
        }

        private void doLogin_Click(object sender, EventArgs e)
        {
            LoginFrm newMDIChild = new LoginFrm();
            // Set the Parent Form of the Child window.  
            newMDIChild.MdiParent = this;
            // Display the new form.  
            newMDIChild.Show();
        }

        private void doLogout_Click(object sender, EventArgs e)
        {
            DeshabilitarOpciones();
            doLogin.Enabled = true;
            doLogout.Enabled = false;
            SisLey sistema = SisLey.getInstance();
            sistema.UsuarioAsesor = null;
            sistema.UsuarioParlamentario = null;
            usuarioLabel.Text = "";
            grupoLabel.Text = "";
            tipoLabel.Text = "";
        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void label5_Click(object sender, EventArgs e)
        {

        }

        private void OpcionPrestamo_Click(object sender, EventArgs e)
        {
            PrestamoFrm newMDIChild = new PrestamoFrm();
            // Set the Parent Form of the Child window.  
            newMDIChild.MdiParent = this;
            // Display the new form.  
            newMDIChild.Show();
        }
    }
}
