using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Adapter.Sample2
{
    class Main
    {
        public static void Execute()
        {
            Print p = new PrintBanner("Hello");
            p.PrintWeek();
            p.PrintStrong();
        }
    }
}
