﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Mediator.Sample
{
    /// <summary>
    /// 「メンバー」のインタフェース(API)を定めるインタフェース。
    /// 具体的なメンバーは、このインタフェースを実装する。
    /// 役割：Colleague(同僚)
    /// </summary>
    public interface IColleague
    {
        /// <summary>
        /// このメソッドの引数で渡されたインスタンスは、後で相談役が必要になったとき(IMadiator.ColleaguesChangedを呼び出すとき)に使う。
        /// </summary>
        /// <param name="mediator">相談役</param>
        void SetMediator(IMediator mediator);

        /// <summary>
        /// 相談役からやってくる「指示」に相当する。
        /// 引数のenabledがtrueなら自分自身を「有効状態」にし、falseなら自分自身を「無効状態」にする。
        /// </summary>
        /// <param name="enabled">自分自身の有効無効状態</param>
        void SetColleagueEnabled(bool enabled);
    }
}
