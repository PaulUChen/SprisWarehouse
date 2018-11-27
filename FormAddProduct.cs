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

namespace Spris.Sample1 //進貨單
{
    public partial class FormAddProduct : Form
    {
        public FormAddProduct()
        {
            InitializeComponent();
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            txtDeliveryDate.Format = DateTimePickerFormat.Custom;
            txtDeliveryDate.CustomFormat = "yyyy/MM/dd";
            SqlConnection conn = new SqlConnection("Data Source=.\\SQLEXPRESS;Initial Catalog=Spris;Persist Security Inf" +
                        "o=True;User ID=sa;Password=99437510");

            String SQLStringSearch = "SELECT * FROM Product WHERE (ProductName = '" + txtProductName.Text.ToString() +
                "') AND (CreateDate = '" + txtCreateDate.Text.ToString() + "') AND (ExpiryDate = '" + txtExpiryDate.Text.ToString() +
                "') AND (WareHouseName = '" + txtWarehouseName.Text.ToString() + "')";
            SqlCommand cmdSearch = new SqlCommand(SQLStringSearch, conn);

            String SQLStringAdd = "INSERT INTO Product " +
                " (ProductName, Unit, Type, CreateDate, ExpiryDate, DeliveryDate, WarehouseName, Stock) " +
                "VALUES " +
                " ('" + txtProductName.Text + "', " +
                "'" + txtUnit.Text + "', " +
                "'" + txtType.Text + "', " +
                "'" + txtCreateDate.Text + "', " +
                "'" + txtExpiryDate.Text + "', " +
                "'" + txtDeliveryDate.Text.ToString() + "', " +
                "'" + txtWarehouseName.Text + "', " +
                "'" + txtStock.Text + "') ";
            SqlCommand cmdAdd = new SqlCommand(SQLStringAdd, conn);
            


            try
            {
                conn.Open();
                if (txtType.Text.ToString() != "")
                {
                    String SQLTypeSearch = "SELECT * FROM Type WHERE TypeName ='" + txtType.Text.ToString() + "'";
                    SqlCommand TypeSearch = new SqlCommand(SQLTypeSearch, conn);
                    SqlDataAdapter d = new SqlDataAdapter(TypeSearch);
                    DataTable dt = new DataTable();
                    d.Fill(dt);
                    if (dt.Rows.Count > 0)
                    {

                    }
                    else
                    {
                        String SQLTypeInsert = "INSERT INTO Type (TypeName) VALUES ('" + txtType.Text.ToString() + "') ";
                        SqlCommand TypeInsert = new SqlCommand(SQLTypeInsert, conn);
                        TypeInsert.ExecuteNonQuery();

                    }

                }

                try
                {
                    int iCountAdd, iCountUpdate;
                    //執行SQL指令
                    SqlDataReader SearchReader;
                    SearchReader = cmdSearch.ExecuteReader();
                   
                    if (SearchReader.Read())
                    {
                        int stock = Int32.Parse(txtStock.Text.ToString());
                        int news = Int32.Parse(SearchReader["Stock"].ToString());
                        stock = stock + news;
                        txtStock.Text= stock.ToString();                      
                        SearchReader.Close();
                        String SQLStringUpdate = "UPDATE Product SET Stock = '" + txtStock.Text.ToString() + "' WHERE (ProductName = '" + txtProductName.Text.ToString() +
                "') AND (CreateDate = '" + txtCreateDate.Text.ToString() + "') AND (ExpiryDate = '" + txtExpiryDate.Text.ToString() + "')";
                        SqlCommand cmdUpdate = new SqlCommand(SQLStringUpdate, conn);
                        iCountUpdate = cmdUpdate.ExecuteNonQuery();
                        MessageBox.Show(txtProductName.Text.ToString()+"物品已存在，物品數量更新成功!\r\n\r\n目前物品總數共" + txtStock.Text.ToString());
                                       
                    }
                    else                     
                    {
                        SearchReader.Close();
                        int stock = Int32.Parse(txtStock.Text.ToString());
                        if (stock == 0)
                        {
                            MessageBox.Show("物品數量不得為0");
                        }
                        else
                        {
                            //執行SQL指令
                            iCountAdd = cmdAdd.ExecuteNonQuery();

                            MessageBox.Show("新增記錄成功!\r\n\r\n共" + iCountAdd.ToString() +
                                            "筆記錄");
                        }
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

                conn.Close();
            }
        }

        private void FormAddProduct_Load(object sender, EventArgs e)
        {
            // TODO: 這行程式碼會將資料載入 'typeDataSet.Type' 資料表。您可以視需要進行移動或移除。
            this.typeTableAdapter.Fill(this.typeDataSet.Type);
            // TODO: 這行程式碼會將資料載入 'warehouseDataSet.WareHouse' 資料表。您可以視需要進行移動或移除。
            this.wareHouseTableAdapter.Fill(this.warehouseDataSet.WareHouse);


        }

    }
}