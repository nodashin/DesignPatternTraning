using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Facade.Sample.PageMaker
{
    /// <summary>
    /// HTMLファイルを作成するクラス
    /// </summary>
    class HtmlWriter
    {
        /// <summary>
        /// StreamWriter
        /// </summary>
        private StreamWriter writer;

        /// <summary>
        /// コンストラクタ
        /// </summary>
        /// <param name="writer">StreamWriter</param>
        public HtmlWriter(StreamWriter writer)
        {
            this.writer = writer;
        }

        /// <summary>
        /// タイトルを出力する。
        /// </summary>
        /// <param name="title">出力するタイトル</param>
        public void Title(string title)
        {
            writer.Write("<html>");
            writer.Write("<head>");
            writer.Write("<title>" + title + "<title>");
            writer.Write("</head>");
            writer.Write("<body>\n");
            writer.Write("<h1>" + title + "<h1>\n");
        }

        /// <summary>
        /// 段落を出力する。
        /// </summary>
        /// <param name="msg">メッセージ</param>
        public void Paragraph(string msg)
        {
            writer.Write("<p>" + msg + "</p>\n");
        }

        /// <summary>
        /// リンクを出力する。
        /// </summary>
        /// <param name="href">href</param>
        /// <param name="caption">キャプション</param>
        public void Link(string href, string caption)
        {
            Paragraph("<a href=\"" + href + "\">" + caption + "</a>");
        }

        /// <summary>
        /// メールアドレスを出力する。
        /// </summary>
        /// <param name="mailAddr">メールアドレス</param>
        /// <param name="userName">ユーザー名</param>
        public void MailTo(string mailAddr, string userName)
        {
            Link(mailAddr, userName);
        }

        /// <summary>
        /// 閉じる。
        /// </summary>
        public void Close()
        {
            writer.Write("</body>");
            writer.Write("</html>\n");
            writer.Close();
        }
    }
}
