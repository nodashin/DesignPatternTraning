using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using AbstractFactory.Sample.Factory;

namespace AbstractFactory.Sample
{
    /// <summary>
    /// 役割：Client(依頼者)
    /// </summary>
    class Main
    {
        public static void Execute()
        {
            Console.Write("工場のクラス名を入力してください。(1:ListFactory 2：TableFactory)：");
            var factoryType = Console.ReadLine();
            var factoryName = "AbstractFactory.Sample.";
            var fileName = "";
            switch (factoryType)
            {
                case "1":
                    factoryName += "ListFactory.ListFactory";
                    fileName = "LinkPage";
                    break;
                case "2":
                    factoryName += "TableFactory.TableFactory";
                    fileName = "TablePage";
                    break;
                default:
                    Console.WriteLine("1:ListFactory 2：TableFactory 以外のキーが押されました。");
                    Console.ReadKey();
                    return;
            }


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

            Page page = factory.CreatePage(fileName, "結城　浩");
            page.Add(trayNews);
            page.Add(traySearch);
            page.Output();
        }
    }
}
