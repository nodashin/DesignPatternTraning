using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Adapter.Sample1.Elements
{
    /// <summary>
    /// 必要なもの
    /// </summary>
    interface IPrint
    {
        /// <summary>
        /// 弱く出力する。
        /// </summary>
        void PrintWeak();

        /// <summary>
        /// 強く出力する。
        /// </summary>
        void PrintStrong();
    }
}
