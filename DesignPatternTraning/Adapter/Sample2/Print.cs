using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Adapter.Sample2
{
    /// <summary>
    /// 必要とされている機能を持つクラス
    /// 役割：Target(対象)
    /// </summary>
    abstract class Print
    {
        /// <summary>
        /// 文字列を弱く表示する。
        /// </summary>
        public abstract void PrintWeek();

        /// <summary>
        /// 文字列を強く表示する。
        /// </summary>
        public abstract void PrintStrong();
    }
}
