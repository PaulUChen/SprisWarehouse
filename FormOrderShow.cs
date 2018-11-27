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
    public partial class FormOrderShow : Form
    {
        public FormUsers f1 = null;
        public string OrderIDs = "";
        public FormOrderShow()
        {
            InitializeComponent();
        }
        private void FormOrderShow_Load(object sender, EventArgs e)
        {
            // TODO: 這行程式碼會將資料載入 'ordersDataSet.Orders' 資料表。您可以視需要進行移動或移除。
            this.ordersTableAdapter.Fill(this.ordersDataSet.Orders, f1.UserID);
            string txtID = f1.UserID;
            txtUser.Text = f1.UserName;

        }
        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            var senderGrid = (DataGridView)sender;
            if (e.RowIndex ==-1)
            {

            }
            else
            {
                if (senderGrid.Rows[e.RowIndex].Cells[e.ColumnIndex] is DataGridViewButtonCell )
                {
                    OrderIDs = dataGridView1.Rows[e.RowIndex].Cells[1].Value.ToString();
                    FormShowList f = new FormShowList();
                    f.f1 = this;
                    f.ShowDialog();
                }
            }
        }
    }
}