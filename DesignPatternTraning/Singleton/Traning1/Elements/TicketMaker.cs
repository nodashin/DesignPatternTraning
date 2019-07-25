using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Singleton.Traning1.Elements
{
    /// <summary>
    /// チケットメーカー
    /// </summary>
    class TicketMaker
    {
        /// <summary>
        /// チケット№
        /// </summary>
        private int ticket = 1000;

        /// <summary>
        /// チケットメーカーインスタンス
        /// </summary>
        private static TicketMaker singleton = new TicketMaker();

        /// <summary>
        /// コンストラクタ
        /// </summary>
        private TicketMaker()
        {
        }

        /// <summary>
        /// チケット№を取得する。
        /// </summary>
        /// <returns>チケット№</returns>
        public int GetNextTicketNumber()
        {
            return ticket++;
        }

        /// <summary>
        /// チケットメーカーを取得する。
        /// </summary>
        /// <returns>チケットメーカー</returns>
        public static TicketMaker GetTicketMaker()
        {
            return singleton;
        }
    }
}
