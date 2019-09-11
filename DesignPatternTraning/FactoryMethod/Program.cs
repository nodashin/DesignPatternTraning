﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Common;

namespace FactoryMethod
{
    class Program
    {
        static void Main(string[] args)
        {
            ConsoleWriter.WriteStart("Sample");
            Sample.Main.Execute();
            ConsoleWriter.WriteEnd("Sample");

            ConsoleWriter.WriteDelimiter();

            ConsoleWriter.WriteStart("Traning2");
            Traning2.Main.Execute();
            ConsoleWriter.WriteEnd("Traning2");

            Console.ReadKey();
        }
    }
}
