using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Adapter.Sample2
{
    /// <summary>
    /// 役割：Client(依頼者)
    /// </summary>
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
