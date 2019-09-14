using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Bridge.Sample
{
    class Main
    {
        public static void Execute()
        {
            Display d1 = new Display(new StringDisplayImpl("Hello, Japan."));
            Display d2 = new CountDisplay(new StringDisplayImpl("Hello, world."));
            CountDisplay d3 = new CountDisplay(new StringDisplayImpl("Hello, Universe"));

            Console.WriteLine("d1.Display()が表示");
            d1.Dislay();
            Console.WriteLine();
            Console.WriteLine("d2.Display()が表示");
            d2.Dislay();
            Console.WriteLine();
            Console.WriteLine("d3.MultiDisplay(5)が表示");
            d3.MultiDisplay(5);
            Console.WriteLine();
        }
    }
}
