using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Adapter.Sample1
{
    /// <summary>
    /// 必要とされているインタフェース
    /// </summary>
    interface IPrint
    {
        /// <summary>
        /// 文字列を弱く表示する。
        /// </summary>
        void PrintWeek();

        /// <summary>
        /// 文字列を強く表示する。
        /// </summary>
        void PrintStrong();
    }
}
