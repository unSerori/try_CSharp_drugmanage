using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SQLite;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.ListView;
using System.Data;

namespace DrugManagement
{
    internal class DBConnection
    {
        private const string _DB_NAME = "drug_management.db";
        private SQLiteConnectionStringBuilder? sqlConnectionSb;

        /// <summary>
        /// Constructor
        /// </summary>
        public DBConnection()
        {
            try
            {
                // DBファイルの有無を確認
                string filePath = Path.Combine(Path.GetDirectoryName(Application.ExecutablePath), _DB_NAME);  // パス作成
                if (!File.Exists(filePath))
                {
                    // DBファイルが未作成の場合
                    // DB接続情報の保持、テーブル作成
                    sqlConnectionSb = new SQLiteConnectionStringBuilder { DataSource = _DB_NAME };
                    createDrugTable();  // テーブルを作成し、
                }
                else
                {
                    // DB接続情報の保持
                    sqlConnectionSb = new SQLiteConnectionStringBuilder { DataSource = _DB_NAME };
                }

            }catch(Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        /// <summary>
        /// テーブル作成処理
        /// </summary>
        public void createDrugTable()
        {
            try
            {
                // DBに接続
                using (SQLiteConnection sqlcon = new SQLiteConnection(sqlConnectionSb?.ToString()))  // SQLiteのインスタンス生成
                {
                    sqlcon.Open();  // 接続開始
                    using (SQLiteCommand cmd = new SQLiteCommand(sqlcon))  // SQLコマンドに接続を渡す
                    {
                        // テーブル作成
                        cmd.CommandText = "CREATE TABLE IF NOT EXISTS drugs(" +
                            "no INTEGER NOT NULL PRIMARY KEY AUTOINCREMENT," +
                            "name TEXT NOT NULL," +
                            "category TEXT NOT NULL," +
                            "price INT NOT NULL," +
                            "stock INT NOT NULL," +
                            "detail NEXT," + 
                            "image TEXT)";
                        cmd.ExecuteNonQuery();
                    }
                }
            }catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        /// <summary>
        /// Insert処理
        /// </summary>
        /// <param name="cmd"></param>
        /// <param name="name"></param>
        /// <param name="category"></param>
        /// <param name="price"></param>
        /// <param name="stock"></param>
        /// <param name="image"></param>
        private Boolean insertDrugSQL(SQLiteCommand cmd, string name, string category, int price, int stock, string detail, string image = null)
        {
            try
            {
                // nullな項目はnullで設定
                var imageStr = image == null ? "null" : $"'{image}'";  // 画像がない場合はnullを設定

                // SQLコマンドを設定
                cmd.CommandText = "INSERT INTO drugs (name, category, price, stock, detail, image) VALUES(" +
                    $"'{name}', '{category}', '{price}', '{stock}', '{detail}', '{image}')";
                cmd.ExecuteNonQuery();  // 結果を返さないSQL文を実行

                return true;  // 成功した場合
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
                return false;  // 失敗
            }
        }

        /// <summary>
        /// List形式のデータをforでinsert
        /// </summary>
        /// <param name="csvCata"></param>
        /// <returns></returns>
        public int insertDrugsCSVListData(List<string[]> csvCata)
        {
            int countData = 0;
            try
            {
                // DBに接続
                using (SQLiteConnection sqlcon = new SQLiteConnection(sqlConnectionSb?.ToString()))
                {
                    sqlcon.Open();  // 接続開始
                    using(SQLiteCommand cmd = new SQLiteCommand(sqlcon))
                    {
                        // foreach
                        foreach (var line in csvCata)  // 一行ずつ取り出す。
                        {
                            if (insertDrugSQL(cmd, line[0], line[1], int.Parse(line[2]), int.Parse(line[3]), line[4], line[5]))
                            {
                                countData++;
                            }
                        }
                    }
                }
            }
            catch (Exception ex) 
            {
                MessageBox.Show(ex.Message);
            }

            return countData;  // 成功回数
        }


        /// <summary>
        /// テーブルのデータをデータテーブルで取得
        /// </summary>
        /// <returns></returns>
        public DataTable getDrugsData(string tablename)
        {
            try
            {
                // DBに接続
                using (SQLiteConnection sqlcon = new SQLiteConnection(sqlConnectionSb?.ToString()))
                {
                    sqlcon.Open();  // 接続開始
                    using(SQLiteCommand cmd = new SQLiteCommand(sqlcon))
                    {
                        cmd.CommandText = $"SELECT no AS '薬品番号', name AS '薬品名', category AS 'カテゴリ', price AS '金額', stock AS '在庫数' from {tablename}";  // コマンドテキストを作成
                        using(var reader = cmd.ExecuteReader())  // 結果を返すSQL文を実行  // 結果を格納
                        {
                            // SQL文を実行しデータテーブルに読み込み
                            DataTable datatable = new DataTable();  // テーブルデータを作成
                            datatable.Load(reader);  // テーブルデータに結果を読み込む
                            return datatable;
                        }
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
                return null;
            }
        }
    }
}
