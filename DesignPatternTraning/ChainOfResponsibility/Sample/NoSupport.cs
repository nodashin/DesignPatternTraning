using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ChainOfResponsibility.Sample
{
    /// <summary>
    /// トラブルを解決する具象クラス。
    /// 常に「処理しない」。
    /// 役割：Concretehandler(具体的処理者)
    /// </summary>
    class NoSupport : Support
    {
        /// <summary>
        /// コンストラクタ
        /// </summary>
        /// <param name="name">トラブル解決者の名前</param>
        public NoSupport(string name) : base(name)
        {
        }

        /// <summary>
        /// 解決用メソッド
        /// </summary>
        /// <param name="trouble">解決すべきトラブル</param>
        /// <returns>tureのときは要求が処理されたことを表し、falseのときには要求はまだ処理されていない(すなわち、次にたらい回しする)ことを表す</returns>
        protected override bool Resolve(Trouble trouble)
        {
            //自分は何も問題を処理しない。
            return false;
        }
    }
}
