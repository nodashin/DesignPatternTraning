using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AbstractFactory.Sample.Factory
{
    /// <summary>
    /// HTMLのハイパーリンク
    /// 役割：AbstractProduct(抽象的な製品)
    /// </summary>
    abstract class Link : Item
    {
        /// <summary>
        /// リンクのURL
        /// </summary>
        protected string url;

        /// <summary>
        /// コンストラクタ
        /// </summary>
        /// <param name="caption">見出し</param>
        /// <param name="url">リンクのURL</param>
        protected Link(string caption, string url) : base(caption)
        {
            this.url = url;
        }
    }
}
