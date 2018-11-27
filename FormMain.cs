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
    public partial class FormMain : Form
    {
        public FormMain()
        {
            InitializeComponent();
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
             FormAddMain f = new FormAddMain();//產生Form2的物件，才可以使用它所提供的Method

            this.Visible = false;//將Form1隱藏。由於在Form1的程式碼內使用this，所以this為Form1的物件本身
            f.Visible = true;//顯示第二個視窗
        }
        private void btnList_Click(object sender, EventArgs e)
        {
            FormListMain f = new FormListMain();//產生Form2的物件，才可以使用它所提供的Method
            f.ShowDialog();

        }
        private void btnOrder_Click(object sender, EventArgs e)
        {
            FormOrder f = new FormOrder();//產生Form2的物件，才可以使用它所提供的Method
            f.ShowDialog();

        }
        private void btnAlert_Click(object sender, EventArgs e)
        {
            FormAlert f = new FormAlert();//產生Form2的物件，才可以使用它所提供的Method
            f.ShowDialog();

        }

        private void UserButton_Click(object sender, EventArgs e)
        {
            FormUsers f = new FormUsers();//產生Form2的物件，才可以使用它所提供的Method
            f.ShowDialog();
        }

        private void OrdersBtn_Click(object sender, EventArgs e)
        {
            FormLog f = new FormLog();//產生Form2的物件，才可以使用它所提供的Method
            f.ShowDialog();

        }

        private void LogOut_Click(object sender, EventArgs e)
        {
            FormLogin f = new FormLogin();
            this.Visible = false;
            f.Visible = true;
        }
    }
}