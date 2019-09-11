using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Iterator.Traning
{
    /// <summary>
    /// イテレータ
    /// </summary>
    /// <typeparam name="TElement">イテレートする要素の型</typeparam>
    interface IIterator<TElement>
    {
        /// <summary>
        /// 次の要素を保持しているか。
        /// </summary>
        /// <returns>保持有無</returns>
        bool HasNext();

        /// <summary>
        /// 次の要素を取得する。
        /// </summary>
        /// <returns>次の要素</returns>
        TElement Next();
    }
}
