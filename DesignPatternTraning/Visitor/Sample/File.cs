using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Visitor.Sample
{
    /// <summary>
    /// ファイルを表すクラス。
    /// 役割：ConcreteElement(具体的な要素)
    /// </summary>
    public class File : Entry
    {
        /// <summary>
        /// 名称
        /// </summary>
        private string name;

        /// <summary>
        /// サイズ
        /// </summary>
        private int size;

        /// <summary>
        /// コンストラクタ
        /// </summary>
        /// <param name="name">名称</param>
        /// <param name="size">サイズ</param>
        public File(string name, int size)
        {
            this.name = name;
            this.size = size;
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
        /// サイズを取得する。
        /// </summary>
        /// <returns>サイズ</returns>
        public override int GetSize()
        {
            return size;
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
