namespace Spris.Sample1
{
    partial class FormOrder
    {
        /// <summary>
        /// 設計工具所需的變數。
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// 清除任何使用中的資源。
        /// </summary>
        /// <param name="disposing">如果應該處置 Managed 資源則為 true，否則為 false。</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form 設計工具產生的程式碼

        /// <summary>
        /// 此為設計工具支援所需的方法 - 請勿使用程式碼編輯器修改
        /// 這個方法的內容。
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            this.UserComboBox = new System.Windows.Forms.ComboBox();
            this.usersBindingSource1 = new System.Windows.Forms.BindingSource(this.components);
            this.userDataSet = new Spris.Sample1.UserDataSet();
            this.UserLabel = new System.Windows.Forms.Label();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.productBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.productDataSet = new Spris.Sample1.ProductDataSet();
            this.label1 = new System.Windows.Forms.Label();
            this.OrderDate = new System.Windows.Forms.DateTimePicker();
            this.sqlConnection1 = new System.Data.SqlClient.SqlConnection();
            this.SearchSetLabel = new System.Windows.Forms.Label();
            this.txtProductNameSearch = new System.Windows.Forms.TextBox();
            this.panel1 = new System.Windows.Forms.Panel();
            this.SearchDate2 = new System.Windows.Forms.DateTimePicker();
            this.SearchDate1 = new System.Windows.Forms.DateTimePicker();
            this.DateLabel2 = new System.Windows.Forms.Label();
            this.DateLabel1 = new System.Windows.Forms.Label();
            this.DateLabel = new System.Windows.Forms.Label();
            this.WarehouseLabel = new System.Windows.Forms.Label();
            this.ComboBoxWarehouse = new System.Windows.Forms.ComboBox();
            this.wareHouseBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.warehouseDataSet = new Spris.Sample1.WarehouseDataSet();
            this.ProductSearchLabel = new System.Windows.Forms.Label();
            this.ShowButton = new System.Windows.Forms.Button();
            this.NextPageButton = new System.Windows.Forms.Button();
            this.productTableAdapter = new Spris.Sample1.ProductDataSetTableAdapters.ProductTableAdapter();
            this.wareHouseTableAdapter = new Spris.Sample1.WarehouseDataSetTableAdapters.WareHouseTableAdapter();
            this.usersTableAdapter1 = new Spris.Sample1.UserDataSetTableAdapters.UsersTableAdapter();
            this.chooseit = new System.Windows.Forms.DataGridViewCheckBoxColumn();
            this.dataGridViewTextBoxColumn1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn3 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn4 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn5 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn6 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn7 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn8 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)(this.usersBindingSource1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.userDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.productBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.productDataSet)).BeginInit();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.wareHouseBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.warehouseDataSet)).BeginInit();
            this.SuspendLayout();
            // 
            // UserComboBox
            // 
            this.UserComboBox.DataSource = this.usersBindingSource1;
            this.UserComboBox.DisplayMember = "Name";
            this.UserComboBox.FormattingEnabled = true;
            this.UserComboBox.Location = new System.Drawing.Point(74, 12);
            this.UserComboBox.MaxLength = 10;
            this.UserComboBox.Name = "UserComboBox";
            this.UserComboBox.Size = new System.Drawing.Size(121, 24);
            this.UserComboBox.TabIndex = 14;
            this.UserComboBox.ValueMember = "UserID";
            // 
            // usersBindingSource1
            // 
            this.usersBindingSource1.DataMember = "Users";
            this.usersBindingSource1.DataSource = this.userDataSet;
            // 
            // userDataSet
            // 
            this.userDataSet.DataSetName = "UserDataSet";
            this.userDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // UserLabel
            // 
            this.UserLabel.AutoSize = true;
            this.UserLabel.Location = new System.Drawing.Point(12, 15);
            this.UserLabel.Name = "UserLabel";
            this.UserLabel.Size = new System.Drawing.Size(56, 16);
            this.UserLabel.TabIndex = 15;
            this.UserLabel.Text = "提貨人";
            // 
            // dataGridView1
            // 
            this.dataGridView1.AutoGenerateColumns = false;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.chooseit,
            this.dataGridViewTextBoxColumn1,
            this.dataGridViewTextBoxColumn2,
            this.dataGridViewTextBoxColumn3,
            this.dataGridViewTextBoxColumn4,
            this.dataGridViewTextBoxColumn5,
            this.dataGridViewTextBoxColumn6,
            this.dataGridViewTextBoxColumn7,
            this.dataGridViewTextBoxColumn8});
            this.dataGridView1.DataSource = this.productBindingSource;
            this.dataGridView1.Location = new System.Drawing.Point(16, 105);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.RowTemplate.Height = 24;
            this.dataGridView1.Size = new System.Drawing.Size(926, 311);
            this.dataGridView1.TabIndex = 16;
            // 
            // productBindingSource
            // 
            this.productBindingSource.DataMember = "Product";
            this.productBindingSource.DataSource = this.productDataSet;
            // 
            // productDataSet
            // 
            this.productDataSet.DataSetName = "ProductDataSet";
            this.productDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(212, 15);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(72, 16);
            this.label1.TabIndex = 21;
            this.label1.Text = "提貨日期";
            // 
            // OrderDate
            // 
            this.OrderDate.Location = new System.Drawing.Point(316, 8);
            this.OrderDate.Name = "OrderDate";
            this.OrderDate.Size = new System.Drawing.Size(200, 27);
            this.OrderDate.TabIndex = 22;
            // 
            // sqlConnection1
            // 
            this.sqlConnection1.ConnectionString = "Data Source=.\\\\SQLEXPRESS;Initial Catalog=Spris;Persist Security Info=True;User I" +
    "D=sa";
            this.sqlConnection1.FireInfoMessageEventOnUserErrors = false;
            // 
            // SearchSetLabel
            // 
            this.SearchSetLabel.AutoSize = true;
            this.SearchSetLabel.Location = new System.Drawing.Point(6, 48);
            this.SearchSetLabel.Name = "SearchSetLabel";
            this.SearchSetLabel.Size = new System.Drawing.Size(72, 16);
            this.SearchSetLabel.TabIndex = 23;
            this.SearchSetLabel.Text = "搜尋工具";
            // 
            // txtProductNameSearch
            // 
            this.txtProductNameSearch.Location = new System.Drawing.Point(11, 27);
            this.txtProductNameSearch.Name = "txtProductNameSearch";
            this.txtProductNameSearch.Size = new System.Drawing.Size(100, 27);
            this.txtProductNameSearch.TabIndex = 24;
            this.txtProductNameSearch.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.txtProductNameSearch.TextChanged += new System.EventHandler(this.ProductNameSearch_TextChanged);
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.SearchDate2);
            this.panel1.Controls.Add(this.SearchDate1);
            this.panel1.Controls.Add(this.DateLabel2);
            this.panel1.Controls.Add(this.DateLabel1);
            this.panel1.Controls.Add(this.DateLabel);
            this.panel1.Controls.Add(this.WarehouseLabel);
            this.panel1.Controls.Add(this.ComboBoxWarehouse);
            this.panel1.Controls.Add(this.ProductSearchLabel);
            this.panel1.Controls.Add(this.txtProductNameSearch);
            this.panel1.Location = new System.Drawing.Point(105, 42);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(761, 57);
            this.panel1.TabIndex = 25;
            // 
            // SearchDate2
            // 
            this.SearchDate2.Location = new System.Drawing.Point(547, 26);
            this.SearchDate2.Name = "SearchDate2";
            this.SearchDate2.Size = new System.Drawing.Size(143, 27);
            this.SearchDate2.TabIndex = 33;
            this.SearchDate2.ValueChanged += new System.EventHandler(this.SearchDate_ValueChanged);
            // 
            // SearchDate1
            // 
            this.SearchDate1.Location = new System.Drawing.Point(360, 27);
            this.SearchDate1.Name = "SearchDate1";
            this.SearchDate1.Size = new System.Drawing.Size(143, 27);
            this.SearchDate1.TabIndex = 32;
            // 
            // DateLabel2
            // 
            this.DateLabel2.AutoSize = true;
            this.DateLabel2.Font = new System.Drawing.Font("微軟正黑體", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.DateLabel2.Location = new System.Drawing.Point(512, 27);
            this.DateLabel2.Name = "DateLabel2";
            this.DateLabel2.Size = new System.Drawing.Size(29, 24);
            this.DateLabel2.TabIndex = 31;
            this.DateLabel2.Text = "到";
            // 
            // DateLabel1
            // 
            this.DateLabel1.AutoSize = true;
            this.DateLabel1.Font = new System.Drawing.Font("微軟正黑體", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.DateLabel1.Location = new System.Drawing.Point(325, 27);
            this.DateLabel1.Name = "DateLabel1";
            this.DateLabel1.Size = new System.Drawing.Size(29, 24);
            this.DateLabel1.TabIndex = 30;
            this.DateLabel1.Text = "從";
            // 
            // DateLabel
            // 
            this.DateLabel.AutoSize = true;
            this.DateLabel.Font = new System.Drawing.Font("微軟正黑體", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.DateLabel.Location = new System.Drawing.Point(472, 3);
            this.DateLabel.Name = "DateLabel";
            this.DateLabel.Size = new System.Drawing.Size(86, 24);
            this.DateLabel.TabIndex = 29;
            this.DateLabel.Text = "入庫日期";
            // 
            // WarehouseLabel
            // 
            this.WarehouseLabel.AutoSize = true;
            this.WarehouseLabel.Font = new System.Drawing.Font("微軟正黑體", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.WarehouseLabel.Location = new System.Drawing.Point(193, 1);
            this.WarehouseLabel.Name = "WarehouseLabel";
            this.WarehouseLabel.Size = new System.Drawing.Size(48, 24);
            this.WarehouseLabel.TabIndex = 28;
            this.WarehouseLabel.Text = "倉庫";
            // 
            // ComboBoxWarehouse
            // 
            this.ComboBoxWarehouse.DataSource = this.wareHouseBindingSource;
            this.ComboBoxWarehouse.DisplayMember = "WarehouseName";
            this.ComboBoxWarehouse.FormattingEnabled = true;
            this.ComboBoxWarehouse.Location = new System.Drawing.Point(142, 27);
            this.ComboBoxWarehouse.MaxLength = 100;
            this.ComboBoxWarehouse.Name = "ComboBoxWarehouse";
            this.ComboBoxWarehouse.Size = new System.Drawing.Size(152, 24);
            this.ComboBoxWarehouse.TabIndex = 27;
            this.ComboBoxWarehouse.SelectedIndexChanged += new System.EventHandler(this.ComboBoxWarehouse_SelectedIndexChanged);
            // 
            // wareHouseBindingSource
            // 
            this.wareHouseBindingSource.DataMember = "WareHouse";
            this.wareHouseBindingSource.DataSource = this.warehouseDataSet;
            // 
            // warehouseDataSet
            // 
            this.warehouseDataSet.DataSetName = "WarehouseDataSet";
            this.warehouseDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // ProductSearchLabel
            // 
            this.ProductSearchLabel.AutoSize = true;
            this.ProductSearchLabel.Font = new System.Drawing.Font("微軟正黑體", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.ProductSearchLabel.Location = new System.Drawing.Point(16, 1);
            this.ProductSearchLabel.Name = "ProductSearchLabel";
            this.ProductSearchLabel.Size = new System.Drawing.Size(86, 24);
            this.ProductSearchLabel.TabIndex = 26;
            this.ProductSearchLabel.Text = "物品名稱";
            // 
            // ShowButton
            // 
            this.ShowButton.Location = new System.Drawing.Point(3, 73);
            this.ShowButton.Name = "ShowButton";
            this.ShowButton.Size = new System.Drawing.Size(75, 23);
            this.ShowButton.TabIndex = 26;
            this.ShowButton.Text = "顯示";
            this.ShowButton.UseVisualStyleBackColor = true;
            this.ShowButton.Click += new System.EventHandler(this.ShowButton_Click);
            // 
            // NextPageButton
            // 
            this.NextPageButton.Location = new System.Drawing.Point(806, 8);
            this.NextPageButton.Name = "NextPageButton";
            this.NextPageButton.Size = new System.Drawing.Size(145, 30);
            this.NextPageButton.TabIndex = 38;
            this.NextPageButton.Text = "查訪提貨單";
            this.NextPageButton.UseVisualStyleBackColor = true;
            this.NextPageButton.Click += new System.EventHandler(this.NextPageButton_Click);
            // 
            // productTableAdapter
            // 
            this.productTableAdapter.ClearBeforeFill = true;
            // 
            // wareHouseTableAdapter
            // 
            this.wareHouseTableAdapter.ClearBeforeFill = true;
            // 
            // usersTableAdapter1
            // 
            this.usersTableAdapter1.ClearBeforeFill = true;
            // 
            // chooseit
            // 
            this.chooseit.FalseValue = "0";
            this.chooseit.HeaderText = "提領";
            this.chooseit.Name = "chooseit";
            this.chooseit.TrueValue = "1";
            this.chooseit.Width = 80;
            // 
            // dataGridViewTextBoxColumn1
            // 
            this.dataGridViewTextBoxColumn1.DataPropertyName = "ProductName";
            this.dataGridViewTextBoxColumn1.HeaderText = "物品名稱";
            this.dataGridViewTextBoxColumn1.Name = "dataGridViewTextBoxColumn1";
            this.dataGridViewTextBoxColumn1.ReadOnly = true;
            this.dataGridViewTextBoxColumn1.Width = 110;
            // 
            // dataGridViewTextBoxColumn2
            // 
            this.dataGridViewTextBoxColumn2.DataPropertyName = "Unit";
            this.dataGridViewTextBoxColumn2.HeaderText = "單位";
            this.dataGridViewTextBoxColumn2.Name = "dataGridViewTextBoxColumn2";
            this.dataGridViewTextBoxColumn2.ReadOnly = true;
            // 
            // dataGridViewTextBoxColumn3
            // 
            this.dataGridViewTextBoxColumn3.DataPropertyName = "Type";
            this.dataGridViewTextBoxColumn3.HeaderText = "類型";
            this.dataGridViewTextBoxColumn3.Name = "dataGridViewTextBoxColumn3";
            this.dataGridViewTextBoxColumn3.ReadOnly = true;
            // 
            // dataGridViewTextBoxColumn4
            // 
            this.dataGridViewTextBoxColumn4.DataPropertyName = "CreateDate";
            this.dataGridViewTextBoxColumn4.HeaderText = "製造日期";
            this.dataGridViewTextBoxColumn4.Name = "dataGridViewTextBoxColumn4";
            this.dataGridViewTextBoxColumn4.ReadOnly = true;
            this.dataGridViewTextBoxColumn4.Width = 110;
            // 
            // dataGridViewTextBoxColumn5
            // 
            this.dataGridViewTextBoxColumn5.DataPropertyName = "ExpiryDate";
            this.dataGridViewTextBoxColumn5.HeaderText = "有效日期";
            this.dataGridViewTextBoxColumn5.Name = "dataGridViewTextBoxColumn5";
            this.dataGridViewTextBoxColumn5.ReadOnly = true;
            this.dataGridViewTextBoxColumn5.Width = 110;
            // 
            // dataGridViewTextBoxColumn6
            // 
            this.dataGridViewTextBoxColumn6.DataPropertyName = "DeliveryDate";
            this.dataGridViewTextBoxColumn6.HeaderText = "入庫日期";
            this.dataGridViewTextBoxColumn6.Name = "dataGridViewTextBoxColumn6";
            this.dataGridViewTextBoxColumn6.ReadOnly = true;
            this.dataGridViewTextBoxColumn6.Width = 110;
            // 
            // dataGridViewTextBoxColumn7
            // 
            this.dataGridViewTextBoxColumn7.DataPropertyName = "WarehouseName";
            this.dataGridViewTextBoxColumn7.HeaderText = "存放位置";
            this.dataGridViewTextBoxColumn7.Name = "dataGridViewTextBoxColumn7";
            this.dataGridViewTextBoxColumn7.ReadOnly = true;
            this.dataGridViewTextBoxColumn7.Width = 110;
            // 
            // dataGridViewTextBoxColumn8
            // 
            this.dataGridViewTextBoxColumn8.DataPropertyName = "Stock";
            this.dataGridViewTextBoxColumn8.HeaderText = "數量";
            this.dataGridViewTextBoxColumn8.Name = "dataGridViewTextBoxColumn8";
            this.dataGridViewTextBoxColumn8.ReadOnly = true;
            // 
            // FormOrder
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(954, 428);
            this.Controls.Add(this.NextPageButton);
            this.Controls.Add(this.ShowButton);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.SearchSetLabel);
            this.Controls.Add(this.OrderDate);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.UserLabel);
            this.Controls.Add(this.UserComboBox);
            this.Cursor = System.Windows.Forms.Cursors.Default;
            this.Font = new System.Drawing.Font("新細明體", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Margin = new System.Windows.Forms.Padding(4);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "FormOrder";
            this.Text = "貨品總覽";
            this.Load += new System.EventHandler(this.FormOrder_Load);
            ((System.ComponentModel.ISupportInitialize)(this.usersBindingSource1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.userDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.productBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.productDataSet)).EndInit();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.wareHouseBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.warehouseDataSet)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Label UserLabel;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.DateTimePicker OrderDate;
        private System.Data.SqlClient.SqlConnection sqlConnection1;
        private System.Windows.Forms.Label SearchSetLabel;
        private System.Windows.Forms.TextBox txtProductNameSearch;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label ProductSearchLabel;
        private System.Windows.Forms.ComboBox ComboBoxWarehouse;
        private System.Windows.Forms.Label WarehouseLabel;
        private System.Windows.Forms.Label DateLabel;
        private System.Windows.Forms.Label DateLabel2;
        private System.Windows.Forms.Label DateLabel1;
        private System.Windows.Forms.DateTimePicker SearchDate2;
        private System.Windows.Forms.DateTimePicker SearchDate1;
        private System.Windows.Forms.Button ShowButton;
        private System.Windows.Forms.Button NextPageButton;
        private System.Windows.Forms.DataGridViewTextBoxColumn productNameDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn unitDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn typeDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn createDateDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn expiryDateDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn deliveryDateDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn warehouseNameDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn stockDataGridViewTextBoxColumn;
        private ProductDataSet productDataSet;
        private System.Windows.Forms.BindingSource productBindingSource;
        private ProductDataSetTableAdapters.ProductTableAdapter productTableAdapter;
        private WarehouseDataSet warehouseDataSet;
        private System.Windows.Forms.BindingSource wareHouseBindingSource;
        private WarehouseDataSetTableAdapters.WareHouseTableAdapter wareHouseTableAdapter;
        private System.Windows.Forms.ComboBox UserComboBox;
        private UserDataSet userDataSet;
        private System.Windows.Forms.BindingSource usersBindingSource1;
        private UserDataSetTableAdapters.UsersTableAdapter usersTableAdapter1;
        private System.Windows.Forms.DataGridViewCheckBoxColumn chooseit;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn1;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn2;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn3;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn4;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn5;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn6;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn7;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn8;
    }
}

