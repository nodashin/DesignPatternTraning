using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace State.Sample
{
    /// <summary>
    /// IContextを実装しているクラス。ボタンや画面表示などのユーザーインタフェースを持つ。
    /// </summary>
    public partial class SafeForm : Form, IContext
    {
        /// <summary>
        /// コンストラクタ
        /// </summary>
        public SafeForm()
        {
            InitializeComponent();
        }

        /// <summary>
        /// コンストラクタ
        /// </summary>
        /// <param name="text">text</param>
        public SafeForm(string text) : this()
        {
            this.Text = text;
        }

        public void CallSeculityCenter(string msg)
        {
            throw new NotImplementedException();
        }

        public void ChangeState(IState state)
        {
            throw new NotImplementedException();
        }

        public void RecordLog(string msg)
        {
            throw new NotImplementedException();
        }

        public void SetClock(int hour)
        {
            throw new NotImplementedException();
        }
    }
}
