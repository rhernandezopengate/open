using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using WFAHomeDelivery.Controllers;

namespace WFAHomeDelivery.Formularios
{
    public partial class frmOrdenes : Form
    {
        OrdenesController ctrlOrdenes;
        public frmOrdenes()
        {
            InitializeComponent();
        }

        private void FrmOrdenes_Load(object sender, EventArgs e)
        {
            CargarGrid();
        }

        public void CargarGrid()
        {
            dgvOrdenes.AutoGenerateColumns = false;
            ctrlOrdenes = new OrdenesController();
            if (this.txtBusqueda.Text.Equals(string.Empty))
            {
                dgvOrdenes.DataSource = ctrlOrdenes.listByOrden(string.Empty);
            }
            else
            {
                dgvOrdenes.DataSource = ctrlOrdenes.listByOrden(this.txtBusqueda.Text);
            }
        }

        private void TxtBusqueda_KeyUp(object sender, KeyEventArgs e)
        {
            CargarGrid();
        }
    }
}
