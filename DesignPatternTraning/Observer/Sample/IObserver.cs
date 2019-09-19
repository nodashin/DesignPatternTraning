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
        void Update(NumberGenerator generator);
    }
}
