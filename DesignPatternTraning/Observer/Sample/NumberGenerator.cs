using System.Collections.Generic;

namespace Observer.Sample
{
    /// <summary>
    /// 数を生成するオブジェクトを表す抽象クラス。
    /// 役割：Subject(被験者)
    /// </summary>
    public abstract class NumberGenerator
    {
        /// <summary>
        /// Observerたちを保存
        /// </summary>
        private List<IObserver> observers = new List<IObserver>();

        /// <summary>
        /// Observerを追加する。
        /// </summary>
        /// <param name="observer">追加するObserver</param>
        public void AddObserver(IObserver observer)
        {
            observers.Add(observer);
        }

        /// <summary>
        /// Observerを削除する。
        /// </summary>
        /// <param name="observer">削除するObserver</param>
        public void DeleteObserver(IObserver observer)
        {
            observers.Remove(observer);
        }

        /// <summary>
        /// Observerへ通知する。
        /// </summary>
        public void NotifyObservers()
        {
            foreach (var o in observers)
            {
                o.Update(this);
            }
        }

        /// <summary>
        /// 数を取得する。
        /// </summary>
        /// <returns>数</returns>
        public abstract int GetNumber();

        /// <summary>
        /// 数を生成する。
        /// </summary>
        public abstract void Exeute();
    }
}