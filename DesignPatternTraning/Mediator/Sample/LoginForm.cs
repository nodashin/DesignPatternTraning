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
        public LoginForm()
        {
            InitializeComponent();
        }

        public void ColleaguesChanged()
        {
            throw new NotImplementedException();
        }

        public void CreateColleagues()
        {
            throw new NotImplementedException();
        }
    }
}
