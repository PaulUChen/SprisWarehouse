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
    public partial class FormWarehouse : Form
    {
        public FormWarehouse()
        {
            InitializeComponent();
        }

        private void btnAddWarehouse_Click(object sender, EventArgs e)
        {
             FormAddWarehouse f = new FormAddWarehouse();//產生Form2的物件，才可以使用它所提供的Method
             f.ShowDialog();
        }
        private void btnDeleteWarehouse_Click(object sender, EventArgs e)
        {
            FormDeleteWarehouse f = new FormDeleteWarehouse();//產生Form2的物件，才可以使用它所提供的Method
            f.ShowDialog();

        }


    }
}