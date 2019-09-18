using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ChainOfResponsibility.Sample
{
    /// <summary>
    /// トラブルを解決する具象クラス。
    /// 指定した番号未満のトラブルを解決。
    /// </summary>
    class LimitSupport : Support
    {
        /// <summary>
        /// この番号未満なら解決できる。
        /// </summary>
        private int limit;

        /// <summary>
        /// コンストラクタ
        /// </summary>
        /// <param name="name">トラブル解決者の名前</param>
        /// <param name="limit">この番号未満なら解決できる</param>
        public LimitSupport(string name, int limit) : base(name)
        {
            this.limit = limit;
        }

        /// <summary>
        /// 解決用メソッド
        /// </summary>
        /// <param name="trouble">解決すべきトラブル</param>
        /// <returns>tureのときは要求が処理されたことを表し、falseのときには要求はまだ処理されていない(すなわち、次にたらい回しする)ことを表す</returns>
        protected override bool Resolve(Trouble trouble)
        {
            throw new NotImplementedException();
        }
    }
}
