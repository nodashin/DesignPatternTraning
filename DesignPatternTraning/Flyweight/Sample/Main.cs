using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Flyweight.Sample
{
    class Main
    {
        public static void Execute()
        {
            Console.Write("数字を入力してください：");
            var inputNumnbers = Console.ReadLine();
            Console.WriteLine();

            BigString bs = new BigString(inputNumnbers);
            bs.Print();
        }
    }
}
