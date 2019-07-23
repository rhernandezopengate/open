﻿using System;
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

        public bool CerrarOrden(string orden, string picker)
        {
            try
            {
                ordenes ordenes = db.ordenes.Where(x => x.Orden.Contains(orden)).FirstOrDefault();
                ordenes.StatusOrdenImpresa_Id = 3;
                ordenes.Picker = picker;

                db.SaveChanges();

                return true;
            }
            catch (Exception)
            {
                return false;
            }
        }

        public int ValidarGuia(string orden, string _guias)
        {
            try
            {
                var guias = db.guias.Where(x => x.Guia.Equals(_guias.Trim())).FirstOrDefault();

                if (guias == null)
                {
                    //La guia no existe
                    return 0;
                }
                else
                {
                    var ordenTemp = (from ordenes in db.ordenes                                    
                                    where ordenes.Orden.Equals(orden.Trim())
                                    select ordenes).FirstOrDefault();

                    if (ordenTemp != null)
                    {
                        if (ordenTemp.id == guias.Ordenes_Id)
                        {
                            //La guia existe y pertenece a la orden
                            return 1;
                        }
                        else
                        {
                            //La guia existe pero no pertenece a la orden
                            return 2;
                        }
                    }
                    else
                    {
                        return 2;
                    }                    
                }                
            }
            catch (Exception)
            {
                return 0;
            }           
        }

        public void AgregarAuditorOrden(string orden, string usuario)
        {
            try
            {                
                detusuariosordenes detusuariosordenes = new detusuariosordenes();

                detusuariosordenes.Ordenes_Id = db.ordenes.Where(x => x.Orden == orden).FirstOrDefault().id;
                detusuariosordenes.Usuarios_Id = db.usuarios.Where(x => x.nombre.Equals(usuario)).FirstOrDefault().id;

                db.detusuariosordenes.Add(detusuariosordenes);

                db.SaveChanges();
            }
            catch (Exception _ex)
            {
                Console.Write(_ex.Message);
            }
        }

        public void AgregarQrOrden(string orden, List<detordenproductoshd> list)
        {
            foreach (var item in list)
            {
                if (item.codigoqr != "NA")
                {
                    codigoqrordenes codigoqrordenes = new codigoqrordenes();
                    codigoqrordenes.CodigoQR = item.codigoqr;
                    codigoqrordenes.Ordenes_Id = db.ordenes.Where(x => x.Orden == orden).FirstOrDefault().id;

                    db.codigoqrordenes.Add(codigoqrordenes);
                    db.SaveChanges();
                }                
            }
        }

        public bool ValidarOrdenCerrada(string orden)
        {
            try
            {
                int status = db.ordenes.Where(x => x.Orden.Contains(orden)).FirstOrDefault().StatusOrdenImpresa_Id;
                if (status == 3)
                {
                    return false;
                }
                else
                {
                    return true;
                }
            }
            catch (Exception e)
            {
                Console.WriteLine(e.Message);
                return false;
            }
        }
    }
}
