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
using WFAHomeDelivery.Entities;

namespace WFAHomeDelivery.Formularios
{
    public partial class frmCargaGuias : Form
    {
        private string Excel03ConString = "Provider=Microsoft.Jet.OLEDB.4.0;Data Source={0};Extended Properties='Excel 8.0;HDR={1}'";
        private string Excel07ConString = "Provider=Microsoft.ACE.OLEDB.12.0;Data Source={0};Extended Properties='Excel 8.0;HDR={1}'";
        DataTable dtCharge;
        DB_A3F19C_OGEntities db = new DB_A3F19C_OGEntities();

        public frmCargaGuias()
        {
            InitializeComponent();
        }

        private void BtnSeleccionarArchivo_Click(object sender, EventArgs e)
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

        public void AgregarGuias()
        {
            DataTable dtGuias = new DataTable();

            dtGuias.Columns.Add(new DataColumn()
            {
                ColumnName = "Guia",
                DataType = typeof(string)
            });

            dtGuias.Columns.Add(new DataColumn()
            {
                ColumnName = "Ordenes_Id",
                DataType = typeof(int)
            });

            List<ordenes> lista = db.ordenes.ToList();

            foreach (DataRow row in dtCharge.Rows)
            {                
                dtGuias.Rows.Add(new object[] {
                    row[1].ToString(),
                    lista.Where(x => x.Orden == row[0].ToString()).FirstOrDefault().id
                });
            }

            string connectionString = @"Data Source=SQL7001.site4now.net;Initial Catalog=DB_A3F19C_OG;User Id=DB_A3F19C_OG_admin;Password=xQ9znAhU;";

            using (SqlBulkCopy bulkCopy = new SqlBulkCopy(connectionString))
            {
                bulkCopy.DestinationTableName = "dbo.guias";

                bulkCopy.ColumnMappings.Add("Guia", "Guia");
                bulkCopy.ColumnMappings.Add("Ordenes_Id", "Ordenes_Id");                

                try
                {
                    bulkCopy.WriteToServer(dtGuias);
                }
                catch (Exception ex)
                {
                    Console.WriteLine(ex.Message);
                }
            }

            MessageBox.Show("Se han cargado los registros correctamente");
        }

        private void BtnCargarArchivo_Click(object sender, EventArgs e)
        {
            AgregarGuias();
        }
    }
}
