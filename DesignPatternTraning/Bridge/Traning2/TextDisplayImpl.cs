using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Bridge.Sample;

namespace Bridge.Traning2
{
    /// <summary>
    /// テキストに出力するクラス。
    /// </summary>
    class TextDisplayImpl : DisplayImpl
    {
        /// <summary>
        /// ファイル名
        /// </summary>
        public string FileName { get; }

        /// <summary>
        /// 書き込む文字列
        /// </summary>
        public string WriteString { get; }

        /// <summary>
        /// StreamWriter
        /// </summary>
        StreamWriter Writer { get; set; }

        /// <summary>
        /// コンストラクタ
        /// </summary>
        /// <param name="fileName">ファイル名(拡張子無し)</param>
        /// <param name="writeString">書き込む文字列</param>
        public TextDisplayImpl(string fileName, string writeString)
        {
            FileName = fileName + ".txt";
            WriteString = writeString;
        }

        /// <summary>
        /// ファイルをOpenする。
        /// </summary>
        public override void RawOpen()
        {
            this.Writer = new StreamWriter(this.FileName);
        }

        /// <summary>
        /// ファイルに出力する。
        /// </summary>
        public override void RawPrint()
        {
            this.Writer.WriteLine(this.WriteString);
        }

        /// <summary>
        /// ファイルを閉じる。
        /// </summary>
        public override void RawClose()
        {
            this.Writer.Close();
        }
    }
}
