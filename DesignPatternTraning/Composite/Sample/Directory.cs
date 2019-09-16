using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Composite.Sample
{
    /// <summary>
    /// ディレクトリを表すクラス。
    /// </summary>
    class Directory : Entry
    {
        /// <summary>
        /// 名前
        /// </summary>
        private string name;

        /// <summary>
        /// ディレクトリエントリの集合
        /// </summary>
        private List<Entry> directory = new List<Entry>();

        /// <summary>
        /// コンストラクタ
        /// </summary>
        /// <param name="name">名前</param>
        public Directory(string name)
        {
            this.name = name;
        }

        /// <summary>
        /// 名前を得る。
        /// </summary>
        /// <returns>名前</returns>
        public override string GetName()
        {
            return name;
        }

        /// <summary>
        /// サイズを得る。
        /// </summary>
        /// <returns>サイズ</returns>
        public override int GetSize()
        {
            int size = 0;
            foreach (var entry in directory)
            {
                size += entry.GetSize();
            }
            return size;
        }

        /// <summary>
        /// ディレクトリの中にファイルやディレクトリを入れるメソッド。
        /// </summary>
        /// <param name="entry">中に入れるファイルやディレクトリ</param>
        /// <returns>入れたファイルやディレクトリ</returns>
        public Entry Add(Entry entry)
        {
            directory.Add(entry);
            return entry;
        }

        /// <summary>
        /// prefixを前につけて一覧を表示する。
        /// </summary>
        /// <param name="prefix">プレフィックス</param>
        public override void PrintList(string prefix)
        {
            Console.WriteLine(prefix + "/" + this);
            foreach (var entry in directory)
            {
                entry.PrintList(prefix + "/" + name);
            }
        }
    }
}
