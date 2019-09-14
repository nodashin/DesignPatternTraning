using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Strategy.Sample
{
    /// <summary>
    /// 過去の勝ち負けの履歴を使って、それぞれ手を出す確率を変える戦略を表すクラス。
    /// 役割：ConcreteStrategy(具体的戦略)
    /// </summary>
    class ProbStrategy : IStrategy
    {
        /// <summary>
        /// 次のじゃんけんの手を決めるときに使用する乱数発生器。
        /// </summary>
        private Random random;

        /// <summary>
        /// 前回のじゃんけんの手の値
        /// </summary>
        private int PrevHandValue = 0;

        /// <summary>
        /// 今回のじゃんけんの手の値
        /// </summary>
        private int CurrentHandValue = 0;

        /// <summary>
        /// 過去の勝敗を反映した確率計算のための表
        /// history[前回出した手][今回出す手] = 勝利数
        /// </summary>
        private int[,] history = new int[3, 3]
        {
            {1, 1, 1 },
            {1, 1, 1 },
            {1, 1, 1 },
        };

        /// <summary>
        /// コンストラクタ
        /// </summary>
        /// <param name="seed">シード値</param>
        public ProbStrategy(int seed)
        {
            random = new Random(seed);
        }

        /// <summary>
        /// 「次に出す手を得る」ためのメソッド。
        /// </summary>
        /// <returns>次に出す手</returns>
        public Hand NextHand()
        {
            int bet = random.Next(GetSum(CurrentHandValue));
            int handvalue = 0;
            if (bet < history[CurrentHandValue, 0])
            {
                handvalue = 0;
            }
            else if (bet < history[CurrentHandValue, 0] + history[CurrentHandValue, 1])
            {
                handvalue = 1;
            }
            else
            {
                handvalue = 2;
            }
            PrevHandValue = CurrentHandValue;
            CurrentHandValue = handvalue;
            return Hand.GetHand(CurrentHandValue);
        }

        /// <summary>
        /// 指定したじゃんけんの手の値の過去の勝敗の総和を取得する。
        /// </summary>
        /// <param name="hv">じゃんけんの手の値</param>
        /// <returns>過去の勝敗の総和</returns>
        private int GetSum(int hv)
        {
            int sum = 0;
            for (int i = 0; i < 3; i++)
            {
                sum += history[hv, i];
            }
            return sum;
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
            if (win)
            {
                history[PrevHandValue, CurrentHandValue]++;
            }
            else
            {
                history[PrevHandValue, (CurrentHandValue + 1) % 3]++;
                history[PrevHandValue, (CurrentHandValue + 2) % 3]++;
            }
        }
    }
}
