using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Adapter.Sample2.Elements
{
    /// <summary>
    /// プリント
    /// </summary>
    abstract class Print
    {
        /// <summary>
        /// 弱く出力する。
        /// </summary>
        public abstract void PrintWeak();

        /// <summary>
        /// 強く出力する。
        /// </summary>
        public abstract void PrintStrong();
    }
}
