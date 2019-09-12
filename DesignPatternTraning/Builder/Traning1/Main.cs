using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Builder.Traning1
{
    class Main
    {
        public static void Execute()
        {
            Console.WriteLine("Text");
            var tb = new TextDocumentBuilder();
            var director = new Director(tb);
            var result = director.Construct();
            Console.WriteLine(result);
        }
    }
}
