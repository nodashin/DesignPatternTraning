﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Adapter.Sample1.Elements;

namespace Adapter.Sample1
{
    class Sample1
    {
        /// <summary>
        /// 与えられた文字列を変換する。
        /// </summary>
        public void Execute()
        {
            IPrint p = new PrintBanner("Hello");
            p.PrintWeak();
            p.PrintStrong();
        }
    }
}
