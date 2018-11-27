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
    public partial class FormAddMain : Form
    {
        public FormAddMain()
        {
            InitializeComponent();
        }

        private void btnProduct_Click(object sender, EventArgs e)
        {
             FormAddProduct f = new FormAddProduct();//產生Form2的物件，才可以使用它所提供的Method
            f.ShowDialog();
        }
        private void btnWarehouse_Click(object sender, EventArgs e)
        {
            FormWarehouse f = new FormWarehouse();//產生Form2的物件，才可以使用它所提供的Method
            f.ShowDialog();

        }

        private void btnBack_Click_1(object sender, EventArgs e)
        {
            FormMain f = new FormMain();//產生Form2的物件，才可以使用它所提供的Method

            this.Visible = false;//將Form1隱藏。由於在Form1的程式碼內使用this，所以this為Form1的物件本身
            f.Visible = true;//顯示第二個視窗
        }
    }
}