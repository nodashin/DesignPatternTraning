using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Memeton.Sample.Game
{
    /// <summary>
    /// Gamerの状態を表すクラス
    /// </summary>
    public class Memento
    {
        /// <summary>
        /// 所持金
        /// </summary>
        internal int money;

        /// <summary>
        /// フルーツ
        /// </summary>
        internal List<string> fruits;

        /// <summary>
        /// コンストラクタ
        /// </summary>
        /// <param name="money">所持金</param>
        internal Memento(int money)
        {
            this.money = money;
            this.fruits = new List<string>();
        }

        /// <summary>
        /// 所持金を得る。(narrow interface)
        /// </summary>
        /// <returns>所持金</returns>
        public int GetMoney()
        {
            return money;
        }

        /// <summary>
        /// フルーツを追加する。
        /// </summary>
        /// <param name="fruit">追加するフルーツ</param>
        internal void AddFruit(string fruit)
        {
            fruits.Add(fruit);
        }

        /// <summary>
        /// フルーツを取得する。
        /// </summary>
        /// <returns>フルーツ</returns>
        List<string> GetFruit()
        {
            var clone = new List<string>();
            fruits.ForEach(s => clone.Add(s));
            return clone;
        }
    }
}
