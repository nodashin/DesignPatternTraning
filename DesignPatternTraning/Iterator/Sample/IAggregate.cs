using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Iterator.Sample
{
    /// <summary>
    /// 集合体を表すインタフェース
    /// </summary>
    interface IAggregate
    {
        /// <summary>
        /// 集合体に対応するIteratorを1個作成する。
        /// </summary>
        /// <returns>集合体に対応するIterator</returns>
        IIterator Iterator();
    }
}
