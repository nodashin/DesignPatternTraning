using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Singleton.Traning2
{
    class Main
    {
        public static void Execute()
        {
            try
            {
                Console.WriteLine($"取得したいTriple.ID：1");
                var t1_1 = Triple.GetInstance(1);
                Console.WriteLine($"取得したTriple.ID：{t1_1.Id}");

                Console.WriteLine($"取得したいTriple.ID：1");
                var t1_2 = Triple.GetInstance(1);
                Console.WriteLine($"取得したTriple.ID：{t1_2.Id}");

                Console.WriteLine($"インスタンス一致判定：{t1_1 == t1_2}");

                Console.WriteLine($"取得したいTriple.ID：2");
                var t2 = Triple.GetInstance(2);
                Console.WriteLine($"取得したTriple.ID：{t2.Id}");

                Console.WriteLine($"取得したいTriple.ID：3");
                var t3 = Triple.GetInstance(3);
                Console.WriteLine($"取得したTriple.ID：{t3.Id}");

                Console.WriteLine($"取得したいTriple.ID：4");
                var t4 = Triple.GetInstance(4);
                Console.WriteLine($"取得したTriple.ID：{t4.Id}");
            }
            catch (ApplicationException ex)
            {
                Console.WriteLine(ex.Message);
            }
        }
    }
}
