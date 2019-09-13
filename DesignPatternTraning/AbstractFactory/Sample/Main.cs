using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using AbstractFactory.Sample.Factory;

namespace AbstractFactory.Sample
{
    class Main
    {
        public static void Execute()
        {
            Console.Write("工場のクラス名を入力してください。：");
            var factoryName = Console.ReadLine();

            Factory.Factory factory = Factory.Factory.GetFactory(factoryName);

            Link asahi = factory.CreateLink("朝日新聞", "http://www.asahi.com/");
            Link yomiuri = factory.CreateLink("読売新聞", "http://www.yomiuri.co.jp/");

            Link us_yahoo = factory.CreateLink("Yahoo!", "http://www.yahoo.com/");
            Link jp_yahoo = factory.CreateLink("Yahoo!Japan", "http://www.yahoo.co.jp/");
            Link excite = factory.CreateLink("Excite", "http://www.excite.com/");
            Link google = factory.CreateLink("Google", "http://www.google.com/");

            Tray trayNews = factory.CreateTray("新聞");
            trayNews.Add(asahi);
            trayNews.Add(yomiuri);

            Tray trayYahoo = factory.CreateTray("Yahoo!");
            trayYahoo.Add(us_yahoo);
            trayYahoo.Add(jp_yahoo);

            Tray traySearch = factory.CreateTray("サーチエンジン");
            traySearch.Add(trayYahoo);
            traySearch.Add(excite);
            traySearch.Add(google);

            Page page = factory.CreatePage("LinkPage", "結城　浩");
            page.Add(trayNews);
            page.Add(traySearch);
            page.Output();
        }
    }
}
