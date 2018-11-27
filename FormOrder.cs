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

    public partial class FormOrder : Form
    {
        private BindingSource bindingSource1 = new BindingSource();
        public DataTable OrderTable = new DataTable();
        public string UserID,Username,Date;
        public static string LoginUserID;
        TextBox txtChooseProductName = new TextBox();
        TextBox txtStock = new TextBox();
        TextBox txtCreateDate = new TextBox();
        TextBox txtExpiryDate = new TextBox();
        public FormOrder()
        {
           
            InitializeComponent();
            dataGridView1.DataSource = null;
            dataGridView1.DataSource = bindingSource1;
            GetData("SELECT * from Product");
            LoginUserID = FormLogin.LoginUserID;
            Console.WriteLine("Order"+LoginUserID);
            
            if (LoginUserID != "1") 
            {
                UserID = LoginUserID;
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
                            Username = UserRead[0].ToString();
                        }
                        UserRead.Close();
                    }
                    catch (Exception ex)
                    {

                    }
                }
                finally
                {
                    conn.Close();
                }
                UserLabel.Text += "    "+Username;
                UserComboBox.Visible = false; 
                Console.WriteLine("Here" + UserID +Username);

            }

        }


        private void FormOrder_Load(object sender, EventArgs e)
        {
            // TODO: 這行程式碼會將資料載入 'userDataSet.Users' 資料表。您可以視需要進行移動或移除。
            this.usersTableAdapter1.Fill(this.userDataSet.Users);
            // TODO: 這行程式碼會將資料載入 'usersDataSet.Users' 資料表。您可以視需要進行移動或移除。
            //this.usersTableAdapter.Fill(this.usersDataSet.Users);
            // TODO: 這行程式碼會將資料載入 'warehouseDataSet.WareHouse' 資料表。您可以視需要進行移動或移除。
            this.wareHouseTableAdapter.Fill(this.warehouseDataSet.WareHouse);
            // TODO: 這行程式碼會將資料載入 'productDataSet.Product' 資料表。您可以視需要進行移動或移除。
            // this.productTableAdapter.Fill(this.productDataSet.Product);
            dataGridView1.DataSource = null;
            dataGridView1.DataSource = bindingSource1;
            GetData("SELECT * from Product");

        }

        private void ProductNameSearch_TextChanged(object sender, EventArgs e)
        {
            dataGridView1.DataSource = null;
            dataGridView1.DataSource = bindingSource1;
            String Word = txtProductNameSearch.Text;
            GetData("select * from product where (ProductName Like '%" + txtProductNameSearch.Text.ToString() + "%')");

        }

        private void GetData(string selectCommand)
        {
            try
            {
                String connectionString = "Data Source=.\\SQLEXPRESS;Initial Catalog=Spris;Persist Security Inf" +
                        "o=True;User ID=sa;Password=99437510";
                SqlDataAdapter dataAdapter = new SqlDataAdapter(selectCommand, connectionString);
                SqlCommandBuilder commandBuilder = new SqlCommandBuilder(dataAdapter);

                DataTable table = new DataTable();
                table.Locale = System.Globalization.CultureInfo.InvariantCulture;
                dataAdapter.Fill(table);

                if (table.Rows.Count == 0)
                {
                   // MessageBox.Show("資料庫無相關資料");
                }
                for (int I = 0; I < table.Rows.Count; I++)
                {
                    if (table.Rows[I][3].ToString() == "1900/1/1 上午 12:00:00")
                    {
                        table.Rows[I][3] = DBNull.Value;
                    }
                    if (table.Rows[I][4].ToString() == "1900/1/1 上午 12:00:00")
                    {
                        table.Rows[I][4] = DBNull.Value;
                    }
                    if (table.Rows[I][5].ToString() == "1900/1/1 上午 12:00:00")
                    {
                        table.Rows[I][5] = DBNull.Value;
                    }
                }
                bindingSource1.DataSource = table;
                //dataGridView1.AutoResizeColumns(DataGridViewAutoSizeColumnsMode.AllCellsExceptHeader);

            }
            catch (SqlException)
            {
                MessageBox.Show("To run this example, replace the value of the connectionString variable with a connection string that is valid for your system.");
            }
        }

        private void ComboBoxWarehouse_SelectedIndexChanged(object sender, EventArgs e)
        {
            dataGridView1.DataSource = null;
            dataGridView1.DataSource = bindingSource1;
            Console.WriteLine(ComboBoxWarehouse.Text);
            String Word = ComboBoxWarehouse.Text;
            GetData("select * from product where (WarehouseName = '" + ComboBoxWarehouse.Text.ToString() + "')");

        }

        private void SearchDate_ValueChanged(object sender, EventArgs e)
        {
            dataGridView1.DataSource = null;
            dataGridView1.DataSource = bindingSource1;
            String FromDate, ToDate;
            SearchDate1.Format = DateTimePickerFormat.Custom;
            SearchDate1.CustomFormat = "yyyy/MM/dd";
            SearchDate2.Format = DateTimePickerFormat.Custom;
            SearchDate2.CustomFormat = "yyyy/MM/dd";
            FromDate = SearchDate1.Text.ToString();
            ToDate = SearchDate2.Text.ToString();

            GetData("Select * from product where DeliveryDate BETWEEN '" + FromDate + "' AND '" + ToDate + "' ");

        }
        private void ShowButton_Click(object sender, EventArgs e)
        {
            dataGridView1.DataSource = null;
            dataGridView1.DataSource = bindingSource1;
            GetData("SELECT * from Product");
        }




        private void NextPageButton_Click(object sender, EventArgs e)
        {
            FormOrderList f = new FormOrderList();//產生Form2的物件，才可以使用它所提供的Method

            //this.Visible = false;//將Form1隱藏。由於在Form1的程式碼內使用this，所以this為Form1的物件本身
            //f.Visible = true;//顯示第二個視窗
            OrderTable = new DataTable();
            OrderTable.Columns.Add("物品名稱", typeof(string));
            OrderTable.Columns.Add("目前數量", typeof(string));
            //OrderTable.Columns.Add("提取數量", typeof(string));
            OrderTable.Columns.Add("製造日期", typeof(DateTime));
            OrderTable.Columns.Add("有效日期", typeof(DateTime));
            int events = 0;

            for (int i = 0; i< dataGridView1.Rows.Count; i++)
            {
                DataGridViewCheckBoxCell check = (DataGridViewCheckBoxCell)dataGridView1.Rows[i].Cells[0];

                if (check!=null && ((bool)check.EditingCellFormattedValue == true || (bool)check.FormattedValue==true))
                {
                    txtChooseProductName.Text = dataGridView1.Rows[i].Cells[1].Value.ToString();
                    txtStock.Text = dataGridView1.Rows[i].Cells[8].Value.ToString();
                    txtCreateDate.Text = dataGridView1.Rows[i].Cells[4].Value.ToString();
                    txtExpiryDate.Text = dataGridView1.Rows[i].Cells[5].Value.ToString();
                    DataRow dataRow = OrderTable.NewRow();
                    dataRow["物品名稱"] = txtChooseProductName.Text.ToString();
                    dataRow["目前數量"] = txtStock.Text.ToString();
                    if (txtCreateDate.Text.ToString() !="")
                    {
                        dataRow["製造日期"] = txtCreateDate.Text.ToString();
                    }
                    if (txtExpiryDate.Text.ToString() != "")
                    {
                        dataRow["有效日期"] = txtExpiryDate.Text.ToString();
                    }

                    OrderTable.Rows.Add(dataRow);
                    events = events + 1;
                }

            }
            if (events!=0)
            {
                if (LoginUserID == "1")
                {
                    UserID = UserComboBox.SelectedValue.ToString();
                    Username = UserComboBox.Text.ToString();
                    Date = OrderDate.Value.ToString("yyyy/MM/dd");
                }
                else //除管理者外，其餘使用者只能以自身身分提領
                {
                    UserID = LoginUserID;
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
                                Username = UserRead[0].ToString();
                            }
                            UserRead.Close();
                        }
                        catch (Exception ex)
                        {

                        }
                    }
                    finally
                    {
                        conn.Close();
                    }
                    Date = OrderDate.Value.ToString("yyyy/MM/dd");
                }
                
                f.f1 = this;
                f.ShowDialog();
                dataGridView1.DataSource = null;
                dataGridView1.DataSource = bindingSource1;
                GetData("SELECT * from Product");
            }
            else { MessageBox.Show("請勾選欲提取之物品"); }
            
        }


    }
}