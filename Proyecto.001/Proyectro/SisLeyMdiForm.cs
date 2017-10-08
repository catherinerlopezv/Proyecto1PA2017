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

        }

        private void button1_Click(object sender, EventArgs e)
        {
            UsuariosFrm newMDIChild = new UsuariosFrm();
            // Set the Parent Form of the Child window.  
            newMDIChild.MdiParent = this;
            // Display the new form.  
            newMDIChild.Show();
        }
    }
}
