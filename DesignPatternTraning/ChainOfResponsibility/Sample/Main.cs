using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ChainOfResponsibility.Sample
{
    /// <summary>
    /// 役割：Client(要求者)
    /// </summary>
    class Main
    {
        public static void Execute()
        {
            Support alice = new NoSupport("Alice");
            Support bob = new LimitSupport("Bob", 100);
            Support charlie = new SpecialSupport("Charlie", 429);
            Support diana = new LimitSupport("Diana", 200);
            Support elmo = new OddSupport("Elmo");
            Support fred = new LimitSupport("Fred", 300);
            //連鎖の形成
            alice.SetNext(bob).SetNext(charlie).SetNext(diana).SetNext(elmo).SetNext(fred);
            //さまざまなトラブル発生
            for (int i = 0; i < 500; i+=33)
            {
                alice.SupportTrouble(new Trouble(i));
            }
        }
    }
}
