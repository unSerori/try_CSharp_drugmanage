namespace DrugManagement
{
    partial class ListForm
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            gbxSearch = new GroupBox();
            txtMoneyBelow = new TextBox();
            txtMoneyAbove = new TextBox();
            txtName = new TextBox();
            btnClear = new Button();
            btnSearch = new Button();
            lblTo = new Label();
            lblMoney = new Label();
            lblStockBelow = new Label();
            lblStock = new Label();
            lblCategory = new Label();
            lblName = new Label();
            grddDrugs = new DataGridView();
            lblHits = new Label();
            cmbCategory = new ComboBox();
            nudStockNum = new NumericUpDown();
            gbxSearch.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)grddDrugs).BeginInit();
            ((System.ComponentModel.ISupportInitialize)nudStockNum).BeginInit();
            SuspendLayout();
            // 
            // gbxSearch
            // 
            gbxSearch.Controls.Add(nudStockNum);
            gbxSearch.Controls.Add(cmbCategory);
            gbxSearch.Controls.Add(txtMoneyBelow);
            gbxSearch.Controls.Add(lblStockBelow);
            gbxSearch.Controls.Add(txtMoneyAbove);
            gbxSearch.Controls.Add(txtName);
            gbxSearch.Controls.Add(btnClear);
            gbxSearch.Controls.Add(btnSearch);
            gbxSearch.Controls.Add(lblTo);
            gbxSearch.Controls.Add(lblMoney);
            gbxSearch.Controls.Add(lblStock);
            gbxSearch.Controls.Add(lblCategory);
            gbxSearch.Controls.Add(lblName);
            gbxSearch.Location = new Point(12, 12);
            gbxSearch.Name = "gbxSearch";
            gbxSearch.Size = new Size(776, 146);
            gbxSearch.TabIndex = 0;
            gbxSearch.TabStop = false;
            gbxSearch.Text = "検索条件";
            // 
            // txtMoneyBelow
            // 
            txtMoneyBelow.Location = new Point(401, 35);
            txtMoneyBelow.Name = "txtMoneyBelow";
            txtMoneyBelow.Size = new Size(100, 23);
            txtMoneyBelow.TabIndex = 11;
            // 
            // txtMoneyAbove
            // 
            txtMoneyAbove.Location = new Point(274, 35);
            txtMoneyAbove.Name = "txtMoneyAbove";
            txtMoneyAbove.Size = new Size(100, 23);
            txtMoneyAbove.TabIndex = 10;
            // 
            // txtName
            // 
            txtName.Location = new Point(96, 35);
            txtName.Name = "txtName";
            txtName.Size = new Size(100, 23);
            txtName.TabIndex = 8;
            // 
            // btnClear
            // 
            btnClear.Location = new Point(686, 105);
            btnClear.Name = "btnClear";
            btnClear.Size = new Size(75, 23);
            btnClear.TabIndex = 7;
            btnClear.Text = "クリア";
            btnClear.UseVisualStyleBackColor = true;
            // 
            // btnSearch
            // 
            btnSearch.Location = new Point(605, 105);
            btnSearch.Name = "btnSearch";
            btnSearch.Size = new Size(75, 23);
            btnSearch.TabIndex = 6;
            btnSearch.Text = "検索";
            btnSearch.UseVisualStyleBackColor = true;
            // 
            // lblTo
            // 
            lblTo.AutoSize = true;
            lblTo.Location = new Point(380, 38);
            lblTo.Name = "lblTo";
            lblTo.Size = new Size(15, 15);
            lblTo.TabIndex = 5;
            lblTo.Text = "~";
            // 
            // lblMoney
            // 
            lblMoney.AutoSize = true;
            lblMoney.Location = new Point(228, 38);
            lblMoney.Name = "lblMoney";
            lblMoney.Size = new Size(40, 15);
            lblMoney.TabIndex = 4;
            lblMoney.Text = "金額 : ";
            // 
            // lblStockBelow
            // 
            lblStockBelow.AutoSize = true;
            lblStockBelow.Location = new Point(165, 96);
            lblStockBelow.Name = "lblStockBelow";
            lblStockBelow.Size = new Size(31, 15);
            lblStockBelow.TabIndex = 3;
            lblStockBelow.Text = "以下";
            // 
            // lblStock
            // 
            lblStock.AutoSize = true;
            lblStock.Location = new Point(38, 96);
            lblStock.Name = "lblStock";
            lblStock.Size = new Size(52, 15);
            lblStock.TabIndex = 2;
            lblStock.Text = "在庫数 : ";
            // 
            // lblCategory
            // 
            lblCategory.AutoSize = true;
            lblCategory.Location = new Point(39, 67);
            lblCategory.Name = "lblCategory";
            lblCategory.Size = new Size(51, 15);
            lblCategory.TabIndex = 1;
            lblCategory.Text = "カテゴリ : ";
            // 
            // lblName
            // 
            lblName.AutoSize = true;
            lblName.Location = new Point(38, 38);
            lblName.Name = "lblName";
            lblName.Size = new Size(52, 15);
            lblName.TabIndex = 0;
            lblName.Text = "薬品名 : ";
            // 
            // grddDrugs
            // 
            grddDrugs.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            grddDrugs.Location = new Point(12, 179);
            grddDrugs.Name = "grddDrugs";
            grddDrugs.Size = new Size(776, 259);
            grddDrugs.TabIndex = 1;
            // 
            // lblHits
            // 
            lblHits.AutoSize = true;
            lblHits.Location = new Point(750, 161);
            lblHits.Name = "lblHits";
            lblHits.Size = new Size(25, 15);
            lblHits.TabIndex = 2;
            lblHits.Text = "0件";
            // 
            // cmbCategory
            // 
            cmbCategory.FormattingEnabled = true;
            cmbCategory.Location = new Point(96, 64);
            cmbCategory.Name = "cmbCategory";
            cmbCategory.Size = new Size(100, 23);
            cmbCategory.TabIndex = 12;
            // 
            // nudStockNum
            // 
            nudStockNum.Location = new Point(96, 93);
            nudStockNum.Name = "nudStockNum";
            nudStockNum.Size = new Size(63, 23);
            nudStockNum.TabIndex = 13;
            // 
            // ListForm
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(lblHits);
            Controls.Add(grddDrugs);
            Controls.Add(gbxSearch);
            Name = "ListForm";
            Text = "一覧画面";
            gbxSearch.ResumeLayout(false);
            gbxSearch.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)grddDrugs).EndInit();
            ((System.ComponentModel.ISupportInitialize)nudStockNum).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private GroupBox gbxSearch;
        private Label lblName;
        private Label lblTo;
        private Label lblMoney;
        private Label lblStockBelow;
        private Label lblStock;
        private Label lblCategory;
        private TextBox txtMoneyBelow;
        private TextBox txtMoneyAbove;
        private TextBox txtName;
        private Button btnClear;
        private Button btnSearch;
        private DataGridView grddDrugs;
        private Label lblHits;
        private ComboBox cmbCategory;
        private NumericUpDown nudStockNum;
    }
}