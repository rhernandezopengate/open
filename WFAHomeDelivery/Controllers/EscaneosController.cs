using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using WFAHomeDelivery.Entities;

namespace WFAHomeDelivery.Controllers
{
    public class EscaneosController
    {
        DB_A3F19C_OGEntities db = new DB_A3F19C_OGEntities();
        public List<detordenproductoshd> ListaDetallesByOrden(string orden)
        {
            try
            {
                List<detordenproductoshd> lista = new List<detordenproductoshd>();
                ordenes ordenes = db.ordenes.Where(x => x.Orden.Contains(orden)).FirstOrDefault();

                foreach (var item in db.detordenproductoshd.Where(x => x.Ordenes_Id == ordenes.id).ToList())
                {
                    detordenproductoshd detordenproductoshd = new detordenproductoshd();
                    detordenproductoshd.SKU = item.skus.Sku;
                    detordenproductoshd.cantidad = item.cantidad;
                    detordenproductoshd.CantidadSKUS = 0;

                    lista.Add(detordenproductoshd);
                }

                return lista;
            }
            catch (Exception)
            {
                return null;
            }
        }

        public int? CantidadTotalArticulos(string orden)
        {
            try
            {
                int? cantidad = db.detordenproductoshd.Where(x => x.ordenes.Orden.Contains(orden)).Sum(x => x.cantidad);
                int? positivo = cantidad * -1;

                return positivo;
            }
            catch (Exception)
            {
                return 0;
            }
        }

        public bool CantidadByArticulo(string orden, string sku, List<detordenproductoshd> lista)
        {            
            int? positivo = 0;
            
            try
            {
                int? cantidad = db.detordenproductoshd.Where(x => x.ordenes.Orden.Contains(orden) && x.skus.Sku.Contains(sku)).Sum(x => x.cantidad);
                positivo = cantidad * -1;

                int contadorArticulos = lista.Where(x => x.SKU == sku).Sum(x => x.CantidadSKUS);

                if (contadorArticulos > positivo)
                {
                    return false;
                }
                else
                {
                    return true;
                }                
            }
            catch (Exception _ex)
            {
                Console.WriteLine(_ex.Message.ToString());
                return false;
            }            
        }

        public bool ValidarSKU(string _orden, string _sku)
        {
            try
            {
                var sku = db.detordenproductoshd.Where(x => x.skus.Sku.Contains(_sku) && x.ordenes.Orden.Contains(_orden)).FirstOrDefault();
                if (sku != null)
                {
                    return true;
                }
                else
                {
                    return false;
                }
            }
            catch (Exception)
            {
                return false;
            }
        }

        public bool CerrarOrden(string[] arreglo)
        {
            try
            {
                for (int i = 0; i < arreglo.Count(); i++)
                {
                    string a = arreglo[i].ToString();
                }

                return true;
            }
            catch (Exception)
            {
                return false;
            }
        }

        public bool IsQTYManual(string sku)
        {
            try
            {
                skus query = db.skus.Where(x => x.Sku.Contains(sku)).FirstOrDefault();

                if (query.qtymanual.Equals("SI"))
                {
                    return true;
                }
                else
                {
                    return false;
                }
            }
            catch (Exception)
            {
                return false;
            }
        }

        public bool IsQRCode(string sku)
        {
            try
            {
                skus query = db.skus.Where(x => x.Sku.Contains(sku)).FirstOrDefault();

                if (query.codigobidimensional.Equals("SI"))
                {
                    return true;
                }
                else
                {
                    return false;
                }
            }
            catch (Exception)
            {
                return false;
            }
        }

        public int? CantidadManualByArticulo(string orden, string sku)
        {
            try
            {
                int? cantidad = db.detordenproductoshd.Where(x => x.ordenes.Orden.Contains(orden) && x.skus.Sku.Contains(sku)).Sum(x => x.cantidad);
                int? positivo = cantidad * -1;
                                
                return positivo;
            }
            catch (Exception)
            {
                return 0;
            }
        }

        public bool ValidarQR(string qr, string sku, List<detordenproductoshd> list)
        {
            try
            {
                var query = list.Where(x => x.codigoqr == qr && x.SKU == sku).Sum(x => x.CantidadSKUS);

                if (query > 0)
                {
                    return true;
                }
                else
                {
                    return false;
                }                
            }
            catch (Exception)
            {
                return false;
            }
        }
    }
}
