using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ChainOfResponsibility.Sample
{
    /// <summary>
    /// トラブルを解決する具象クラス。
    /// 特定番号のトラブルを解決。
    /// 役割：Concretehandler(具体的処理者)
    /// </summary>
    class SpecialSupport : Support
    {
        /// <summary>
        /// この番号だけ解決できる
        /// </summary>
        private int number;

        /// <summary>
        /// コンストラクタ
        /// </summary>
        /// <param name="name">トラブル解決者の名前</param>
        /// <param name="number">解決できる番号</param>
        public SpecialSupport(string name, int number) : base(name)
        {
            this.number = number;
        }

        /// <summary>
        /// 解決用メソッド
        /// </summary>
        /// <param name="trouble">解決すべきトラブル</param>
        /// <returns>tureのときは要求が処理されたことを表し、falseのときには要求はまだ処理されていない(すなわち、次にたらい回しする)ことを表す</returns>
        protected override bool Resolve(Trouble trouble)
        {
            if(trouble.GetNumber() == number)
            {
                return true;
            }
            else
            {
                return false;
            }
        }
    }
}
