using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Adapter.Sample2
{
    /// <summary>
    /// アダプターの役目を果たすクラス
    /// </summary>
    class PrintBanner : Print
    {
        /// <summary>
        /// バナー
        /// </summary>
        private Banner banner;

        /// <summary>
        /// コンストラクタ
        /// </summary>
        /// <param name="string">書き込む文字列</param>
        public PrintBanner(string @string)
        {
            this.banner = new Banner(@string);
        }

        /// <summary>
        /// 文字列を弱く表示する。
        /// </summary>
        public override void PrintWeek()
        {
            banner.ShowWirhParen();
        }

        /// <summary>
        /// 文字列を強く表示する。
        /// </summary>
        public override void PrintStrong()
        {
            banner.ShowWithAster();
        }
    }
}
