using System;
using System.Collections;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using WFAHomeDelivery.Controllers;
using WFAHomeDelivery.Entities;

namespace WFAHomeDelivery
{
    public partial class frmEscaneos : Form
    {
        EscaneosController ctrlEscaneos;
        int index = 0;
        string[] arreglo;

        public frmEscaneos()
        {
            InitializeComponent();
        }

        private void FrmEscaneos_Load(object sender, EventArgs e)
        {
            
        }

        private void TxtTicket_TextChanged(object sender, EventArgs e)
        {
            CargarGrid(this.txtTicket.Text);
            CargarArreglo();
        }

        public void CargarGrid(string orden)
        {
            ctrlEscaneos = new EscaneosController();
            dgvEscaneos.AutoGenerateColumns = false;
            dgvEscaneos.DataSource = ctrlEscaneos.ListaDetallesByOrden(orden);
        }

        public void CargarArreglo()
        {
            arreglo = new string[(int)ctrlEscaneos.CantidadTotalArticulos(this.txtTicket.Text)];
        }

        private void TxtProducto_TextChanged(object sender, EventArgs e)
        {
            int? cantidad = ctrlEscaneos.CantidadTotalArticulos(this.txtTicket.Text);
            //Valdiar Cantidad Total de Articulos de la Orden
            if (index < cantidad)
            {
                //Validar que el SKU pertenece a la orden
                if (ctrlEscaneos.ValidarSKU(this.txtTicket.Text, this.txtProducto.Text))
                {
                    arreglo[index] = txtProducto.Text.Trim();
                    //Validarque la cantidad del articulo escaneado sea menor a la cantidad de la orden
                    if (ctrlEscaneos.CantidadByArticulo(this.txtTicket.Text, this.txtProducto.Text, arreglo))
                    {                        
                        listBox1.Items.Add(arreglo[index].ToString());
                        index++;
                    }
                    else
                    {                        
                        //Si la cantidad de SKU es mayor o no pertenece a la orden se elimina del array
                        Array.Clear(arreglo, index, 1);
                        MessageBox.Show("LA CANTIDAD DE ESTE SKU ES MAYOR AL DE LA ORDEN");                        
                    }                    
                }
                else
                {                    
                    MessageBox.Show("ESTE SKU NO PERTENECE A LA ORDEN");
                }               
            }
            else
            {
                MessageBox.Show("YA SE HA COMPLETADO LA CANTIDAD DE SKUS");
            }      
        }

        private void Button1_Click(object sender, EventArgs e)
        {
            if (ctrlEscaneos.CerrarOrden(arreglo))
            {
                Array.Clear(arreglo, 0, arreglo.Length);
                index = 0;
                listBox1.Items.Clear();
                txtTicket.Text = "";
                txtProducto.Text = "";

                MessageBox.Show("ORDEN CERRADA CORRECTAMENTE");
            }
            else
            {
                MessageBox.Show("NO SE HA COMPLETADO EL ESCANEO");
            }           
        }
    }
}
