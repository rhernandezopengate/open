using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.OleDb;
using System.Data.SqlClient;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using WFAHomeDelivery.Controllers;
using WFAHomeDelivery.Entities;

namespace WFAHomeDelivery
{
    public partial class frmCargaOracle : Form
    {
        private string Excel03ConString = "Provider=Microsoft.Jet.OLEDB.4.0;Data Source={0};Extended Properties='Excel 8.0;HDR={1}'";
        private string Excel07ConString = "Provider=Microsoft.ACE.OLEDB.12.0;Data Source={0};Extended Properties='Excel 8.0;HDR={1}'";
        DataTable dtCharge;
        DB_A3F19C_OGEntities db = new DB_A3F19C_OGEntities();

        public frmCargaOracle()
        {
            InitializeComponent();
        }

        private void Button1_Click(object sender, EventArgs e)
        {
            openFileDialog1.ShowDialog();
        }

        private void OpenFileDialog1_FileOk(object sender, CancelEventArgs e)
        {
            string filePath = openFileDialog1.FileName;
            string extension = Path.GetExtension(filePath);
            string header = "YES";
            string conStr, sheetName;

            conStr = string.Empty;
            switch (extension)
            {

                case ".xls": //Excel 97-03
                    conStr = string.Format(Excel03ConString, filePath, header);
                    break;

                case ".xlsx": //Excel 07
                    conStr = string.Format(Excel07ConString, filePath, header);
                    break;
            }

            //Get the name of the First Sheet.
            using (OleDbConnection con = new OleDbConnection(conStr))
            {
                using (OleDbCommand cmd = new OleDbCommand())
                {
                    cmd.Connection = con;
                    con.Open();
                    DataTable dtExcelSchema = con.GetOleDbSchemaTable(OleDbSchemaGuid.Tables, null);
                    sheetName = dtExcelSchema.Rows[0]["TABLE_NAME"].ToString();
                    con.Close();
                }
            }

            //Read Data from the First Sheet.
            using (OleDbConnection con = new OleDbConnection(conStr))
            {
                using (OleDbCommand cmd = new OleDbCommand())
                {
                    using (OleDbDataAdapter oda = new OleDbDataAdapter())
                    {
                        DataTable dt = new DataTable();
                        cmd.CommandText = "SELECT * From [" + sheetName + "]";
                        cmd.Connection = con;
                        con.Open();
                        oda.SelectCommand = cmd;
                        oda.Fill(dt);
                        con.Close();

                        //Populate DataGridView.
                        dataGridView1.DataSource = dt;
                        dtCharge = dt;
                    }
                }
            }
        }

