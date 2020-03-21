using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace KanbaraProject
{
    static class Program
    {
        //スタート位置(ここから始まる)
        /// <summary>
        /// アプリケーションのメイン エントリ ポイントです。
        /// </summary>
        [STAThread]
        static void Main()
        {
            //アプリケーションで visual スタイルを有効にする(自動生成)
            Application.EnableVisualStyles();

            //特定のコントロールで定義された UseCompatibleTextRendering プロパティにアプリケーション全体で有効な既定値を設定します。
            Application.SetCompatibleTextRenderingDefault(false);

            //現在のスレッドで標準のアプリケーション メッセージ ループの実行を開始し、指定したフォームを表示します。
            //Form1が始まる
            Application.Run(new Form1());
        }
    }
}
