using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Decorator.Sample
{
    /// <summary>
    /// 1行だけからなる文字列表示用のクラス
    /// </summary>
    class StringDisplay : Display
    {
        /// <summary>
        /// 表示する文字列
        /// </summary>
        private string @string;

        /// <summary>
        /// コンストラクタ
        /// </summary>
        /// <param name="string">表示する文字列</param>
        public StringDisplay(string @string)
        {
            this.@string = @string;
        }

        /// <summary>
        /// 横の文字数を得る。
        /// </summary>
        /// <returns>横の文字数</returns>
        public override int GetColumns()
        {
            return Encoding.GetEncoding("shift-jis").GetBytes(@string).Length;
        }

        /// <summary>
        /// 縦の文字数を得る。
        /// </summary>
        /// <returns>縦の文字数</returns>
        public override int GetRows()
        {
            //1行なので1固定。
            return 1;
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
                return @string;
            }
            else
            {
                return null;
            }
        }
    }
}
