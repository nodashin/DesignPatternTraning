using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace IteratorExercise.Elemets
{
    /// <summary>
    /// イテレータインタフェース
    /// </summary>
    /// <typeparam name="T">イテレータで取り扱うクラスの型</typeparam>
    interface IIterator<T>
    {
        /// <summary>
        /// 現在の要素の次の要素が存在するか確認する。
        /// </summary>
        /// <returns>true:存在する false:存在しない</returns>
        bool HasNext();

        /// <summary>
        /// 現在の要素の次の要素を取得し、対象を次へ移動させる。
        /// </summary>
        /// <returns>現在の要素</returns>
        T GetNextElementAndAdvanceToNext();
    }
}
