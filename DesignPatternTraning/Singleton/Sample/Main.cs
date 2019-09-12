using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Singleton.Sample
{
    class Main
    {
        public static void Execute()
        {
            Singleton obj1 = Singleton.GetInstance();
            Singleton obj2 = Singleton.GetInstance();
            if (obj1 == obj2)
            {
                Console.WriteLine("obj1とobj2は同じインスタンスです。");
            }
            else
            {
                Console.WriteLine("obj1とobj2は同じインスタンスでがありません。");
            }
        }
    }
}
