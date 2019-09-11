using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Adapter.Sample1
{
    /// <summary>
    /// アダプターの役目を果たすクラス
    /// </summary>
    class PrintBanner : Banner, IPrint
    {
        /// <summary>
        /// コンストラクタ
        /// </summary>
        /// <param name="string"></param>
        public PrintBanner(string @string) : base(@string)
        {
        }

        /// <summary>
        /// 文字列を弱く表示する。
        /// </summary>
        public void PrintWeek()
        {
            ShowWirhParen();
        }

        /// <summary>
        /// 文字列を強く表示する。
        /// </summary>
        public void PrintStrong()
        {
            ShowWithAster();
        }
    }
}
