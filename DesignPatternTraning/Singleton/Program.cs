using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Singleton
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("サンプルプログラム");
            Sample.Main.Execute();
            Console.WriteLine("");

            Console.WriteLine("練習問題5-1");
            Traning1.Traning1.Execute();
            Console.WriteLine("");

            Console.ReadKey();
        }
    }
}
