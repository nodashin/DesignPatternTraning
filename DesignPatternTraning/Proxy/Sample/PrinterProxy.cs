﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace Proxy.Sample
{
    /// <summary>
    /// 名前つきのプリンタを表すクラス(代理人)
    /// 役割：Proxy(代理人)
    /// </summary>
    public class PrinterProxy : IPrintable
    {
        /// <summary>
        /// 名前
        /// </summary>
        private string name;

        /// <summary>
        /// 本人
        /// </summary>
        private Printer real;

        /// <summary>
        /// コンストラクタ
        /// </summary>
        /// <param name="name">名前</param>
        public PrinterProxy(string name)
        {
            this.name = name;
        }

        /// <summary>
        /// 名前の設定。
        /// </summary>
        /// <param name="name">名前</param>
        public void SetPrinterName(string name)
        {
            if (real != null)
            {
                Monitor.Enter(real);
                real.SetPrinterName(name);
                Monitor.Exit(real);
            }
            this.name = name;
        }

        /// <summary>
        /// 名前の取得。
        /// </summary>
        /// <returns>名前</returns>
        public string GetPrinterName()
        {
            return name;
        }

        /// <summary>
        /// プリントする。
        /// </summary>
        /// <param name="string">プリントする内容</param>
        public void Print(string @string)
        {
            Realize();
            Monitor.Enter(real);
            real.Print(@string);
            Monitor.Exit(real);
        }

        /// <summary>
        /// 「本人」を生成
        /// </summary>
        private void Realize()
        {
            if(real == null)
            {
                real = new Printer(name);
            }
        }
    }
}
