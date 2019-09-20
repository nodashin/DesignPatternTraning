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
    /// 役割：Context(状況、前後関係、文脈)
    /// </summary>
    public partial class SafeForm : Form, IContext
    {
        /// <summary>
        /// 現在の状態
        /// </summary>
        private IState state = DayState.GetInstance();

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
            this.Refresh();
        }

        /// <summary>
        /// 金庫使用Button_Click
        /// </summary>
        /// <param name="sender">object</param>
        /// <param name="e">EventArgs</param>
        private void buttonUse_Click(object sender, EventArgs e)
        {
            state.DoUse(this);
        }

        /// <summary>
        /// 非常ベルButton_Click
        /// </summary>
        /// <param name="sender">object</param>
        /// <param name="e">EventArgs</param>
        private void buttonAlram_Click(object sender, EventArgs e)
        {
            state.DoAlarm(this);
        }

        /// <summary>
        /// 通常通話Button_Click
        /// </summary>
        /// <param name="sender">object</param>
        /// <param name="e">EventArgs</param>
        private void buttonPhone_Click(object sender, EventArgs e)
        {
            state.DoPhone(this);
        }

        /// <summary>
        /// 終了Button_Click
        /// </summary>
        /// <param name="sender">object</param>
        /// <param name="e">EventArgs</param>
        private void buttonClose_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        /// <summary>
        /// 時刻の設定。
        /// </summary>
        /// <param name="hour">時刻</param>
        public void SetClock(int hour)
        {
            string clockString = "現在時刻は";
            if(hour < 10)
            {
                clockString += "0" + hour + ":00";
            }
            else
            {
                clockString += hour + ":00";
            }
            Console.WriteLine(clockString);
            this.textBoxCurrentTime.Text = clockString;
            state.DoClock(this, hour);
            this.Refresh();
        }

        /// <summary>
        /// 状態変化
        /// </summary>
        /// <param name="state">状態</param>
        public void ChangeState(IState state)
        {
            Console.WriteLine(this.state + "から" + state + "へ状態が変化しました。");
            this.state = state;
            this.Refresh();
        }

        /// <summary>
        /// 警備センター呼び出し
        /// </summary>
        /// <param name="msg">メッセージ</param>
        public void CallSeculityCenter(string msg)
        {
            this.textBoxRecords.Text = "call!" + msg + "\n";
            this.Refresh();
        }

        /// <summary>
        /// 警備センター記録
        /// </summary>
        /// <param name="msg">メッセージ</param>
        public void RecordLog(string msg)
        {
            this.textBoxRecords.Text = "redord..." + msg + "\n";
            this.Refresh();
        }
    }
}
