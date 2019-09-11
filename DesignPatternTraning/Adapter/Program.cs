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

            Console.ReadKey();
        }
    }
}
