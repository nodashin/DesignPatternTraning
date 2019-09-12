using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Builder.Traning1
{
    /// <summary>
    /// ドキュメントビルダー
    /// </summary>
    interface IDocumentBuilder
    {
        /// <summary>
        /// タイトルを書き込む。
        /// </summary>
        /// <param name="title">書き込むタイトル</param>
        void WriteTitle(string title);

        /// <summary>
        /// 文字列を書き込むする。
        /// </summary>
        /// <param name="string">書き込む文字列</param>
        void WriteString(string @string);

        /// <summary>
        /// 箇条書きを書き込む。
        /// </summary>
        /// <param name="items">書き込む箇条書きの項目</param>
        void WriteItems(params string[] items);

        /// <summary>
        /// 完了する。
        /// </summary>
        /// <returns>
        /// 実装クラスによる。
        /// </returns>
        string Complete();
    }
}
