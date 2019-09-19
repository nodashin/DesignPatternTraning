using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace Observer.Sample
{
    /// <summary>
    /// 簡易グラフで数を表現するクラス。
    /// </summary>
    public class GraphObserver : IObserver
    {
        /// <summary>
        /// NumberGeneratorが「私の内容が更新されました。表示の方も更新してください」とObserverに伝えるためのメソッド。
        /// </summary>
        /// <param name="generator">NumberGenerator</param>
        public void Update(NumberGenerator generator)
        {
            int count = generator.GetNumber();
            for (int i = 0; i < count; i++)
            {
                Console.Write("*");
            }
            Console.WriteLine();
            Thread.Sleep(100);
        }
    }
}