        public void AgregarOrdenes()
        {
            List<ordenes> listaValidacion = db.ordenes.ToList();
            DataTable dtOrden = new DataTable();

            //Fecha Alta
            dtOrden.Columns.Add(new DataColumn()
            {
                ColumnName = "FechaAlta",
                DataType = typeof(DateTime)
            });

            //Status Orden
            dtOrden.Columns.Add(new DataColumn()
            {
                ColumnName = "StatusOrdenImpresa_Id",
                DataType = typeof(int)
            });

            //3 Orden
            dtOrden.Columns.Add(new DataColumn()
            {
                ColumnName = "Orden",
                DataType = typeof(string)
            });

            //4 User
            dtOrden.Columns.Add(new DataColumn()
            {
                ColumnName = "User",
                DataType = typeof(string)
            });
            

            List<ordenes> lista = new List<ordenes>();

            foreach (DataRow row in dtCharge.Rows)
            {
                ordenes ordenes = new ordenes();
                ordenes.FechaAlta = DateTime.Now;
                ordenes.Orden = row[3].ToString();
                ordenes.User = row[4].ToString();
                ordenes.StatusOrdenImpresa_Id = 1;

                //ordenes.TxnDate = DateTime.Parse(row[0].ToString());
                //ordenes.TxnNumber = row[1].ToString();


                var orden = listaValidacion.Where(x => x.Orden.Contains(row[4].ToString())).FirstOrDefault();
                if (orden == null)
                {
                    lista.Add(ordenes);
                }                
            }

            if (lista.Count > 0)
            {
                var grouping = lista.GroupBy(x => x.Orden).ToList();

                foreach (var item in grouping)
                {
                    var orden = lista.Where(x => x.Orden == item.Key).FirstOrDefault();

                    if (orden != null)
                    {
                        dtOrden.Rows.Add(new object[] {
                            DateTime.Now,
                            orden.StatusOrdenImpresa_Id,
                            orden.Orden,
                            //orden.TxnDate,
                            //orden.TxnNumber,
                            orden.User
                            
                        });
                    }
                    else
                    {
                        Console.Write("La orden ya existe");
                    }
                }

                string connectionString = @"Data Source=SQL7001.site4now.net;Initial Catalog=DB_A3F19C_OG;User Id=DB_A3F19C_OG_admin;Password=xQ9znAhU;";

                using (SqlBulkCopy bulkCopy = new SqlBulkCopy(connectionString))
                {
                    bulkCopy.DestinationTableName = "dbo.ordenes";

                    bulkCopy.ColumnMappings.Add("FechaAlta", "FechaAlta");
                    bulkCopy.ColumnMappings.Add("Orden", "Orden");
                    //bulkCopy.ColumnMappings.Add("TxnDate", "TxnDate");
                    //bulkCopy.ColumnMappings.Add("TxnNumber", "TxnNumber");
                    bulkCopy.ColumnMappings.Add("User", "User");
                    bulkCopy.ColumnMappings.Add("StatusOrdenImpresa_Id", "StatusOrdenImpresa_Id");

                    try
                    {
                        bulkCopy.WriteToServer(dtOrden);
                    }
                    catch (Exception ex)
                    {
                        Console.WriteLine(ex.Message);
                    }
                }

                DataTable dtDetalles = new DataTable();

                dtDetalles.Columns.Add(new DataColumn()
                {
                    ColumnName = "Ordenes_Id",
                    DataType = typeof(int)
                });

                dtDetalles.Columns.Add(new DataColumn()
                {
                    ColumnName = "Skus_Id",
                    DataType = typeof(int)
                });

                dtDetalles.Columns.Add(new DataColumn()
                {
                    ColumnName = "cantidad",
                    DataType = typeof(int)
                });

                List<ordenes> listaOrdenes = db.ordenes.ToList();
                List<skus> listaSKU = db.skus.ToList();

                foreach (DataRow row in dtCharge.Rows)
                {
                    string orden = row[3].ToString();
                    string sku = row[0].ToString();

                    int idOrden = listaOrdenes.Where(x => x.Orden.Contains(orden)).FirstOrDefault().id;
                    int idSKU = listaSKU.Where(x => x.Sku.Contains(sku)).FirstOrDefault().id;
                    dtDetalles.Rows.Add(new object[] {
                    idOrden,
                    idSKU,
                    int.Parse(row[1].ToString())
                });
                }

                using (SqlBulkCopy bulkCopy = new SqlBulkCopy(connectionString))
                {
                    bulkCopy.DestinationTableName = "dbo.detordenproductoshd";

                    bulkCopy.ColumnMappings.Add("Ordenes_Id", "Ordenes_Id");
                    bulkCopy.ColumnMappings.Add("Skus_Id", "Skus_Id");
                    bulkCopy.ColumnMappings.Add("cantidad", "cantidad");

                    try
                    {
                        bulkCopy.WriteToServer(dtDetalles);
                    }
                    catch (Exception ex)
                    {
                        Console.WriteLine(ex.Message);
                    }
                }

                MessageBox.Show("Se han cargado los registros correctamente");
            }
            else
            {
                MessageBox.Show("NO SE HAN ENCONTRADO REGISTROS NUEVOS");
            }
        }

        private void BtnCargarArchivos_Click(object sender, EventArgs e)
        {
            AgregarOrdenes();            
        }
    }
}
