using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using WFAHomeDelivery.Entities;
using WFAHomeDelivery.Controllers;

namespace WFAHomeDelivery.Formularios
{
    public partial class frmSKU : Form
    {        
        SkusController ctrl;
        public frmSKU()
        {
            InitializeComponent();
        }

        private void FrmSKU_Load(object sender, EventArgs e)
        {
            lblId.Visible = false;
            rbNo.Checked = true;
            CargarGrid();
        }

        public void CargarGrid()
        {
            dgvSKUS.AutoGenerateColumns = false;
            ctrl = new SkusController();
            if (this.txtBusqueda.Text.Equals(string.Empty))
            {
                dgvSKUS.DataSource = ctrl.listBySKU(string.Empty);
            }
            else
            {
                dgvSKUS.DataSource = ctrl.listBySKU(this.txtBusqueda.Text);
            }            
        }

        private void BtnAgregar_Click(object sender, EventArgs e)
        {
            ctrl = new SkusController();
            skus skus = new skus();
            skus.Sku = this.txtSKU.Text;
            skus.Descripcion = this.txtDescripcion.Text;
            skus.uom = this.txtUOM.Text;
            skus.codigobarras = this.txtCodigoBarras.Text;
            skus.codigobarras = rbSi.Checked ? "SI" : "NO";

            if (ctrl.ConsultaBySku(this.txtSKU.Text) == null)
            {
                if (this.txtSKU.Text.Equals(string.Empty))
                {
                    MessageBox.Show("Debe Agregar Un SKU", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
                else if (this.txtDescripcion.Text.Equals(string.Empty))
                {
                    MessageBox.Show("Debe Agregar Una Descripcion", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
                else if (this.txtUOM.Text.Equals(string.Empty))
                {
                    MessageBox.Show("Debe Agregar Una UOM", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
                else
                {
                    if (ctrl.CreateSku(skus))
                    {
                        CargarGrid();
                        MessageBox.Show("Se ha creado el registro correctamente", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    }
                    else
                    {
                        MessageBox.Show("Ha ocurrido un error", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                }
            }
            else
            {
                MessageBox.Show("El SKU debe ser unico", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }                   
        }

        private void DgvSKUS_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            int id = int.Parse(dgvSKUS.Rows[e.RowIndex].Cells[0].Value.ToString());
            skus skus = ctrl.ConsultaById(id);
            if (skus != null)
            {
                this.txtSKU.Text = skus.Sku;
                this.txtDescripcion.Text = skus.Descripcion;
                this.txtUOM.Text = skus.uom;
                this.lblId.Text = skus.id.ToString();

                if (skus.codigobidimensional.Equals("SI"))
                {
                    rbSi.Checked = true;
                    rbNo.Checked = false;
                }
                else
                {
                    rbSi.Checked = false;
                    rbNo.Checked = true;
                }
            }
        }

        private void BtnEditar_Click(object sender, EventArgs e)
        {
            try
            {
                if (lblId.Text.Equals(string.Empty))
                {
                    MessageBox.Show("Selleccione un elemento para editar", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
                else
                {
                    skus skus = new skus();
                    skus.id = int.Parse(lblId.Text);
                    skus.Sku = this.txtSKU.Text;
                    skus.Descripcion = this.txtDescripcion.Text;
                    skus.uom = this.txtUOM.Text;
                    skus.codigobarras = this.txtCodigoBarras.Text;
                    skus.codigobidimensional = rbSi.Checked ? "SI" : "NO";

                    if (ctrl.EditarSKU(skus))
                    {
                        CargarGrid();
                        MessageBox.Show("Se ha editado el registro correctamente", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    }
                    else
                    {
                        MessageBox.Show("Ha ocurrido un error", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                }                
            }
            catch (Exception)
            {
                MessageBox.Show("Ha ocurrido un error", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }            
        }

        private void BtnLimpiar_Click(object sender, EventArgs e)
        {
            this.txtSKU.Text = "";
            this.txtDescripcion.Text = "";
            this.txtUOM.Text = "";
            this.txtCodigoBarras.Text = "";
            this.lblId.Text = "";
            rbSi.Checked = false;
            rbNo.Checked = true;
        }

        private void TxtBusqueda_KeyUp(object sender, KeyEventArgs e)
        {
            CargarGrid();
        }
    }
}
