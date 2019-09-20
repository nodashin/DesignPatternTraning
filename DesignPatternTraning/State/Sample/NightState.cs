using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace State.Sample
{
    /// <summary>
    /// IStateを実装しているクラス。夜間の状態を表す。
    /// </summary>
    public class NightState : IState
    {
        /// <summary>
        /// シングルトン
        /// </summary>
        private static NightState singleton = new NightState();

        /// <summary>
        /// コンストラクタ
        /// </summary>
        private NightState() { }

        /// <summary>
        /// インスタンスを取得する。
        /// </summary>
        /// <returns>NightState</returns>
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
            if (9 <= hour && hour < 17)
            {
                context.ChangeState(DayState.GetInstance());
            }
        }

        /// <summary>
        /// 金庫使用。
        /// </summary>
        /// <param name="context">コンテキスト</param>
        public void DoUse(IContext context)
        {
            context.RecordLog("非常：夜間の金庫使用！");
        }

        /// <summary>
        /// 非常ベル。
        /// </summary>
        /// <param name="context">コンテキスト</param>
        public void DoAlarm(IContext context)
        {
            context.CallSeculityCenter("非常ベル(夜間)");
        }

        /// <summary>
        /// 通常通話。
        /// </summary>
        /// <param name="context">コンテキスト</param>
        public void DoPhone(IContext context)
        {
            context.CallSeculityCenter("夜間の通話録音");
        }

        /// <summary>
        /// 文字列表現。
        /// </summary>
        /// <returns>文字列</returns>
        public override string ToString()
        {
            return "[夜間]";
        }
    }
}
