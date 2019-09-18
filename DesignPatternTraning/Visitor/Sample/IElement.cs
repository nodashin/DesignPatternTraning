using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Visitor.Sample
{
    /// <summary>
    /// Visitorクラスのインスタンスを受け入れるデータ構造を表すインタフェース。
    /// 役割：Element(要素)
    /// </summary>
    public interface IElement
    {
        /// <summary>
        /// 訪問者を受け入れる。
        /// </summary>
        /// <param name="v">訪問者</param>
        void Accept(Visitor v);
    }
}
