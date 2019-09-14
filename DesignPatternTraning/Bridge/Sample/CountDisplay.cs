using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Bridge.Sample
{
    /// <summary>
    /// Displayクラスに機能を追加したもの。
    /// </summary>
    class CountDisplay : Display
    {
        /// <summary>
        /// コンストラクタ
        /// </summary>
        /// <param name="impl">Displayクラスの「実装」を表すインスタンス</param>
        public CountDisplay(DisplayImpl impl) : base(impl)
        {
        }

        /// <summary>
        /// 指定回数だけ表示する。
        /// </summary>
        /// <param name="times">表示する回数</param>
        public void MultiDisplay(int times)
        {
            Open();
            for (int i = 0; i < times; i++)
            {
                Print();
            }
            Close();
        }
    }
}
