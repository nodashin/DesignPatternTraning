using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Iterator.Traning
{
    /// <summary>
    /// 集合体インタフェース
    /// </summary>
    interface IAggregate<T>
    {
        /// <summary>
        /// イテレータを生成する。
        /// </summary>
        /// <returns>イテレータ</returns>
        IIterator<T> CreateIterator();
    }
}
