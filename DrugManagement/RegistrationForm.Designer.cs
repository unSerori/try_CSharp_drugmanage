namespace DrugManagement
{
    partial class RegistrationForm
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
            btnSelectionFile = new Button();
            btnImport = new Button();
            lblFilePath = new Label();
            txtFilePath = new TextBox();
            lblNote = new Label();
            lblNotePath = new Label();
            SuspendLayout();
            // 
            // btnSelectionFile
            // 
            btnSelectionFile.Location = new Point(12, 12);
            btnSelectionFile.Name = "btnSelectionFile";
            btnSelectionFile.Size = new Size(776, 70);
            btnSelectionFile.TabIndex = 0;
            btnSelectionFile.Text = "ファイル選択";
            btnSelectionFile.UseVisualStyleBackColor = true;
            // 
            // btnImport
            // 
            btnImport.Location = new Point(12, 155);
            btnImport.Name = "btnImport";
            btnImport.Size = new Size(776, 70);
            btnImport.TabIndex = 1;
            btnImport.Text = "インポート";
            btnImport.UseVisualStyleBackColor = true;
            // 
            // lblFilePath
            // 
            lblFilePath.AutoSize = true;
            lblFilePath.Location = new Point(23, 94);
            lblFilePath.Name = "lblFilePath";
            lblFilePath.Size = new Size(69, 15);
            lblFilePath.TabIndex = 2;
            lblFilePath.Text = "ファイルパス : ";
            // 
            // txtFilePath
            // 
            txtFilePath.Location = new Point(98, 91);
            txtFilePath.Name = "txtFilePath";
            txtFilePath.Size = new Size(690, 23);
            txtFilePath.TabIndex = 3;
            // 
            // lblNote
            // 
            lblNote.AutoSize = true;
            lblNote.ForeColor = Color.Red;
            lblNote.Location = new Point(23, 117);
            lblNote.Name = "lblNote";
            lblNote.Size = new Size(375, 15);
            lblNote.TabIndex = 4;
            lblNote.Text = "※画像を設定する場合は以下のフォルダに画像ファイルの格納をお願いします。";
            // 
            // lblNotePath
            // 
            lblNotePath.AutoSize = true;
            lblNotePath.ForeColor = Color.Red;
            lblNotePath.Location = new Point(23, 132);
            lblNotePath.Name = "lblNotePath";
            lblNotePath.Size = new Size(31, 15);
            lblNotePath.TabIndex = 5;
            lblNotePath.Text = "path";
            // 
            // RegistrationForm
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 237);
            Controls.Add(lblNotePath);
            Controls.Add(lblNote);
            Controls.Add(txtFilePath);
            Controls.Add(lblFilePath);
            Controls.Add(btnImport);
            Controls.Add(btnSelectionFile);
            Name = "RegistrationForm";
            Text = "RegistrationForm";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button btnSelectionFile;
        private Button btnImport;
        private Label lblFilePath;
        private TextBox txtFilePath;
        private Label lblNote;
        private Label lblNotePath;
    }
}