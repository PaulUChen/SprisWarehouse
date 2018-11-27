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
    public partial class FormAlert : Form
    {
        private BindingSource bindingSource1 = new BindingSource();
        private BindingSource bindingSource2 = new BindingSource();
        public DataTable OrderTable = new DataTable();
        public string UserID, Username, Date;
        public static string LoginUserID;
        TextBox txtChooseProductName = new TextBox();
        TextBox txtStock = new TextBox();
        TextBox txtCreateDate = new TextBox();
        TextBox txtExpiryDate = new TextBox();
        public FormAlert()
        {
            LoginUserID = FormLogin.LoginUserID;
            Console.WriteLine("Alert" + LoginUserID);
            InitializeComponent();
        }
        private void FormAlert_Load(object sender, EventArgs e)
        {
            // TODO: 這行程式碼會將資料載入 'sprisDataSet.Product' 資料表。您可以視需要進行移動或移除。
            this.productTableAdapter.Fill(this.ProductDataSet.Product);
            dateTimePicker1.Format = DateTimePickerFormat.Custom;
            dateTimePicker1.CustomFormat = "yyyy/MM/dd";
            Console.WriteLine(dateTimePicker1);            
            txtTimer.Text = Convert.ToDateTime(dateTimePicker1.Value).ToString("yyyy/MM/dd");
            dataGridView1.DataSource = null;
            dataGridView1.DataSource = bindingSource1;
            string  DateString = "19000102";
            GetData("select * from product WHERE ExpiryDate <= DATEADD(m,+0,GetDate()) AND  ExpiryDate > '1900/1/1'", bindingSource1);
            dataGridView2.DataSource = null;
            dataGridView2.DataSource = bindingSource2;
            GetData("select * from product WHERE ExpiryDate Between DATEADD(m,+0,GetDate()) AND DATEADD(m,+2,GetDate()) ",bindingSource2);
            if (dataGridView1.Rows.Count ==1 )
            {
                MessageBox.Show("無到期物品存在於倉庫中");
            }
            if (dataGridView2.Rows.Count == 1)
            {
                MessageBox.Show("無即將到期物品存在於倉庫中");
            }

        }

        private void GetData(string selectCommand,BindingSource bindingsource)
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

                bindingsource.DataSource = table;

                //dataGridView1.AutoResizeColumns(DataGridViewAutoSizeColumnsMode.AllCellsExceptHeader);

            }
            catch (SqlException)
            {
                MessageBox.Show("To run this example, replace the value of the connectionString variable with a connection string that is valid for your system.");
            }
        }

        private void Orderbutton_Click(object sender, EventArgs e)
        {
            FormOrderList f = new FormOrderList();//產生Form2的物件，才可以使用它所提供的Method
            OrderTable = new DataTable();
            OrderTable.Columns.Add("物品名稱", typeof(string));
            OrderTable.Columns.Add("目前數量", typeof(string));
            //OrderTable.Columns.Add("提取數量", typeof(string));
            OrderTable.Columns.Add("製造日期", typeof(DateTime)); 
            OrderTable.Columns.Add("有效日期", typeof(DateTime));
            int events = 0;

            for (int i = 0; i < dataGridView1.Rows.Count; i++)
            {
                DataGridViewCheckBoxCell check = (DataGridViewCheckBoxCell)dataGridView1.Rows[i].Cells[0];

                if (check != null && ((bool)check.EditingCellFormattedValue == true || (bool)check.FormattedValue == true))
                {
                    txtChooseProductName.Text = dataGridView1.Rows[i].Cells[1].Value.ToString();
                    txtStock.Text = dataGridView1.Rows[i].Cells[5].Value.ToString();
                    txtCreateDate.Text = dataGridView1.Rows[i].Cells[3].Value.ToString();
                    txtExpiryDate.Text = dataGridView1.Rows[i].Cells[4].Value.ToString();
                    DataRow dataRow = OrderTable.NewRow();
                    dataRow["物品名稱"] = txtChooseProductName.Text.ToString();
                    dataRow["目前數量"] = txtStock.Text.ToString();
                    if (txtCreateDate.Text.ToString() != "")
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
            for(int i = 0; i<dataGridView2.Rows.Count; i++)
            {
                DataGridViewCheckBoxCell check = (DataGridViewCheckBoxCell)dataGridView2.Rows[i].Cells[0];

                if (check != null && ((bool)check.EditingCellFormattedValue == true || (bool)check.FormattedValue == true))
                {
                    txtChooseProductName.Text = dataGridView2.Rows[i].Cells[1].Value.ToString();
                    txtStock.Text = dataGridView2.Rows[i].Cells[5].Value.ToString();
                    txtCreateDate.Text = dataGridView2.Rows[i].Cells[3].Value.ToString();
                    txtExpiryDate.Text = dataGridView2.Rows[i].Cells[4].Value.ToString();
                    DataRow dataRow = OrderTable.NewRow();
                    dataRow["物品名稱"] = txtChooseProductName.Text.ToString();
                    dataRow["目前數量"] = txtStock.Text.ToString();
                    if (txtCreateDate.Text.ToString() != "")
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
            if (events != 0)
            {
                UserID = LoginUserID;
                Date = dateTimePicker1.Value.ToString("yyyy/MM/dd");
                f.f2 = this;
                f.ShowDialog();
            }
            else { MessageBox.Show("請勾選欲提取之物品"); }

            //Update
            dataGridView1.DataSource = null;
            dataGridView1.DataSource = bindingSource1;
            GetData("select * from product WHERE ExpiryDate <= DATEADD(m,+0,GetDate()) AND  ExpiryDate > '1900/1/1'", bindingSource1);
            dataGridView2.DataSource = null;
            dataGridView2.DataSource = bindingSource2;
            GetData("select * from product WHERE ExpiryDate Between DATEADD(m,+0,GetDate()) AND DATEADD(m,+2,GetDate()) ", bindingSource2);

        }


    }
}