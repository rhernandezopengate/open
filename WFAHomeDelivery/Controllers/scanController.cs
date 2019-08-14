using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using WFAHomeDelivery.Entities;

namespace WFAHomeDelivery.Controllers
{
    public class scanController
    {
        DB_A3F19C_OGEntities db = new DB_A3F19C_OGEntities();

        public bool ExisteOrden(string orden)
        {
            try
            {
                var ordenTemp = db.ordenes.Where(x => x.Orden.Contains(orden)).FirstOrDefault();

                if (ordenTemp != null)
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

        public bool OrdenCerrada(string orden)
        {
            try
            {
                int ordenTemp = db.ordenes.Where(x => x.Orden.Contains(orden)).FirstOrDefault().StatusOrdenImpresa_Id;

                if (ordenTemp == 1)
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

        public int IdOrdenByOrden(string orden)
        {
            return db.ordenes.Where(x => x.Orden.Equals(orden)).FirstOrDefault().id;
        }

        public bool ExisteSKU(string producto)
        {
            try
            {
                var sku = db.skus.Where(x=> x.Sku.Equals(producto)).FirstOrDefault();

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

        public bool SKUPerteneceOrden(string orden, string producto)
        {
            try
            {
                var respuesta = db.detordenproductoshd.Where(x => x.ordenes.Orden.Equals(orden) && x.skus.Sku.Equals(producto)).FirstOrDefault();

                if (respuesta != null)
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

        public bool IsQRCode(string producto)
        {
            try
            {
                string respuesta = db.skus.Where(x => x.Sku.Equals(producto)).FirstOrDefault().codigobidimensional;

                if (respuesta.Equals("SI"))
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

        public bool IsQTYManual(string producto)
        {
            try
            {
                string respuesta = db.skus.Where(x => x.Sku.Equals(producto)).FirstOrDefault().qtymanual;

                if (respuesta.Equals("SI"))
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

        public bool IsKit(string producto)
        {
            try
            {
                string respuesta = db.skus.Where(x => x.Sku.Equals(producto)).FirstOrDefault().kit;

                if (respuesta.Equals("SI"))
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

        public bool CantidadKitCorrecta(string producto, List<detordenproductoshd> lista)
        {
            try
            {
                List<detkitskus> listaTemp = db.detkitskus.Where(x => x.kit.descripcion.Equals(producto)).ToList();
                int contador = 0;

                foreach (var item in listaTemp)
                {
                    int cantidadBD = (int)lista.Where(x => x.SKU.Equals(item.skus.Sku)).FirstOrDefault().cantidad * -1;
                    int cantidadEscaneados = (int)lista.Where(x => x.SKU.Equals(item.skus.Sku)).FirstOrDefault().CantidadEscaneos;
                    int cantidadAgregar = cantidadEscaneados + (int)item.Cantidad;

                    if (cantidadAgregar > cantidadBD)
                    {
                        contador++;
                    }
                }

                if (contador == 0)
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

        public List<detordenproductoshd> DetalleOrden(string orden)
        {
            try
            {
                List<detordenproductoshd> listaTemp = new List<detordenproductoshd>();
                var detallesOrden = db.detordenproductoshd.Where(x => x.ordenes.Orden.Equals(orden)).ToList();

                foreach (var item in detallesOrden)
                {
                    detordenproductoshd detordenproductoshd = new detordenproductoshd();
                    detordenproductoshd.SKU = item.skus.Sku;
                    detordenproductoshd.cantidad = item.cantidad;
                    detordenproductoshd.CantidadEscaneos = 0;                    

                    listaTemp.Add(detordenproductoshd);
                }

                return listaTemp;
            }
            catch (Exception)
            {
                return null;
            }
        }

        public List<detkitskus> ListaKit(string producto)
        {
            return db.detkitskus.Where(x => x.kit.descripcion.Equals(producto)).ToList();
        }

        public bool ExisteGuia(string guia)
        {
            try
            {
                var validarguia = db.guias.Where(x => x.Guia.Equals(guia)).FirstOrDefault();

                if (validarguia != null)
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

        public bool GuiaOrden(string orden, string guia)
        {
            try
            {
                var validarguia = db.guias.Where(x => x.ordenes.Orden.Equals(orden) && x.Guia.Equals(guia)).FirstOrDefault();

                if (validarguia != null)
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
                return true;
            }
        }

        public async Task<bool> CerrarOrden(string orden, string picker)
        {
            ordenes ordenes = db.ordenes.Where(x => x.Orden.Equals(orden)).FirstOrDefault();
            ordenes.StatusOrdenImpresa_Id = 3;
            ordenes.Picker = picker;

            await db.SaveChangesAsync();
            return true;
        }

        public async Task<bool> CerrarOrdenBackOrden(string orden, string picker)
        {
            ordenes ordenes = db.ordenes.Where(x => x.Orden.Equals(orden)).FirstOrDefault();
            ordenes.StatusOrdenImpresa_Id = 4;
            ordenes.Picker = picker;

            await db.SaveChangesAsync();
            return true;
        }

        public async Task<bool> CerrarOrdenSinGuia(string orden, string picker)
        {
            ordenes ordenes = db.ordenes.Where(x => x.Orden.Equals(orden)).FirstOrDefault();
            ordenes.StatusOrdenImpresa_Id = 2;
            ordenes.Picker = picker;

            await db.SaveChangesAsync();
            return true;
        }

        public async Task<bool> AgregarAuditor(string orden, string auditor)
        {
            detusuariosordenes detusuariosordenes = new detusuariosordenes();
            detusuariosordenes.Ordenes_Id = db.ordenes.Where(x => x.Orden == orden).FirstOrDefault().id;
            detusuariosordenes.Usuarios_Id = db.usuarios.Where(x => x.nombre.Equals(auditor)).FirstOrDefault().id;
            db.detusuariosordenes.Add(detusuariosordenes);        

            await db.SaveChangesAsync();
            return true;
        }

        public async Task<bool> CapturaQR(List<codigoqrordenes> ListaQR)
        {
            if (ListaQR.Count > 0)
            {
                foreach (var item in ListaQR)
                {
                    codigoqrordenes codigoqrordenes = new codigoqrordenes();
                    codigoqrordenes.CodigoQR = item.CodigoQR;
                    codigoqrordenes.Ordenes_Id = item.Ordenes_Id;

                    db.codigoqrordenes.Add(codigoqrordenes);                    
                }

                await db.SaveChangesAsync();
            }
            return true;
        }

        public async Task<bool> CapturaErrores(List<erroresordenes> ListaErrores)
        {
            if (ListaErrores.Count > 0)
            {
                foreach (var item in ListaErrores)
                {
                    erroresordenes erroresordenes = new erroresordenes();
                    erroresordenes.TipoError_Id = item.TipoError_Id;
                    erroresordenes.Ordenes_Id = item.Ordenes_Id;

                    db.erroresordenes.Add(erroresordenes);                    
                }

                await db.SaveChangesAsync();
            }
            return true;
        }
    }
}
