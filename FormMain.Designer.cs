namespace Spris.Sample1
{
    partial class FormMain
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
            this.btnAdd = new System.Windows.Forms.Button();
            this.btnList = new System.Windows.Forms.Button();
            this.btnAlert = new System.Windows.Forms.Button();
            this.btnOrder = new System.Windows.Forms.Button();
            this.UserButton = new System.Windows.Forms.Button();
            this.OrdersBtn = new System.Windows.Forms.Button();
            this.LogOut = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // btnAdd
            // 
            this.btnAdd.Location = new System.Drawing.Point(12, 12);
            this.btnAdd.Name = "btnAdd";
            this.btnAdd.Size = new System.Drawing.Size(145, 52);
            this.btnAdd.TabIndex = 10;
            this.btnAdd.Text = "進貨與新增倉庫";
            this.btnAdd.UseVisualStyleBackColor = true;
            this.btnAdd.Click += new System.EventHandler(this.btnAdd_Click);
            // 
            // btnList
            // 
            this.btnList.Location = new System.Drawing.Point(212, 71);
            this.btnList.Name = "btnList";
            this.btnList.Size = new System.Drawing.Size(145, 95);
            this.btnList.TabIndex = 10;
            this.btnList.Text = "瀏覽倉庫";
            this.btnList.UseVisualStyleBackColor = true;
            this.btnList.Click += new System.EventHandler(this.btnList_Click);
            // 
            // btnAlert
            // 
            this.btnAlert.Location = new System.Drawing.Point(12, 230);
            this.btnAlert.Name = "btnAlert";
            this.btnAlert.Size = new System.Drawing.Size(145, 52);
            this.btnAlert.TabIndex = 11;
            this.btnAlert.Text = "貨品到期提醒";
            this.btnAlert.UseVisualStyleBackColor = true;
            this.btnAlert.Click += new System.EventHandler(this.btnAlert_Click);
            // 
            // btnOrder
            // 
            this.btnOrder.Location = new System.Drawing.Point(12, 172);
            this.btnOrder.Name = "btnOrder";
            this.btnOrder.Size = new System.Drawing.Size(145, 52);
            this.btnOrder.TabIndex = 11;
            this.btnOrder.Text = "提貨功能";
            this.btnOrder.UseVisualStyleBackColor = true;
            this.btnOrder.Click += new System.EventHandler(this.btnOrder_Click);
            // 
            // UserButton
            // 
            this.UserButton.Location = new System.Drawing.Point(409, 172);
            this.UserButton.Name = "UserButton";
            this.UserButton.Size = new System.Drawing.Size(145, 52);
            this.UserButton.TabIndex = 12;
            this.UserButton.Text = "查訪員工名單";
            this.UserButton.UseVisualStyleBackColor = true;
            this.UserButton.Click += new System.EventHandler(this.UserButton_Click);
            // 
            // OrdersBtn
            // 
            this.OrdersBtn.Location = new System.Drawing.Point(409, 230);
            this.OrdersBtn.Name = "OrdersBtn";
            this.OrdersBtn.Size = new System.Drawing.Size(145, 53);
            this.OrdersBtn.TabIndex = 13;
            this.OrdersBtn.Text = "歷史提貨單查詢";
            this.OrdersBtn.UseVisualStyleBackColor = true;
            this.OrdersBtn.Click += new System.EventHandler(this.OrdersBtn_Click);
            // 
            // LogOut
            // 
            this.LogOut.Location = new System.Drawing.Point(479, 12);
            this.LogOut.Name = "LogOut";
            this.LogOut.Size = new System.Drawing.Size(75, 36);
            this.LogOut.TabIndex = 14;
            this.LogOut.Text = "登出";
            this.LogOut.UseVisualStyleBackColor = true;
            this.LogOut.Click += new System.EventHandler(this.LogOut_Click);
            // 
            // FormMain
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(566, 302);
            this.Controls.Add(this.LogOut);
            this.Controls.Add(this.OrdersBtn);
            this.Controls.Add(this.UserButton);
            this.Controls.Add(this.btnAdd);
            this.Controls.Add(this.btnList);
            this.Controls.Add(this.btnAlert);
            this.Controls.Add(this.btnOrder);
            this.Cursor = System.Windows.Forms.Cursors.Default;
            this.Font = new System.Drawing.Font("新細明體", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Margin = new System.Windows.Forms.Padding(4);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "FormMain";
            this.Text = "主選單";
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.Button btnAdd;
        private System.Windows.Forms.Button btnList;
        private System.Windows.Forms.Button btnAlert;
        private System.Windows.Forms.Button btnOrder;
        private System.Windows.Forms.Button UserButton;
        private System.Windows.Forms.Button OrdersBtn;
        private System.Windows.Forms.Button LogOut;
    }

}

