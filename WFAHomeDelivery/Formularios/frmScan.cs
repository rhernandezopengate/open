using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Media;
using System.Windows.Forms;
using WFAHomeDelivery.Controllers;
using WFAHomeDelivery.Entities;

namespace WFAHomeDelivery.Formularios
{
    public partial class frmScan : Form
    {
        scanController ctrlScan;
        List<detordenproductoshd> ListaInicial;
        List<codigoqrordenes> ListaQR;
        List<erroresordenes> ListaErrores;
        
        public frmScan(string nombre)
        {
            InitializeComponent();
            lblAuditor.Text = nombre;
            this.txtOrden.Focus();
        }

        public List<string> ListaPicker()
        {
            List<string> lista = new List<string>();

            string pck2 = "GENOVEVA";
            lista.Add(pck2);

            string pck3 = "LETICIA";
            lista.Add(pck3);

            return lista;
        }

        private void TxtOrden_KeyPress(object sender, KeyPressEventArgs e)
        {
            if ((int)e.KeyChar == (int)Keys.Enter)
            {                
                string orden = this.txtOrden.Text;
                string picker;
                ctrlScan = new scanController();
                if (ctrlScan.ExisteOrden(orden))
                {
                    if (ctrlScan.OrdenCerrada(orden))
                    {
                        do
                        {
                            picker = Microsoft.VisualBasic.Interaction.InputBox("ESCANEAR CODIGO DE PICKER QUE SURTIO LA ORDEN", "CODIGO DE PICKER");

                            string pickerValidacion = ListaPicker().Where(x => x.Equals(picker)).FirstOrDefault();

                            if (pickerValidacion == null)
                            {
                                picker = string.Empty;
                            }

                        } while (picker.Equals(string.Empty));

                        ListaInicial = ctrlScan.DetalleOrden(orden);
                        ListaQR = new List<codigoqrordenes>();
                        ListaErrores = new List<erroresordenes>();
                        lblOrdenId.Text = ctrlScan.IdOrdenByOrden(orden).ToString();
                        lblPicker.Text = picker;
                        this.txtOrden.Enabled = false;
                        this.dataGridView1.AutoGenerateColumns = false;
                        this.dataGridView1.DataSource = ListaInicial;
                    }
                    else
                    {
                        SystemSounds.Asterisk.Play();

                        MessageBox.Show("ORDEN CERRADA");
                        
                        this.txtOrden.Text = "";
                        this.txtOrden.Focus();
                    }                    
                }
                else
                {
                    SystemSounds.Asterisk.Play();
                    MessageBox.Show("ORDEN NO EXISTE");
                    this.txtOrden.Text = "";
                    this.txtOrden.Focus();
                }

                e.Handled = true;
            }
        }

