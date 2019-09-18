using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Visitor.Sample
{
    /// <summary>
    /// ディレクトリを表すクラス。
    /// </summary>
    public class Directory : Entry
    {
        /// <summary>
        /// 名称
        /// </summary>
        private string name;

        /// <summary>
        /// ディレクトリエントリの集合
        /// </summary>
        private List<Entry> dir = new List<Entry>();

        /// <summary>
        /// コンストラクタ
        /// </summary>
        /// <param name="name">名称</param>
        public Directory(string name)
        {
            this.name = name;
        }

        /// <summary>
        /// 名称を取得する。
        /// </summary>
        /// <returns>名称</returns>
        public override string GetName()
        {
            return name;
        }

        /// <summary>
        /// エントリを追加する。
        /// </summary>
        /// <param name="entry">エントリ</param>
        /// <returns>追加したエントリ</returns>
        public override Entry Add(Entry entry)
        {
            dir.Add(entry);
            return entry;
        }

        /// <summary>
        /// Iteratorの生成。
        /// </summary>
        /// <returns>Iterator</returns>
        /// <remarks>
        /// Iteratorを作るのが面倒なのでコレクションを返す。
        /// </remarks>
        public override List<Entry> Iterator()
        {
            return dir;
        }

        /// <summary>
        /// サイズを取得する。
        /// </summary>
        /// <returns>サイズ</returns>
        public override int GetSize()
        {
            return dir.Sum(e => e.GetSize());
        }

        /// <summary>
        /// 訪問者を受け入れる。
        /// </summary>
        /// <param name="v">訪問者</param>
        public override void Accept(Visitor v)
        {
            v.Visit(this);
        }
    }
}
