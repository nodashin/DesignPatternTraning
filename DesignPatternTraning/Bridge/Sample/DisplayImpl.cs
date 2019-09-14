using System;

namespace Bridge.Sample
{
    /// <summary>
    /// 「実装のクラス階層」の最上位に位置する。
    /// 役割：Implementor(実装者)
    /// </summary>
    abstract class DisplayImpl
    {
        /// <summary>
        /// Display.Openに対応するメソッド。
        /// 前処理。
        /// </summary>
        public abstract void RawOpen();

        /// <summary>
        /// Display.Printに対応するメソッド。
        /// 表示。
        /// </summary>
        public abstract void RawPrint();

        /// <summary>
        /// Display.Closeに対応するメソッド。
        /// 後処理。
        /// </summary>
        public abstract void RawClose();
    }
}