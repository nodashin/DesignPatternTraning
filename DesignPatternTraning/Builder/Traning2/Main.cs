using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Builder.Traning1;

namespace Builder.Traning2
{
    class Main
    {
        public static void Execute()
        {
            var mdBuilder = new MarkdownDocumentBuilder("markdown");
            var director = new Director(mdBuilder);
            var result = director.Construct();
            Console.WriteLine(result);
        }
    }
}
