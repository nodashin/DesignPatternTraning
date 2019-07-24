using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Adapter.Traning2.Elements;

namespace Adapter.Traning2
{
    /// <summary>
    /// 練習問題2-2
    /// </summary>
    class Traning2
    {
        /// <summary>
        /// 実行する。
        /// </summary>
        public void Execute()
        {
            IFileIO f = new FileProperties();

            f.ReadFromFile("file.txt");
            f.SetValue("year", "2004");
            f.SetValue("month", "4");
            f.SetValue("day", "21");
            f.WriteToFile("newFile.txt");
        }
    }
}
