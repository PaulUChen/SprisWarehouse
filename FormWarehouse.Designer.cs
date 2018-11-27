namespace Spris.Sample1
{
    partial class FormWarehouse
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
            this.btnAddWarehouse = new System.Windows.Forms.Button();
            this.btnDeleteWarehouse = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // btnAddWarehouse
            // 
            this.btnAddWarehouse.Location = new System.Drawing.Point(34, 27);
            this.btnAddWarehouse.Name = "btnAddWarehouse";
            this.btnAddWarehouse.Size = new System.Drawing.Size(124, 36);
            this.btnAddWarehouse.TabIndex = 10;
            this.btnAddWarehouse.Text = "新增倉庫";
            this.btnAddWarehouse.UseVisualStyleBackColor = true;
            this.btnAddWarehouse.Click += new System.EventHandler(this.btnAddWarehouse_Click);
            // 
            // btnDeleteWarehouse
            // 
            this.btnDeleteWarehouse.Location = new System.Drawing.Point(186, 27);
            this.btnDeleteWarehouse.Name = "btnDeleteWarehouse";
            this.btnDeleteWarehouse.Size = new System.Drawing.Size(124, 36);
            this.btnDeleteWarehouse.TabIndex = 10;
            this.btnDeleteWarehouse.Text = "刪除倉庫";
            this.btnDeleteWarehouse.UseVisualStyleBackColor = true;
            this.btnDeleteWarehouse.Click += new System.EventHandler(this.btnDeleteWarehouse_Click);
            // 
            // FormWarehouse
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(485, 92);
            this.Controls.Add(this.btnAddWarehouse);
            this.Controls.Add(this.btnDeleteWarehouse);
            this.Cursor = System.Windows.Forms.Cursors.Default;
            this.Font = new System.Drawing.Font("新細明體", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Margin = new System.Windows.Forms.Padding(4);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "FormWarehouse";
            this.Text = "倉庫功能選單";
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.Button btnAddWarehouse;
        private System.Windows.Forms.Button btnDeleteWarehouse;
    }
}

