using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Decorator.Sample
{
    /// <summary>
    /// 文字列表示用の抽象クラス。
    /// </summary>
    abstract class Display
    {
        /// <summary>
        /// 横の文字数を得る。
        /// </summary>
        /// <returns>横の文字数</returns>
        public abstract int GetColumns();

        /// <summary>
        /// 縦の文字数を得る。
        /// </summary>
        /// <returns>縦の文字数</returns>
        public abstract int GetRows();

        /// <summary>
        /// 指定した行の文字列を得る。
        /// </summary>
        /// <param name="row">得たい文字列の行</param>
        /// <returns>指定した行の文字列</returns>
        public abstract string GetRowText(int row);

        /// <summary>
        /// すべての行の文字列を表示する。
        /// </summary>
        public void Show()
        {
            for (int i = 0; i < GetRows(); i++)
            {
                Console.WriteLine(GetRowText(i));
            }
        }
    }
}
