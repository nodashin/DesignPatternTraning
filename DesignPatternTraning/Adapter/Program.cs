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

            Console.ReadKey();
        }
    }
}
