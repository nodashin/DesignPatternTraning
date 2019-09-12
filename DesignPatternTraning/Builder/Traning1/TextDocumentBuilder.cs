using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Builder.Traning1
{
    /// <summary>
    /// テキストドキュメントビルダー
    /// </summary>
    class TextDocumentBuilder : IDocumentBuilder
    {
        /// <summary>
        /// 現在書き込まれている内容
        /// </summary>
        private readonly StringBuilder wroteContent = new StringBuilder();

        /// <summary>
        /// タイトルを書き込む。
        /// </summary>
        /// <param name="title">書き込むタイトル</param>
        public void WriteTitle(string title)
        {
            this.WriteLine();
            this.wroteContent.Append($"『{title}』");
            this.wroteContent.Append(Environment.NewLine);
        }

        /// <summary>
        /// 文字列を書き込むする。
        /// </summary>
        /// <param name="string">書き込む文字列</param>
        public void WriteString(string @string)
        {
            this.wroteContent.Append($"■{@string}");
            this.wroteContent.Append(Environment.NewLine);
            this.wroteContent.Append(Environment.NewLine);
        }

        /// <summary>
        /// 箇条書きを書き込む。
        /// </summary>
        /// <param name="items">書き込む箇条書きの項目</param>
        public void WriteItems(params string[] items)
        {
            foreach (var item in items)
                this.wroteContent.Append($"・{item}");
            this.wroteContent.Append(Environment.NewLine);
        }

        /// <summary>
        /// 完了する。
        /// </summary>
        /// <returns>
        /// 作成した内容
        /// </returns>
        public string Complete()
        {
            throw new NotImplementedException();
        }

        /// <summary>
        /// 飾り線を書き込む。
        /// </summary>
        void WriteLine()
            => this.wroteContent.Append("==================================================" + Environment.NewLine);
    }
}
