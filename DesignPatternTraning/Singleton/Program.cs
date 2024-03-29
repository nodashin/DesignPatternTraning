﻿using System;
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
            var writer = new ConsoleWriter("Sample");
            writer.WriteStart();
            Sample.Main.Execute();
            writer.WriteEnd();

            ConsoleWriter.WriteDelimiter();

            writer = new ConsoleWriter("Traning1");
            writer.WriteStart();
            Traning1.Main.Execute();
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
