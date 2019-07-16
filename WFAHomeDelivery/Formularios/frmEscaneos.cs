using System;
using System.Collections;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Media;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using WFAHomeDelivery.Controllers;
using WFAHomeDelivery.Entities;
using Microsoft.VisualBasic;

namespace WFAHomeDelivery
{
    public partial class frmEscaneos : Form
    {
        EscaneosController ctrlEscaneos;
        int index = 0;
        List<detordenproductoshd> lista;

        public frmEscaneos()
        {
            InitializeComponent();            
        }

        private void FrmEscaneos_Load(object sender, EventArgs e)
        {
            
        }

        public void CargarGrid(string orden)
        {
            ctrlEscaneos = new EscaneosController();
            dgvEscaneos.AutoGenerateColumns = false;

            if (ctrlEscaneos.ListaDetallesByOrden(orden) != null)
            {
                dgvEscaneos.DataSource = ctrlEscaneos.ListaDetallesByOrden(orden);
            }
            else
            {
                MessageBox.Show("ESTE TICKET NO EXISTE");
            }            
        }  

        public void CargarArreglo()
        {            
            lista = new List<detordenproductoshd>();            
        }

        private void TxtTicket_KeyPress(object sender, KeyPressEventArgs e)
        {
            if ((int)e.KeyChar == (int)Keys.Enter)
            {
                CargarGrid(this.txtTicket.Text);
                CargarArreglo();
                this.txtProducto.Focus();
            }
        }

        private void TxtProducto_KeyPress(object sender, KeyPressEventArgs e)
        {            
            if ((int)e.KeyChar == (int)Keys.Enter)
            {
                ValidarLista();                
                e.Handled = true;
                this.txtProducto.Text = "";
                this.txtProducto.Focus();
            }               
        }      

        public void ValidarLista()
        {
            //Validar que la caja de producto no este vacia
            if (txtProducto.Text != string.Empty)
            {
                detordenproductoshd detalle = new detordenproductoshd();

                //Validando SKU
                if (ctrlEscaneos.ValidarSKU(this.txtTicket.Text, this.txtProducto.Text))
                {
                    index++;

                    detalle.Index = index;
                    detalle.SKU = txtProducto.Text;
                    detalle.CantidadSKUS = 1;
                    detalle.codigoqr = "NA";
                    lista.Add(detalle);

                    if (ValidarByCantidadTotal())
                    {
                        if (ValidarByCantidadArticulo())
                        {
                            if (ctrlEscaneos.IsQTYManual(this.txtProducto.Text))
                            {                          
                                if (ValidarByCantidadArticulo())
                                {
                                    int cantidad = int.Parse(Microsoft.VisualBasic.Interaction.InputBox("AGREGAR CANTIDAD MANUAL", "TECLEAR LA CANTIDAD DE PRODUCTOS A INGRESAR"));
                                    if (cantidad > ctrlEscaneos.CantidadManualByArticulo(this.txtTicket.Text, this.txtProducto.Text))
                                    {
                                        SystemSounds.Asterisk.Play();
                                        MessageBox.Show("ERROR EN CANTIDAD MANUAL. LA CANTIDAD NO PUEDE SER MAYOR A LADE LA ORDEN, ESCANEA NUEVAMENTE EL SKU Y TECLEA UNA CANTIDAD VALIDA");
                                        index--;
                                        lista.RemoveAt(index);
                                    }
                                    else if (cantidad < ctrlEscaneos.CantidadManualByArticulo(this.txtTicket.Text, this.txtProducto.Text))
                                    {
                                        SystemSounds.Asterisk.Play();
                                        MessageBox.Show("ERROR EN CANTIDAD MANUAL. LA CANTIDAD NO PUEDE SER MENOR A LADE LA ORDEN, ESCANEA NUEVAMENTE EL SKU Y TECLEA UNA CANTIDAD VALIDA");
                                        index--;
                                        lista.RemoveAt(index);
                                    }
                                    else
                                    {
                                        detordenproductoshd detalleTemp = lista.Where(x => x.SKU == this.txtProducto.Text).FirstOrDefault();
                                        detalle.CantidadSKUS = cantidad;
                                    }
                                }
                            }

                            if (ctrlEscaneos.IsQRCode(this.txtProducto.Text))
                            {
                                string qr = Microsoft.VisualBasic.Interaction.InputBox("AGREGAR CODIGO QR", "ESCANEAR CODIGO QR DEL PRODUCTO");

                                if (qr.Equals(string.Empty))
                                {
                                    SystemSounds.Asterisk.Play();
                                    MessageBox.Show("ERROR DE CODIGO QR. EL CODIGO QR NO PUEDE ESTAR VACIO, ESCANEA NUEVAMENTE EL SKU Y SU CODIGO QR");
                                    index--;
                                    lista.RemoveAt(index);
                                }
                                else
                                {
                                    if (ctrlEscaneos.ValidarQR(qr, this.txtProducto.Text, lista))
                                    {
                                        index--;
                                        lista.RemoveAt(index);
                                        SystemSounds.Asterisk.Play();
                                        MessageBox.Show("ERROR DE CODIGO QR. ESTE CODIGO QR YA EXISTE, ESCANEA NUEVAMENTE EL SKU Y SU CODIGO QR");
                                    }
                                    else
                                    {
                                        detalle.codigoqr = qr;
                                        var detalleTemp = lista.Where(x => x.Index == index).FirstOrDefault();
                                        if (detalleTemp != null)
                                        {
                                            detalle.codigoqr = detalleTemp.codigoqr;
                                        }                                        
                                    }
                                }
                            }
                        }
                    }                    
                }
                else
                {
                    //Se tiene que configurar en Windows el Sonido de Asterisk
                    SystemSounds.Asterisk.Play();
                    MessageBox.Show("ESTE SKU NO PERTENECE A LA ORDEN");
                }
            }            
        }

        public bool ValidarByCantidadArticulo()
        {
            if (ctrlEscaneos.CantidadByArticulo(this.txtTicket.Text, this.txtProducto.Text, lista))
            {
                return true;
            }
            else
            {
                index--;
                lista.RemoveAt(index);
                SystemSounds.Asterisk.Play();
                MessageBox.Show("YA SE HA COMPLETADO ES ESCANEO DE ESTE SKU");
                return false;
            }            
        }

        public bool ValidarByCantidadTotal()
        {
            if (lista.Count <= ctrlEscaneos.CantidadTotalArticulos(this.txtTicket.Text))
            {
                return true;
            }
            else
            {
                index--;
                lista.RemoveAt(index);
                SystemSounds.Asterisk.Play();
                MessageBox.Show("LA ORDEN YA SE ENCUENTRA COMPLETA");

                return false;
            }
        }        

        private void BtnLimpiar_Click(object sender, EventArgs e)
        {
            SystemSounds.Beep.Play();
        }

        
    }
}
