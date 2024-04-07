using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace DrugManagement
{
    public partial class DetailForm : Form
    {
        // fields
        private int _no;  // ウィンドウのインスタンスに現在の図鑑番号を持たせる

        public DetailForm(int no)
        {
            InitializeComponent();

            this._no = no;

            InitializeFormWithData();  // 画面作成
        }

        /// <summary>
        /// 
        /// </summary>
        private void InitializeFormWithData()
        {
            
        }

        private void btnL_Click(object sender, EventArgs e)
        {

        }

        private void btnR_Click(object sender, EventArgs e)
        {

        }
    }
}
