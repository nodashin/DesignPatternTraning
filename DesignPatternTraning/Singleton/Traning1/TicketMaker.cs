using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Singleton.Traning1
{
    /// <summary>
    /// チケットメーカー
    /// </summary>
    class TicketMaker
    {
        /// <summary>
        /// チケットNo.
        /// </summary>
        static int TicketNumber { get; set; } = 1000;

        /// <summary>
        /// コンストラクタ
        /// </summary>
        private TicketMaker() { }

        /// <summary>
        /// 次のチケットNo.を取得する。
        /// </summary>
        /// <returns>チケットNo</returns>
        public int GetNextTicketNumber()
            => TicketMaker.TicketNumber++;

        /// <summary>
        /// チケットメーカーを取得する。
        /// </summary>
        /// <returns>チケットメーカー</returns>
        public static TicketMaker GetTicketMaker()
            => new TicketMaker();
    }
}
