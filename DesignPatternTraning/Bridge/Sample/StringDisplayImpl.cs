using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Bridge.Sample
{
    /// <summary>
    /// 文字列を表示するクラス
    /// 役割：ConcreteImplementor(具体的な実装者)
    /// </summary>
    class StringDisplayImpl : DisplayImpl
    {
        /// <summary>
        /// 表示するべき文字列。
        /// </summary>
        private string @string;

        /// <summary>
        /// バイト単位で計算した文字列の「幅」。
        /// </summary>
        public int width;

        /// <summary>
        /// コンストラクタ
        /// </summary>
        /// <param name="string">表示するべき文字列</param>
        public StringDisplayImpl(string @string)
        {
            //コンストラクタで渡された文字列stringを、フィールドに記憶しておく。
            this.@string = @string;
            //さらにバイト単位の幅もフィールドに記憶しておいて、後で使う。
            this.width = Encoding.GetEncoding("shift-jis").GetBytes(@string).Length;
        }

        /// <summary>
        /// 前処理。
        /// </summary>
        public override void RawOpen()
        {
            PrintLine();
        }

        /// <summary>
        /// 表示する。
        /// </summary>
        public override void RawPrint()
        {
            Console.WriteLine("|" + @string + "|");
        }

        /// <summary>
        /// 後処理。
        /// </summary>
        public override void RawClose()
        {
            PrintLine();
        }

        /// <summary>
        /// 飾り線を表示する。
        /// </summary>
        private void PrintLine()
        {
            //枠の角を表現する"+"マークを表示する。
            Console.Write("+");
            //width個の"-"を表示して、枠線として用いる。
            for (int i = 0; i < width; i++)
            {
                Console.Write("-");
            }
            //枠の角を表現する"+"マークを表示する。
            Console.WriteLine("+"); ;
        }
    }
}
