using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Decorator.Sample;

namespace Decorator.Traning1
{
    class Main
    {
        public static void Execute()
        {
            Display b1 = new StringDisplay("Hello, world.");
            Display b2 = new UpDownBorder(b1, '-');
            Display b3 = new SideBorder(b2, '*');
            Console.WriteLine("b1");
            b1.Show();
            Console.WriteLine("b2");
            b2.Show();
            Console.WriteLine("b3");
            b3.Show();
            Display b4 =
                new FullBorder(
                    new UpDownBorder(
                        new SideBorder(
                            new UpDownBorder(
                                new SideBorder(
                                    new StringDisplay("こんにちは。"),
                                    '*'),
                                '='),
                            '|'),
                        '/')
                    );
            Console.WriteLine("b4");
            b4.Show();
        }
    }
}
