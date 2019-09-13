using AbstractFactory.Sample.Factory;

namespace AbstractFactory.Sample.TableFactory
{
    /// <summary>
    /// Linkクラスのサブクラス
    /// </summary>
    internal class TableLink : Link
    {
        /// <summary>
        /// コンストラクタ
        /// </summary>
        /// <param name="caption">見出し</param>
        /// <param name="url">リンクのURL</param>
        public TableLink(string caption, string url) : base(caption, url)
        {
        }

        /// <summary>
        /// HTMLを作成する。
        /// </summary>
        /// <returns>作成したHTML</returns>
        public override string MakeHTML()
        {
            return "<td><a href=\"" + url + "\">" + caption + "</a></td>\n";
        }
    }
}