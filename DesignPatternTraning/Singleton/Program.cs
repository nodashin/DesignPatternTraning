using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Common;

namespace Singleton
{
    class Program
    {
        static void Main(string[] args)
        {
            ConsoleWriter.WriteStart("Sample");
            Sample.Main.Execute();
            ConsoleWriter.WriteEnd("Sample");

            Console.ReadKey();
        }
    }
}
