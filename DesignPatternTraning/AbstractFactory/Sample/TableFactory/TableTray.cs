using System.Text;
using AbstractFactory.Sample.Factory;

namespace AbstractFactory.Sample.TableFactory
{
    /// <summary>
    /// Trayクラスのサブクラス
    /// 役割：ConcreteProducut(具体的な製品)
    /// </summary>
    internal class TableTray : Tray
    {
        /// <summary>
        /// コンストラクタ
        /// </summary>
        /// <param name="caption">見出し</param>
        public TableTray(string caption) : base(caption)
        {
        }

        /// <summary>
        /// HTMLを作成する。
        /// </summary>
        /// <returns>作成したHTML</returns>
        public override string MakeHTML()
        {
            StringBuilder buffer = new StringBuilder();
            buffer.Append("<td>");
            buffer.Append("<table width=\"100%\" border=\"1\")<tr>");
            buffer.Append("<td bgcolor=\"#cccccc\" align=\"center\" colspan=\"" + tray.Count + "\"><b>" + caption + "</b></td>");
            buffer.Append("</tr>\n");
            buffer.Append("<tr>\n");
            foreach (var item in tray)
            {
                buffer.Append(item.MakeHTML());
            }
            buffer.Append("</tr></table>");
            buffer.Append("</td>");
            return buffer.ToString();
        }
    }
}