using Common;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Strategy
{
    class Program
    {
        static void Main(string[] args)
        {
            var writer = new ConsoleWriter("Sample");
            writer.WriteStart();
            Sample.Main.Execute();
            writer.WriteEnd();

            Console.ReadKey();
        }
    }
}
