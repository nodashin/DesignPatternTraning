using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Singleton.Sample
{
    static class Main
    {
        public static void Execute()
        {
            Elements.Singleton obj1 = Elements.Singleton.GetInstance();
            Elements.Singleton obj2 = Elements.Singleton.GetInstance();
            if(obj1 == obj2)
            {
                Console.WriteLine("obj1とobj2は同じインスタンスです。");
            }
            else
            {
                Console.WriteLine("obj1とobj2は同じインスタンスではありません。");
            }
        }
    }
}
