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
        List<detordenproductoshd> ListaGrid;        

        public frmEscaneos(string nombre)
        {
            InitializeComponent();
            lblAuditor.Text = nombre;
            this.txtTicket.Focus();            
        }

        private void FrmEscaneos_Load(object sender, EventArgs e)
        {
                      
        }

        public void CargarLista(string orden)
        {
            ctrlEscaneos = new EscaneosController();
            dgvEscaneos.AutoGenerateColumns = false;
            ListaGrid = new List<detordenproductoshd>();

            if (ctrlEscaneos.ListaDetallesByOrden(orden) != null)
            {                
                ListaGrid = ctrlEscaneos.ListaDetallesByOrden(orden);
                CargarGrid();
                string picker;

                do
                {
                    picker = Microsoft.VisualBasic.Interaction.InputBox("ESCANEAR CODIGO DE PICKER QUE SURTIO LA ORDEN", "CODIGO DE PICKER");
                } while (picker.Equals(string.Empty));
                
                lblPicker.Text = picker;
            }
            else
            {
                MessageBox.Show("ESTE TICKET NO EXISTE");
            }            
        }

        public void CargarGrid()
        {
            dgvEscaneos.AutoGenerateColumns = false;
            dgvEscaneos.DataSource = ListaGrid;            
        }

        public void CargarArreglo()
        {            
            lista = new List<detordenproductoshd>();            
        }

        private void TxtTicket_KeyPress(object sender, KeyPressEventArgs e)
        {
            if ((int)e.KeyChar == (int)Keys.Enter)
            {
                ctrlEscaneos = new EscaneosController();
                if (ctrlEscaneos.ValidarOrdenCerrada(this.txtTicket.Text))
                {
                    CargarLista(this.txtTicket.Text);
                    CargarArreglo();
                    this.txtTicket.Enabled = false;
                    this.txtProducto.Focus();
                }
                else
                {
                    SystemSounds.Asterisk.Play();
                    MessageBox.Show("Esta Orden Esta Cerrada");
                    this.txtTicket.Text = "";
                    this.txtTicket.Focus();
                }

                e.Handled = true;
            }
        }

        private void TxtProducto_KeyPress(object sender, KeyPressEventArgs e)
        {            
            if ((int)e.KeyChar == (int)Keys.Enter)
            {
                ValidarLista();                
                e.Handled = true;                
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
                                    SystemSounds.Beep.Play();
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
                                SystemSounds.Beep.Play();
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

                            if (CerrarAutomaticamente())
                            {
                                SystemSounds.Beep.Play();                                
                            }
                            else
                            {                                
                                int cantidad = lista.Where(x => x.SKU.Contains(this.txtProducto.Text)).Sum(x => x.CantidadSKUS);
                                var detalleTemp = ListaGrid.Where(x => x.SKU.Contains(this.txtProducto.Text.ToUpper())).FirstOrDefault();
                                detalleTemp.CantidadSKUS = cantidad;

                                dgvEscaneos.DataSource = null;
                                dgvEscaneos.DataSource = ListaGrid;
                                this.txtProducto.Text = "";
                                this.txtProducto.Focus();                                   
                            }
                        }
                        else
                        {
                            this.txtProducto.Text = "";
                            this.txtProducto.Focus();
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
            int cantidadLista = lista.Sum(x => x.CantidadSKUS);
            if (cantidadLista <= ctrlEscaneos.CantidadTotalArticulos(this.txtTicket.Text))
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

        public bool CerrarAutomaticamente()
        {
            int cantidadLista = lista.Sum(x => x.CantidadSKUS);
            if (cantidadLista == ctrlEscaneos.CantidadTotalArticulos(this.txtTicket.Text))
            {
                ctrlEscaneos = new EscaneosController();

                string guia;
                int? status = 0;
                
                do
                {
                    guia = Microsoft.VisualBasic.Interaction.InputBox("GUIA DE LA ORDEN", "ESCANEAR GUIA DE DHL");
                                        
                    if (guia != string.Empty)
                    {
                        if (guia.Equals("NA"))
                        {
                            SystemSounds.Asterisk.Play();
                            MessageBox.Show("ESTA ORDEN NO SE PUEDE CERRAR, SIN LA GUIA CORRECTA, DEBE LIMPIAR LA ORDEN Y COMENZAR NUEVAMENTE.");
                            break;
                        }

                        int statusGuia = ctrlEscaneos.ValidarGuia(this.txtTicket.Text, guia);
                        status = statusGuia;
                        if (statusGuia == 0)
                        {
                            SystemSounds.Asterisk.Play();
                            MessageBox.Show("ESTA GUIA NO EXISTE");                            
                        }
                        else if (statusGuia == 1)
                        {                            
                            if (ctrlEscaneos.CerrarOrden(this.txtTicket.Text, this.lblPicker.Text))
                            {
                                ctrlEscaneos.AgregarAuditorOrden(this.txtTicket.Text, this.lblAuditor.Text);
                                ctrlEscaneos.AgregarQrOrden(this.txtTicket.Text, lista);

                                lista = null;
                                index = 0;
                                this.txtProducto.Text = "";
                                this.txtTicket.Text = "";
                                this.lblPicker.Text = "";
                                dgvEscaneos.DataSource = null;
                                this.txtTicket.Enabled = true;
                                this.txtTicket.Focus();                               
                            }                            
                        }
                        else
                        {
                            SystemSounds.Asterisk.Play();
                            MessageBox.Show("ESTA GUIA NO PERTENECE A LA ORDEN");                            
                        }
                    }                   

                } while (status != 1);

                if (status == 1)
                {
                    return true;
                }
                else
                {
                    return false;
                }
            }
            else
            {
                return false;
            }
        }

        private void BtnLimpiar_Click(object sender, EventArgs e)
        {
            SystemSounds.Beep.Play();
            lista = null;
            index = 0;
            this.txtProducto.Text = "";
            this.lblPicker.Text = "";
            this.txtTicket.Text = "";
            this.txtTicket.Enabled = true;
            dgvEscaneos.DataSource = null;
            this.txtTicket.Focus();
        }        
    }
}