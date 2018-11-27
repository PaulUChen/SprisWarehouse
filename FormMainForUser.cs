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
    public partial class FormMainForUser : Form
    {

        public FormMainForUser()
        {
            InitializeComponent();
            
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            FormAddProduct f = new FormAddProduct();//產生Form2的物件，才可以使用它所提供的Method
            f.ShowDialog();
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

        private void LogOut_Click(object sender, EventArgs e)
        {
            FormLogin f = new FormLogin();
            this.Visible = false;
            f.Visible = true;
        }
    }
}