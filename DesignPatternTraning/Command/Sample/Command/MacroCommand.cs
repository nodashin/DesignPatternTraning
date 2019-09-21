using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Command.Sample.Command
{
    /// <summary>
    /// 「複数の命令をまとめた命令」を表現するクラス。
    /// 役割：ConcreteCommand(具体的命令)
    /// </summary>
    public class MacroCommand : ICommand
    {
        /// <summary>
        /// 命令の集合
        /// </summary>
        private Stack<ICommand> commands = new Stack<ICommand>();

        /// <summary>
        /// 命令を実行する。
        /// </summary>
        public void Execute()
        {
            while(commands.Count > 0)
            {
                commands.Pop().Execute();
            }
        }

        /// <summary>
        /// 追加。
        /// </summary>
        /// <param name="cmd">追加するコマンド</param>
        public void Append(ICommand cmd)
        {
            if(cmd != this)
            {
                commands.Push(cmd);
            }
        }

        /// <summary>
        /// 最後の命令を削除する。
        /// </summary>
        public void Undo()
        {
            if(commands.Count != 0)
            {
                commands.Pop();
            }
        }

        /// <summary>
        /// 全部削除
        /// </summary>
        public void Clear()
        {
            commands.Clear();
        }
    }
}
