using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace Proxy.Sample
{
    /// <summary>
    /// 名前つきのプリンタを表すクラス(本人)
    /// 役割：RealSubject(実際の主体)
    /// </summary>
    public class Printer : IPrintable
    {
        /// <summary>
        /// 名前
        /// </summary>
        private string name;

        /// <summary>
        /// コンストラクタ
        /// </summary>
        public Printer()
        {
            HeavyJob("Printerのインスタンスを生成中");
        }

        /// <summary>
        /// コンストラクタ
        /// </summary>
        /// <param name="name">名前</param>
        public Printer(string name)
        {
            this.name = name;
            HeavyJob("Printerのインスタンス(" + name + ")を生成中");
        }

        /// <summary>
        /// 名前の設定。
        /// </summary>
        /// <param name="name">名前</param>
        public void SetPrinterName(string name)
        {
            this.name = name;
        }

        /// <summary>
        /// 名前の取得。
        /// </summary>
        /// <returns>名前</returns>
        public string GetPrinterName()
        {
            return name;
        }

        /// <summary>
        /// プリントする。
        /// </summary>
        /// <param name="string">プリントする内容</param>
        public void Print(string @string)
        {
            Console.WriteLine("=== " + name + " ===");
            Console.WriteLine(@string);
        }

        /// <summary>
        /// 重い作業
        /// </summary>
        /// <param name="msg">メッセージ</param>
        private void HeavyJob(string msg)
        {
            Console.Write(msg);
            for (int i = 0; i < 5; i++)
            {
                Thread.Sleep(1000);
                Console.Write(".");
            }
            Console.WriteLine("完了。");
        }
    }
}
