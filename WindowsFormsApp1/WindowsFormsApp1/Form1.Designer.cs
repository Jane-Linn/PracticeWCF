namespace WindowsFormsApp1
{
    partial class Form1
    {
        /// <summary>
        /// 設計工具所需的變數。
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// 清除任何使用中的資源。
        /// </summary>
        /// <param name="disposing">如果應該處置受控資源則為 true，否則為 false。</param>
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
            this.InputStockId = new System.Windows.Forms.TextBox();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.InputDate = new System.Windows.Forms.TextBox();
            this.SearchByDate = new System.Windows.Forms.Button();
            this.SearchByStockId = new System.Windows.Forms.Button();
            this.TimeConsume = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // InputStockId
            // 
            this.InputStockId.Location = new System.Drawing.Point(123, 14);
            this.InputStockId.Name = "InputStockId";
            this.InputStockId.Size = new System.Drawing.Size(100, 22);
            this.InputStockId.TabIndex = 0;
            // 
            // dataGridView1
            // 
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(27, 127);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.RowTemplate.Height = 24;
            this.dataGridView1.Size = new System.Drawing.Size(761, 311);
            this.dataGridView1.TabIndex = 2;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(38, 23);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(63, 12);
            this.label1.TabIndex = 3;
            this.label1.Text = "輸入stockId";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(38, 64);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(53, 12);
            this.label2.TabIndex = 4;
            this.label2.Text = "輸入日期";
            // 
            // InputDate
            // 
            this.InputDate.Location = new System.Drawing.Point(123, 61);
            this.InputDate.Name = "InputDate";
            this.InputDate.Size = new System.Drawing.Size(100, 22);
            this.InputDate.TabIndex = 5;
            // 
            // SearchByDate
            // 
            this.SearchByDate.Location = new System.Drawing.Point(241, 64);
            this.SearchByDate.Name = "SearchByDate";
            this.SearchByDate.Size = new System.Drawing.Size(103, 23);
            this.SearchByDate.TabIndex = 6;
            this.SearchByDate.Text = "依日期查詢";
            this.SearchByDate.UseVisualStyleBackColor = true;
            this.SearchByDate.Click += new System.EventHandler(this.ButtonClick);
            this.SearchByDate.Tag = new SearchByDate(InputDate, TimeConsume);
            // 
            // SearchByStockId
            // 
            this.SearchByStockId.Location = new System.Drawing.Point(241, 14);
            this.SearchByStockId.Name = "SearchByStockId";
            this.SearchByStockId.Size = new System.Drawing.Size(103, 23);
            this.SearchByStockId.TabIndex = 1;
            this.SearchByStockId.Text = "依stockId查詢";
            this.SearchByStockId.UseVisualStyleBackColor = true;
            this.SearchByStockId.Click += new System.EventHandler(this.ButtonClick);
            this.SearchByStockId.Tag = new SearchByStockId(InputStockId, TimeConsume);
            // 
            // TimeConsume
            // 
            this.TimeConsume.Location = new System.Drawing.Point(455, 12);
            this.TimeConsume.Multiline = true;
            this.TimeConsume.Name = "TimeConsume";
            this.TimeConsume.Size = new System.Drawing.Size(210, 75);
            this.TimeConsume.TabIndex = 7;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(420, 13);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(29, 12);
            this.label3.TabIndex = 8;
            this.label3.Text = "耗時";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.TimeConsume);
            this.Controls.Add(this.SearchByDate);
            this.Controls.Add(this.InputDate);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.SearchByStockId);
            this.Controls.Add(this.InputStockId);
            this.Name = "Form1";
            this.Text = "Form1";
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox InputStockId;
        private System.Windows.Forms.Button SearchByStockId;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox InputDate;
        private System.Windows.Forms.Button SearchByDate;
        private System.Windows.Forms.TextBox TimeConsume;
        private System.Windows.Forms.Label label3;
    }
}

