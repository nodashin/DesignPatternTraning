using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Singleton.Traning1
{
    class Main
    {
        public static void Execute()
        {
            var tm1 = TicketMaker.GetTicketMaker();
            var tm2 = TicketMaker.GetTicketMaker();

            Console.WriteLine(tm1.GetNextTicketNumber());
            Console.WriteLine(tm2.GetNextTicketNumber());
            Console.WriteLine(tm1.GetNextTicketNumber());
            Console.WriteLine(tm2.GetNextTicketNumber());
        }
    }
}
