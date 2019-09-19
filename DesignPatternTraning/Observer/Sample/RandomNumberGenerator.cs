using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Observer.Sample
{
    /// <summary>
    /// ランダムに数を生成するクラス。
    /// </summary>
    public class RandomNumberGenerator : NumberGenerator
    {
        /// <summary>
        /// 乱数発生器
        /// </summary>
        private Random random = new Random();

        /// <summary>
        /// 現在の数
        /// </summary>
        private int number;

        /// <summary>
        /// 数を取得する。
        /// </summary>
        /// <returns>数</returns>
        public override int GetNumber()
        {
            return number;
        }

        /// <summary>
        /// 数を生成する。
        /// </summary>
        public override void Exeute()
        {
            for (int i = 0; i < 20; i++)
            {
                number = random.Next(50);
                NotifyObservers();
            }
        }
    }
}
