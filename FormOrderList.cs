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
    public partial class FormOrderList : Form
    {
        private BindingSource bindingSource1 = new BindingSource();
        public FormOrder f1 = null;
        public FormAlert f2 = null;
        DataTable Orders = new DataTable();
        string UserID,UserName, OrderDate;
        public FormOrderList()
        {
           
            InitializeComponent();

        }
        private void FormOrderList_Load(object sender, EventArgs e)
        {
            if (f1!=null)
            {
                Orders = f1.OrderTable;
                UserID = f1.UserID;
                UserName = f1.Username;
                OrderDate = f1.Date;
            }
            else // ALERT 的使用者名稱須經由查尋獲得
            {
                Orders = f2.OrderTable;
                UserID = f2.UserID;
                UserName = f2.Username;
                OrderDate = f2.Date;
                SqlConnection conn = new SqlConnection("Data Source=.\\SQLEXPRESS;Initial Catalog=Spris;Persist Security Inf" +
                        "o=True;User ID=sa;Password=99437510");
                try
                {
                    conn.Open();
                    try
                    {
                        String SQLUserName = "SELECT Name FROM Users WHERE UserID = '" + UserID + "'";
                        SqlCommand cmdUserName = new SqlCommand(SQLUserName, conn);
                        SqlDataReader UserRead = cmdUserName.ExecuteReader();
                        while (UserRead.Read())
                        {
                            UserName = UserRead[0].ToString();
                        }
                        UserRead.Close();
                    }
                    catch(Exception ex)
                    {

                    }
                }
                finally
                {
                    conn.Close();
                }
                
            }
            dataGridView1.DataSource = null;
            dataGridView1.DataSource = bindingSource1;
            bindingSource1.DataSource = Orders;
            Console.WriteLine(UserID + "and" + UserName +"and"+OrderDate);

        }

        private void btnSend_Click(object sender, EventArgs e)
        {
            int[] orderlist = new int[dataGridView1.Rows.Count - 1];
            int[] objlist = new int[dataGridView1.Rows.Count - 1];
            SqlConnection conn = new SqlConnection("Data Source=.\\SQLEXPRESS;Initial Catalog=Spris;Persist Security Inf" +
                        "o=True;User ID=sa;Password=99437510");
            
                foreach (DataGridViewRow row in dataGridView1.Rows)
                {
                    int i;
                    if (row.Index == dataGridView1.Rows.Count - 1)
                    {
                        break;
                    }
                    if (!int.TryParse(row.Cells[1].Value.ToString(),out i))
                    {
                        MessageBox.Show("請勿輸入非數字之字串");
                    }
                    else
                    {
                        if (row.Cells[1].Value == null)
                        {
                            MessageBox.Show("提取數量不得為0");

                            break;
                        }

                        if (Convert.ToInt32(row.Cells[1].Value) < 0)
                        {
                            MessageBox.Show("提取數量不得小於0");
                        }
                        if (Convert.ToInt32(row.Cells[1].Value) > Convert.ToInt32(row.Cells[3].Value))
                        {
                            MessageBox.Show("提取數量不得超過物品數量");
                        }
                        else
                        {
                            objlist[row.Index] = Convert.ToInt32(row.Index);//儲存物品的index
                            orderlist[row.Index] = Convert.ToInt32(row.Cells[1].Value); //儲存提取數量的陣列
                        }
                    }
                    
                }

            if (orderlist.Contains(0))
            {
                
            }
            else
            {
                try
                {
                    conn.Open();
                    try
                    {
                        string newOrderID ="";
                        int iCountUpdate, iCountDelete;
                        String SQLOrderInsert = "INSERT INTO Orders  (OrderDate , UserID , UserName)" +
                            "VALUES " +
                            " ('" + OrderDate + "', " +
                            "'" + UserID + "', " +
                            "'" + UserName + "') ;" + "SELECT SCOPE_IDENTITY()";
                        SqlCommand sqlCommandAdd = new SqlCommand(SQLOrderInsert, conn);
                        newOrderID = sqlCommandAdd.ExecuteScalar().ToString();
                        string newProductList="",newOrderList="",LastOrderDate = "";

                        //User資料表更新//

                        //User 抓過去領取的領貨單號
                        LastOrderDate = OrderDate;
                        String SQLUserSearch = "SELECT OrderID FROM Users WHERE UserID = '" + UserID + "'";
                        SqlCommand cmdUserSearch = new SqlCommand(SQLUserSearch, conn);
                        SqlDataReader UserRead = cmdUserSearch.ExecuteReader();
                        while(UserRead.Read())
                        {
                            if (UserRead[0].ToString() == "")
                            {
                                newOrderList = UserRead[0].ToString();
                            }
                            else
                            {
                                newOrderList = UserRead[0].ToString() + ",";
                            }
                        }
                        UserRead.Close();

                        //加上新貨單
                        newOrderList = newOrderList + newOrderID;
                        //User資料表更新
                        String SQLUserUpdate = "UPDATE Users SET OrderID = '" + newOrderList +
                            "' ,LastOrderDate ='" + LastOrderDate + "' WHERE UserID = '" + UserID + "'";
                        SqlCommand cmdUserUpdate = new SqlCommand(SQLUserUpdate, conn);
                        cmdUserUpdate.ExecuteNonQuery();


                        for (int i = 0; i < orderlist.Length; i++)
                        {
                            int j = objlist[i];

     //Order資料表更新
                            newProductList = newProductList +"("+ dataGridView1.Rows[j].Cells[2].Value.ToString() + "," + dataGridView1.Rows[j].Cells[1].Value + ") ";
                            String SQLOrderUpdate = "UPDATE Orders SET ProductList = '" + newProductList + "' WHERE (OrderID = '" +
                                newOrderID + "')";
                            SqlCommand cmdOrderUpdate = new SqlCommand(SQLOrderUpdate, conn);
                            cmdOrderUpdate.ExecuteNonQuery();
                            
                            //貨物已無庫存 進行資料刪除
                            if (Convert.ToInt32(dataGridView1.Rows[j].Cells[3].Value) == orderlist[i])
                            {

                                if (dataGridView1.Rows[j].Cells[4].Value == DBNull.Value)
                                {
                                    dataGridView1.Rows[j].Cells[4].Value = Convert.ToDateTime("1900/1/1 上午 12:00:00");
                                }
                                if (dataGridView1.Rows[j].Cells[5].Value == DBNull.Value)
                                {
                                    dataGridView1.Rows[j].Cells[5].Value = Convert.ToDateTime("1900/1/1 上午 12:00:00");
                                }

                                String SQLStringDelete = "DELETE FROM Product" + " WHERE (ProductName = '" + dataGridView1.Rows[j].Cells[2].Value.ToString() +
                        "') AND (CreateDate = '" + Convert.ToDateTime(dataGridView1.Rows[j].Cells[4].Value).ToString("yyyy/MM/dd") + "')" +
                        "AND (ExpiryDate = '" + Convert.ToDateTime(dataGridView1.Rows[j].Cells[5].Value).ToString("yyyy/MM/dd") + "')";
                                SqlCommand cmdDelete = new SqlCommand(SQLStringDelete, conn);
                                iCountDelete = cmdDelete.ExecuteNonQuery();

                            }
                            else //貨物還有剩餘 進行資料更新
                            {
                                int result = Convert.ToInt32(dataGridView1.Rows[j].Cells[3].Value) - orderlist[i];

                                if (dataGridView1.Rows[j].Cells[4].Value == DBNull.Value)
                                {
                                    dataGridView1.Rows[j].Cells[4].Value = Convert.ToDateTime("1900/1/1 上午 12:00:00");
                                }
                                if (dataGridView1.Rows[j].Cells[5].Value == DBNull.Value)
                                {
                                    dataGridView1.Rows[j].Cells[5].Value = Convert.ToDateTime("1900/1/1 上午 12:00:00");
                                }
                                String SQLStringUpdate = "UPDATE Product SET Stock = '" + result.ToString() +
                                    "' WHERE (ProductName = '" + dataGridView1.Rows[j].Cells[2].Value.ToString() +
                            "') AND (CreateDate = '" + Convert.ToDateTime(dataGridView1.Rows[j].Cells[4].Value).ToString("yyyy/MM/dd") + "')" +
                            "AND (ExpiryDate = '" + Convert.ToDateTime(dataGridView1.Rows[j].Cells[5].Value).ToString("yyyy/MM/dd") + "')";

                                    SqlCommand cmdUpdate = new SqlCommand(SQLStringUpdate, conn);
                                    iCountUpdate = cmdUpdate.ExecuteNonQuery();
                      
                            }
                        }
                        MessageBox.Show("提貨成功，提貨單已存入資料庫");
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
                Close();

            }
        }

        private void DeleteOrder_Click(object sender, EventArgs e)
        {
            int [] Rowindex =new int [dataGridView1.Rows.Count-1];
            for (int i = dataGridView1.Rows.Count - 1; i >= 0; i--)
            {
                DataGridViewCheckBoxCell check = (DataGridViewCheckBoxCell)dataGridView1.Rows[i].Cells[0];
                
                if (check != null && ( (bool)check.FormattedValue == true))
                {
                    Orders.Rows[i].Delete();
                }

            }

            dataGridView1.DataSource = null;
            dataGridView1.DataSource = bindingSource1;
            bindingSource1.DataSource = Orders;
        }
    }
}