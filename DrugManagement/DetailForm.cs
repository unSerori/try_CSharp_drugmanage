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
            // 詳細データを取得
            DBConnection dbcon = new DBConnection();  // インスタンス生成
            DataTable dataTable = dbcon.getDbugData(_no);  // 詳細データをデータテーブル形式で取得

            // TODO: ボタンを変更

            // TODO: 取得した値を反映
            // 取得された値をtxtにセット
            txtName.Text = dataTable.Rows[0].ItemArray[1].ToString();
            txtCategory.Text = dataTable.Rows[0].ItemArray[2].ToString();
            txtPrice.Text = dataTable.Rows[0].ItemArray[3].ToString();
            txtStock.Text = dataTable.Rows[0].ItemArray[4].ToString();
            txtExplanation.Text = dataTable.Rows[0].ItemArray[5].ToString();
            // 画像パスを取得し、
            string imgPath = Path.Combine(  // 引数の文字列をパスの形に成型する。  
                Path.GetDirectoryName(Application.ExecutablePath),  // EXEまでのパス,
                "assets", "images",  // assetsフォルダ名, 
                dataTable.Rows[0].ItemArray[6].ToString()  // 画像ファイル名
            );
            // picに設定
            picDrug.Image = Image.FromFile(imgPath);  // ファイルから読み込む。
            picDrug.SizeMode = PictureBoxSizeMode.Zoom;  // サイズの調整
        }

        private void btnL_Click(object sender, EventArgs e)
        {

        }

        private void btnR_Click(object sender, EventArgs e)
        {

        }

        private void txtCategory_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
