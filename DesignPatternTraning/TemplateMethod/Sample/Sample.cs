using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TemplateMethod.Sample.Elements;

namespace TemplateMethod.Sample
{
    class Sample
    {
        /// <summary>
        /// 文字や文字列を5回繰り返して表示する。
        /// </summary>
        public void Execute()
        {
            AbstractDisplay d1 = new CharDisplay('H');
            AbstractDisplay d2 = new StringDisplay("Hello, World.");
            AbstractDisplay d3 = new StringDisplay("こんにちは。");

            d1.Display();
            d2.Display();
            d3.Display();
        }
    }
}
