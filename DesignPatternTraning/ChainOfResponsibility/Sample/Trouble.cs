using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ChainOfResponsibility.Sample
{
    /// <summary>
    /// 発生したトラブルを表すクラス。
    /// </summary>
    class Trouble
    {
        /// <summary>
        /// トラブル番号
        /// </summary>
        private int number;

        /// <summary>
        /// コンストラクタ
        /// </summary>
        /// <param name="number">トラブル番号</param>
        public Trouble(int number)
        {
            this.number = number;
        }

        /// <summary>
        /// トラブル番号を取得する。
        /// </summary>
        /// <returns>トラブル番号</returns>
        public int GetNumber()
        {
            return number;
        }

        /// <summary>
        /// トラブルの文字列表現。
        /// </summary>
        /// <returns>トラブルの文字列</returns>
        public override string ToString()
        {
            return "[Trouble" + number + "]"; 
        }
    }
}
