using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Visitor.Sample
{
    /// <summary>
    /// FileとDirectoryのスーパークラスとなる抽象クラス。
    /// (Acceptorインタf－エスを実装)
    /// </summary>
    public abstract class Entry : IElement
    {
        /// <summary>
        /// 名称を取得する。
        /// </summary>
        /// <returns>名称</returns>
        public abstract string GetName();

        /// <summary>
        /// サイズを取得する。
        /// </summary>
        /// <returns>サイズ</returns>
        public abstract int GetSize();

        /// <summary>
        /// エントリを追加する。
        /// </summary>
        /// <param name="entry">エントリ</param>
        /// <returns>追加したエントリ</returns>
        public virtual Entry Add(Entry entry)
        {
            throw new FileTreatmentException();
        }

        /// <summary>
        /// Iteratorの生成。
        /// </summary>
        /// <returns>Iterator</returns>
        public virtual Iterator Iterator()
        {
            throw new FileTreatmentException();
        }

        /// <summary>
        /// 訪問者を受け入れる。
        /// </summary>
        /// <param name="v">訪問者</param>
        public abstract void Accept(Visitor v);

        /// <summary>
        /// ToString
        /// </summary>
        /// <returns>string</returns>
        public override string ToString()
        {
            return GetName() + "(" + GetSize() + ")";
        }
    }
}
