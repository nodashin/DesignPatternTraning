using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Strategy.Sample
{
    /// <summary>
    /// じゃんけんの「戦略」のための抽象メソッド
    /// </summary>
    interface IStrategy
    {
        /// <summary>
        /// 「次に出す手を得る」ためのメソッド。
        /// </summary>
        /// <returns>次に出す手</returns>
        Hand NextHand();

        /// <summary>
        /// 「さっき出した手によって勝ったかどうか」を学習するためのメソッド。
        /// </summary>
        /// <param name="win">勝利有無</param>
        /// <example>
        /// 勝った場合：study(true)
        /// 負けた場合：study(false)
        /// </example>
        void Study(bool win);
    }
}
