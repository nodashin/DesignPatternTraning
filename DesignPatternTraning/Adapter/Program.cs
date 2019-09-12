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
            var writer = new ConsoleWriter("Sample1");
            writer.WriteStart();
            Sample1.Main.Execute();
            writer.WriteEnd();

            ConsoleWriter.WriteDelimiter();

            writer = new ConsoleWriter("Sample2");
            writer.WriteStart();
            Sample2.Main.Execute();
            writer.WriteEnd();

            ConsoleWriter.WriteDelimiter();

            writer = new ConsoleWriter("Traning2");
            writer.WriteStart();
            Traning2.Main.Execute();
            writer.WriteEnd();

            Console.ReadKey();
        }
    }
}
