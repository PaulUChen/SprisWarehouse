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

namespace Spris.Sample1 
{
    public partial class FormAddUsers : Form
    {
        public FormAddUsers()
        {
            InitializeComponent();
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {

            //建立SqlConnectionStringBuilder物件
            SqlConnectionStringBuilder builder = new SqlConnectionStringBuilder();
            builder.DataSource = ".\\SQLEXPRESS";
            builder.InitialCatalog = "Spris";
            builder.IntegratedSecurity = true;
            //建立SqlConnection物件
            SqlConnection sqlConnection1 = new SqlConnection();
            //將SqlConnectionStringBuilder的連線字串指向SqlConnection物件
            sqlConnection1.ConnectionString = builder.ConnectionString;
            SqlCommand sqlCommandAdd = new SqlCommand();
            sqlCommandAdd.Connection = sqlConnection1;

            sqlCommandAdd.CommandText = "INSERT INTO Users (Name , Mobile , Class ,Password)" +
                            "VALUES " +
                            " ('" + txtUserName.Text.ToString() + "', " +
                            "'" + txtPhonenum.Text.ToString() + "', " +
                            "'" + ComboBoxClass.Text.ToString() + "', "+
                            "'" + txtPassword.Text.ToString()+ "') ";
            int iCount;

            try
            {
                //開啟SqlConnection物件
                sqlConnection1.Open();
                try
                {
                    //SqlCommand cmdAdd = new SqlCommand(SQLStringAdd, conn);
                    iCount = sqlCommandAdd.ExecuteNonQuery();

                    //執行SQL指令
                   // iCount = cmdAdd.ExecuteNonQuery();


                    MessageBox.Show("員工"+txtUserName.Text.ToString()+"資料建立完成!\r\n\r\n");


                }
                catch (Exception ex)
                {

                    MessageBox.Show(ex.Message);
                }
            }
            finally
            {
                //關閉SqlConnection物件
                sqlConnection1.Close();
            }

        }


        private void FormAddProduct_Load(object sender, EventArgs e)
        {
            // TODO: 這行程式碼會將資料載入 'classDataSet.Class' 資料表。您可以視需要進行移動或移除。
            this.classTableAdapter.Fill(this.classDataSet.Class);


        }


    }
}