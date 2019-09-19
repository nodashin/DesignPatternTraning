using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Observer.Sample
{
    /// <summary>
    /// 観測者を表すインタフェース
    /// </summary>
    public interface IObserver
    {
        /// <summary>
        /// NumberGeneratorが「私の内容が更新されました。表示の方も更新してください」とObserverに伝えるためのメソッド。
        /// </summary>
        /// <param name="generator"></param>
        void Update(NumberGenerator generator);
    }
}
