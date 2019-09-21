using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Command.Sample
{
    /// <summary>
    /// 「命令」を表現するインタフェース
    /// </summary>
    public interface ICommand
    {
        /// <summary>
        /// 命令を実行する。
        /// </summary>
        void Execute();
    }
}
