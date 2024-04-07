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
        private int _index;  // ウィンドウのインスタンスに現在の図鑑番号を持たせる
        private DataTable _dataTalbe;  // 前後の薬品と薬品データ群の端を知るために一覧データを保持

        /// <summary>
        /// Constructor
        /// </summary>
        /// <param name="no"></param>
        /// <param name="dataTable"></param>
        public DetailForm(int index, DataTable dataTable)
        {
            InitializeComponent();  // 画面デザインの初期化

            // ウィンドウに持たせるフィールドを初期化
            this._index = index;  // 現在の薬品番号を
            this._dataTalbe = dataTable;

            InitializeFormWithData();  // 画面作成
        }

        /// <summary>
        /// 
        /// </summary>
        private void InitializeFormWithData()
        {
            // データの取得と反映
            getAndSetData();

            // ボタンの状態を適切に変化
            setButtonVisible();
        }

        /// <summary>
        /// フィールドの薬品番号から詳細データを取得し反映させる。
        /// </summary>
        private void getAndSetData()
        {
            // 詳細データを取得
            DBConnection dbcon = new DBConnection();  // インスタンス生成
            DataTable dataTable = dbcon.getDbugData(Convert.ToInt32(_dataTalbe.Rows[_index].ItemArray[0]));  // 詳細データをデータテーブル形式で取得  // 検索一覧配列からindexで指定した要素のnoを取得して

            // 取得した値を反映
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

        /// <summary>
        /// 現在の薬品が最初か最後ならボタンを非表示にする
        /// </summary>
        private void setButtonVisible()
        {
            //MessageBox.Show(_no.ToString());
            // 行番号が最小値0なら左の要素に移動できないので非表示
            btnL.Visible = _index == 0? false : true;
            // 行番号が最大値_dataTable.Rows.Count -1なら右の要素に移動できないので非表示
            btnR.Visible = _index == _dataTalbe.Rows.Count -1? false : true;
        }

        /// <summary>
        /// 「<<」ボタンの処理
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnL_Click(object sender, EventArgs e)
        {
            _index--;  // フィールドの薬品番号を更新
            InitializeFormWithData();  // 画面の初期化
        }

        /// <summary>
        /// 「>>」ボタンの処理
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnR_Click(object sender, EventArgs e)
        {
            _index++;  // フィールドの薬品番号を更新
            InitializeFormWithData();  // 画面の初期化
        }
    }
}
