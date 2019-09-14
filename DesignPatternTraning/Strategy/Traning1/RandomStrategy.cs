using Strategy.Sample;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Strategy.Traning1
{
    /// <summary>
    /// ランダムストラテジ
    /// </summary>
    class RandomStrategy : IStrategy
    {
        /// <summary>
        /// 乱数シード
        /// </summary>
        public int Seed { get; }

        /// <summary>
        /// 乱数ジェネレータ
        /// </summary>
        Random Random { get; }

        /// <summary>
        /// コンストラクタ
        /// </summary>
        /// <param name="seed">乱数シード</param>
        public RandomStrategy(int seed)
        {
            this.Seed = seed;
            this.Random = new Random(seed);
        }

        /// <summary>
        /// 次の手を出す。
        /// </summary>
        /// <returns>次の手</returns>
        public Hand NextHand()
        {
            return Hand.GetHand(this.Random.Next(3));
        }

        /// <summary>
        /// 勝敗を学ぶ。
        /// </summary>
        /// <param name="win">勝利か否か</param>
        public void Study(bool win)
        {
            //何もしない。
        }
    }
}
