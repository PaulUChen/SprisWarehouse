using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.Sql;
using System.Data.OleDb;
using System.Data.SqlClient;

namespace Spris.Sample1
{
    public partial class FormLogin : Form
    {
        public static string LoginUserID;


        SqlConnection con = new SqlConnection();
        public FormLogin()
        {
            SqlConnection con = new SqlConnection();
            con.ConnectionString = "Data Source=.\\SQLEXPRESS;Initial Catalog=Spris;Persist Security Inf" +
                        "o=True;User ID=sa;Password=99437510";
            InitializeComponent();
           
        }
        private void FormLogin_Load(object sender,EventArgs e)
        {
            
        }

        private void Login_Click(object sender, EventArgs e)
        {
            SqlConnection con = new SqlConnection();
            con.ConnectionString = "Data Source=localhost;Initial Catalog=Spris;Persist Security Inf" +
                        "o=True;User ID=sa;Password=99437510";
            try
            {
                con.Open();
                try
                {
                    string SQLLoginString = "SELECT UserID,Password FROM Users WHERE UserID = '"+txtUserID.Text.ToString()+"' and Password = '"+txtUserPassword.Text.ToString() + "'";
                    SqlCommand cmdlogin = new SqlCommand(SQLLoginString, con);
                    SqlDataAdapter d = new SqlDataAdapter(cmdlogin);
                    DataTable dt = new DataTable();
                    d.Fill(dt);
                    if (dt.Rows.Count>0)
                    {
                        if (txtUserID.Text == "1")
                        {
                            LoginUserID = txtUserID.Text.ToString();
                            FormMain f = new FormMain();
                            this.Visible = false;//將Form1隱藏。由於在Form1的程式碼內使用this，所以this為Form1的物件本身
                            f.Visible = true;//顯示第二個視窗
                        }
                        else
                        {
                            LoginUserID = txtUserID.Text.ToString();
                            FormMainForUser f = new FormMainForUser();
                            this.Visible = false;//將Form1隱藏。由於在Form1的程式碼內使用this，所以this為Form1的物件本身
                            f.Visible = true;//顯示第二個視窗
                        }
                        
                    }
                    else
                    {
                        MessageBox.Show("Error UserID or Password");
                    }
                }
                catch(Exception ex)
                {
                    MessageBox.Show(ex.Message);
                }
            }
            finally
            {
                con.Close();
            }
        }
    }
}
