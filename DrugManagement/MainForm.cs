namespace DrugManagement
{
    public partial class MainForm : Form
    {
        public MainForm()
        {
            InitializeComponent();
        }

        private void btnDrugList_Click(object sender, EventArgs e)
        {
            ListForm listForm = new ListForm();  // インスタンス生成
            listForm.ShowDialog();  // ウィンドウ作成
        }

        private void btnRegistWin_Click(object sender, EventArgs e)
        {
            RegistrationForm registrationForm = new RegistrationForm();
            registrationForm.ShowDialog();
        }
    }
}
