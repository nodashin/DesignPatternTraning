using System.Text;
using AbstractFactory.Sample.Factory;

namespace AbstractFactory.Sample.ListFactory
{
    /// <summary>
    /// Pageクラスのサブクラス
    /// </summary>
    internal class ListPage : Page
    {
        /// <summary>
        /// コンストラクタ
        /// </summary>
        /// <param name="title">ページのタイトル</param>
        /// <param name="author">ページの作者</param>
        public ListPage(string title, string author) : base(title, author)
        {
        }

        /// <summary>
        /// HTMLを作成する。
        /// </summary>
        /// <returns>作成したHTML</returns>
        public override string MakeHTML()
        {
            StringBuilder buffer = new StringBuilder();
            buffer.Append("<html><head><title>" + title + "</title></head>\n");
            buffer.Append("<body>\n");
            buffer.Append("<h1>" + title + "</h1>\n");
            buffer.Append("<ul>\n");
            foreach (var item in content)
            {
                buffer.Append(item.MakeHTML());
            }
            buffer.Append("</ul>\n");
            buffer.Append("<hr><address>" + author + "</address>");
            buffer.Append("</body></html>\n");
            return buffer.ToString();
        }
    }
}