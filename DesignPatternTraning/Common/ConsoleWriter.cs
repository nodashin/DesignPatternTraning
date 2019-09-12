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
    public class ConsoleWriter
    {
        /// <summary>
        /// プログラム名
        /// </summary>
        public string ProgramName { get; }

        /// <summary>
        /// プログラム名
        /// </summary>
        /// <param name="programName"></param>
        public ConsoleWriter(string programName)
        {
            ProgramName = programName;
        }

        /// <summary>
        /// 開始を書き込む。
        /// </summary>
        public void WriteStart()
        {
            Console.WriteLine($"***** {this.ProgramName} start *****");
            Console.WriteLine();
        }

        public void WriteEnd()
        {
            Console.WriteLine();
            Console.WriteLine($"***** {this.ProgramName} end *****");
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
