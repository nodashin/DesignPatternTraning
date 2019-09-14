using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Bridge.Traning1;

namespace Bridge.Traning2
{
    class Main
    {
        public static void Execute()
        {
            var d = new RandomDisplay(new TextDisplayImpl("Traning2", "Traning2 Content!"));
            d.DisplayRandom(10);
            Console.WriteLine("ファイルを出力しました。");
        }
    }
}
