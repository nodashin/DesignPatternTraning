using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace Observer.Sample
{
    /// <summary>
    /// 数字で数を表現するクラス
    /// </summary>
    public class DigitObserver : IObserver
    {
        /// <summary>
        /// NumberGeneratorが「私の内容が更新されました。表示の方も更新してください」とObserverに伝えるためのメソッド。
        /// </summary>
        /// <param name="generator">NumberGenerator</param>
        public void Update(NumberGenerator generator)
        {
            Console.WriteLine("DigitObserver:" + generator.GetNumber());
            Thread.Sleep(100);
        }
    }
}
