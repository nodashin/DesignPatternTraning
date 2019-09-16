using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Composite.Sample
{
    /// <summary>
    /// FileとDirectoryを同一視する抽象クラス。
    /// 役割；Component
    /// </summary>
    abstract class Entry
    {
        /// <summary>
        /// 名前を得る。
        /// </summary>
        /// <returns>名前</returns>
        public abstract string GetName();

        /// <summary>
        /// サイズを得る。
        /// </summary>
        /// <returns>サイズ</returns>
        public abstract int GetSize();

        /// <summary>
        /// ディレクトリの中にファイルやディレクトリを入れるメソッド。
        /// </summary>
        /// <param name="entry">中に入れるファイルやディレクトリ</param>
        /// <returns>入れたファイルやディレクトリ</returns>
        public Entry Add(Entry entry)
        {
            throw new FileTreatmebtException();
        }

        /// <summary>
        /// 一覧を表示する。
        /// </summary>
        public void PrintList()
        {
            PrintList("");
        }

        /// <summary>
        /// prefixを前につけて一覧を表示する。
        /// </summary>
        /// <param name="prefix">プレフィックス</param>
        public abstract void PrintList(string prefix);

        /// <summary>
        /// ToString
        /// </summary>
        /// <returns>自身を文字列に変換したもの</returns>
        public override string ToString()
        {
            return GetName() + "(" + GetSize() + ")";
        }
    }
}
