using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Common;

namespace Iterator
{
    class Program
    {
        static void Main(string[] args)
        {
            ConsoleWriter.WriteStart("Sample");
            Sample.Main.Execute();
            ConsoleWriter.WriteEnd("Sample");

            ConsoleWriter.WriteDelimiter();

            ConsoleWriter.WriteStart("Traning");
            Traning.Main.Execute();
            ConsoleWriter.WriteEnd("Traning");

            Console.ReadKey();
        }
    }
}