        private async void TxtProducto_KeyPress(object sender, KeyPressEventArgs e)
        {
            if ((int)e.KeyChar == (int)Keys.Enter)
            {
                ctrlScan = new scanController();
                string producto = this.txtProducto.Text;
                string orden = this.txtOrden.Text;
                if (ctrlScan.ExisteSKU(producto))
                {
                    if (ctrlScan.IsKit(producto))
                    {
                        if (ctrlScan.CantidadKitCorrecta(producto, ListaInicial))
                        {
                            foreach (var item in ctrlScan.ListaKit(producto))
                            {
                                int cantidadEscaneados = (int)ListaInicial.Where(x => x.SKU.Equals(item.skus.Sku)).FirstOrDefault().CantidadEscaneos;
                                int cantidadAgregar = cantidadEscaneados + (int)item.Cantidad;

                                var cantidadEscaneado = ListaInicial.Where(x => x.SKU.Equals(item.skus.Sku)).FirstOrDefault();
                                cantidadEscaneado.CantidadEscaneos = cantidadAgregar;
                            }
                        }
                        else
                        {
                            SystemSounds.Asterisk.Play();
                            MessageBox.Show("LA CANTIDAD DEL PAH O KIT ES MAYOR A LA SOLICITADA EN LA ORDEN");
                            ErrorSobrante();
                        }

                        this.dataGridView1.DataSource = null;
                        this.dataGridView1.DataSource = ListaInicial;                        
                        this.txtProducto.Text = "";
                        this.txtProducto.Focus();

                        if (ListaInicial.Sum(x => x.CantidadEscaneos) == ListaInicial.Sum(x => x.cantidad))
                        {
                            //Cerrar Orden
                            string guia;

                            SystemSounds.Beep.Play();

                            do
                            {
                                guia = Microsoft.VisualBasic.Interaction.InputBox("ESCANEAR GUIA");

                                if (guia.Equals("NA"))
                                {
                                    SystemSounds.Asterisk.Play();
                                    MessageBox.Show("ESTA ORDEN NO SE PUEDE CERRAR, SIN LA GUIA CORRECTA, DEBE LIMPIAR LA ORDEN Y COMENZAR NUEVAMENTE.");
                                    break;
                                }

                                if (ctrlScan.ExisteGuia(guia))
                                {
                                    if (ctrlScan.GuiaOrden(orden, guia))
                                    {
                                        //Cerrar Orden                                            
                                        bool qr = await ctrlScan.CapturaQR(ListaQR);
                                        bool error = await ctrlScan.CapturaErrores(ListaErrores);
                                        bool agregarauditor = await ctrlScan.AgregarAuditor(orden, this.lblAuditor.Text);
                                        bool cerrarorden = await ctrlScan.CerrarOrden(orden, this.lblPicker.Text);
                                        Limpiar();
                                    }
                                    else
                                    {
                                        SystemSounds.Asterisk.Play();
                                        MessageBox.Show("GUIA NO PERTENECE A LA ORDEN");
                                        guia = string.Empty;
                                    }
                                }
                                else
                                {
                                    SystemSounds.Asterisk.Play();
                                    MessageBox.Show("GUIA NO EXISTE");
                                    guia = string.Empty;
                                }
                            }
                            while (guia.Equals(string.Empty));
                        }
                    }
                    else
                    {
                        if (ctrlScan.SKUPerteneceOrden(orden, producto))
                        {
                            if (ctrlScan.IsQRCode(producto))
                            {
                                int cantidadBD = (int)ListaInicial.Where(x => x.SKU.Equals(producto)).FirstOrDefault().cantidad;
                                int cantidadEscaneados = (int)ListaInicial.Where(x => x.SKU.Equals(producto)).FirstOrDefault().CantidadEscaneos;
                                int cantidadAgregar = cantidadEscaneados + 1;

                                if (cantidadAgregar <= cantidadBD)
                                {
                                    string qrcode;
                                    SystemSounds.Beep.Play();
                                    do
                                    {
                                        qrcode = Microsoft.VisualBasic.Interaction.InputBox("ESCANEAR CODIGO QR");

                                        if (qrcode != string.Empty)
                                        {
                                            var validarqr = ListaQR.Where(x => x.CodigoQR.Equals(qrcode)).FirstOrDefault();

                                            if (validarqr == null)
                                            {
                                                var cantidadEscaneado = ListaInicial.Where(x => x.SKU.Equals(producto)).FirstOrDefault();
                                                cantidadEscaneado.CantidadEscaneos = cantidadAgregar;

                                                codigoqrordenes codigoqrordenes = new codigoqrordenes();
                                                codigoqrordenes.CodigoQR = qrcode;
                                                codigoqrordenes.Ordenes_Id = int.Parse(lblOrdenId.Text);
                                                ListaQR.Add(codigoqrordenes);
                                            }
                                            else
                                            {
                                                SystemSounds.Asterisk.Play();
                                                MessageBox.Show("EL CODIGO QR NO PUEDE ESTAR REPETIDO");
                                            }
                                        }
                                        else
                                        {
                                            SystemSounds.Asterisk.Play();
                                            MessageBox.Show("EL CODIGO QR NO PUEDE ESTAR VACIO");
                                        }
                                    } while (qrcode.Equals(string.Empty));
                                }
                                else
                                {
                                    SystemSounds.Asterisk.Play();
                                    MessageBox.Show("YA SE HA COMPLETADO EL ESCANEO DE ESTE SKU");
                                    ErrorSobrante();
                                }
                            }
                            else if (ctrlScan.IsQTYManual(producto))
                            {
                                string qty;
                                do
                                {
                                    qty = Microsoft.VisualBasic.Interaction.InputBox("CAPTURE LA CANTIDAD DE SKUS");
                                    int cantidadBD = (int)ListaInicial.Where(x => x.SKU.Equals(producto)).FirstOrDefault().cantidad;
                                    int cantidadEscaneados = (int)ListaInicial.Where(x => x.SKU.Equals(producto)).FirstOrDefault().CantidadEscaneos;
                                    int cantidadAgregar = cantidadEscaneados + int.Parse(qty);

                                    if (cantidadAgregar <= cantidadBD)
                                    {
                                        var cantidadEscaneado = ListaInicial.Where(x => x.SKU.Equals(producto)).FirstOrDefault();
                                        cantidadEscaneado.CantidadEscaneos = cantidadAgregar;
                                    }
                                    else
                                    {
                                        SystemSounds.Asterisk.Play();
                                        MessageBox.Show("LA CANTIDAD DE SKUS NO PUEDE SER MAYOR A LA DE LA ORDEN");
                                        ErrorSobrante();
                                    }
                                } while (qty.Equals(string.Empty));
                            }
                            else
                            {
                                int cantidadBD = (int)ListaInicial.Where(x => x.SKU.Equals(producto)).FirstOrDefault().cantidad;
                                int cantidadEscaneados = (int)ListaInicial.Where(x => x.SKU.Equals(producto)).FirstOrDefault().CantidadEscaneos;
                                int cantidadAgregar = cantidadEscaneados + 1;

                                if (cantidadAgregar <= cantidadBD)
                                {
                                    var cantidadEscaneado = ListaInicial.Where(x => x.SKU.Equals(producto)).FirstOrDefault();
                                    cantidadEscaneado.CantidadEscaneos = cantidadAgregar;
                                }
                                else
                                {
                                    SystemSounds.Asterisk.Play();
                                    MessageBox.Show("YA SE HA COMPLETADO EL ESCANEO DE ESTE SKU");
                                    ErrorSobrante();
                                }
                            }

                            this.dataGridView1.DataSource = null;
                            this.dataGridView1.DataSource = ListaInicial;
                            this.txtProducto.Text = "";
                            this.txtProducto.Focus();

                            if (ListaInicial.Sum(x => x.CantidadEscaneos) == ListaInicial.Sum(x => x.cantidad))
                            {
                                string guia;
                                SystemSounds.Beep.Play();
                                do
                                {
                                    guia = Microsoft.VisualBasic.Interaction.InputBox("ESCANEAR GUIA");

                                    if (guia.Equals("NA"))
                                    {
                                        SystemSounds.Asterisk.Play();
                                        MessageBox.Show("ESTA ORDEN NO SE PUEDE CERRAR, SIN LA GUIA CORRECTA, DEBE LIMPIAR LA ORDEN Y COMENZAR NUEVAMENTE.");
                                        break;
                                    }

                                    if (ctrlScan.ExisteGuia(guia))
                                    {
                                        if (ctrlScan.GuiaOrden(orden, guia))
                                        {
                                            //Cerrar Orden                                            
                                            bool qr = await ctrlScan.CapturaQR(ListaQR);
                                            bool error = await ctrlScan.CapturaErrores(ListaErrores);
                                            bool agregarauditor = await ctrlScan.AgregarAuditor(orden, this.lblAuditor.Text);
                                            bool cerrarorden = await ctrlScan.CerrarOrden(orden, this.lblPicker.Text);

                                            Limpiar();
                                        }
                                        else
                                        {
                                            SystemSounds.Asterisk.Play();
                                            MessageBox.Show("GUIA NO PERTENECE A LA ORDEN");                                            
                                            guia = string.Empty;
                                        }                                        
                                    }
                                    else
                                    {
                                        SystemSounds.Asterisk.Play();
                                        MessageBox.Show("GUIA NO EXISTE");
                                        guia = string.Empty;
                                    }
                                }
                                while (guia.Equals(string.Empty));                        
                            }
                        }
                        else
                        {
                            SystemSounds.Asterisk.Play();
                            MessageBox.Show("ESTE SKU NO PERTENECE A LA ORDEN");
                            ErrorSkuIncorrecto();
                            this.txtProducto.Text = "";
                            this.txtProducto.Focus();
                        }
                    }                    
                }
                else
                {
                    SystemSounds.Asterisk.Play();
                    MessageBox.Show("ESTE SKU NO EXISTE");
                    this.txtProducto.Text = "";
                    this.txtProducto.Focus();
                }

                e.Handled = true;
            }            
        }

