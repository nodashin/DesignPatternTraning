using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Prototype.Sample.Framework
{
    /// <summary>
    /// 抽象メソッド Use と CleateClone が宣言されているインタフェース
    /// </summary>
    interface IProduct : ICloneable
    {
        /// <summary>
        /// 使う。
        /// 「使う」が何を意味するかは、サブクラスの実装にまかされている。
        /// </summary>
        /// <param name="s">引数</param>
        void Use(string s);

        /// <summary>
        /// インスタンスの複製を行うためのもの。
        /// </summary>
        /// <returns>複製したインタフェース</returns>
        IProduct CreateClone();
    }
}
