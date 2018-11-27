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
    public partial class FormLog : Form
    {
        private BindingSource bindingSource1 = new BindingSource();

        public FormLog()
        {
            InitializeComponent();
        }
        private void FormLog_Load(object sender, EventArgs e)
        {
            dataGridView1.DataSource = null;
            dataGridView1.DataSource = bindingSource1;
            GetData("SELECT * from Orders");
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
                    MessageBox.Show("資料庫無相關資料");
                }

                bindingSource1.DataSource = table;
                //dataGridView1.AutoResizeColumns(DataGridViewAutoSizeColumnsMode.AllCellsExceptHeader);

            }
            catch (SqlException)
            {
                MessageBox.Show("To run this example, replace the value of the connectionString variable with a connection string that is valid for your system.");
            }
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
            Console.WriteLine("form" + FromDate + "to " + ToDate);

            GetData("Select * from Orders where OrderDate BETWEEN '" + FromDate + "' AND '" + ToDate + "' ");

        }

    }
   

}