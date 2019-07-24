using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TemplateMethod.Sample.Elements
{
    class StringDisplay : AbstractDisplay
    {
        /// <summary>
        /// 表示する文字列
        /// </summary>
        private string @string;

        /// <summary>
        /// 表示する文字列のバイト数
        /// </summary>
        private int width;

        /// <summary>
        /// コンストラクタ
        /// </summary>
        /// <param name="string">表示する文字列</param>
        public StringDisplay(string @string)
        {
            this.@string = @string;
            this.width = Encoding.GetEncoding("shift-jis").GetByteCount(@string);
        }

        /// <summary>
        /// 開始文字(+---+)を出力する。
        /// </summary>
        public override void Open()
        {
            this.PrintLine();
        }

        /// <summary>
        /// 文字列を表示する。
        /// </summary>
        public override void Print()
        {
            Console.WriteLine("|" + this.@string + "|");
        }

        /// <summary>
        /// 終了文字(+---+)を出力する。
        /// </summary>
        public override void Close()
        {
            this.PrintLine();
        }

        /// <summary>
        /// 固定文字列を1行出力する。
        /// </summary>
        private void PrintLine()
        {
            Console.Write("+");
            for (int i = 0; i < this.width; i++)
            {
                Console.Write("-");
            }
            Console.WriteLine("+");
        }
    }
}
