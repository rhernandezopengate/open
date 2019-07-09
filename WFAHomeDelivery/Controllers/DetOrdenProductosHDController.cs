using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using WFAHomeDelivery.Entities;

namespace WFAHomeDelivery.Controllers
{
    public class DetOrdenProductosHDController
    {
        DB_A3F19C_OGEntities db = new DB_A3F19C_OGEntities();
        public bool AgregarDetalles(List<detordenproductoshd> listOracle)
        {
            try
            {
                int contador = 0;
                foreach (var item in listOracle)
                {
                    detordenproductoshd detordenproductoshd = new detordenproductoshd();
                    contador++;
                    detordenproductoshd.Ordenes_Id = item.Ordenes_Id;
                    detordenproductoshd.Skus_Id = item.Skus_Id;
                    detordenproductoshd.cantidad = item.cantidad;
                    db.detordenproductoshd.Add(detordenproductoshd);
                    db.SaveChanges();
                }
                return true;
            }
            catch (Exception _ex)
            {
                Console.WriteLine(_ex.Message.ToString());
                return false;
            }
        }
    }
}
