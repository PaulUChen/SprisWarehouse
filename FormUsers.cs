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
    public partial class FormUsers : Form
    {
        private BindingSource bindingSource1 = new BindingSource();
        public String UserID, UserName;
        public FormUsers()
        {
            InitializeComponent();
            dataGridView1.DataSource = null;
            dataGridView1.DataSource = bindingSource1;
            GetData("SELECT * from Users");
        }
        private void UserName_TextChanged(object sender, EventArgs e)
        {
            dataGridView1.DataSource = null;
            dataGridView1.DataSource = bindingSource1;
            String Word = txtUserName.Text;
            GetData("select * from Users where (Name Like '%" + txtUserName.Text.ToString() + "%')");
        }
        private void ComboBoxClassName_TextChanged(object sender, EventArgs e)
        {
            dataGridView1.DataSource = null;
            dataGridView1.DataSource = bindingSource1;
            Console.WriteLine(ComboBoxClassName.Text);
            String Word = ComboBoxClassName.Text;
            GetData("select * from Users where (Class = '" + ComboBoxClassName.Text.ToString() + "')");
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


        private void FormUsers_Load(object sender, EventArgs e)
        {
            // TODO: 這行程式碼會將資料載入 'usersDataSet.Users' 資料表。您可以視需要進行移動或移除。
         //   this.usersTableAdapter.Fill(this.usersDataSet.Users);
            // TODO: 這行程式碼會將資料載入 'classDataSet.Class' 資料表。您可以視需要進行移動或移除。
            this.classTableAdapter.Fill(this.classDataSet.Class);

        }

        private void AddUser_Click(object sender, EventArgs e)
        {
            FormAddUsers f = new FormAddUsers();//產生Form2的物件，才可以使用它所提供的Method
            f.ShowDialog();
        }

        private void RemoveUser_Click(object sender, EventArgs e)
        {
            FormDeleteUser f = new FormDeleteUser();//產生Form2的物件，才可以使用它所提供的Method
            
            this.Visible = false;//將Form1隱藏。由於在Form1的程式碼內使用this，所以this為Form1的物件本身
            f.Visible = true;//顯示第二個視窗
        }
        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            var senderGrid = (DataGridView)sender;
            if (e.RowIndex == -1)
            {

            }
            else
            {
                if (senderGrid.Rows[e.RowIndex].Cells[e.ColumnIndex] is DataGridViewButtonCell && e.ColumnIndex == 0)
                {
                    UserID = dataGridView1.Rows[e.RowIndex].Cells[1].Value.ToString();
                    FormUpdateUser f = new FormUpdateUser();//產生Form2的物件，才可以使用它所提供的Method
                    f.f1 = this;
                    f.ShowDialog();
                    this.usersTableAdapter.Fill(this.usersDataSet.Users);
                }
                else if (senderGrid.Rows[e.RowIndex].Cells[e.ColumnIndex] is DataGridViewButtonCell && e.ColumnIndex == 6)
                {
                    UserID = dataGridView1.Rows[e.RowIndex].Cells[1].Value.ToString();
                    UserName = dataGridView1.Rows[e.RowIndex].Cells[2].Value.ToString();
                    FormOrderShow f = new FormOrderShow();//產生Form2的物件，才可以使用它所提供的Method
                    f.f1 = this;
                    f.ShowDialog();
                }

            }
            

        }
    }
}