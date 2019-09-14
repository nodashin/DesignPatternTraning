
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Bridge.Sample;

namespace Bridge.Traning1
{
    class Main
    {
        public static void Execute()
        {
            var d = new RandomDisplay(new StringDisplayImpl("Traning1"));
            d.DisplayRandom(5);
        }
    }
}
