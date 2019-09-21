using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Proxy.Sample
{
    /// <summary>
    /// 役割：Client(依頼人)
    /// </summary>
    class Main
    {
        public static void Execute()
        {
            IPrintable p = new PrinterProxy("Alice");
            Console.WriteLine("名前は現在" + p.GetPrinterName() + "です。");
            p.SetPrinterName("Bob");
            Console.WriteLine("名前は現在" + p.GetPrinterName() + "です。");
            p.Print("Hello, world.");
        }
    }
}
