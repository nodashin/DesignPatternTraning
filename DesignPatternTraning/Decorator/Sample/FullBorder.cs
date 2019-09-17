using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Decorator.Sample
{
    /// <summary>
    /// 上下左右に飾り枠をつけるクラス。
    /// 役割：ConreteDecorator(具体的な装飾者)
    /// </summary>
    class FullBorder : Border
    {
        /// <summary>
        /// コンストラクタ
        /// </summary>
        /// <param name="display">この飾り枠がくるんでいる「中身」</param>
        public FullBorder(Display display) : base(display)
        {
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
            //行数は中身の行数に上下の飾り文字を加えたもの。
            return 1 + display.GetRows() + 1;
        }

        /// <summary>
        /// 指定した行の文字列を得る。
        /// </summary>
        /// <param name="row">得たい文字列の行</param>
        /// <returns>指定した行の文字列</returns>
        public override string GetRowText(int row)
        {
            if(row == 0)
            {
                //枠の上端
                return "+" + MakeLine('-', display.GetColumns()) + "+";
            }
            else if(row == display.GetRows() + 1)
            {
                //枠の下端
                return "+" + MakeLine('-', display.GetColumns()) + "+";
            }
            else
            {
                //それ以外
                return "|" + display.GetRowText(row - 1) + "|";
            }
        }

        /// <summary>
        /// 指定した文字列を連結させた文字列を作る。
        /// </summary>
        /// <param name="ch">連結させる文字</param>
        /// <param name="count">連結させる回数</param>
        /// <returns>指定した文字列を連結させた文字列</returns>
        private string MakeLine(char ch, int count)
        {
            StringBuilder buf = new StringBuilder();
            for (int i = 0; i < count; i++)
            {
                buf.Append(ch);
            }
            return buf.ToString();
        }
    }
}
