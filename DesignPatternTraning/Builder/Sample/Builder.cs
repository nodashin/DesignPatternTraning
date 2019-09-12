using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Builder.Sample
{
    /// <summary>
    /// 文章を構成するためのメソッドを定めた抽象クラス
    /// </summary>
    abstract class Builder
    {
        /// <summary>
        /// タイトルを文章中に構築するメソッド
        /// </summary>
        /// <param name="title">タイトル</param>
        public abstract void MakeTitle(string title);

        /// <summary>
        /// 文字列を文章中に構築するメソッド
        /// </summary>
        /// <param name="str">文字列</param>
        public abstract void MakeString(string str);

        /// <summary>
        /// 箇条書きを文章中に構築するメソッド
        /// </summary>
        /// <param name="items">箇条書き</param>
        public abstract void MakeItems(string[] items);

        /// <summary>
        /// 文章を完成させるメソッド
        /// </summary>
        public abstract void Close();
    }
}
