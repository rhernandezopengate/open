using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using WFAHomeDelivery.Formularios;

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
            frmEscaneos newMDIChild = new frmEscaneos("Hola");
            // Set the parent form of the child window.  
            newMDIChild.MdiParent = this;
            // Display the new form.  
            newMDIChild.Show();
        }

        private void SalirToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }       

        private void CargaOracleToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmCargaOracle newMDIChild = new frmCargaOracle();
            // Set the parent form of the child window.  
            newMDIChild.MdiParent = this;
            // Display the new form.  
            newMDIChild.Show();
        }

        private void ProductosToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmSKU newMDIChild = new frmSKU();
            // Set the parent form of the child window.  
            newMDIChild.MdiParent = this;
            // Display the new form.  
            newMDIChild.Show();
        }

        private void OrdenesToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmScan newMDIChild = new frmScan();
            // Set the parent form of the child window.  
            newMDIChild.MdiParent = this;
            // Display the new form.  
            newMDIChild.Show();
        }

        private void CargarGuiasToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmCargaGuias newMDIChild = new frmCargaGuias();
            // Set the parent form of the child window.  
            newMDIChild.MdiParent = this;
            // Display the new form.  
            newMDIChild.Show();
        }
    }
}
