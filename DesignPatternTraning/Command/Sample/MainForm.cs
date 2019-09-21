using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Command.Sample.Command;
using Command.Sample.Drawer;

namespace Command.Sample
{
    /// <summary>
    /// 画面
    /// 役割：Client(依頼者), Invoker(起動者)
    /// </summary>
    /// <remarks>
    /// 参考書だけではC#に置き換えられなかったので下記URLを参考にした。
    /// https://qiita.com/skyc_lin/items/0b4bbebd19225eaed054
    /// </remarks>
    public partial class MainForm : Form
    {
        /// <summary>
        /// 描画履歴
        /// </summary>
        private MacroCommand history = new MacroCommand();

        /// <summary>
        /// ドラッグ中かどうか。
        /// </summary>
        bool drag = false;

        /// <summary>
        /// コンストラクタ
        /// </summary>
        public MainForm()
        {
            InitializeComponent();
        }

        /// <summary>
        /// コンストラクタ
        /// </summary>
        /// <param name="text">テキスト</param>
        public MainForm(string text) : this()
        {
            this.Text = text;
        }

        /// <summary>
        /// clearButton_Click
        /// </summary>
        /// <param name="sender">object</param>
        /// <param name="e">EventArgs</param>
        private void buttonClear_Click(object sender, EventArgs e)
        {
            history.Clear();
            this.drawCanvas.Invalidate();
        }

        /// <summary>
        /// キャンバス_MouseDown
        /// </summary>
        /// <param name="sender">object</param>
        /// <param name="e">MouseEventArgs</param>
        private void drawCanvas_MouseDown(object sender, MouseEventArgs e)
        {
            this.drag = true;
        }

        /// <summary>
        /// キャンバス_MouseUp
        /// </summary>
        /// <param name="sender">object</param>
        /// <param name="e">MouseEventArgs</param>
        private void drawCanvas_MouseUp(object sender, MouseEventArgs e)
        {
            this.drag = false;
        }

        /// <summary>
        /// キャンバス_MouseMove
        /// </summary>
        /// <param name="sender">object</param>
        /// <param name="e">MouseEventArgs</param>
        private void drawCanvas_MouseMove(object sender, MouseEventArgs e)
        {
            if(this.drag)
            {
                ICommand cmd = new DrawCommand(this.drawCanvas, e.Location);
                history.Append(cmd);
                cmd.Execute();
            }
        }
    }
}
