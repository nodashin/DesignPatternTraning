using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Adapter.Sample1
{
    /// <summary>
    /// 役割：Client(依頼者)
    /// </summary>
    class Main
    {
        public static void Execute()
        {
            IPrint p = new PrintBanner("Hello");
            p.PrintWeek();
            p.PrintStrong();
        }
    }
}
