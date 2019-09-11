using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TemplateMethod.Sample
{
    class Main
    {
        public static void Execute()
        {
            //'H' を持ったCharDisplayのインスタンスを1個作る。
            AbstractDisplay d1 = new CharDisplay('H');
            //"Hello, World" を持ったStringDisplayのインスタンスを1個作る。
            AbstractDisplay d2 = new StringDisplay("Hello, World");
            //"こんにちは。" を持ったStringDisplayのインスタンスを1個作る。
            AbstractDisplay d3 = new StringDisplay("こんにちは。");

            //d1, d2, d3とも、すべて同じAbstractDisplayのサブクラスのインスタンスだから、継承したDisplayメソッドを呼び出すことができる。
            //実際の動作は個々のクラスCharDisplayやStringDisplayで定まる。
            d1.Display();
            d2.Display();
            d3.Display();
        }
    }
}
