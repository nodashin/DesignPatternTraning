using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Adapter
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("サンプル1");
            new Sample1.Sample1().Execute();
            Console.WriteLine("");

            Console.WriteLine("サンプル2");
            new Sample2.Sample2().Execute();
            Console.WriteLine("");

            Console.WriteLine("練習問題2-2");
            new Traning2.Traning2().Execute();
            Console.WriteLine("");

            Console.ReadKey();
        }
    }
}
