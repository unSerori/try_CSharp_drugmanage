namespace DrugManagement
{
    partial class MainForm
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            pnlDrugManage = new Panel();
            lblDrugManage = new Label();
            btnDrugList = new Button();
            btnRegistWin = new Button();
            pnlDrugManage.SuspendLayout();
            SuspendLayout();
            // 
            // pnlDrugManage
            // 
            pnlDrugManage.BackColor = Color.Cyan;
            pnlDrugManage.Controls.Add(lblDrugManage);
            pnlDrugManage.Location = new Point(0, 0);
            pnlDrugManage.Name = "pnlDrugManage";
            pnlDrugManage.Size = new Size(800, 220);
            pnlDrugManage.TabIndex = 0;
            // 
            // lblDrugManage
            // 
            lblDrugManage.AutoSize = true;
            lblDrugManage.Font = new Font("Yu Gothic UI", 50F);
            lblDrugManage.Location = new Point(166, 66);
            lblDrugManage.Name = "lblDrugManage";
            lblDrugManage.Size = new Size(513, 89);
            lblDrugManage.TabIndex = 0;
            lblDrugManage.Text = "薬剤管理システム";
            // 
            // btnDrugList
            // 
            btnDrugList.Font = new Font("Yu Gothic UI", 15F);
            btnDrugList.Location = new Point(310, 259);
            btnDrugList.Name = "btnDrugList";
            btnDrugList.Size = new Size(162, 58);
            btnDrugList.TabIndex = 1;
            btnDrugList.Text = "薬剤一覧";
            btnDrugList.UseVisualStyleBackColor = true;
            btnDrugList.Click += btnDrugList_Click;
            // 
            // btnRegistWin
            // 
            btnRegistWin.Font = new Font("Yu Gothic UI", 15F);
            btnRegistWin.Location = new Point(310, 335);
            btnRegistWin.Name = "btnRegistWin";
            btnRegistWin.Size = new Size(162, 58);
            btnRegistWin.TabIndex = 3;
            btnRegistWin.Text = "商品登録";
            btnRegistWin.UseVisualStyleBackColor = true;
            btnRegistWin.Click += btnRegistWin_Click;
            // 
            // MainForm
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(btnRegistWin);
            Controls.Add(btnDrugList);
            Controls.Add(pnlDrugManage);
            Name = "MainForm";
            Text = "トップ画面";
            pnlDrugManage.ResumeLayout(false);
            pnlDrugManage.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private Panel pnlDrugManage;
        private Label lblDrugManage;
        private Button btnDrugList;
        private Button btnRegistWin;
    }
}
