using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Iterator.Elements
{
    /// <summary>
    /// 数え上げ、スキャンを行うインタフェース。
    /// </summary>
    interface IIterator
    {
        /// <summary>
        /// 「次の要素」が存在するかどうかを調べる。
        /// </summary>
        /// <returns>
        /// 次の要素が存在したらtrueを返す。
        /// 次の要素が存在しなかったら(最後の要素までたどり着いたら)falseを返す。
        /// </returns>
        /// <remarks>
        /// ループの終了条件で使用する。
        /// </remarks>
        bool HasNext();

        /// <summary>
        /// 「次の要素」を得る。
        /// </summary>
        /// <returns>
        /// 次の要素を返す。
        /// </returns>
        /// <remarks>
        /// 内部状態を次に進めておくという仕事も兼ねる。
        /// </remarks>
        object Next();
    }
}