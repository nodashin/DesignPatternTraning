using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Builder.Sample
{
    /// <summary>
    /// HTMLファイルとして文書を構築する。
    /// </summary>
    class HTMLBuilder : Builder
    {
        /// <summary>
        /// 作成するファイル名
        /// </summary>
        private string fileName;

        /// <summary>
        /// ファイルに書き込むStreamWriter
        /// </summary>
        public StreamWriter writer;

        /// <summary>
        /// HTMLファイルでのタイトル。
        /// </summary>
        /// <param name="title">タイトル</param>
        public override void MakeTitle(string title)
        {
            //タイトルを元にファイル名を決定。
            fileName = title + ".html";
            //StreamWriterを作る。
            writer = new StreamWriter(fileName);

            writer.WriteLine("<html><head><title>" + title + "</title></head><body>");
            //タイトルを出力
            writer.WriteLine("<h1>" + title + "</h1>");
        }

        /// <summary>
        /// HTMLファイルでの文字列。
        /// </summary>
        /// <param name="str">文字列</param>
        public override void MakeString(string str)
        {
            //<p>タグで出力
            writer.WriteLine("<p>" + str + "</p>");
        }

        /// <summary>
        /// HTMLファイルでの箇条書き
        /// </summary>
        /// <param name="items">箇条書き</param>
        public override void MakeItems(string[] items)
        {
            //<ul>と<li>で出力
            writer.WriteLine("<ul>");
            for (int i = 0; i < items.Length; i++)
            {
                writer.WriteLine("<li>" + items[i] + "</li>");
            }
            writer.WriteLine("</ul>");
        }

        /// <summary>
        /// 文書の完成。
        /// </summary>
        public override void Close()
        {
            //タグを閉じる。
            writer.WriteLine("</body></html>");
            //ファイルをクローズ。
            writer.Close();
        }

        /// <summary>
        /// 完成した文書のファイル名を取得する。
        /// </summary>
        /// <returns>完成した文書のファイル名</returns>
        public string GetResult()
        {
            return fileName;
        }
    }
}
