
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Strategy.Sample
{
    class Main
    {
        public static void Execute()
        {
            Console.Write("シード値①の設定：");
            var seed1 = int.Parse(Console.ReadLine());
            Console.Write("シード値②の設定：");
            var seed2 = int.Parse(Console.ReadLine());
            Player player1 = new Player("Taro", new WinningStrategy(seed1));
            Player player2 = new Player("Hana", new ProbStrategy(seed2));
            for (int i = 0; i < 1000; i++)
            {
                Hand nextHand1 = player1.NextHand();
                Hand nextHand2 = player2.NextHand();
                if(nextHand1.IsStrongerThan(nextHand2))
                {
                    Console.WriteLine("Winner;" + player1);
                    player1.Win();
                    player2.Lose();
                }
                else if(nextHand2.IsStrongerThan(nextHand1))
                {
                    Console.WriteLine("Winner;" + player2);
                    player1.Lose();
                    player2.Win();
                }
                else
                {
                    Console.WriteLine("Even...");
                    player1.Even();
                    player2.Even();
                }
            }
            Console.WriteLine("Total results:");
            Console.WriteLine(player1);
            Console.WriteLine(player2);
        }
    }
}
