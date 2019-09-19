using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Mediator.Sample
{
    /// <summary>
    /// IMediatorインタフェースを実装。
    /// ログインダイアログを表すクラス。
    /// </summary>
    public partial class LoginForm : Form, IMediator
    {
        /// <summary>
        /// コンストラクタ
        /// </summary>
        public LoginForm()
        {
            InitializeComponent();
        }

        public LoginForm(string text) : this()
        {
            this.Text = text;
        }

        /// <summary>
        /// Load
        /// </summary>
        /// <param name="sender">object</param>
        /// <param name="e">EventArgs</param>
        private void LoginForm_Load(object sender, EventArgs e)
        {
            //有効／無効の初期化指定
            CreateColleagues();
        }

        /// <summary>
        /// Madiatorが管理するメンバーを生成するメソッド。
        /// </summary>
        public void CreateColleagues()
        {
            //Madiatorのセット
            foreach (var c in this.Controls.Cast<Control>().Where(c => c is IColleague).Cast<IColleague>())
            {
                c.SetMediator(this);
            }
        }

        /// <summary>
        /// Colleagueからの通知で各Colleagueの有効／向こうを判定する。
        /// </summary>
        public void ColleaguesChanged()
        {
            if (colleagueRadioButtonGuest.Checked)
            {
                this.colleagueTextBoxUsername.SetColleagueEnabled(false);
                this.colleagueTextBoxPassword.SetColleagueEnabled(false);
                this.colleagueButtonOK.SetColleagueEnabled(false);
            }
            else
            {
                this.colleagueTextBoxUsername.SetColleagueEnabled(true);
                UserPassChanged();
            }
        }

        /// <summary>
        /// ユーザー名テキストまたはパスワードテキストの変更があった。
        /// 各Colleagueの有効／無効を判定する。
        /// </summary>
        private void UserPassChanged()
        {
            if (this.colleagueTextBoxUsername.Text.Length > 0)
            {
                this.colleagueTextBoxPassword.SetColleagueEnabled(true);
                if(colleagueTextBoxPassword.Text.Length > 0)
                {
                    this.colleagueButtonOK.SetColleagueEnabled(true);
                }
                else
                {
                    this.colleagueButtonOK.SetColleagueEnabled(false);
                }
            }
            else
            {
                this.colleagueTextBoxPassword.SetColleagueEnabled(false);
                this.colleagueButtonOK.SetColleagueEnabled(false);
            }
        }
    }
}
