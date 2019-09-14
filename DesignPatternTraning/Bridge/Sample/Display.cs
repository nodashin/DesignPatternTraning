using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Bridge.Sample
{
    /// <summary>
    /// 抽象的な「何かを表示するもの」。
    /// 「機能のクラス階層」の最上位にあるクラス。
    /// 役割：Abstraction(抽象化)
    /// </summary>
    class Display
    {
        /// <summary>
        /// Displayクラスの「実装」を表すインスタンス
        /// 橋渡し役。
        /// </summary>
        private DisplayImpl impl;

        /// <summary>
        /// コンストラクタ
        /// </summary>
        /// <param name="impl">Displayクラスの「実装」を表すインスタンス</param>
        public Display(DisplayImpl impl)
        {
            this.impl = impl;
        }

        /// <summary>
        /// Open
        /// </summary>
        public void Open()
        {
            impl.RawOpen();
        }

        /// <summary>
        /// Print
        /// </summary>
        public void Print()
        {
            impl.RawPrint();
        }

        /// <summary>
        /// Close
        /// </summary>
        public void Close()
        {
            impl.RawClose();
        }

        /// <summary>
        /// 表示する。
        /// </summary>
        public void Dislay()
        {
            Open();
            Print();
            Close();
        }
    }
}
