using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Decorator.Sample
{
    /// <summary>
    /// 「飾り枠」
    /// </summary>
    abstract class Border : Display
    {
        /// <summary>
        /// この飾り枠がくるんでいる「中身」を指す。
        /// </summary>
        protected Display display;

        /// <summary>
        /// コンストラクタ
        /// </summary>
        /// <param name="display">この飾り枠がくるんでいる「中身」</param>
        protected Border(Display display)
        {
            //インスタンス生成時に「中身」を引数で指定
            this.display = display;
        }
    }
}
