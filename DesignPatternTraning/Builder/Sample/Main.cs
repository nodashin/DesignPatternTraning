using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Builder.Sample
{
    class Main
    {
        public static void Execute()
        {
            Console.Write("作成する文書を選択してください。(plain/html)：");
            var builderType = Console.ReadLine();
            
            if(builderType == "plain")
            {
                TextBuilder textBuilder = new TextBuilder();
                Director director = new Director(textBuilder);
                director.Construct();
                string result = textBuilder.GetResult();
                Console.WriteLine(result);
            }
            else if(builderType == "html")
            {
                HTMLBuilder htmlBuilder = new HTMLBuilder();
                Director director = new Director(htmlBuilder);
                director.Construct();
                string fileName = htmlBuilder.GetResult();
                Console.WriteLine(fileName + "が作成されました。");
            }
            else
            {
                Console.WriteLine("Usage:plain  プレーンテキストで文書作成");
                Console.WriteLine("Usage:html   HTMLファイルで文書作成");
            }
        }
    }
}
