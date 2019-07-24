using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FactoryMethod
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("サンプルプログラム");
            Sample.Sample.Execute();
            Console.WriteLine("");

            Console.WriteLine("練習問題");
            Traning.Traning.Execute();
            Console.WriteLine("");

            Console.ReadKey();
        }
    }
}
