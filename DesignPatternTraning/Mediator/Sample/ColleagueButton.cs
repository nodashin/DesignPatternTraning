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
    /// IColleagueのインタフェースを実装。ボタンを表すクラス。
    /// </summary>
    public partial class ColleagueButton : Button, IColleague
    {
        /// <summary>
        /// SetMadiatorで渡されてくるMadiatorオブジェクト
        /// </summary>
        private IMediator mediator;

        /// <summary>
        /// コンストラクタ
        /// </summary>
        public ColleagueButton()
        {
            InitializeComponent();
        }

        /// <summary>
        /// このメソッドの引数で渡されたインスタンスは、後で相談役が必要になったとき(IMadiator.ColleaguesChangedを呼び出すとき)に使う。
        /// </summary>
        /// <param name="madiator">相談役</param>
        public void SetMadiator(IMediator madiator)
        {
            throw new NotImplementedException();
        }

        /// <summary>
        /// 相談役からやってくる「指示」に相当する。
        /// 引数のenabledがtrueなら自分自身を「有効状態」にし、falseなら自分自身を「無効状態」にする。
        /// </summary>
        /// <param name="enabled">自分自身の有効無効状態</param>
        public void SetColleagueEnabled(bool enabled)
        {
            this.Enabled = enabled;
        }
    }
}
