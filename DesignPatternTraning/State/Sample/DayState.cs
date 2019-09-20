using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace State.Sample
{
    /// <summary>
    /// IStateを実装しているクラス。昼間の状態を表す。
    /// </summary>
    public class DayState : IState
    {
        /// <summary>
        /// シングルトン
        /// </summary>
        private static DayState singleton = new DayState();

        /// <summary>
        /// コンストラクタ
        /// </summary>
        private DayState() { }

        /// <summary>
        /// インスタンスを取得する。
        /// </summary>
        /// <returns>DayState</returns>
        public static IState GetInstance()
        {
            return singleton;
        }

        /// <summary>
        /// 時刻設定。
        /// </summary>
        /// <param name="context">コンテキスト</param>
        /// <param name="hour">時間</param>
        public void DoClock(IContext context, int hour)
        {
            if(hour < 9 || 17 <= hour)
            {
                context.ChangeState(NightState.GetInstance());
            }
        }

        /// <summary>
        /// 金庫使用。
        /// </summary>
        /// <param name="context">コンテキスト</param>
        public void DoUse(IContext context)
        {
            context.RecordLog("金庫使用(昼間)");
        }

        /// <summary>
        /// 非常ベル。
        /// </summary>
        /// <param name="context">コンテキスト</param>
        public void DoAlarm(IContext context)
        {
            context.CallSeculityCenter("非常ベル(昼間)");
        }

        /// <summary>
        /// 通常通話。
        /// </summary>
        /// <param name="context">コンテキスト</param>
        public void DoPhone(IContext context)
        {
            context.CallSeculityCenter("通常の通話(昼間)");
        }

        /// <summary>
        /// 文字列表現。
        /// </summary>
        /// <returns>文字列</returns>
        public override string ToString()
        {
            return "[昼間]";
        }
    }
}
