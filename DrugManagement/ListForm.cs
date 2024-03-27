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
    public partial class ListForm : Form
    {
        public ListForm()
        {
            InitializeComponent();

            // DBから一覧取得
            DBConnection dbcon = new DBConnection();  // 接続用のインスタンスを作成
            DataTable datatableDrugs = dbcon.getDrugsData("drugs");  // データテーブル取得
            gridDrugs.DataSource = datatableDrugs;  // データテーブルをgridのDatasourceプロパティに設定

            // 検索結果数表示
            int HitsOfSearches = datatableDrugs.Rows.Count;  // データテーブルの行数を保存
            lblHits.Text = HitsOfSearches.ToString() + "件";  // 設定

            // 詳細ボタン設定
            DataGridViewButtonColumn columnDetail = new DataGridViewButtonColumn();  // 詳細ボタン列を作成
            columnDetail.HeaderText = "詳細";  // ヘッダー名設定
            columnDetail.Text = "詳細";  // ボタンの中に表示するテキスト設定
            columnDetail.UseColumnTextForButtonValue = true;  // ボタンの中のテキストを表示する設定をONにする。(これをしないとまっさらなボタンになる。)
            gridDrugs.Columns.Add(columnDetail);  // 行を追加
            // 背景色変更
            gridDrugs.Columns["在庫数"].DefaultCellStyle.BackColor = Color.AliceBlue;
        }

        private void btnSearch_Click(object sender, EventArgs e)
        {
            MessageBox.Show($"薬品名{txtName.Text}, カテゴリ{cmbCategory.Text}, 在庫の表示{nudStockNum.Text}, 下限{txtPriceAbove.Text}, 上限{txtPriceBelow.Text}, 在庫の値{nudStockNum.Value}");
        }

        /// <summary>
        /// 検索条件クリア
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnClear_Click(object sender, EventArgs e)
        {
            txtName.Text = "";  // 薬品名クリア
            cmbCategory.Text = "";  // カテゴリクリア
            nudStockNum.Text = "";  // 表示をクリア
            txtPriceAbove.Text = "";  // 値段の下限クリア
            txtPriceBelow.Text = "";  // 値段の上限クリア
        }

        // グリッドツール(詳細ボタンに限定)をクリックした時の処理
        private void gridDrugs_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            // 特定の要素に限定する
            if (e.RowIndex < 0) { return; }  // 列ヘッダーをクリックした場合などにキャンセルする。
            if (gridDrugs.Columns[e.ColumnIndex].HeaderText != "詳細") { return; }  // 特定要素以外の列をクリックした場合もキャンセルする。

            // 引数に渡し遷移
            int drugNo = int.Parse(gridDrugs.Rows[e.RowIndex].Cells["薬品番号"].Value.ToString());
            // 詳細画面のインスタンス
        }
    }
}
