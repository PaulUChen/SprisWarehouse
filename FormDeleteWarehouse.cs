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
    public partial class FormDeleteWarehouse : Form
    {
        public FormDeleteWarehouse()
        {
            InitializeComponent();
        }

        private void btnDelete_Click(object sender, EventArgs e)
        {

            SqlConnection conn = new SqlConnection("Data Source=.\\SQLEXPRESS;Initial Catalog=Spris;Persist Security Inf" +
                        "o=True;User ID=sa;Password=99437510");
            String SQLStringDelete = "DELETE FROM WareHouse WHERE WarehouseName = '" + txtWarehouseName.Text.ToString() + "'";
            SqlCommand cmdDelete = new SqlCommand(SQLStringDelete, conn);
            String SQLStringUpdate = "UPDATE Product SET WarehouseName = '" + comboBoxMoveWarehouse.Text.ToString() + "' WHERE WarehouseName = '" + txtWarehouseName.Text.ToString() + "'";
            SqlCommand cmdUpdate = new SqlCommand(SQLStringUpdate, conn);
            try
            {
                conn.Open();

                try
                {
                    int iCountDelete, iCountUpdate;
                    //執行SQL指令
                    iCountDelete = cmdDelete.ExecuteNonQuery();
                    if (iCountDelete.ToString() == "0")
                    {
                        MessageBox.Show("請輸入欲刪除之倉庫名稱");
                    }
                    else
                    {
                        iCountUpdate = cmdUpdate.ExecuteNonQuery();
                        this.wareHouseTableAdapter.Fill(this.warehouseDataSet.WareHouse);
                        MessageBox.Show("刪除倉庫 " + txtWarehouseName.Text.ToString() + "成功!");
                        MessageBox.Show("有 " + iCountUpdate.ToString() + "筆資料被移至" + comboBoxMoveWarehouse.Text.ToString() + "倉庫");

                    }

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


        private void FormDeleteWarehouse_Load(object sender, EventArgs e)
        {
            // TODO: 這行程式碼會將資料載入 'warehouseDataSet.WareHouse' 資料表。您可以視需要進行移動或移除。
            this.wareHouseTableAdapter.Fill(this.warehouseDataSet.WareHouse);

        }
        private void selectedCellsButton_Click(Object sender, System.EventArgs e)
        {
            Int32 selectedCellCount = dataGridView1.GetCellCount(DataGridViewElementStates.Selected);
            if (selectedCellCount > 0)
            {

                Console.WriteLine(dataGridView1.CurrentRow.Cells[0].Value.ToString());
                txtWarehouseName.Text = dataGridView1.CurrentRow.Cells[0].Value.ToString();
            }
        }
 
    }
}