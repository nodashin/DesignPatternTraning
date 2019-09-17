using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Decorator.Sample;

namespace Decorator.Traning1
{
    /// <summary>
    /// 上下飾り付け
    /// </summary>
    class UpDownBorder : Border
    {
        /// <summary>
        /// 飾り付け文字
        /// </summary>
        public char DecorateChar {get;}

        /// <summary>
        /// コンストラクタ
        /// </summary>
        /// <param name="display">中身</param>
        /// <param name="decorateChar">飾り付け文字</param>
        public UpDownBorder(Display display, char decorateChar) : base(display)
        {
            this.DecorateChar = decorateChar;
        }

        /// <summary>
        /// 縦の文字数を得る。
        /// </summary>
        /// <returns>縦の文字数</returns>
        public override int GetColumns()
        {
            return this.display.GetColumns();
        }

        /// <summary>
        /// 指定した行の文字列を得る。
        /// </summary>
        /// <param name="row">得たい文字列の行</param>
        /// <returns>指定した行の文字列</returns>
        public override int GetRows()
        {
            return this.display.GetRows() + 2; //+2は上下の飾り付け分。
        }

        /// <summary>
        /// すべての行の文字列を表示する。
        /// </summary>
        public override string GetRowText(int row)
        {
            switch (row)
            {
                case 0:
                case 2:
                    return this.MakeDecorateLine();
                case 1:
                    return this.GetRowText(row);
                default:
                    throw new IndexOutOfRangeException($"指定したrowが不正です。指定値：{row}");
            }
        }

        /// <summary>
        /// 飾り付け線を作成する。
        /// </summary>
        /// <returns>作成した飾り付け線</returns>
        string MakeDecorateLine()
        {
            var line = "";
            for (int i = 0; i < this.GetColumns(); i++)
            {
                line += this.DecorateChar;
            }

            return line;
        }
    }
}
