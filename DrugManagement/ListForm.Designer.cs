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
            nudStockNum = new NumericUpDown();
            cmbCategory = new ComboBox();
            txtPriceBelow = new TextBox();
            lblStockBelow = new Label();
            txtPriceAbove = new TextBox();
            txtName = new TextBox();
            btnClear = new Button();
            btnSearch = new Button();
            lblPriceTo = new Label();
            lblPrice = new Label();
            lblStock = new Label();
            lblCategory = new Label();
            lblName = new Label();
            gridDrugs = new DataGridView();
            lblHits = new Label();
            button1 = new Button();
            button2 = new Button();
            gbxSearch.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)nudStockNum).BeginInit();
            ((System.ComponentModel.ISupportInitialize)gridDrugs).BeginInit();
            SuspendLayout();
            // 
            // gbxSearch
            // 
            gbxSearch.Controls.Add(nudStockNum);
            gbxSearch.Controls.Add(cmbCategory);
            gbxSearch.Controls.Add(txtPriceBelow);
            gbxSearch.Controls.Add(lblStockBelow);
            gbxSearch.Controls.Add(txtPriceAbove);
            gbxSearch.Controls.Add(txtName);
            gbxSearch.Controls.Add(btnClear);
            gbxSearch.Controls.Add(btnSearch);
            gbxSearch.Controls.Add(lblPriceTo);
            gbxSearch.Controls.Add(lblPrice);
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
            // nudStockNum
            // 
            nudStockNum.Location = new Point(96, 93);
            nudStockNum.Name = "nudStockNum";
            nudStockNum.Size = new Size(63, 23);
            nudStockNum.TabIndex = 13;
            // 
            // cmbCategory
            // 
            cmbCategory.FormattingEnabled = true;
            cmbCategory.Items.AddRange(new object[] { "医薬品・医薬部外品", "化粧品", "日用品" });
            cmbCategory.Location = new Point(96, 64);
            cmbCategory.Name = "cmbCategory";
            cmbCategory.Size = new Size(100, 23);
            cmbCategory.TabIndex = 12;
            // 
            // txtPriceBelow
            // 
            txtPriceBelow.Location = new Point(401, 35);
            txtPriceBelow.Name = "txtPriceBelow";
            txtPriceBelow.Size = new Size(100, 23);
            txtPriceBelow.TabIndex = 11;
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
            // txtPriceAbove
            // 
            txtPriceAbove.Location = new Point(274, 35);
            txtPriceAbove.Name = "txtPriceAbove";
            txtPriceAbove.Size = new Size(100, 23);
            txtPriceAbove.TabIndex = 10;
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
            btnClear.Click += btnClear_Click;
            // 
            // btnSearch
            // 
            btnSearch.Location = new Point(605, 105);
            btnSearch.Name = "btnSearch";
            btnSearch.Size = new Size(75, 23);
            btnSearch.TabIndex = 6;
            btnSearch.Text = "検索";
            btnSearch.UseVisualStyleBackColor = true;
            btnSearch.Click += btnSearch_Click;
            // 
            // lblPriceTo
            // 
            lblPriceTo.AutoSize = true;
            lblPriceTo.Location = new Point(380, 38);
            lblPriceTo.Name = "lblPriceTo";
            lblPriceTo.Size = new Size(15, 15);
            lblPriceTo.TabIndex = 5;
            lblPriceTo.Text = "~";
            // 
            // lblPrice
            // 
            lblPrice.AutoSize = true;
            lblPrice.Location = new Point(228, 38);
            lblPrice.Name = "lblPrice";
            lblPrice.Size = new Size(40, 15);
            lblPrice.TabIndex = 4;
            lblPrice.Text = "金額 : ";
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
            // gridDrugs
            // 
            gridDrugs.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            gridDrugs.Location = new Point(12, 179);
            gridDrugs.Name = "gridDrugs";
            gridDrugs.Size = new Size(776, 230);
            gridDrugs.TabIndex = 1;
            gridDrugs.CellContentClick += gridDrugs_CellContentClick;
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
            // button1
            // 
            button1.Location = new Point(632, 415);
            button1.Name = "button1";
            button1.Size = new Size(75, 23);
            button1.TabIndex = 3;
            button1.Text = "button1";
            button1.UseVisualStyleBackColor = true;
            // 
            // button2
            // 
            button2.Location = new Point(713, 415);
            button2.Name = "button2";
            button2.Size = new Size(75, 23);
            button2.TabIndex = 4;
            button2.Text = "button2";
            button2.UseVisualStyleBackColor = true;
            // 
            // ListForm
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(button2);
            Controls.Add(button1);
            Controls.Add(lblHits);
            Controls.Add(gridDrugs);
            Controls.Add(gbxSearch);
            Name = "ListForm";
            Text = "一覧画面";
            gbxSearch.ResumeLayout(false);
            gbxSearch.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)nudStockNum).EndInit();
            ((System.ComponentModel.ISupportInitialize)gridDrugs).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private GroupBox gbxSearch;
        private Label lblName;
        private Label lblPriceTo;
        private Label lblPrice;
        private Label lblStockBelow;
        private Label lblStock;
        private Label lblCategory;
        private TextBox txtPriceBelow;
        private TextBox txtPriceAbove;
        private TextBox txtName;
        private Button btnClear;
        private Button btnSearch;
        private DataGridView gridDrugs;
        private Label lblHits;
        private ComboBox cmbCategory;
        private NumericUpDown nudStockNum;
        private Button button1;
        private Button button2;
    }
}