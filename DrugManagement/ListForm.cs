﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Xml.Linq;

namespace DrugManagement
{
    public partial class ListForm : Form
    {
        public ListForm()
        {
            InitializeComponent();

            // DBから一覧取得
            DBConnection dbcon = new DBConnection();  // 接続用のインスタンスを作成
            DataTable datatableDrugs = dbcon.getDrugsData();  // データテーブル取得
            gridDrugs.DataSource = datatableDrugs;  // データテーブルをgridのDatasourceプロパティに設定

            // 検索結果数表示
            int HitsOfSearches = datatableDrugs.Rows.Count;  // データテーブルの行数を保存
            lblHits.Text = HitsOfSearches.ToString() + "件";  // 設定

            // セルの編集可能
            foreach (DataGridViewColumn column in gridDrugs.Columns)  // すべての列をいったん編集不可に
            {
                column.ReadOnly = true;
            }
            gridDrugs.Columns["在庫数"].ReadOnly = false;  // 特定カラムのみ編集可能

            // 詳細ボタン設定
            DataGridViewButtonColumn columnDetail = new DataGridViewButtonColumn();  // 詳細ボタン列を作成
            columnDetail.HeaderText = "詳細";  // ヘッダー名設定
            columnDetail.Text = "詳細";  // ボタンの中に表示するテキスト設定
            columnDetail.UseColumnTextForButtonValue = true;  // ボタンの中のテキストを表示する設定をONにする。(これをしないとまっさらなボタンになる。)
            gridDrugs.Columns.Add(columnDetail);  // 行を追加
            // セルの背景色変更
            gridDrugs.Columns["在庫数"].DefaultCellStyle.BackColor = Color.AliceBlue;
        }

        // イベント
        private void txtOnlyInt(object sender, KeyPressEventArgs e)
        {
            // 数字（0-9）, バックスペース, デリートキーの場合は許可
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar))
            {
                e.Handled = true;  // イベントを処理済みとしてマークし、入力を無視
            }
        }

        /// <summary>
        /// 検索ボタン
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnSearch_Click(object sender, EventArgs e)
        {
            // 条件取得
            MessageBox.Show($"nudStockNum.Text: {nudStockNum.Text}, nudStockNum.Value: {nudStockNum.Value}");

            // 検索関数に投げる
            DBConnection dbcon = new DBConnection();  // インスタンス生成
            DataTable dataTable = dbcon.getDrugsData(txtName.Text, cmbCategory.Text, nudStockNum.Text, txtPriceAbove.Text, txtPriceBelow.Text);
            //MessageBox.Show($"薬品名{txtName.Text}, カテゴリ{cmbCategory.Text}, 在庫の表示{nudStockNum.Text}, 下限{txtPriceAbove.Text}, 上限{txtPriceBelow.Text}, 在庫の値{nudStockNum.Value}");
            gridDrugs.DataSource = dataTable;  // データテーブルをgridのDataSourceプロパティに設定し反映させる。

            // 検索結果数表示
            if (dataTable.Rows == null)
            {
                lblHits.Text = dataTable.Rows.Count + "0件";
            }
            else
            {
                lblHits.Text = dataTable.Rows.Count.ToString() + "件";
            }

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

        private void btnDataUpd_Click(object sender, EventArgs e)
        {

        }

        private void btnCancelListForm_Click(object sender, EventArgs e)
        {

        }
    }
}
