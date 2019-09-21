using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Command.Sample.Command;

namespace Command.Sample.Drawer
{
    /// <summary>
    /// 「点の描画命令」を表現するクラス。
    /// </summary>
    public class DrawCommand : ICommand
    {
        /// <summary>
        /// 描画対象
        /// </summary>
        protected IDrawable drawable;

        /// <summary>
        /// 描画位置
        /// </summary>
        private Point position;

        /// <summary>
        /// コンストラクタ
        /// </summary>
        /// <param name="drawable">描画対象</param>
        /// <param name="position">描画位置</param>
        public DrawCommand(IDrawable drawable, Point position)
        {
            this.drawable = drawable;
            this.position = position;
        }

        /// <summary>
        /// 実行
        /// </summary>
        public void Execute()
        {
            drawable.Draw(position.X, position.Y);
        }
    }
}
