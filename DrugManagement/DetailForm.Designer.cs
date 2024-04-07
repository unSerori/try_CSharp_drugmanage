namespace DrugManagement
{
    partial class DetailForm
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
            lblName = new Label();
            lblCategory = new Label();
            lblPrice = new Label();
            lblStock = new Label();
            lblExplanation = new Label();
            picDrug = new PictureBox();
            btnL = new Button();
            btnR = new Button();
            txtName = new TextBox();
            txtCategory = new TextBox();
            txtPrice = new TextBox();
            txtStock = new TextBox();
            txtExplanation = new TextBox();
            ((System.ComponentModel.ISupportInitialize)picDrug).BeginInit();
            SuspendLayout();
            // 
            // lblName
            // 
            lblName.AutoSize = true;
            lblName.Location = new Point(24, 9);
            lblName.Name = "lblName";
            lblName.Size = new Size(52, 15);
            lblName.TabIndex = 0;
            lblName.Text = "薬品名 : ";
            // 
            // lblCategory
            // 
            lblCategory.AutoSize = true;
            lblCategory.Location = new Point(25, 47);
            lblCategory.Name = "lblCategory";
            lblCategory.Size = new Size(51, 15);
            lblCategory.TabIndex = 1;
            lblCategory.Text = "カテゴリ : ";
            // 
            // lblPrice
            // 
            lblPrice.AutoSize = true;
            lblPrice.Location = new Point(36, 86);
            lblPrice.Name = "lblPrice";
            lblPrice.Size = new Size(40, 15);
            lblPrice.TabIndex = 2;
            lblPrice.Text = "金額 : ";
            // 
            // lblStock
            // 
            lblStock.AutoSize = true;
            lblStock.Location = new Point(24, 123);
            lblStock.Name = "lblStock";
            lblStock.Size = new Size(52, 15);
            lblStock.TabIndex = 3;
            lblStock.Text = "在庫数 : ";
            // 
            // lblExplanation
            // 
            lblExplanation.AutoSize = true;
            lblExplanation.Location = new Point(12, 219);
            lblExplanation.Name = "lblExplanation";
            lblExplanation.Size = new Size(64, 15);
            lblExplanation.TabIndex = 4;
            lblExplanation.Text = "商品説明 : ";
            // 
            // picDrug
            // 
            picDrug.Location = new Point(293, 35);
            picDrug.Name = "picDrug";
            picDrug.Size = new Size(249, 199);
            picDrug.TabIndex = 5;
            picDrug.TabStop = false;
            // 
            // btnL
            // 
            btnL.Font = new Font("Yu Gothic UI", 12F);
            btnL.Location = new Point(12, 389);
            btnL.Name = "btnL";
            btnL.Size = new Size(128, 49);
            btnL.TabIndex = 6;
            btnL.Text = "<<";
            btnL.UseVisualStyleBackColor = true;
            btnL.Click += btnL_Click;
            // 
            // btnR
            // 
            btnR.Font = new Font("Yu Gothic UI", 12F);
            btnR.Location = new Point(414, 389);
            btnR.Name = "btnR";
            btnR.Size = new Size(128, 49);
            btnR.TabIndex = 7;
            btnR.Text = ">>";
            btnR.UseVisualStyleBackColor = true;
            btnR.Click += btnR_Click;
            // 
            // txtName
            // 
            txtName.Location = new Point(82, 6);
            txtName.Name = "txtName";
            txtName.ReadOnly = true;
            txtName.Size = new Size(460, 23);
            txtName.TabIndex = 8;
            txtName.TabStop = false;
            // 
            // txtCategory
            // 
            txtCategory.Location = new Point(82, 44);
            txtCategory.Name = "txtCategory";
            txtCategory.ReadOnly = true;
            txtCategory.Size = new Size(192, 23);
            txtCategory.TabIndex = 9;
            txtCategory.TabStop = false;
            // 
            // txtPrice
            // 
            txtPrice.Location = new Point(82, 83);
            txtPrice.Name = "txtPrice";
            txtPrice.ReadOnly = true;
            txtPrice.Size = new Size(192, 23);
            txtPrice.TabIndex = 10;
            txtPrice.TabStop = false;
            // 
            // txtStock
            // 
            txtStock.Location = new Point(82, 120);
            txtStock.Name = "txtStock";
            txtStock.ReadOnly = true;
            txtStock.Size = new Size(192, 23);
            txtStock.TabIndex = 11;
            txtStock.TabStop = false;
            // 
            // txtExplanation
            // 
            txtExplanation.Location = new Point(12, 237);
            txtExplanation.Multiline = true;
            txtExplanation.Name = "txtExplanation";
            txtExplanation.ReadOnly = true;
            txtExplanation.Size = new Size(530, 146);
            txtExplanation.TabIndex = 12;
            txtExplanation.TabStop = false;
            // 
            // DetailForm
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(554, 450);
            Controls.Add(txtExplanation);
            Controls.Add(txtStock);
            Controls.Add(txtPrice);
            Controls.Add(txtCategory);
            Controls.Add(txtName);
            Controls.Add(btnR);
            Controls.Add(btnL);
            Controls.Add(picDrug);
            Controls.Add(lblExplanation);
            Controls.Add(lblStock);
            Controls.Add(lblPrice);
            Controls.Add(lblCategory);
            Controls.Add(lblName);
            Name = "DetailForm";
            Text = "DetailForm";
            ((System.ComponentModel.ISupportInitialize)picDrug).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label lblName;
        private Label lblCategory;
        private Label lblPrice;
        private Label lblStock;
        private Label lblExplanation;
        private PictureBox picDrug;
        private Button btnL;
        private Button btnR;
        private TextBox txtName;
        private TextBox txtCategory;
        private TextBox txtPrice;
        private TextBox txtStock;
        private TextBox txtExplanation;
    }
}