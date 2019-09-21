using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Command.Sample.Command
{
    /// <summary>
    /// 「命令」を表現するインタフェース
    /// 役割：Command(命令), Invoker(起動者)
    /// </summary>
    public interface ICommand
    {
        /// <summary>
        /// 命令を実行する。
        /// </summary>
        void Execute();
    }
}
