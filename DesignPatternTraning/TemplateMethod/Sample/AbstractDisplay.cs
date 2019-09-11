using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TemplateMethod.Sample
{
    /// <summary>
    /// メソッドDisplayのみ実装されている抽象クラス
    /// 役割：AbstractClass(抽象クラス)
    /// </summary>
    abstract class AbstractDisplay
    {
        /// <summary>
        /// サブクラスに処理をまかせる抽象メソッド(1) Open
        /// </summary>
        public abstract void Open();

        /// <summary>
        /// サブクラスに処理をまかせる抽象メソッド(2) Print
        /// </summary>
        public abstract void Print();

        /// <summary>
        /// サブクラスに処理をまかせる抽象メソッド(3) Close
        /// </summary>
        public abstract void Close();

        /// <summary>
        /// この抽象クラスで実装しているメソッドDisplay
        /// </summary>
        public void Display()
        {
            //まずOpenして…
            Open();

            //5回Printを繰り返して…
            for (int i = 0; i < 5; i++)
            {
                Print();
            }

            //最後にCloseする。
            Close();
        }
    }
}
