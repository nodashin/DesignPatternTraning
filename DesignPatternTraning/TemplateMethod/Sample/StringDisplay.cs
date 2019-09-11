using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TemplateMethod.Sample
{
    /// <summary>
    /// メソッドOpen, Print, Closeを実行しているクラス
    /// +----------------+
    /// |{指定した文字列}|
    /// |{指定した文字列}|
    /// |{指定した文字列}|
    /// |{指定した文字列}|
    /// |{指定した文字列}|
    /// +----------------+ と表示する。
    /// </summary>
    class StringDisplay : AbstractDisplay
    {
        /// <summary>
        /// 表示すべき文字列
        /// </summary>
        private string @string;

        /// <summary>
        /// バイト単位で計算した文字列の幅
        /// </summary>
        private int width;

        /// <summary>
        /// コンストラクタ
        /// </summary>
        /// <param name="string">表示スべき文字列</param>
        public StringDisplay(string @string)
        {
            //コンストラクタで渡された文字列stringをフィールドに記憶。
            this.@string = @string;
            //バイト単位の幅もフィールドに記憶していて、後で使う。
            this.width = Encoding.GetEncoding("shift-jis").GetBytes(@string).Length;
        }

        /// <summary>
        /// 文字列 "+-----+" を表示する。
        /// </summary>
        public override void Open()
        {
            PlintLine();
        }

        /// <summary>
        /// コンストラクタで与えられていた文字列を "|" と "|" ではさんで表示する。
        /// </summary>
        public override void Print()
        {
            Console.WriteLine("|" + @string + "|");
        }

        /// <summary>
        /// 文字列 "+-----+" を表示する。
        /// </summary>
        public override void Close()
        {
            PlintLine();
        }

        /// <summary>
        /// OpenとCloseから呼ばれるメソッドPlintLineだ。
        /// privateなので、このクラスの中だけで使われる。
        /// </summary>
        private void PlintLine()
        {
            //枠の角を表す "+" マークを表示。
            Console.Write("+");

            //width個の "-" を表示して、枠線として用いる。
            for (int i = 0; i < width; i++)
            {
                Console.Write("-");
            }

            //枠の角を表す "+" マークを表示。
            Console.WriteLine("+");
        }
    }
}
