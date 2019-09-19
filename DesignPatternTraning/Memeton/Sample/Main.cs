using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using Memeton.Sample.Game;

namespace Memeton.Sample
{
    /// <summary>
    /// 役割：Caretaker(世話をする人)
    /// </summary>
    class Main
    {
        public static void Execute()
        {
            //最初の所持金は100。
            Gamer gamer = new Gamer(100);
            //最初の状態を保存しておく。
            Memento memento = gamer.CreateMemento();
            for (int i = 0; i < 100; i++)
            {
                //回数表示。
                Console.WriteLine("====" + i);
                //現在の主人公の状態。
                Console.WriteLine("現状：" + gamer);

                //ゲームを進める。
                gamer.Bet();

                Console.WriteLine("所持金は" + gamer.GetMoney() + "円になりました。");

                //Mementoの取り扱いの決定
                if(gamer.GetMoney() > memento.GetMoney())
                {
                    Console.WriteLine("(だいぶ増えたので、現在の状態を保存しておこう)");
                    memento = gamer.CreateMemento();
                }
                else if(gamer.GetMoney() < memento.GetMoney() / 2)
                {
                    Console.WriteLine("(だいぶ減ったので、以前の状態に復帰しよう)");
                    gamer.RestoreMemento(memento);
                }

                ////時間待ち。
                //Thread.Sleep(1000);
                Console.WriteLine();
            }
        }
    }
}
