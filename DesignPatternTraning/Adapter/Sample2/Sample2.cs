using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Adapter.Sample2.Elements;

namespace Adapter.Sample2
{
    class Sample2
    {
        /// <summary>
        /// 与えられた文字列を変換する。
        /// </summary>
        public void Execute()
        {
            Print p = new PrintBanner("Hello");
            p.PrintWeak();
            p.PrintStrong();
        }
    }
}
