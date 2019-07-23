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
        /// 集合体を数え上げたい、スキャンしたい、1つずつ調べていきたいというときには、このIteratorメソッドを使って
        /// IIteratorインタフェースを実装したクラスのインスタンスを1個作る。
        /// </summary>
        /// <returns>IIteratorインタフェースを実装したクラスのインスタンス</returns>
        IIterator Iterator();
    }
}
