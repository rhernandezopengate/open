using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WFAHomeDelivery.Formularios
{
    public partial class frmScan : Form
    {
        public frmScan()
        {
            InitializeComponent();
        }

        private void TxtOrden_KeyPress(object sender, KeyPressEventArgs e)
        {
            if ((int)e.KeyChar == (int)Keys.Enter)
            {
                lblMostrar.Text = this.txtOrden.Text;
                e.Handled = true;
            }            
        }
    }
}
