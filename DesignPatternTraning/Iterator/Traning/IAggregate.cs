using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Iterator.Traning
{
    /// <summary>
    /// 集合体
    /// </summary>
    /// <typeparam name="TElement">イテレートする要素の型</typeparam>
    interface IAggregate<TElement>
    {
        /// <summary>
        /// 集合体をスキャンするイテレータを生成する。
        /// </summary>
        /// <returns>集合体をスキャンするイテレータ</returns>
        IIterator<TElement> CreateIterator();
    }
}
