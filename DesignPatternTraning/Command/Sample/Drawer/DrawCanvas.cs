using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Command.Sample.Command;

namespace Command.Sample.Drawer
{
    /// <summary>
    /// 「描画対象」を実装したクラス。
    /// </summary>
    /// <remarks>
    /// 参考書だけではC#に置き換えられなかったので下記URLを参考にした。
    /// https://qiita.com/skyc_lin/items/0b4bbebd19225eaed054
    /// </remarks>
    public partial class DrawCanvas : UserControl, IDrawable
    {
        /// <summary>
        /// 描画色
        /// </summary>
        private Color color = Color.Red;

        /// <summary>
        /// 描画する点の半径
        /// </summary>
        private int radius = 6;

        /// <summary>
        /// 履歴
        /// </summary>
        private MacroCommand history;

        /// <summary>
        /// コンストラクタ
        /// </summary>
        public DrawCanvas()
        {
            InitializeComponent();
        }

        /// <summary>
        /// 履歴を設定する。
        /// </summary>
        /// <param name="history">履歴</param>
        /// <remarks>
        /// 参考書ではコンストラクタだが、UserControlはポトペタで配置するため、専用のメソッドを用意。
        /// </remarks>
        public void SetHistroy(MacroCommand history)
        {
            this.history = history;
        }

        /// <summary>
        /// OnPaint
        /// </summary>
        /// <param name="e">PaintEventArgs</param>
        /// <remarks>参考書ではpaintメソッド</remarks>
        protected override void OnPaint(PaintEventArgs e)
        {
            base.OnPaint(e);
            history?.Execute();
        }

        /// <summary>
        /// 描画
        /// </summary>
        /// <param name="x">描画位置X軸</param>
        /// <param name="y">描画位置Y軸</param>
        public void Draw(int x, int y)
        {
            using (Graphics g = CreateGraphics())
            using (Brush brush = new SolidBrush(color))
            {
                Rectangle rectangle = new Rectangle(x, y, radius, radius);
                g.FillEllipse(brush, rectangle);
            }
        }
    }
}
