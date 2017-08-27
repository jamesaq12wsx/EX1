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
            this.sendButton = new System.Windows.Forms.Button();
            this.productACnt = new System.Windows.Forms.NumericUpDown();
            this.productBCnt = new System.Windows.Forms.NumericUpDown();
            this.productCCnt = new System.Windows.Forms.NumericUpDown();
            this.productDCnt = new System.Windows.Forms.NumericUpDown();
            this.productECnt = new System.Windows.Forms.NumericUpDown();
            this.productsGroupBox = new System.Windows.Forms.GroupBox();
            this.productEUpDown = new System.Windows.Forms.NumericUpDown();
            this.productDUpDown = new System.Windows.Forms.NumericUpDown();
            this.productCUpDown = new System.Windows.Forms.NumericUpDown();
            this.productBUpDown = new System.Windows.Forms.NumericUpDown();
            this.productAUpDown = new System.Windows.Forms.NumericUpDown();
            this.productECheckBox = new System.Windows.Forms.CheckBox();
            this.productDCheckBox = new System.Windows.Forms.CheckBox();
            this.productCCheckBox = new System.Windows.Forms.CheckBox();
            this.productBCheckBox = new System.Windows.Forms.CheckBox();
            this.productACheckBox = new System.Windows.Forms.CheckBox();
            ((System.ComponentModel.ISupportInitialize)(this.productACnt)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.productBCnt)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.productCCnt)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.productDCnt)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.productECnt)).BeginInit();
            this.productsGroupBox.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.productEUpDown)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.productDUpDown)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.productCUpDown)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.productBUpDown)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.productAUpDown)).BeginInit();
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
            // sendButton
            // 
            this.sendButton.Location = new System.Drawing.Point(423, 211);
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
            // productsGroupBox
            // 
            this.productsGroupBox.Controls.Add(this.productEUpDown);
            this.productsGroupBox.Controls.Add(this.productDUpDown);
            this.productsGroupBox.Controls.Add(this.productCUpDown);
            this.productsGroupBox.Controls.Add(this.productBUpDown);
            this.productsGroupBox.Controls.Add(this.productAUpDown);
            this.productsGroupBox.Controls.Add(this.productECheckBox);
            this.productsGroupBox.Controls.Add(this.productDCheckBox);
            this.productsGroupBox.Controls.Add(this.productCCheckBox);
            this.productsGroupBox.Controls.Add(this.productBCheckBox);
            this.productsGroupBox.Controls.Add(this.productACheckBox);
            this.productsGroupBox.Location = new System.Drawing.Point(57, 132);
            this.productsGroupBox.Name = "productsGroupBox";
            this.productsGroupBox.Size = new System.Drawing.Size(315, 221);
            this.productsGroupBox.TabIndex = 9;
            this.productsGroupBox.TabStop = false;
            this.productsGroupBox.Text = "商品欄";
            // 
            // productEUpDown
            // 
            this.productEUpDown.Location = new System.Drawing.Point(199, 147);
            this.productEUpDown.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.productEUpDown.Name = "productEUpDown";
            this.productEUpDown.Size = new System.Drawing.Size(72, 25);
            this.productEUpDown.TabIndex = 16;
            this.productEUpDown.Value = new decimal(new int[] {
            1,
            0,
            0,
            0});
            // 
            // productDUpDown
            // 
            this.productDUpDown.Location = new System.Drawing.Point(199, 117);
            this.productDUpDown.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.productDUpDown.Name = "productDUpDown";
            this.productDUpDown.Size = new System.Drawing.Size(72, 25);
            this.productDUpDown.TabIndex = 15;
            this.productDUpDown.Value = new decimal(new int[] {
            1,
            0,
            0,
            0});
            // 
            // productCUpDown
            // 
            this.productCUpDown.Location = new System.Drawing.Point(199, 87);
            this.productCUpDown.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.productCUpDown.Name = "productCUpDown";
            this.productCUpDown.Size = new System.Drawing.Size(72, 25);
            this.productCUpDown.TabIndex = 14;
            this.productCUpDown.Value = new decimal(new int[] {
            1,
            0,
            0,
            0});
            // 
            // productBUpDown
            // 
            this.productBUpDown.Location = new System.Drawing.Point(199, 57);
            this.productBUpDown.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.productBUpDown.Name = "productBUpDown";
            this.productBUpDown.Size = new System.Drawing.Size(72, 25);
            this.productBUpDown.TabIndex = 13;
            this.productBUpDown.Value = new decimal(new int[] {
            1,
            0,
            0,
            0});
            // 
            // productAUpDown
            // 
            this.productAUpDown.Location = new System.Drawing.Point(198, 27);
            this.productAUpDown.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.productAUpDown.Name = "productAUpDown";
            this.productAUpDown.Size = new System.Drawing.Size(72, 25);
            this.productAUpDown.TabIndex = 12;
            this.productAUpDown.Value = new decimal(new int[] {
            1,
            0,
            0,
            0});
            // 
            // productECheckBox
            // 
            this.productECheckBox.AutoSize = true;
            this.productECheckBox.Font = new System.Drawing.Font("新細明體", 12F);
            this.productECheckBox.Location = new System.Drawing.Point(6, 144);
            this.productECheckBox.Name = "productECheckBox";
            this.productECheckBox.Size = new System.Drawing.Size(178, 24);
            this.productECheckBox.TabIndex = 11;
            this.productECheckBox.Text = "商品E，金額$430";
            this.productECheckBox.UseVisualStyleBackColor = true;
            // 
            // productDCheckBox
            // 
            this.productDCheckBox.AutoSize = true;
            this.productDCheckBox.Font = new System.Drawing.Font("新細明體", 12F);
            this.productDCheckBox.Location = new System.Drawing.Point(6, 114);
            this.productDCheckBox.Name = "productDCheckBox";
            this.productDCheckBox.Size = new System.Drawing.Size(181, 24);
            this.productDCheckBox.TabIndex = 11;
            this.productDCheckBox.Text = "商品D，金額$700";
            this.productDCheckBox.UseVisualStyleBackColor = true;
            // 
            // productCCheckBox
            // 
            this.productCCheckBox.AutoSize = true;
            this.productCCheckBox.Font = new System.Drawing.Font("新細明體", 12F);
            this.productCCheckBox.Location = new System.Drawing.Point(6, 84);
            this.productCCheckBox.Name = "productCCheckBox";
            this.productCCheckBox.Size = new System.Drawing.Size(180, 24);
            this.productCCheckBox.TabIndex = 11;
            this.productCCheckBox.Text = "商緊C，金額$530";
            this.productCCheckBox.UseVisualStyleBackColor = true;
            // 
            // productBCheckBox
            // 
            this.productBCheckBox.AutoSize = true;
            this.productBCheckBox.Font = new System.Drawing.Font("新細明體", 12F);
            this.productBCheckBox.Location = new System.Drawing.Point(6, 54);
            this.productBCheckBox.Name = "productBCheckBox";
            this.productBCheckBox.Size = new System.Drawing.Size(180, 24);
            this.productBCheckBox.TabIndex = 11;
            this.productBCheckBox.Text = "商品B，金額$350";
            this.productBCheckBox.UseVisualStyleBackColor = true;
            // 
            // productACheckBox
            // 
            this.productACheckBox.AutoSize = true;
            this.productACheckBox.Font = new System.Drawing.Font("新細明體", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.productACheckBox.Location = new System.Drawing.Point(6, 24);
            this.productACheckBox.Name = "productACheckBox";
            this.productACheckBox.Size = new System.Drawing.Size(181, 24);
            this.productACheckBox.TabIndex = 10;
            this.productACheckBox.Text = "商品A，金額$200";
            this.productACheckBox.UseVisualStyleBackColor = true;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(543, 394);
            this.Controls.Add(this.productsGroupBox);
            this.Controls.Add(this.productECnt);
            this.Controls.Add(this.productDCnt);
            this.Controls.Add(this.productCCnt);
            this.Controls.Add(this.productBCnt);
            this.Controls.Add(this.productACnt);
            this.Controls.Add(this.sendButton);
            this.Controls.Add(this.nameTextBox);
            this.Controls.Add(this.nameLable);
            this.Name = "Form1";
            this.Text = "購物車";
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.productACnt)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.productBCnt)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.productCCnt)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.productDCnt)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.productECnt)).EndInit();
            this.productsGroupBox.ResumeLayout(false);
            this.productsGroupBox.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.productEUpDown)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.productDUpDown)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.productCUpDown)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.productBUpDown)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.productAUpDown)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label nameLable;
        private System.Windows.Forms.TextBox nameTextBox;
        private System.Windows.Forms.Button sendButton;
        private System.Windows.Forms.NumericUpDown productACnt;
        private System.Windows.Forms.NumericUpDown productBCnt;
        private System.Windows.Forms.NumericUpDown productCCnt;
        private System.Windows.Forms.NumericUpDown productDCnt;
        private System.Windows.Forms.NumericUpDown productECnt;
        private System.Windows.Forms.GroupBox productsGroupBox;
        private System.Windows.Forms.NumericUpDown productEUpDown;
        private System.Windows.Forms.NumericUpDown productDUpDown;
        private System.Windows.Forms.NumericUpDown productCUpDown;
        private System.Windows.Forms.NumericUpDown productBUpDown;
        private System.Windows.Forms.NumericUpDown productAUpDown;
        private System.Windows.Forms.CheckBox productECheckBox;
        private System.Windows.Forms.CheckBox productDCheckBox;
        private System.Windows.Forms.CheckBox productCCheckBox;
        private System.Windows.Forms.CheckBox productBCheckBox;
        private System.Windows.Forms.CheckBox productACheckBox;
    }
}

