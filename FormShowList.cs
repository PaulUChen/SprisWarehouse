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
    public partial class FormShowList : Form
    {
        public FormOrderShow f1 = null;

        public FormShowList()
        {
            InitializeComponent();
        }
        private void FormShowList_Load(object sender, EventArgs e)
        {
            SqlConnection conn = new SqlConnection("Data Source=.\\SQLEXPRESS;Initial Catalog=Spris;Persist Security Inf" +
                       "o=True;User ID=sa;Password=99437510");
            String SQLStringSearch = "SELECT * FROM Orders WHERE (OrderID = '" + f1.OrderIDs + "')";
            SqlCommand cmdSearch = new SqlCommand(SQLStringSearch, conn);
            string OrderProduct, OrderPerson;
            try
            {
                conn.Open();
                try
                {
                    SqlDataReader SearchReader;
                    SearchReader = cmdSearch.ExecuteReader();
                    while(SearchReader.Read())
                    {
                        if (!SearchReader[0].Equals(DBNull.Value))
                        {
                            OrderPerson = SearchReader[3].ToString();
                            string Date = Convert.ToDateTime(SearchReader[1].ToString()).ToString("yyyy/MM/dd");
                            this.Text = "[ " + OrderPerson + " ] " + Date + " 提貨單";
                            txtOrderID.Text = f1.OrderIDs;
                            OrderProduct = SearchReader[4].ToString();

                            String[] item = OrderProduct.Split(new Char[] { '(', ')'});

                            String Objects = "";
                            foreach (var substring in item)
                            {
                                //Console.WriteLine(substring);
                                if (substring.Trim() != "")
                                {
                                    Objects += substring;
                                    if (Objects.Contains(","))
                                    {
                                        String[] Objectsc = Objects.Split(',');
                                        dataGridView1.Rows.Add(Objectsc[0], Objectsc[1]);
                                        Objects = "";

                                    }

                                    //  dataGridView1.Rows.Add(Objects[0], Objects[1]);
                                }

                            }
               
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
                conn.Close();
            }
        }
    }
}