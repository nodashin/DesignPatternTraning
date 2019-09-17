using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Decorator.Sample
{
    /// <summary>
    /// 左右にのみ飾り枠をつけるクラス。
    /// </summary>
    class SideBorder : Border
    {
        /// <summary>
        /// 飾りとなる文字
        /// </summary>
        private char borderChar;

        /// <summary>
        /// コンストラクタ
        /// </summary>
        /// <param name="display">この飾り枠がくるんでいる「中身」</param>
        /// <param name="ch">飾りとなる文字</param>
        public SideBorder(Display display, char ch) : base(display)
        {
            this.borderChar = ch;
        }

        /// <summary>
        /// 横の文字数を得る。
        /// </summary>
        /// <returns>横の文字数</returns>
        public override int GetColumns()
        {
            //文字数は中身の両側に飾り文字分を加えたもの。
            return 1 + display.GetColumns() + 1;
        }

        /// <summary>
        /// 縦の文字数を得る。
        /// </summary>
        /// <returns>縦の文字数</returns>
        public override int GetRows()
        {
            //行数は中身の行数と同じ。
            return display.GetRows();
        }

        /// <summary>
        /// 指定した行の文字列を得る。
        /// </summary>
        /// <param name="row">得たい文字列の行</param>
        /// <returns>指定した行の文字列</returns>
        public override string GetRowText(int row)
        {
            //指定行の内容は、中身の指定行の両側に飾り文字を付けたもの。
            return borderChar + display.GetRowText(row) + borderChar;
        }
    }
}
