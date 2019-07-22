using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Iterator.Elements
{
    /// <summary>
    /// 集合体を表すインタフェース。
    /// </summary>
    interface IAggregate
    {
        /// <summary>
        /// 集合体に対応するIteratorを1個作成する。
        /// </summary>
        /// <returns>
        /// IIteratorインタフェースを実装したクラスを返す。
        /// </returns>
        /// <remarks>
        /// 集合体を数え上げたい、スキャンしたい、1つずつ調べていきたいというときには、このメソッドを使って
        /// IIteratorインタフェースを実装したクラスを1個作る。
        /// </remarks>
        IIterator Iterator();
    }
}
