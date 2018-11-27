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
    public partial class FormUpdateUser : Form
    {
        public FormUsers f1 = null;
        public FormUpdateUser()
        {
            InitializeComponent();
        }

        private void FormUpdateUser_Load(object sender, EventArgs e)
        {
            txtID.Text = f1.UserID;
            String connectionString = "Data Source=.\\SQLEXPRESS;Initial Catalog=Spris;Persist Security Inf" +
                        "o=True;User ID=sa;Password=99437510";
            string selectCommand = "select * from Users where (UserID = '" +txtID.Text.ToString()+"') " ;
            SqlDataAdapter dataAdapter = new SqlDataAdapter(selectCommand, connectionString);
            SqlCommandBuilder commandBuilder = new SqlCommandBuilder(dataAdapter);

            DataTable table = new DataTable();
            table.Locale = System.Globalization.CultureInfo.InvariantCulture;
            dataAdapter.Fill(table);
            txtName.Text = table.Rows[0][1].ToString();
            txtPhone.Text = table.Rows[0][2].ToString();
            txtClass.Text = table.Rows[0][3].ToString();
            txtPassword.Text = table.Rows[0][4].ToString();

        }

        private void Cancel_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void Update_Click(object sender, EventArgs e)
        {
            SqlConnection conn = new SqlConnection("Data Source=.\\SQLEXPRESS;Initial Catalog=Spris;Persist Security Inf" +
            "o=True;User ID=sa;Password=99437510");
            int iCountUpdate;
            String SQLStringUpdate = "UPDATE Users SET Name = '" + txtName.Text.ToString() +
                "', Class = '" + txtClass.Text.ToString() + "', Mobile = '" + txtPhone.Text.ToString()+
                "', Password = '"+txtPassword.Text.ToString() 
                + "' WHERE (UserID = '" + txtID.Text.ToString()+ "')";
            SqlCommand cmdUpdate = new SqlCommand(SQLStringUpdate, conn);
            
            try
            {
                conn.Open();
                try
                {
                    iCountUpdate = cmdUpdate.ExecuteNonQuery();
                    MessageBox.Show(txtName.Text.ToString() + "員工資料修改成功");

                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message);

                }
            }
            finally
            {
                conn.Close();

            }


        }
    }
}