using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Common
{
    /// <summary>
    /// コンソールライター
    /// </summary>
    public static class ConsoleWriter
    {
        /// <summary>
        /// 開始メッセージを書き込む。
        /// </summary>
        /// <param name="programName">プログラム名</param>
        public static void WriteStart(string programName)
        {
            Console.WriteLine($"***** {programName} start *****");
            Console.WriteLine();
        }

        /// <summary>
        /// 終了メッセージを書き込む。
        /// </summary>
        /// <param name="programName">プログラム名</param>
        public static void WriteEnd(string programName)
        {
            Console.WriteLine();
            Console.WriteLine($"***** {programName} end *****");
        }

        /// <summary>
        /// プログラム間の区切りを書き込む。
        /// </summary>
        public static void WriteDelimiter()
        {
            Console.WriteLine();
            Console.WriteLine();
        }
    }
}
