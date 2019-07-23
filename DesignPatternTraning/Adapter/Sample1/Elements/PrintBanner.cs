using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Adapter.Sample1.Elements
{
    /// <summary>
    /// アダプター(変換装置)
    /// </summary>
    class PrintBanner : Banner, IPrint
    {
        /// <summary>
        /// コンストラクタ
        /// </summary>
        /// <param name="string">コンソールに表示する文字列</param>
        public PrintBanner(string @string) : base(@string)
        {
        }

        /// <summary>
        /// 弱く出力する。
        /// </summary>
        public void PrintWeak()
        {
            this.ShowWithParen();
        }

        /// <summary>
        /// 強く出力する。
        /// </summary>
        public void PrintStrong()
        {
            this.ShowWithAster();
        }
    }
}
