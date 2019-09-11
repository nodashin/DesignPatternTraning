using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Adapter.Sample2
{
    /// <summary>
    /// 予め用意されているクラス
    /// 指定した文字列に括弧やアスタリスクを加える
    /// 役割：Adaptee(適合される側)
    /// </summary>
    class Banner
    {
        /// <summary>
        /// 書き込む文字列
        /// </summary>
        private string @string;

        /// <summary>
        /// コンストラクタ
        /// </summary>
        /// <param name="string">書き込む文字列</param>
        public Banner(string @string)
        {
            this.@string = @string;
        }

        /// <summary>
        /// 指定した文字列に括弧を加えて表示する。
        /// </summary>
        public void ShowWirhParen()
        {
            Console.WriteLine("(" + @string + ")");
        }

        /// <summary>
        /// 指定した文字列にアスタリスクを加えて表示する。
        /// </summary>
        public void ShowWithAster()
        {
            Console.WriteLine("*" + @string + "*");
        }
    }
}
