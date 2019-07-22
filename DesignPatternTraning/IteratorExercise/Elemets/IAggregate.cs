using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace IteratorExercise.Elemets
{
    /// <summary>
    /// 集合体インタフェース
    /// </summary>
    /// <typeparam name="T">イテレータで取り扱うクラスの型</typeparam>
    interface IAggregate<T>
    {
        /// <summary>
        /// イテレータを生成する。
        /// </summary>
        /// <returns>イテレータ</returns>
        IIterator<T> CreateIterator();
    }
}
