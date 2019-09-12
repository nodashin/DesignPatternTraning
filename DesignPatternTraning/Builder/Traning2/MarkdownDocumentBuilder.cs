using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Builder.Traning1;

namespace Builder.Traning2
{
    /// <summary>
    /// Markdownドキュメントビルダー
    /// </summary>
    class MarkdownDocumentBuilder : IDocumentBuilder
    {
        /// <summary>
        /// ファイルパス
        /// </summary>
        private readonly string filePath;

        /// <summary>
        /// StreamWriter
        /// </summary>
        private readonly StreamWriter writer;

        /// <summary>
        /// コンストラクタ
        /// </summary>
        /// <param name="fileNameWithoutExtension">拡張子無しファイル名</param>
        public MarkdownDocumentBuilder(string fileNameWithoutExtension)
        {
            this.filePath = fileNameWithoutExtension + ".md";
            this.writer = new StreamWriter(this.filePath);
        }

        /// <summary>
        /// タイトルを書き込む。
        /// </summary>
        /// <param name="title">タイトル</param>
        public void WriteTitle(string title)
        {
            this.writer.WriteLine($"# {title}");
            this.writer.WriteLine();
        }

        /// <summary>
        /// 文字列を書き込む。
        /// </summary>
        /// <param name="string">文字列</param>
        public void WriteString(string @string)
        {
            this.writer.Write($"{@string}");
            this.WriteMarkdownNewLine();
        }

        /// <summary>
        /// 箇条書きを書き込む。
        /// </summary>
        /// <param name="items">箇条書き項目</param>
        public void WriteItems(params string[] items)
        {
            foreach (var item in items)
                this.writer.WriteLine($"* {item}");
            this.writer.WriteLine();
        }

        /// <summary>
        /// 完了する。
        /// </summary>
        /// <returns>ファイル名</returns>
        public string Complete()
        {
            this.writer.Close();
            return this.filePath;
        }

        /// <summary>
        /// Markdown用の改行を書き込む。
        /// </summary>
        void WriteMarkdownNewLine()
            => this.writer.WriteLine("  ");
       
    }
}
