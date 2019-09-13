using System.Text;
using AbstractFactory.Sample.Factory;

namespace AbstractFactory.Sample.ListFactory
{
    /// <summary>
    /// Trayクラスのサブクラス
    /// </summary>
    internal class ListTray : Tray
    {
        /// <summary>
        /// コンストラクタ
        /// </summary>
        /// <param name="caption">見出し</param>
        public ListTray(string caption) : base(caption)
        {
        }

        /// <summary>
        /// HTMLを作成する。
        /// </summary>
        /// <returns>作成したHTML</returns>
        public override string MakeHTML()
        {
            StringBuilder buffer = new StringBuilder();
            buffer.Append("<li>\n");
            buffer.Append(caption +  "\n");
            buffer.Append("<ul>\n");
            foreach (var item in tray)
            {
                buffer.Append(item.MakeHTML());
            }
            buffer.Append("</ul>\n");
            buffer.Append("</li>\n");

            return buffer.ToString();
        }
    }
}