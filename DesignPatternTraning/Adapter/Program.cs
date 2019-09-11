using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Common;

namespace Adapter
{
    class Program
    {
        static void Main(string[] args)
        {
            ConsoleWriter.WriteStart("Sample1");
            Sample1.Main.Execute();
            ConsoleWriter.WriteEnd("Sample1");

            ConsoleWriter.WriteDelimiter();

            ConsoleWriter.WriteStart("Sample2");
            Sample2.Main.Execute();
            ConsoleWriter.WriteEnd("Sample2");

            Console.ReadKey();
        }
    }
}
