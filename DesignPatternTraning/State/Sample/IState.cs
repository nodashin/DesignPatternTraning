using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace State.Sample
{
    /// <summary>
    /// 金庫の状態を表すインタフェース。
    /// </summary>
    public interface IState
    {
        /// <summary>
        /// 時刻設定。
        /// </summary>
        /// <param name="context">コンテキスト</param>
        /// <param name="hour">時間</param>
        void DoClock(IContext context, int hour);

        /// <summary>
        /// 金庫使用。
        /// </summary>
        /// <param name="context">コンテキスト</param>
        void DoUse(IContext context);

        /// <summary>
        /// 非常ベル。
        /// </summary>
        /// <param name="context">コンテキスト</param>
        void DoAlarm(IContext context);

        /// <summary>
        /// 通常通話。
        /// </summary>
        /// <param name="context">コンテキスト</param>
        void DoPhone(IContext context);
    }
}
