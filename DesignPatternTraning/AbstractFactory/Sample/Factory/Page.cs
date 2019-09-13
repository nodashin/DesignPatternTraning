using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AbstractFactory.Sample.Factory
{
    /// <summary>
    /// HTMLページ全体を抽象的に表現したクラス。
    /// </summary>
    abstract class Page
    {
        /// <summary>
        /// ページのタイトル
        /// </summary>
        protected string title;

        /// <summary>
        /// ページの作者
        /// </summary>
        protected string author;

        /// <summary>
        /// ページの項目
        /// </summary>
        protected List<Item> content = new List<Item>();

        /// <summary>
        /// コンストラクタ
        /// </summary>
        /// <param name="title">ページのタイトル</param>
        /// <param name="author">ページの作者</param>
        protected Page(string title, string author)
        {
            this.title = title;
            this.author = author;
        }

        /// <summary>
        /// 項目を追加する。
        /// </summary>
        /// <param name="item">追加する項目</param>
        public void Add(Item item)
        {
            content.Add(item);
        }

        /// <summary>
        /// タイトルを元にファイル名を決定し、MakeHTMLメソッドを使って自分自身のHTMLの内容をファイルに書き込む。
        /// </summary>
        public void Output()
        {
            string fileName = title + ".html";
            StreamWriter writer = new StreamWriter(fileName);
            writer.Write(this.MakeHTML());
            writer.Close();
            Console.WriteLine(fileName + "を作成しました。");
        }

        /// <summary>
        /// HTMLを作成する。
        /// </summary>
        /// <returns>作成したHTML</returns>
        public abstract string MakeHTML();
    }
}
