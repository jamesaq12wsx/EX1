namespace EX1
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
            this.nameLable = new System.Windows.Forms.Label();
            this.nameTextBox = new System.Windows.Forms.TextBox();
            this.productsCheckListBox = new System.Windows.Forms.CheckedListBox();
            this.sendButton = new System.Windows.Forms.Button();
            this.productACnt = new System.Windows.Forms.NumericUpDown();
            this.productBCnt = new System.Windows.Forms.NumericUpDown();
            this.productCCnt = new System.Windows.Forms.NumericUpDown();
            this.productDCnt = new System.Windows.Forms.NumericUpDown();
            this.productECnt = new System.Windows.Forms.NumericUpDown();
            ((System.ComponentModel.ISupportInitialize)(this.productACnt)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.productBCnt)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.productCCnt)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.productDCnt)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.productECnt)).BeginInit();
            this.SuspendLayout();
            // 
            // nameLable
            // 
            this.nameLable.AutoSize = true;
            this.nameLable.Location = new System.Drawing.Point(151, 43);
            this.nameLable.Name = "nameLable";
            this.nameLable.Size = new System.Drawing.Size(56, 15);
            this.nameLable.TabIndex = 0;
            this.nameLable.Text = "購買人:";
            // 
            // nameTextBox
            // 
            this.nameTextBox.Location = new System.Drawing.Point(294, 40);
            this.nameTextBox.Name = "nameTextBox";
            this.nameTextBox.Size = new System.Drawing.Size(125, 25);
            this.nameTextBox.TabIndex = 1;
            this.nameTextBox.Text = "請輸入姓名";
            // 
            // productsCheckListBox
            // 
            this.productsCheckListBox.AccessibleName = "";
            this.productsCheckListBox.BackColor = System.Drawing.SystemColors.ScrollBar;
            this.productsCheckListBox.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.productsCheckListBox.Font = new System.Drawing.Font("MS Reference Sans Serif", 14F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.productsCheckListBox.FormattingEnabled = true;
            this.productsCheckListBox.Items.AddRange(new object[] {
            "商品A，金額$200",
            "商品B，金額$350",
            "商品C，金額$530",
            "商品D，金額$700",
            "商品E，金額$430"});
            this.productsCheckListBox.Location = new System.Drawing.Point(49, 124);
            this.productsCheckListBox.Name = "productsCheckListBox";
            this.productsCheckListBox.Size = new System.Drawing.Size(320, 218);
            this.productsCheckListBox.TabIndex = 2;
            // 
            // sendButton
            // 
            this.sendButton.Location = new System.Drawing.Point(426, 111);
            this.sendButton.Name = "sendButton";
            this.sendButton.Size = new System.Drawing.Size(95, 45);
            this.sendButton.TabIndex = 3;
            this.sendButton.Text = "送出";
            this.sendButton.UseVisualStyleBackColor = true;
            this.sendButton.Click += new System.EventHandler(this.button1_Click);
            // 
            // productACnt
            // 
            this.productACnt.Location = new System.Drawing.Point(332, 131);
            this.productACnt.Name = "productACnt";
            this.productACnt.Size = new System.Drawing.Size(38, 25);
            this.productACnt.TabIndex = 4;
            this.productACnt.Value = new decimal(new int[] {
            1,
            0,
            0,
            0});
            // 
            // productBCnt
            // 
            this.productBCnt.Location = new System.Drawing.Point(333, 162);
            this.productBCnt.Name = "productBCnt";
            this.productBCnt.Size = new System.Drawing.Size(37, 25);
            this.productBCnt.TabIndex = 5;
            this.productBCnt.Value = new decimal(new int[] {
            1,
            0,
            0,
            0});
            // 
            // productCCnt
            // 
            this.productCCnt.Location = new System.Drawing.Point(333, 193);
            this.productCCnt.Name = "productCCnt";
            this.productCCnt.Size = new System.Drawing.Size(38, 25);
            this.productCCnt.TabIndex = 6;
            this.productCCnt.Value = new decimal(new int[] {
            1,
            0,
            0,
            0});
            // 
            // productDCnt
            // 
            this.productDCnt.Location = new System.Drawing.Point(334, 224);
            this.productDCnt.Name = "productDCnt";
            this.productDCnt.Size = new System.Drawing.Size(37, 25);
            this.productDCnt.TabIndex = 7;
            this.productDCnt.Value = new decimal(new int[] {
            1,
            0,
            0,
            0});
            // 
            // productECnt
            // 
            this.productECnt.Location = new System.Drawing.Point(334, 255);
            this.productECnt.Name = "productECnt";
            this.productECnt.Size = new System.Drawing.Size(38, 25);
            this.productECnt.TabIndex = 8;
            this.productECnt.Value = new decimal(new int[] {
            1,
            0,
            0,
            0});
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(543, 394);
            this.Controls.Add(this.productECnt);
            this.Controls.Add(this.productDCnt);
            this.Controls.Add(this.productCCnt);
            this.Controls.Add(this.productBCnt);
            this.Controls.Add(this.productACnt);
            this.Controls.Add(this.sendButton);
            this.Controls.Add(this.productsCheckListBox);
            this.Controls.Add(this.nameTextBox);
            this.Controls.Add(this.nameLable);
            this.Name = "Form1";
            this.Text = "購物車";
            ((System.ComponentModel.ISupportInitialize)(this.productACnt)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.productBCnt)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.productCCnt)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.productDCnt)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.productECnt)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label nameLable;
        private System.Windows.Forms.TextBox nameTextBox;
        private System.Windows.Forms.CheckedListBox productsCheckListBox;
        private System.Windows.Forms.Button sendButton;
        private System.Windows.Forms.NumericUpDown productACnt;
        private System.Windows.Forms.NumericUpDown productBCnt;
        private System.Windows.Forms.NumericUpDown productCCnt;
        private System.Windows.Forms.NumericUpDown productDCnt;
        private System.Windows.Forms.NumericUpDown productECnt;
    }
}

