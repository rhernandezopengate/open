using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WFAHomeDelivery
{
    public partial class frmMenu : Form
    {
        public frmMenu()
        {
            InitializeComponent();
        }

        private void EscaneosToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmEscaneos newMDIChild = new frmEscaneos();
            // Set the parent form of the child window.  
            newMDIChild.MdiParent = this;
            // Display the new form.  
            newMDIChild.Show();
        }

        private void SalirToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }
    }
}
