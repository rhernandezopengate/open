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
    public partial class frmInventarios : Form
    {
        public frmInventarios()
        {
            InitializeComponent();
        }

        private void FrmInventarios_Load(object sender, EventArgs e)
        {
            MessageBox.Show("Hola Mundo");
        }

        private void TextBox1_KeyPress(object sender, KeyPressEventArgs e)
        {
            MessageBox.Show(this.textBox1.Text);
        }        
    }
}
