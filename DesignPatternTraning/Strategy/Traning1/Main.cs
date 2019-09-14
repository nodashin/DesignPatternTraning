using Strategy.Sample;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Strategy.Traning1
{
    class Main
    {
        public static void Execute()
        {
            var p = new Player("Traning1", new RandomStrategy(10));
            for (int i = 0; i < 100; i++)
            {
                var h = p.NextHand();
                Console.WriteLine(h.ToString());
            }
        }
    }
}
