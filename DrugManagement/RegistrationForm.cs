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
    public partial class RegistrationForm : Form
    {
        public RegistrationForm()
        {
            InitializeComponent();

            // 注釈を設定
            lblNote.Text = "※画像を設定する場合は以下のフォルダに格納をお願いします。";
            lblNotePath.Text = Path.Combine(Path.GetDirectoryName(Application.ExecutablePath), "assets", "images");
        }

        /// <summary>
        /// ファイル選択ボタン押下時の処理
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnSelectionFile_Click(object sender, EventArgs e)
        {
            // ファイル選択ダイアログ
            OpenFileDialog ofd = new OpenFileDialog();  // ファイル選択ダイアログのインスタンス
            // 各種設定
            ofd.Title = "ファイルを開く";  // ダイアログ名
            ofd.InitialDirectory = @"C:\";  // 初期フォルダ  // エスケープシーケンス@
            ofd.Filter = "CSVファイル(*.csv)| *.csv";  // 選択できる拡張子をフィルタ
            ofd.FilterIndex = 1;  // 初期の拡張子

            DialogResult result = ofd.ShowDialog();  // ダイアログを表示 ダイアログからの返り血をresultに保存


            // ダイアログのボタンの判定
            if(result == DialogResult.OK)  // OKボタン押下時の処理
            {
                txtFilePath.Text = ofd.FileName;  // 取得したファイルのパスをテキストボックスに設定
            }
            else if(result == DialogResult.Cancel)  // キャンセルボタン押下時の処理
            {
                return;  // 選択ボタン押下処理から登録画面に戻る
            }
        }

        /// <summary>
        /// 登録ボタン
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnImport_Click(object sender, EventArgs e)
        {
            string filePath = txtFilePath.Text;  // ファイル選択または手打ちのパスを取得

            // DB接続
            DBConnection dbcon = new DBConnection();  // 接続

            List<string[]> csvData = new List<string[]>();  // CSVデータの各行リスト

            int countDataRecords = 0; // 最後に登録したデータ数を表示したいのでint型で数を保持する変数を用意
            Boolean flagHeader = true;  // 一行目のヘッダを判断するフラグ

            // UTF-8エンコーディングを使用してcsvファイルを読み込む
            using (StreamReader reader = new StreamReader(filePath, Encoding.UTF8))
            {
                while (!reader.EndOfStream) // CSVファイルをファイルの最後の行まで読み込む
                {
                    string record = reader.ReadLine(); // 1行分のデータを取得
                    if (flagHeader)
                    {
                        flagHeader = false;
                        continue;  // 一行目のみとばす
                    }
                    string[] recordSpritC = record.Split(','); // カンマ区切りでデータを分割する
                    csvData.Add(recordSpritC); // 分割したデータをリストに追加
                    countDataRecords++; // 数を保持している変数を加算(インクリメント)
                }

                int successCount = dbcon.insertDrugsCSVListData(csvData); // 登録処理を呼び出す

                MessageBox.Show($"{successCount}/{countDataRecords}件のデータの登録が完了しました。");
            }
        }
    }
}
