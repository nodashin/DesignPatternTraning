using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Adapter.Sample1.Elements
{
    /// <summary>
    /// 提供されているもの
    /// </summary>
    class Banner
    {
        /// <summary>
        /// コンソールに書き込む文字列
        /// </summary>
        private string @string;

        /// <summary>
        /// コンストラクタ
        /// </summary>
        /// <param name="string">コンソールに書き込む文字列</param>
        public Banner(string @string)
        {
            this.@string = @string;
        }

        /// <summary>
        /// カッコ付きでコンソールに文字列を出力する。
        /// </summary>
        public void ShowWithParen()
        {
            Console.WriteLine("(" + this.@string + ")");
        }

        /// <summary>
        /// アスタリスク付きでコンソールに文字列を出力する。
        /// </summary>
        public void ShowWithAster()
        {
            Console.WriteLine("*" + this.@string + "*");
        }
    }
}
