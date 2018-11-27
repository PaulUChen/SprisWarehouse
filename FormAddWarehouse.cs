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
    public partial class FormAddWarehouse : Form
    {
        public FormAddWarehouse()
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


            sqlCommandAdd.CommandText = "IF NOT EXISTS (SELECT * FROM WareHouse WHERE WarehouseName = '" + txtWarehouseName.Text.ToString() + "' AND Warehousesite = '" + txtWarehousesite.Text.ToString() +
                "') INSERT INTO WareHouse (WarehouseName , Warehousesite)" +
                "VALUES " +
                " ('" + txtWarehouseName.Text + "', " +
                "'" + txtWarehousesite.Text + "') ";
            int iCount;

            try
            {
                //開啟SqlConnection物件
                sqlConnection1.Open();

                try
                {
                    //執行SQL指令
                    iCount = sqlCommandAdd.ExecuteNonQuery();
                    if (iCount>=1)
                    {
                        MessageBox.Show("倉庫"+ txtWarehouseName.Text.ToString()+ "建立成功!\r\n\r\n");
                    }
                    else if (iCount==-1)
                    {
                        MessageBox.Show("該倉庫已存在。倉庫名稱與位置不能與其他資料完全相符");
                    }
                   
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


    }
}