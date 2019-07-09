using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.OleDb;
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
        OrdenesController ctrlOrden;
        DetOrdenProductosHDController ctrlDetalle;
        SkusController ctrlSKU;

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
            List<ordenes> list = new List<ordenes>();
            ctrlOrden = new OrdenesController();
            foreach (DataRow row in dtCharge.Rows)
            {
                ordenes ordenes = new ordenes();

                if (row[3].ToString() != "")
                {
                    ordenes.Orden = row[3].ToString();
                    ordenes.FechaAlta = DateTime.Now;
                    ordenes.TxnNumber = row[1].ToString();
                    ordenes.User = row[5].ToString();

                    if (row[0].ToString() != "")
                    {
                        ordenes.TxnDate = Convert.ToDateTime(row[0].ToString());
                    }

                    list.Add(ordenes);
                }                                
            }

            if (ctrlOrden.CargaOracle(list))
            {
                if (AgregarDetalles())
                {
                    MessageBox.Show("Carga Completa Correctamente", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
                else
                {
                    MessageBox.Show("Ha ocurrido un error", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
            else
            {
                MessageBox.Show("Ha ocurrido un error", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        public bool AgregarDetalles()
        {
            List<detordenproductoshd> list = new List<detordenproductoshd>();
            ctrlOrden = new OrdenesController();
            ctrlDetalle = new DetOrdenProductosHDController();
            ctrlSKU = new SkusController();
            foreach (DataRow row in dtCharge.Rows)
            {
                detordenproductoshd detordenproductoshd = new detordenproductoshd();



                if (row[3].ToString() != "")
                {
                    detordenproductoshd.Ordenes_Id = ctrlOrden.OrdenById(row[3].ToString());
                }

                if (row[2].ToString() != "")
                {
                    detordenproductoshd.Skus_Id = ctrlSKU.ConsultaBySku(row[2].ToString()).id;
                }

                if (row[4].ToString() != "")
                {
                    detordenproductoshd.cantidad = int.Parse(row[4].ToString());
                }
                list.Add(detordenproductoshd);
            }
            return ctrlDetalle.AgregarDetalles(list);
        }    

        private void Button2_Click(object sender, EventArgs e)
        {
            AgregarOrdenes();            
        }
    }
}
