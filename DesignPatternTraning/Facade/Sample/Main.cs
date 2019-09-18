using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Facade.Sample
{
    class Main
    {
        public static void Execute()
        {
            PageMaker.PageMaker.MakeWelcomePage("hyuki@hyuki.com", "welocome.html");
        }
    }
}
