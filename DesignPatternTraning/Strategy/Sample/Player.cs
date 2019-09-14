using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Strategy.Sample
{
    /// <summary>
    /// じゃんけんを行う人
    /// 役割：Context(文脈)
    /// </summary>
    class Player
    {
        /// <summary>
        /// じゃんけんを行う人の名前
        /// </summary>
        private string name;

        /// <summary>
        /// じゃんけんの戦略
        /// </summary>
        private IStrategy strategy;

        /// <summary>
        /// 勝ち数
        /// </summary>
        private int winCount;

        /// <summary>
        /// 負け数
        /// </summary>
        private int loseCount;

        /// <summary>
        /// ゲーム回数
        /// </summary>
        private int gameCount;

        /// <summary>
        /// コンストラクタ
        /// </summary>
        /// <param name="name">じゃんけんを行う人の名前</param>
        /// <param name="strategy">じゃんけんの戦略</param>
        public Player(string name, IStrategy strategy)
        {
            this.name = name;
            this.strategy = strategy;
        }

        /// <summary>
        /// 次の手を出す。
        /// </summary>
        /// <returns>出す手</returns>
        public Hand NextHand()
        {
            return strategy.NextHand();
        }

        /// <summary>
        /// 勝った。
        /// </summary>
        public void Win()
        {
            strategy.Study(true);
            winCount++;
            gameCount++;
        }

        /// <summary>
        /// 負けた。
        /// </summary>
        public void Lose()
        {
            strategy.Study(false);
            loseCount++;
            gameCount++;
        }

        /// <summary>
        /// 引き分け
        /// </summary>
        public void Even()
        {
            gameCount++;
        }

        /// <summary>
        /// ToString()
        /// </summary>
        /// <returns>string</returns>
        public override string ToString()
        {
            return "[" + name + ":" + gameCount + " games, " + winCount + " win, " + loseCount + " lose" + "]";
        }
    }
}
