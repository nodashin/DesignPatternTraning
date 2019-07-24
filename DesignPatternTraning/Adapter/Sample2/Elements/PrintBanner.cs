using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Adapter.Sample2.Elements
{
    /// <summary>
    /// プリントバーナー
    /// </summary>
    class PrintBanner : Print
    {
        /// <summary>
        /// バーナー
        /// </summary>
        private Banner banner;

        /// <summary>
        /// コンストラクタ
        /// </summary>
        /// <param name="string">コンソールに出力する文字列</param>
        public PrintBanner(string @string)
        {
            this.banner = new Banner(@string);
        }

        /// <summary>
        /// 弱く出力する。
        /// </summary>
        public override void PrintWeak()
        {
            this.banner.ShowWithParen();
        }

        /// <summary>
        /// 強く出力する。
        /// </summary>
        public override void PrintStrong()
        {
            this.banner.ShowWithAster();
        }
    }
}
