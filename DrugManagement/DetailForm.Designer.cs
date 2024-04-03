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
            pictureBox1 = new PictureBox();
            btnL = new Button();
            btnR = new Button();
            textBox1 = new TextBox();
            textBox2 = new TextBox();
            textBox3 = new TextBox();
            textBox4 = new TextBox();
            textBox5 = new TextBox();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
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
            // pictureBox1
            // 
            pictureBox1.Location = new Point(293, 35);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(249, 199);
            pictureBox1.TabIndex = 5;
            pictureBox1.TabStop = false;
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
            // 
            // textBox1
            // 
            textBox1.Location = new Point(82, 6);
            textBox1.Name = "textBox1";
            textBox1.ReadOnly = true;
            textBox1.Size = new Size(460, 23);
            textBox1.TabIndex = 8;
            textBox1.TabStop = false;
            // 
            // textBox2
            // 
            textBox2.Location = new Point(82, 44);
            textBox2.Name = "textBox2";
            textBox2.ReadOnly = true;
            textBox2.Size = new Size(192, 23);
            textBox2.TabIndex = 9;
            textBox2.TabStop = false;
            // 
            // textBox3
            // 
            textBox3.Location = new Point(82, 83);
            textBox3.Name = "textBox3";
            textBox3.ReadOnly = true;
            textBox3.Size = new Size(192, 23);
            textBox3.TabIndex = 10;
            textBox3.TabStop = false;
            // 
            // textBox4
            // 
            textBox4.Location = new Point(82, 120);
            textBox4.Name = "textBox4";
            textBox4.ReadOnly = true;
            textBox4.Size = new Size(192, 23);
            textBox4.TabIndex = 11;
            textBox4.TabStop = false;
            // 
            // textBox5
            // 
            textBox5.Location = new Point(12, 237);
            textBox5.Multiline = true;
            textBox5.Name = "textBox5";
            textBox5.ReadOnly = true;
            textBox5.Size = new Size(530, 146);
            textBox5.TabIndex = 12;
            textBox5.TabStop = false;
            // 
            // DetailForm
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(554, 450);
            Controls.Add(textBox5);
            Controls.Add(textBox4);
            Controls.Add(textBox3);
            Controls.Add(textBox2);
            Controls.Add(textBox1);
            Controls.Add(btnR);
            Controls.Add(btnL);
            Controls.Add(pictureBox1);
            Controls.Add(lblExplanation);
            Controls.Add(lblStock);
            Controls.Add(lblPrice);
            Controls.Add(lblCategory);
            Controls.Add(lblName);
            Name = "DetailForm";
            Text = "DetailForm";
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label lblName;
        private Label lblCategory;
        private Label lblPrice;
        private Label lblStock;
        private Label lblExplanation;
        private PictureBox pictureBox1;
        private Button btnL;
        private Button btnR;
        private TextBox textBox1;
        private TextBox textBox2;
        private TextBox textBox3;
        private TextBox textBox4;
        private TextBox textBox5;
    }
}