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
    public partial class FormListMain : Form
    {
        private BindingSource bindingSource1 = new BindingSource();

        public FormListMain()
        {

            InitializeComponent();
            dataGridView1.DataSource = null;
            dataGridView1.DataSource = bindingSource1;
            GetData("SELECT * from Product");
        }

        private void btnInputSearch_Click(object sender, EventArgs e)
        {

            dataGridView1.DataSource = null;
            dataGridView1.DataSource = bindingSource1;
            String Word = txtInputSearch.Text;
            GetData("select * from product where (ProductName Like '%" + txtInputSearch.Text.ToString() + "%')");


        }
        private void btnDateSearch_Click(object sender, EventArgs e)
        {//start
            dataGridView1.DataSource = null;
            dataGridView1.DataSource = bindingSource1;
            String FromDate, ToDate;
            Date1.Format = DateTimePickerFormat.Custom;
            Date1.CustomFormat = "yyyy/MM/dd";
            Date2.Format = DateTimePickerFormat.Custom;
            Date2.CustomFormat = "yyyy/MM/dd";
            FromDate = Date1.Text.ToString();
            ToDate = Date2.Text.ToString();
            Console.WriteLine("form"+ FromDate + "to "+ ToDate);

            GetData("Select * from product where DeliveryDate BETWEEN '"+ FromDate + "' AND '"+ ToDate + "' ");

        }
        private void InputSearch_TextChanged(object sender, EventArgs e)
        {
            dataGridView1.DataSource = null;
            dataGridView1.DataSource = bindingSource1;
            String Word = txtInputSearch.Text;
            GetData("select * from product where (ProductName Like '%" + txtInputSearch.Text.ToString() + "%')");

        }
        private void btnWarehouseSearch_Click(object sender, EventArgs e)
        {
            dataGridView1.DataSource = null;
            dataGridView1.DataSource = bindingSource1;
            Console.WriteLine(ComboBoxWarehouse.Text);
            String Word = ComboBoxWarehouse.Text;
            GetData("select * from product where (WarehouseName = '"+ ComboBoxWarehouse.Text.ToString()+"')");
            
        }

        private void btnBack_Click(object sender, EventArgs e)
        {
            FormMain f = new FormMain();//產生Form2的物件，才可以使用它所提供的Method

            this.Visible = false;//將Form1隱藏。由於在Form1的程式碼內使用this，所以this為Form1的物件本身
            f.Visible = true;//顯示第二個視窗
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

        private void FormListMain_Load(object sender, EventArgs e)
        {
            // TODO: 這行程式碼會將資料載入 'productDataSet.Product' 資料表。您可以視需要進行移動或移除。
            this.productTableAdapter.Fill(this.productDataSet.Product);
            // TODO: 這行程式碼會將資料載入 'warehouseDataSet.WareHouse' 資料表。您可以視需要進行移動或移除。
            this.wareHouseTableAdapter.Fill(this.warehouseDataSet.WareHouse);
            dataGridView1.DataSource = null;
            dataGridView1.DataSource = bindingSource1;
            GetData("select * from product");

        }

        private void button1_Click(object sender, EventArgs e)
        {
            dataGridView1.DataSource = null;
            dataGridView1.DataSource = bindingSource1;
            GetData("select * from product");
        }
    }
}