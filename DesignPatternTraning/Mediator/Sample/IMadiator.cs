using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Mediator.Sample
{
    /// <summary>
    /// 「相談役」のインタフェース(API)を定めるインタフェース。
    /// </summary>
    public interface IMadiator
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
