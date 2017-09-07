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
            this.productsGroupBoxA = new System.Windows.Forms.GroupBox();
            this.label1 = new System.Windows.Forms.Label();
            this.productAUpDown = new System.Windows.Forms.NumericUpDown();
            this.productBUpDown = new System.Windows.Forms.NumericUpDown();
            this.productCUpDown = new System.Windows.Forms.NumericUpDown();
            this.productDUpDown = new System.Windows.Forms.NumericUpDown();
            this.productEUpDown = new System.Windows.Forms.NumericUpDown();
            this.productACheckBox = new System.Windows.Forms.CheckBox();
            this.productBCheckBox = new System.Windows.Forms.CheckBox();
            this.productCCheckBox = new System.Windows.Forms.CheckBox();
            this.productDCheckBox = new System.Windows.Forms.CheckBox();
            this.productECheckBox = new System.Windows.Forms.CheckBox();
            this.productsGroupBoxB = new System.Windows.Forms.GroupBox();
            this.label2 = new System.Windows.Forms.Label();
            this.numericUpDown1 = new System.Windows.Forms.NumericUpDown();
            this.numericUpDown2 = new System.Windows.Forms.NumericUpDown();
            this.numericUpDown3 = new System.Windows.Forms.NumericUpDown();
            this.numericUpDown4 = new System.Windows.Forms.NumericUpDown();
            this.productHCheckBox = new System.Windows.Forms.CheckBox();
            this.productICheckBox = new System.Windows.Forms.CheckBox();
            this.productJCheckBox = new System.Windows.Forms.CheckBox();
            this.productKCheckBox = new System.Windows.Forms.CheckBox();
            this.productsGroupBoxC = new System.Windows.Forms.GroupBox();
            this.label3 = new System.Windows.Forms.Label();
            this.numericUpDown6 = new System.Windows.Forms.NumericUpDown();
            this.numericUpDown7 = new System.Windows.Forms.NumericUpDown();
            this.numericUpDown8 = new System.Windows.Forms.NumericUpDown();
            this.numericUpDown9 = new System.Windows.Forms.NumericUpDown();
            this.numericUpDown10 = new System.Windows.Forms.NumericUpDown();
            this.productOCheckBox = new System.Windows.Forms.CheckBox();
            this.productPCheckBox = new System.Windows.Forms.CheckBox();
            this.productQCheckBox = new System.Windows.Forms.CheckBox();
            this.productRCheckBox = new System.Windows.Forms.CheckBox();
            this.productSCheckBox = new System.Windows.Forms.CheckBox();
            ((System.ComponentModel.ISupportInitialize)(this.productACnt)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.productBCnt)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.productCCnt)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.productDCnt)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.productECnt)).BeginInit();
            this.productsGroupBoxA.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.productAUpDown)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.productBUpDown)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.productCUpDown)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.productDUpDown)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.productEUpDown)).BeginInit();
            this.productsGroupBoxB.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDown1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDown2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDown3)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDown4)).BeginInit();
            this.productsGroupBoxC.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDown6)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDown7)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDown8)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDown9)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDown10)).BeginInit();
            this.SuspendLayout();
            // 
            // nameLable
            // 
            this.nameLable.AutoSize = true;
            this.nameLable.Location = new System.Drawing.Point(375, 46);
            this.nameLable.Name = "nameLable";
            this.nameLable.Size = new System.Drawing.Size(56, 15);
            this.nameLable.TabIndex = 0;
            this.nameLable.Text = "購買人:";
            // 
            // nameTextBox
            // 
            this.nameTextBox.Location = new System.Drawing.Point(565, 42);
            this.nameTextBox.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.nameTextBox.Name = "nameTextBox";
            this.nameTextBox.Size = new System.Drawing.Size(125, 25);
            this.nameTextBox.TabIndex = 1;
            this.nameTextBox.Text = "請輸入姓名";
            // 
            // sendButton
            // 
            this.sendButton.Location = new System.Drawing.Point(460, 364);
            this.sendButton.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
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
            this.productACnt.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.productACnt.Name = "productACnt";
            this.productACnt.Size = new System.Drawing.Size(37, 25);
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
            this.productBCnt.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
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
            this.productCCnt.Location = new System.Drawing.Point(333, 192);
            this.productCCnt.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.productCCnt.Name = "productCCnt";
            this.productCCnt.Size = new System.Drawing.Size(37, 25);
            this.productCCnt.TabIndex = 6;
            this.productCCnt.Value = new decimal(new int[] {
            1,
            0,
            0,
            0});
            // 
            // productDCnt
            // 
            this.productDCnt.Location = new System.Drawing.Point(333, 224);
            this.productDCnt.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
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
            this.productECnt.Location = new System.Drawing.Point(333, 255);
            this.productECnt.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.productECnt.Name = "productECnt";
            this.productECnt.Size = new System.Drawing.Size(37, 25);
            this.productECnt.TabIndex = 8;
            this.productECnt.Value = new decimal(new int[] {
            1,
            0,
            0,
            0});
            // 
            // productsGroupBoxA
            // 
            this.productsGroupBoxA.Controls.Add(this.label1);
            this.productsGroupBoxA.Controls.Add(this.productAUpDown);
            this.productsGroupBoxA.Controls.Add(this.productBUpDown);
            this.productsGroupBoxA.Controls.Add(this.productCUpDown);
            this.productsGroupBoxA.Controls.Add(this.productDUpDown);
            this.productsGroupBoxA.Controls.Add(this.productEUpDown);
            this.productsGroupBoxA.Controls.Add(this.productACheckBox);
            this.productsGroupBoxA.Controls.Add(this.productBCheckBox);
            this.productsGroupBoxA.Controls.Add(this.productCCheckBox);
            this.productsGroupBoxA.Controls.Add(this.productDCheckBox);
            this.productsGroupBoxA.Controls.Add(this.productECheckBox);
            this.productsGroupBoxA.Location = new System.Drawing.Point(57, 132);
            this.productsGroupBoxA.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.productsGroupBoxA.Name = "productsGroupBoxA";
            this.productsGroupBoxA.Padding = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.productsGroupBoxA.Size = new System.Drawing.Size(315, 221);
            this.productsGroupBoxA.TabIndex = 9;
            this.productsGroupBoxA.TabStop = false;
            this.productsGroupBoxA.Text = "甲區商品";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.ForeColor = System.Drawing.Color.Red;
            this.label1.Location = new System.Drawing.Point(93, 192);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(157, 15);
            this.label1.TabIndex = 17;
            this.label1.Text = "總金額滿1000(含)打9折";
            // 
            // productAUpDown
            // 
            this.productAUpDown.Location = new System.Drawing.Point(197, 28);
            this.productAUpDown.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
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
            // productBUpDown
            // 
            this.productBUpDown.Location = new System.Drawing.Point(199, 58);
            this.productBUpDown.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
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
            // productCUpDown
            // 
            this.productCUpDown.Location = new System.Drawing.Point(199, 88);
            this.productCUpDown.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
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
            // productDUpDown
            // 
            this.productDUpDown.Location = new System.Drawing.Point(199, 118);
            this.productDUpDown.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
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
            // productEUpDown
            // 
            this.productEUpDown.Location = new System.Drawing.Point(199, 148);
            this.productEUpDown.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
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
            // productACheckBox
            // 
            this.productACheckBox.AutoSize = true;
            this.productACheckBox.Font = new System.Drawing.Font("新細明體", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.productACheckBox.Location = new System.Drawing.Point(5, 24);
            this.productACheckBox.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.productACheckBox.Name = "productACheckBox";
            this.productACheckBox.Size = new System.Drawing.Size(181, 24);
            this.productACheckBox.TabIndex = 10;
            this.productACheckBox.Text = "商品A，金額$200";
            this.productACheckBox.UseVisualStyleBackColor = true;
            // 
            // productBCheckBox
            // 
            this.productBCheckBox.AutoSize = true;
            this.productBCheckBox.Font = new System.Drawing.Font("新細明體", 12F);
            this.productBCheckBox.Location = new System.Drawing.Point(5, 54);
            this.productBCheckBox.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.productBCheckBox.Name = "productBCheckBox";
            this.productBCheckBox.Size = new System.Drawing.Size(180, 24);
            this.productBCheckBox.TabIndex = 11;
            this.productBCheckBox.Text = "商品B，金額$350";
            this.productBCheckBox.UseVisualStyleBackColor = true;
            // 
            // productCCheckBox
            // 
            this.productCCheckBox.AutoSize = true;
            this.productCCheckBox.Font = new System.Drawing.Font("新細明體", 12F);
            this.productCCheckBox.Location = new System.Drawing.Point(5, 84);
            this.productCCheckBox.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.productCCheckBox.Name = "productCCheckBox";
            this.productCCheckBox.Size = new System.Drawing.Size(180, 24);
            this.productCCheckBox.TabIndex = 11;
            this.productCCheckBox.Text = "商品C，金額$530";
            this.productCCheckBox.UseVisualStyleBackColor = true;
            // 
            // productDCheckBox
            // 
            this.productDCheckBox.AutoSize = true;
            this.productDCheckBox.Font = new System.Drawing.Font("新細明體", 12F);
            this.productDCheckBox.Location = new System.Drawing.Point(5, 114);
            this.productDCheckBox.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.productDCheckBox.Name = "productDCheckBox";
            this.productDCheckBox.Size = new System.Drawing.Size(181, 24);
            this.productDCheckBox.TabIndex = 11;
            this.productDCheckBox.Text = "商品D，金額$700";
            this.productDCheckBox.UseVisualStyleBackColor = true;
            // 
            // productECheckBox
            // 
            this.productECheckBox.AutoSize = true;
            this.productECheckBox.Font = new System.Drawing.Font("新細明體", 12F);
            this.productECheckBox.Location = new System.Drawing.Point(5, 144);
            this.productECheckBox.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.productECheckBox.Name = "productECheckBox";
            this.productECheckBox.Size = new System.Drawing.Size(178, 24);
            this.productECheckBox.TabIndex = 11;
            this.productECheckBox.Text = "商品E，金額$430";
            this.productECheckBox.UseVisualStyleBackColor = true;
            // 
            // productsGroupBoxB
            // 
            this.productsGroupBoxB.Controls.Add(this.label2);
            this.productsGroupBoxB.Controls.Add(this.numericUpDown1);
            this.productsGroupBoxB.Controls.Add(this.numericUpDown2);
            this.productsGroupBoxB.Controls.Add(this.numericUpDown3);
            this.productsGroupBoxB.Controls.Add(this.numericUpDown4);
            this.productsGroupBoxB.Controls.Add(this.productHCheckBox);
            this.productsGroupBoxB.Controls.Add(this.productICheckBox);
            this.productsGroupBoxB.Controls.Add(this.productJCheckBox);
            this.productsGroupBoxB.Controls.Add(this.productKCheckBox);
            this.productsGroupBoxB.Location = new System.Drawing.Point(377, 132);
            this.productsGroupBoxB.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.productsGroupBoxB.Name = "productsGroupBoxB";
            this.productsGroupBoxB.Padding = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.productsGroupBoxB.Size = new System.Drawing.Size(315, 221);
            this.productsGroupBoxB.TabIndex = 10;
            this.productsGroupBoxB.TabStop = false;
            this.productsGroupBoxB.Text = "乙區商品";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.ForeColor = System.Drawing.Color.Red;
            this.label2.Location = new System.Drawing.Point(92, 192);
            this.label2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(197, 15);
            this.label2.TabIndex = 18;
            this.label2.Text = "買五個商品(含)以上打八五折";
            // 
            // numericUpDown1
            // 
            this.numericUpDown1.Location = new System.Drawing.Point(197, 28);
            this.numericUpDown1.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.numericUpDown1.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.numericUpDown1.Name = "numericUpDown1";
            this.numericUpDown1.Size = new System.Drawing.Size(72, 25);
            this.numericUpDown1.TabIndex = 12;
            this.numericUpDown1.Value = new decimal(new int[] {
            1,
            0,
            0,
            0});
            // 
            // numericUpDown2
            // 
            this.numericUpDown2.Location = new System.Drawing.Point(199, 58);
            this.numericUpDown2.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.numericUpDown2.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.numericUpDown2.Name = "numericUpDown2";
            this.numericUpDown2.Size = new System.Drawing.Size(72, 25);
            this.numericUpDown2.TabIndex = 13;
            this.numericUpDown2.Value = new decimal(new int[] {
            1,
            0,
            0,
            0});
            // 
            // numericUpDown3
            // 
            this.numericUpDown3.Location = new System.Drawing.Point(199, 88);
            this.numericUpDown3.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.numericUpDown3.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.numericUpDown3.Name = "numericUpDown3";
            this.numericUpDown3.Size = new System.Drawing.Size(72, 25);
            this.numericUpDown3.TabIndex = 14;
            this.numericUpDown3.Value = new decimal(new int[] {
            1,
            0,
            0,
            0});
            // 
            // numericUpDown4
            // 
            this.numericUpDown4.Location = new System.Drawing.Point(199, 118);
            this.numericUpDown4.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.numericUpDown4.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.numericUpDown4.Name = "numericUpDown4";
            this.numericUpDown4.Size = new System.Drawing.Size(72, 25);
            this.numericUpDown4.TabIndex = 15;
            this.numericUpDown4.Value = new decimal(new int[] {
            1,
            0,
            0,
            0});
            // 
            // productHCheckBox
            // 
            this.productHCheckBox.AutoSize = true;
            this.productHCheckBox.Font = new System.Drawing.Font("新細明體", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.productHCheckBox.Location = new System.Drawing.Point(5, 24);
            this.productHCheckBox.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.productHCheckBox.Name = "productHCheckBox";
            this.productHCheckBox.Size = new System.Drawing.Size(181, 24);
            this.productHCheckBox.TabIndex = 10;
            this.productHCheckBox.Text = "商品H，金額$420";
            this.productHCheckBox.UseVisualStyleBackColor = true;
            // 
            // productICheckBox
            // 
            this.productICheckBox.AutoSize = true;
            this.productICheckBox.Font = new System.Drawing.Font("新細明體", 12F);
            this.productICheckBox.Location = new System.Drawing.Point(5, 54);
            this.productICheckBox.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.productICheckBox.Name = "productICheckBox";
            this.productICheckBox.Size = new System.Drawing.Size(173, 24);
            this.productICheckBox.TabIndex = 11;
            this.productICheckBox.Text = "商品I，金額$300";
            this.productICheckBox.UseVisualStyleBackColor = true;
            // 
            // productJCheckBox
            // 
            this.productJCheckBox.AutoSize = true;
            this.productJCheckBox.Font = new System.Drawing.Font("新細明體", 12F);
            this.productJCheckBox.Location = new System.Drawing.Point(5, 84);
            this.productJCheckBox.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.productJCheckBox.Name = "productJCheckBox";
            this.productJCheckBox.Size = new System.Drawing.Size(174, 24);
            this.productJCheckBox.TabIndex = 11;
            this.productJCheckBox.Text = "商品J，金額$450";
            this.productJCheckBox.UseVisualStyleBackColor = true;
            // 
            // productKCheckBox
            // 
            this.productKCheckBox.AutoSize = true;
            this.productKCheckBox.Font = new System.Drawing.Font("新細明體", 12F);
            this.productKCheckBox.Location = new System.Drawing.Point(5, 114);
            this.productKCheckBox.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.productKCheckBox.Name = "productKCheckBox";
            this.productKCheckBox.Size = new System.Drawing.Size(181, 24);
            this.productKCheckBox.TabIndex = 11;
            this.productKCheckBox.Text = "商品K，金額$670";
            this.productKCheckBox.UseVisualStyleBackColor = true;
            // 
            // productsGroupBoxC
            // 
            this.productsGroupBoxC.Controls.Add(this.label3);
            this.productsGroupBoxC.Controls.Add(this.numericUpDown6);
            this.productsGroupBoxC.Controls.Add(this.numericUpDown7);
            this.productsGroupBoxC.Controls.Add(this.numericUpDown8);
            this.productsGroupBoxC.Controls.Add(this.numericUpDown9);
            this.productsGroupBoxC.Controls.Add(this.numericUpDown10);
            this.productsGroupBoxC.Controls.Add(this.productOCheckBox);
            this.productsGroupBoxC.Controls.Add(this.productPCheckBox);
            this.productsGroupBoxC.Controls.Add(this.productQCheckBox);
            this.productsGroupBoxC.Controls.Add(this.productRCheckBox);
            this.productsGroupBoxC.Controls.Add(this.productSCheckBox);
            this.productsGroupBoxC.Location = new System.Drawing.Point(707, 132);
            this.productsGroupBoxC.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.productsGroupBoxC.Name = "productsGroupBoxC";
            this.productsGroupBoxC.Padding = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.productsGroupBoxC.Size = new System.Drawing.Size(315, 221);
            this.productsGroupBoxC.TabIndex = 11;
            this.productsGroupBoxC.TabStop = false;
            this.productsGroupBoxC.Text = "丙區商品";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.ForeColor = System.Drawing.Color.Red;
            this.label3.Location = new System.Drawing.Point(51, 192);
            this.label3.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(211, 15);
            this.label3.TabIndex = 18;
            this.label3.Text = "買二送一，兩種商品(含)打95折";
            // 
            // numericUpDown6
            // 
            this.numericUpDown6.Location = new System.Drawing.Point(197, 28);
            this.numericUpDown6.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.numericUpDown6.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.numericUpDown6.Name = "numericUpDown6";
            this.numericUpDown6.Size = new System.Drawing.Size(72, 25);
            this.numericUpDown6.TabIndex = 12;
            this.numericUpDown6.Value = new decimal(new int[] {
            1,
            0,
            0,
            0});
            // 
            // numericUpDown7
            // 
            this.numericUpDown7.Location = new System.Drawing.Point(199, 58);
            this.numericUpDown7.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.numericUpDown7.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.numericUpDown7.Name = "numericUpDown7";
            this.numericUpDown7.Size = new System.Drawing.Size(72, 25);
            this.numericUpDown7.TabIndex = 13;
            this.numericUpDown7.Value = new decimal(new int[] {
            1,
            0,
            0,
            0});
            // 
            // numericUpDown8
            // 
            this.numericUpDown8.Location = new System.Drawing.Point(199, 88);
            this.numericUpDown8.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.numericUpDown8.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.numericUpDown8.Name = "numericUpDown8";
            this.numericUpDown8.Size = new System.Drawing.Size(72, 25);
            this.numericUpDown8.TabIndex = 14;
            this.numericUpDown8.Value = new decimal(new int[] {
            1,
            0,
            0,
            0});
            // 
            // numericUpDown9
            // 
            this.numericUpDown9.Location = new System.Drawing.Point(199, 118);
            this.numericUpDown9.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.numericUpDown9.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.numericUpDown9.Name = "numericUpDown9";
            this.numericUpDown9.Size = new System.Drawing.Size(72, 25);
            this.numericUpDown9.TabIndex = 15;
            this.numericUpDown9.Value = new decimal(new int[] {
            1,
            0,
            0,
            0});
            // 
            // numericUpDown10
            // 
            this.numericUpDown10.Location = new System.Drawing.Point(199, 148);
            this.numericUpDown10.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.numericUpDown10.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.numericUpDown10.Name = "numericUpDown10";
            this.numericUpDown10.Size = new System.Drawing.Size(72, 25);
            this.numericUpDown10.TabIndex = 16;
            this.numericUpDown10.Value = new decimal(new int[] {
            1,
            0,
            0,
            0});
            // 
            // productOCheckBox
            // 
            this.productOCheckBox.AutoSize = true;
            this.productOCheckBox.Font = new System.Drawing.Font("新細明體", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.productOCheckBox.Location = new System.Drawing.Point(5, 24);
            this.productOCheckBox.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.productOCheckBox.Name = "productOCheckBox";
            this.productOCheckBox.Size = new System.Drawing.Size(181, 24);
            this.productOCheckBox.TabIndex = 10;
            this.productOCheckBox.Text = "商品O，金額$850";
            this.productOCheckBox.UseVisualStyleBackColor = true;
            // 
            // productPCheckBox
            // 
            this.productPCheckBox.AutoSize = true;
            this.productPCheckBox.Font = new System.Drawing.Font("新細明體", 12F);
            this.productPCheckBox.Location = new System.Drawing.Point(5, 54);
            this.productPCheckBox.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.productPCheckBox.Name = "productPCheckBox";
            this.productPCheckBox.Size = new System.Drawing.Size(177, 24);
            this.productPCheckBox.TabIndex = 11;
            this.productPCheckBox.Text = "商品P，金額$130";
            this.productPCheckBox.UseVisualStyleBackColor = true;
            // 
            // productQCheckBox
            // 
            this.productQCheckBox.AutoSize = true;
            this.productQCheckBox.Font = new System.Drawing.Font("新細明體", 12F);
            this.productQCheckBox.Location = new System.Drawing.Point(5, 84);
            this.productQCheckBox.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.productQCheckBox.Name = "productQCheckBox";
            this.productQCheckBox.Size = new System.Drawing.Size(181, 24);
            this.productQCheckBox.TabIndex = 11;
            this.productQCheckBox.Text = "商品Q，金額$260";
            this.productQCheckBox.UseVisualStyleBackColor = true;
            // 
            // productRCheckBox
            // 
            this.productRCheckBox.AutoSize = true;
            this.productRCheckBox.Font = new System.Drawing.Font("新細明體", 12F);
            this.productRCheckBox.Location = new System.Drawing.Point(5, 114);
            this.productRCheckBox.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.productRCheckBox.Name = "productRCheckBox";
            this.productRCheckBox.Size = new System.Drawing.Size(180, 24);
            this.productRCheckBox.TabIndex = 11;
            this.productRCheckBox.Text = "商品R，金額$330";
            this.productRCheckBox.UseVisualStyleBackColor = true;
            // 
            // productSCheckBox
            // 
            this.productSCheckBox.AutoSize = true;
            this.productSCheckBox.Font = new System.Drawing.Font("新細明體", 12F);
            this.productSCheckBox.Location = new System.Drawing.Point(5, 144);
            this.productSCheckBox.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.productSCheckBox.Name = "productSCheckBox";
            this.productSCheckBox.Size = new System.Drawing.Size(177, 24);
            this.productSCheckBox.TabIndex = 11;
            this.productSCheckBox.Text = "商品S，金額$740";
            this.productSCheckBox.UseVisualStyleBackColor = true;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1036, 422);
            this.Controls.Add(this.productsGroupBoxC);
            this.Controls.Add(this.productsGroupBoxB);
            this.Controls.Add(this.productsGroupBoxA);
            this.Controls.Add(this.productECnt);
            this.Controls.Add(this.productDCnt);
            this.Controls.Add(this.productCCnt);
            this.Controls.Add(this.productBCnt);
            this.Controls.Add(this.productACnt);
            this.Controls.Add(this.sendButton);
            this.Controls.Add(this.nameTextBox);
            this.Controls.Add(this.nameLable);
            this.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.Name = "Form1";
            this.Text = "購物車";
            ((System.ComponentModel.ISupportInitialize)(this.productACnt)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.productBCnt)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.productCCnt)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.productDCnt)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.productECnt)).EndInit();
            this.productsGroupBoxA.ResumeLayout(false);
            this.productsGroupBoxA.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.productAUpDown)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.productBUpDown)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.productCUpDown)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.productDUpDown)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.productEUpDown)).EndInit();
            this.productsGroupBoxB.ResumeLayout(false);
            this.productsGroupBoxB.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDown1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDown2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDown3)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDown4)).EndInit();
            this.productsGroupBoxC.ResumeLayout(false);
            this.productsGroupBoxC.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDown6)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDown7)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDown8)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDown9)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDown10)).EndInit();
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
        private System.Windows.Forms.GroupBox productsGroupBoxA;
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
        private System.Windows.Forms.GroupBox productsGroupBoxB;
        private System.Windows.Forms.NumericUpDown numericUpDown1;
        private System.Windows.Forms.NumericUpDown numericUpDown2;
        private System.Windows.Forms.NumericUpDown numericUpDown3;
        private System.Windows.Forms.NumericUpDown numericUpDown4;
        private System.Windows.Forms.CheckBox productHCheckBox;
        private System.Windows.Forms.CheckBox productICheckBox;
        private System.Windows.Forms.CheckBox productJCheckBox;
        private System.Windows.Forms.CheckBox productKCheckBox;
        private System.Windows.Forms.GroupBox productsGroupBoxC;
        private System.Windows.Forms.NumericUpDown numericUpDown6;
        private System.Windows.Forms.NumericUpDown numericUpDown7;
        private System.Windows.Forms.NumericUpDown numericUpDown8;
        private System.Windows.Forms.NumericUpDown numericUpDown9;
        private System.Windows.Forms.NumericUpDown numericUpDown10;
        private System.Windows.Forms.CheckBox productOCheckBox;
        private System.Windows.Forms.CheckBox productPCheckBox;
        private System.Windows.Forms.CheckBox productQCheckBox;
        private System.Windows.Forms.CheckBox productRCheckBox;
        private System.Windows.Forms.CheckBox productSCheckBox;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
    }
}

