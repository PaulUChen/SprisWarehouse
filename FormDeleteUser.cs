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
    public partial class FormDeleteUser : Form
    {
        public FormDeleteUser()
        {
            InitializeComponent();
        }

        private void btnDelete_Click(object sender, EventArgs e)
        {

            SqlConnection conn = new SqlConnection("Data Source=.\\SQLEXPRESS;Initial Catalog=Spris;Persist Security Inf" +
                        "o=True;User ID=sa;Password=99437510");
            String SQLStringDelete = "DELETE FROM UserS WHERE UserID = '" + txtUserID.Text.ToString() + "'";
            SqlCommand cmdDelete = new SqlCommand(SQLStringDelete, conn);

            try
            {
                conn.Open();

                try
                {
                    int iCountDelete;
                    //執行SQL指令
                    iCountDelete = cmdDelete.ExecuteNonQuery();
                    MessageBox.Show("已成功刪除使用者" + txtUserName.Text.ToString());
                    this.usersTableAdapter1.Fill(this.userDataSet.Users);


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
        private void btnBack_Click(object sender, EventArgs e)
        {
            FormUsers f = new FormUsers();//產生Form2的物件，才可以使用它所提供的Method

            this.Visible = false;//將Form1隱藏。由於在Form1的程式碼內使用this，所以this為Form1的物件本身
            f.Visible = true;//顯示第二個視窗
        }

        private void FormDeleteWarehouse_Load(object sender, EventArgs e)
        {
            // TODO: 這行程式碼會將資料載入 'userDataSet.Users' 資料表。您可以視需要進行移動或移除。
            this.usersTableAdapter1.Fill(this.userDataSet.Users);


        }
        private void selectedCellsButton_Click(Object sender, System.EventArgs e)
        {
            Int32 selectedCellCount = dataGridView1.GetCellCount(DataGridViewElementStates.Selected);
            if (selectedCellCount > 0)
            {

                Console.WriteLine(dataGridView1.CurrentRow.Cells[1].Value.ToString());
                txtUserName.Text = dataGridView1.CurrentRow.Cells[1].Value.ToString();
                txtUserID.Text = dataGridView1.CurrentRow.Cells[0].Value.ToString();
            }
        }
 
    }
}