using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Strategy.Sample
{
    /// <summary>
    /// 勝ったら次も同じ手を出す戦略を表すクラス。
    /// </summary>
    class WinningStrategy : IStrategy
    {
        /// <summary>
        /// 前回負けた場合に次のじゃんけんの手を決めるときに使用する乱数発生器。
        /// </summary>
        private Random random;

        /// <summary>
        /// 前回の勝負の結果(勝ったかどうか)
        /// </summary>
        private bool won = false;

        /// <summary>
        /// 前回の勝負で出した手
        /// </summary>
        private Hand prevHand;

        /// <summary>
        /// コンストラクタ
        /// </summary>
        /// <param name="seed">シード値</param>
        public WinningStrategy(int seed)
        {
            random = new Random(seed);
        }

        /// <summary>
        /// 「次に出す手を得る」ためのメソッド。
        /// </summary>
        /// <returns>次に出す手</returns>
        public Hand NextHand()
        {
            if(!won)
            {
                prevHand = Hand.GetHand(random.Next(3));
            }
            return prevHand;
        }

        /// <summary>
        /// 「さっき出した手によって勝ったかどうか」を学習するためのメソッド。
        /// </summary>
        /// <param name="win">勝利有無</param>
        /// <example>
        /// 勝った場合：study(true)
        /// 負けた場合：study(false)
        /// </example>
        public void Study(bool win)
        {
            won = win;
        }
    }
}