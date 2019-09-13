using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AbstractFactory.Sample.Factory
{
    /// <summary>
    /// 抽象的な工場
    /// 役割：AbstractFactory(抽象的な工場)
    /// </summary>
    abstract class Factory
    {
        /// <summary>
        /// クラス名を指定して具体的な工場を作成する。
        /// </summary>
        /// <param name="className">作成する工場のクラス名</param>
        /// <returns>作成した工場</returns>
        public static Factory GetFactory(string className)
        {
            Factory factory = null;
            var t = Type.GetType(className);
            factory = (Factory)Activator.CreateInstance(t);
            return factory;
        }

        /// <summary>
        /// リンクを作成する。
        /// </summary>
        /// <param name="caption">見出し</param>
        /// <param name="url">URL</param>
        /// <returns>作成したリンク</returns>
        public abstract Link CreateLink(string caption, string url);

        /// <summary>
        /// トレイを作成する。
        /// </summary>
        /// <param name="caption">見出し</param>
        /// <returns>作成したトレイ</returns>
        public abstract Tray CreateTray(string caption);

        /// <summary>
        /// ページを作成する。
        /// </summary>
        /// <param name="title">ページのタイトル</param>
        /// <param name="author">ページの作者</param>
        /// <returns>作成したページ</returns>
        public abstract Page CreatePage(string title, string author);
    }
}
