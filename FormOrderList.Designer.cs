namespace Spris.Sample1
{
    partial class FormOrderList
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            this.btnSend = new System.Windows.Forms.Button();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.DeleteOrder = new System.Windows.Forms.Button();
            this.CheckDelete = new System.Windows.Forms.DataGridViewCheckBoxColumn();
            this.txtOrderNum = new System.Windows.Forms.DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // btnSend
            // 
            this.btnSend.Location = new System.Drawing.Point(514, 292);
            this.btnSend.Name = "btnSend";
            this.btnSend.Size = new System.Drawing.Size(140, 36);
            this.btnSend.TabIndex = 12;
            this.btnSend.Text = "送出提貨單";
            this.btnSend.UseVisualStyleBackColor = true;
            this.btnSend.Click += new System.EventHandler(this.btnSend_Click);
            // 
            // dataGridView1
            // 
            this.dataGridView1.AllowUserToDeleteRows = false;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.CheckDelete,
            this.txtOrderNum});
            this.dataGridView1.Location = new System.Drawing.Point(21, 26);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.RowTemplate.Height = 24;
            this.dataGridView1.Size = new System.Drawing.Size(633, 260);
            this.dataGridView1.TabIndex = 13;
            // 
            // DeleteOrder
            // 
            this.DeleteOrder.Location = new System.Drawing.Point(21, 292);
            this.DeleteOrder.Name = "DeleteOrder";
            this.DeleteOrder.Size = new System.Drawing.Size(170, 36);
            this.DeleteOrder.TabIndex = 14;
            this.DeleteOrder.Text = "刪除選取內容";
            this.DeleteOrder.UseVisualStyleBackColor = true;
            this.DeleteOrder.Click += new System.EventHandler(this.DeleteOrder_Click);
            // 
            // CheckDelete
            // 
            this.CheckDelete.FalseValue = "0";
            this.CheckDelete.HeaderText = "勾選刪除";
            this.CheckDelete.Name = "CheckDelete";
            this.CheckDelete.TrueValue = "1";
            this.CheckDelete.Width = 110;
            // 
            // txtOrderNum
            // 
            dataGridViewCellStyle1.NullValue = "0";
            this.txtOrderNum.DefaultCellStyle = dataGridViewCellStyle1;
            this.txtOrderNum.HeaderText = "提取數量";
            this.txtOrderNum.Name = "txtOrderNum";
            this.txtOrderNum.Width = 110;
            // 
            // FormOrderList
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(678, 340);
            this.Controls.Add(this.DeleteOrder);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.btnSend);
            this.Cursor = System.Windows.Forms.Cursors.Default;
            this.Font = new System.Drawing.Font("新細明體", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Margin = new System.Windows.Forms.Padding(4);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "FormOrderList";
            this.Text = "提貨單";
            this.Load += new System.EventHandler(this.FormOrderList_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btnSend;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.Button DeleteOrder;
        private System.Windows.Forms.DataGridViewCheckBoxColumn CheckDelete;
        private System.Windows.Forms.DataGridViewTextBoxColumn txtOrderNum;
    }
}

