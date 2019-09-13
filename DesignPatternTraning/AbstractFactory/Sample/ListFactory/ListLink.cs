using AbstractFactory.Sample.Factory;

namespace AbstractFactory.Sample.ListFactory
{
    /// <summary>
    /// Linkクラスのサブクラス
    /// 役割：ConcreteProducut(具体的な製品)
    /// </summary>
    internal class ListLink : Link
    {
        /// <summary>
        /// コンストラクタ
        /// </summary>
        /// <param name="caption">見出し</param>
        /// <param name="url">リンクのURL</param>
        public ListLink(string caption, string url) : base(caption, url)
        {
        }

        /// <summary>
        /// HTMLを作成する。
        /// </summary>
        /// <returns>作成したHTML</returns>
        public override string MakeHTML()
        {
            return "  <li><a href=\"" + url + "\">" + caption + "</a></li>\n";
        }
    }
}