        public void Limpiar()
        {
            ListaErrores = null;
            ListaQR = null;
            ListaInicial = null;
            dataGridView1.DataSource = null;
            this.lblOrdenId.Text = "";
            this.lblPicker.Text = "";            
            this.txtProducto.Text = "";
            this.txtOrden.Text = "";
            this.txtOrden.Enabled = true;
            this.txtOrden.Focus();
        }

        public void ErrorFaltante()
        {
            erroresordenes erroresordenes = new erroresordenes();
            erroresordenes.TipoError_Id = 3;
            erroresordenes.Ordenes_Id = int.Parse(lblOrdenId.Text);
            ListaErrores.Add(erroresordenes);
        }

        public void ErrorSobrante()
        {
            erroresordenes erroresordenes = new erroresordenes();
            erroresordenes.TipoError_Id = 2;
            erroresordenes.Ordenes_Id = int.Parse(lblOrdenId.Text);
            ListaErrores.Add(erroresordenes);
        }

        public void ErrorSkuIncorrecto()
        {
            erroresordenes erroresordenes = new erroresordenes();
            erroresordenes.TipoError_Id = 1;
            erroresordenes.Ordenes_Id = int.Parse(lblOrdenId.Text);
            ListaErrores.Add(erroresordenes);
        }

        private void BtnLimpiar_Click(object sender, EventArgs e)
        {
            Limpiar();
        }

