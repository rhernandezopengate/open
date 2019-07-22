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
        public frmOrdenes()
        {
            InitializeComponent();
        }

        private void FrmOrdenes_Load(object sender, EventArgs e)
        {
            // TODO: esta línea de código carga datos en la tabla 'dB_A3F19C_OGDataSet.ordenes' Puede moverla o quitarla según sea necesario.
            this.dataTable1TableAdapter.Fill(this.dB_A3F19C_OGDataSet.DataTable1);
        }

        private void TxtBusqueda_KeyUp(object sender, KeyEventArgs e)
        {
            //CargarGrid();
        }

        private void TxtBusqueda_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
