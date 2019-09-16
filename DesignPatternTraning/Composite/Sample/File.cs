using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Composite.Sample
{
    /// <summary>
    /// ファイルを表すクラス。
    /// 役割：Leaf(葉)
    /// </summary>
    class File : Entry
    {
        /// <summary>
        /// 名前
        /// </summary>
        private string name;

        /// <summary>
        /// サイズ
        /// </summary>
        private int size;

        /// <summary>
        /// コンストラクタ
        /// </summary>
        /// <param name="name">名前</param>
        /// <param name="size">サイズ</param>
        public File(string name, int size)
        {
            this.name = name;
            this.size = size;
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
            return size;
        }

        /// <summary>
        /// prefixを前につけて一覧を表示する。
        /// </summary>
        /// <param name="prefix">プレフィックス</param>
        public override void PrintList(string prefix)
        {
            Console.WriteLine(prefix + "/" + this);
        }
    }
}
