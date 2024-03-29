﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Mediator.Sample
{
    /// <summary>
    /// 「相談役」のインタフェース(API)を定めるインタフェース。
    /// 具体的な相談役は、このインタフェースを実装する。
    /// 役割：Mediator(調停者、仲介者)
    /// </summary>
    public interface IMediator
    {
        /// <summary>
        /// Madiatorが管理するメンバーを生成するメソッド。
        /// </summary>
        void CreateColleagues();

        /// <summary>
        /// 各メンバーであるColleaugeたちから呼び出されるメソッド。
        /// 相談役への「相談」に相当する。
        /// </summary>
        void ColleaguesChanged();
    }
}
