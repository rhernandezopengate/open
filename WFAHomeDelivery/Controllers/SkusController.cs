using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using WFAHomeDelivery.Entities;

namespace WFAHomeDelivery.Controllers
{
    public class SkusController
    {
        DB_A3F19C_OGEntities db = new DB_A3F19C_OGEntities();

        public bool CreateSku(skus sku)
        {
            try
            {                
                db.skus.Add(sku);
                db.SaveChanges();
                return true;
            }
            catch (Exception _ex)
            {
                Console.WriteLine(_ex.Message.ToString());
                return false;
            }
        }

        public skus ConsultaById(int id)
        {
            try
            {
                skus skus = db.skus.Where(x => x.id == id).FirstOrDefault();
                return skus;
            }
            catch (Exception)
            {
                return null;
            }            
        }

        public skus ConsultaBySku(string sku)
        {
            try
            {
                skus skus = db.skus.Where(x => x.Sku == sku).FirstOrDefault();
                return skus;
            }
            catch (Exception)
            {
                return null;
            }
        }

        public bool EditarSKU(skus skus)
        {
            try
            {
                skus skuTemp = db.skus.Where(x => x.id == skus.id).FirstOrDefault();
                skuTemp.Sku = skus.Sku;
                skuTemp.Descripcion = skus.Descripcion;
                skuTemp.uom = skus.uom;
                skuTemp.codigobarras = skus.codigobarras;
                skuTemp.codigobidimensional = skus.codigobidimensional;
                db.SaveChanges();

                return true;
            }
            catch (Exception)
            {
                return false;
            }
        }

        public List<skus> lista()
        {
            List<skus> lista = new List<skus>();

            foreach (var item in db.skus.ToList())
            {
                skus skus = new skus();
                skus.id = item.id;
                skus.Sku = item.Sku;
                skus.Descripcion = item.Descripcion;
                skus.uom = item.uom;
                skus.codigobarras = item.codigobarras;
                skus.codigobidimensional = item.codigobidimensional;
                lista.Add(skus);
            }

            return lista.OrderByDescending(x => x.id).ToList();
        }

        public List<skus> listBySKU(string sku)
        {
            List<skus> lista = new List<skus>();

            foreach (var item in db.skus.Where(x => x.Sku.Contains(sku)).ToList())
            {
                skus skus = new skus();
                skus.id = item.id;
                skus.Sku = item.Sku;
                skus.Descripcion = item.Descripcion;
                skus.uom = item.uom;
                skus.codigobarras = item.codigobarras;
                skus.codigobidimensional = item.codigobidimensional;
                lista.Add(skus);
            }

            return lista.OrderByDescending(x => x.id).ToList();
        }

    }
}
