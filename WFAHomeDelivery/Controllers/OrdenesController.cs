using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using WFAHomeDelivery.Entities;
using System.Linq.Dynamic;

namespace WFAHomeDelivery.Controllers
{
    public class OrdenesController
    {
        DB_A3F19C_OGEntities db = new DB_A3F19C_OGEntities();
        public bool CargaOracle(List<ordenes> listaOracle)
        {
            try
            {                
                foreach (var item in listaOracle)
                {                    
                    if (db.ordenes.Where(x => x.Orden == item.Orden).FirstOrDefault() == null)
                    {
                        if (item.Orden != "")
                        {
                            ordenes ordenes = new ordenes();
                            ordenes.FechaAlta = item.FechaAlta;
                            ordenes.Orden = item.Orden;
                            ordenes.TxnDate = item.TxnDate;
                            ordenes.TxnNumber = item.TxnNumber;
                            ordenes.User = item.User;
                            ordenes.StatusOrdenImpresa_Id = 1;
                            db.ordenes.Add(ordenes);
                            db.SaveChanges();
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

        public int OrdenById(string orden)
        {
            return db.ordenes.Where(x => x.Orden == orden).FirstOrDefault().id;
        }

        public List<ordenes> listByOrden(string orden)
        {
            string query = "SELECT dbo.ordenes.id, dbo.ordenes.Orden, dbo.ordenes.TxnDate, dbo.ordenes.TxnNumber, dbo.ordenes.[User], dbo.ordenes.StatusOrdenImpresa_Id, dbo.ordenes.FechaAlta, dbo.ordenes.Picker " +
                           "FROM dbo.ordenes " +                           
                           "WHERE dbo.ordenes.Orden LIKE '%' + @Orden + '%'"; 

            var sqlQuery1 = db.ordenes.SqlQuery(query, new System.Data.SqlClient.SqlParameter("@Orden", orden)).ToList();

            List<ordenes> list = new List<ordenes>();      

            foreach (var item in sqlQuery1)
            {
                ordenes ordenesTemp = new ordenes();               
                
                ordenesTemp.Orden = item.Orden;
                ordenesTemp.TxnDate = item.TxnDate;
                ordenesTemp.TxnNumber = item.TxnNumber;
                ordenesTemp.User = item.User;
                ordenesTemp.Descripcion = item.statusordenimpresa.descripcion;

                list.Add(ordenesTemp);
            }
            return list;
        }
    }
}
