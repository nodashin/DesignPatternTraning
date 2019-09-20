namespace State.Sample
{
    /// <summary>
    /// 金庫の状態を管理し、警備センターとの連絡をとるインタフェース。
    /// 役割：Context(状況、前後関係、文脈)
    /// </summary>
    public interface IContext
    {
        /// <summary>
        /// 時刻の設定。
        /// </summary>
        /// <param name="hour">時刻</param>
        void SetClock(int hour);

        /// <summary>
        /// 状態変化
        /// </summary>
        /// <param name="state">状態</param>
        void ChangeState(IState state);

        /// <summary>
        /// 警備センター呼び出し
        /// </summary>
        /// <param name="msg">メッセージ</param>
        void CallSeculityCenter(string msg);

        /// <summary>
        /// 警備センター記録
        /// </summary>
        /// <param name="msg">メッセージ</param>
        void RecordLog(string msg);
    }
}