        private void BtnFaltantes_Click(object sender, EventArgs e)
        {
            if (this.txtOrden.Text.Equals(string.Empty))
            {
                SystemSounds.Asterisk.Play();
                MessageBox.Show("DEBE TENER UNA ORDEN ABIERTA");
            }
            else
            {
                SystemSounds.Beep.Play();
                MessageBox.Show("FALTANTE AGREGADO CORRECTAMENTE");
                ErrorFaltante();
            }            
        }

        private async void BtnBackOrder_Click(object sender, EventArgs e)
        {
            if (this.txtOrden.Text.Equals(string.Empty))
            {
                SystemSounds.Asterisk.Play();
                MessageBox.Show("DEBE TENER ABIERTA UNA ORDEN");
            }
            else
            {
                bool cerrarorden = await ctrlScan.CerrarOrdenBackOrden(this.txtOrden.Text, this.lblPicker.Text);

                bool qr = await ctrlScan.CapturaQR(ListaQR);

                bool error = await ctrlScan.CapturaErrores(ListaErrores);

                bool agregarauditor = await ctrlScan.AgregarAuditor(this.txtOrden.Text, this.lblAuditor.Text);

                SystemSounds.Beep.Play();

                MessageBox.Show("ORDEN CERRADA CORRECTAMENTE");

                Limpiar();
            }            
        }
    }
}

