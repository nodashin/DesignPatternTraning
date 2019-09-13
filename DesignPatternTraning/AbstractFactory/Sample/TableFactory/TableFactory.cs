using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using AbstractFactory.Sample.Factory;

namespace AbstractFactory.Sample.TableFactory
{
    /// <summary>
    /// Factoryクラスのサブクラス
    /// 役割：ConcreteFactory(具体的な工場)
    /// </summary>
    class TableFactory : Factory.Factory
    {
        /// <summary>
        /// リンクを作成する。
        /// </summary>
        /// <param name="caption">見出し</param>
        /// <param name="url">URL</param>
        /// <returns>作成したリンク</returns>
        public override Link CreateLink(string caption, string url)
        {
            return new TableLink(caption, url);
        }

        /// <summary>
        /// トレイを作成する。
        /// </summary>
        /// <param name="caption">見出し</param>
        /// <returns>作成したトレイ</returns>
        public override Tray CreateTray(string caption)
        {
            return new TableTray(caption);
        }

        /// <summary>
        /// ページを作成する。
        /// </summary>
        /// <param name="title">ページのタイトル</param>
        /// <param name="author">ページの作者</param>
        /// <returns>作成したページ</returns>
        public override Page CreatePage(string title, string author)
        {
            return new TablePage(title, author);
        }
    }
}
