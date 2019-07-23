using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;

namespace WFAHomeDelivery
{
    public partial class frmLogin : Form
    {
        public frmLogin()
        {
            InitializeComponent();
        }

        SqlConnection con = new SqlConnection(@"Data Source=SQL7001.site4now.net;Initial Catalog=DB_A3F19C_OG;User Id=DB_A3F19C_OG_admin;Password=xQ9znAhU;");

        public void Loguear(string usuario, string password)
        {
            try
            {
                con.Open();
                string comando = "SELECT [nombre] ,[tipousuario] FROM [usuarios] WHERE [usuario] = @user AND [password] = @password";
                SqlCommand cmd = new SqlCommand(comando, con);

                cmd.Parameters.AddWithValue("@user", usuario);
                cmd.Parameters.AddWithValue("@password", password);

                SqlDataAdapter sda = new SqlDataAdapter(cmd);

                DataTable dt = new DataTable();

                sda.Fill(dt);

                if (dt.Rows.Count == 1)
                {
                    this.Hide();

                    if (dt.Rows[0][1].ToString() == "Auditor")
                    {
                        new frmEscaneos(dt.Rows[0][0].ToString()).Show();
                    }
                    else if (dt.Rows[0][1].ToString() == "Admin")
                    {
                        new frmMenu().Show();
                    }
                    else if (dt.Rows[0][1].ToString() == "Supervisor")
                    {
                        new frmMenu().Show();
                    }
                }
                else
                {
                    MessageBox.Show("Usuario Y/O Contraseña Incorrectos");
                }
            }
            catch (Exception e)
            {
                MessageBox.Show(e.Message);
            }
            finally
            {
                con.Close();
            } 
        }

        private void BtnLogin_Click(object sender, EventArgs e)
        {
            Loguear(this.txtUser.Text, this.txtPassword.Text);
        }
    }
}