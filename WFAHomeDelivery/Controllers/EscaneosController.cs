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
                ordenes ordenes = db.ordenes.Where(x => x.Orden == orden).FirstOrDefault();

                foreach (var item in db.detordenproductoshd.Where(x => x.Ordenes_Id == ordenes.id).ToList())
                {
                    detordenproductoshd detordenproductoshd = new detordenproductoshd();
                    detordenproductoshd.SKU = item.skus.Sku;
                    detordenproductoshd.cantidad = item.cantidad;
                    lista.Add(detordenproductoshd);
                }

                return lista;
            }
            catch (Exception)
            {
                return null;
            }
        }

        public List<detordenproductoshd> ListaCantidadesOrdenes(string orden, string sku)
        {
            try
            {
                List<detordenproductoshd> lista = new List<detordenproductoshd>();

                var skuTemp = db.skus.Where(x => x.Sku.Contains(sku));

                if (skuTemp != null)
                {                    
                    foreach (var item in db.detordenproductoshd.Where(x => x.ordenes.Orden == orden && x.skus.Sku == sku).ToList())
                    {
                        detordenproductoshd detordenproductoshd = new detordenproductoshd();
                        detordenproductoshd.SKU = item.skus.Sku;                  
                        detordenproductoshd.cantidad = item.cantidad;
                                             
                        
                        lista.Add(detordenproductoshd);
                    }

                    if (lista.Count == 0)
                    {
                        return null;
                    }
                    else
                    {
                        return lista.OrderByDescending(x => x.SKU).ToList();
                    }                    
                }
                else
                {
                    return null;
                }                
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

        public bool CantidadByArticulo(string orden, string sku, string[] arreglo)
        {
            try
            {
                int? cantidad = db.detordenproductoshd.Where(x => x.ordenes.Orden.Contains(orden) && x.skus.Sku.Contains(sku) ).Sum(x => x.cantidad);
                int? positivo = cantidad * -1;

                foreach (var item in arreglo.GroupBy(x => x))
                {
                    if (item.Key != null)
                    {
                        if (item.Key.Equals(sku))
                        {
                            if (item.Count() > positivo)
                            {
                                return false;
                            }
                            else
                            {
                                return true;
                            }
                        }
                    }
                }

                return true;
            }
            catch (Exception)
            {
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

    }
}
