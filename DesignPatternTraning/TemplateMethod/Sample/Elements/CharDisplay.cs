using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TemplateMethod.Sample.Elements
{
    class CharDisplay : AbstractDisplay
    {
        /// <summary>
        /// 表示する文字
        /// </summary>
        private char ch;

        /// <summary>
        /// コンストラクタ
        /// </summary>
        /// <param name="ch">表示する文字</param>
        public CharDisplay(char ch)
        {
            this.ch = ch;
        }

        /// <summary>
        /// 開始文字(＜＜)を表示する。
        /// </summary>
        public override void Open()
        {
            Console.Write("<<");
        }

        /// <summary>
        /// 文字を表示する。
        /// </summary>
        public override void Print()
        {
            Console.Write(this.ch);
        }

        /// <summary>
        /// 終了文字(＞＞)を表示する。
        /// </summary>
        public override void Close()
        {
            Console.WriteLine(">>");
        }
    }
}
