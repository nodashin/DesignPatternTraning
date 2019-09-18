using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ChainOfResponsibility.Sample
{
    /// <summary>
    /// トラブルを解決する抽象クラス
    /// </summary>
    abstract class Support
    {
        /// <summary>
        /// トラブル解決者の名前
        /// </summary>
        private string name;

        /// <summary>
        /// たらい回し先
        /// </summary>
        private Support next;

        /// <summary>
        /// コンストラクタ
        /// </summary>
        /// <param name="name">トラブル解決者の名前</param>
        protected Support(string name)
        {
            this.name = name;
        }

        /// <summary>
        /// たらい回し先を設定する。
        /// </summary>
        /// <param name="next">設定するたらい回し先</param>
        /// <returns>設定したたらい回し先</returns>
        public Support SetNext(Support next)
        {
            this.next = next;
            return next;
        }

        /// <summary>
        /// トラブル解決の手順
        /// </summary>
        /// <param name="trouble">解決したいトラブル</param>
        public void SupportTrouble(Trouble trouble)
        {
            if(Resolve(trouble))
            {
                Done(trouble);
            }
            else if(next != null)
            {
                next.SupportTrouble(trouble);
            }
            else
            {
                Final(trouble);
            }
        }

        /// <summary>
        /// 解決用メソッド
        /// </summary>
        /// <param name="trouble">解決すべきトラブル</param>
        /// <returns>tureのときは要求が処理されたことを表し、falseのときには要求はまだ処理されていない(すなわち、次にたらい回しする)ことを表す</returns>
        protected abstract bool Resolve(Trouble trouble);

        /// <summary>
        /// 解決。
        /// </summary>
        /// <param name="trouble">解決したトラブル</param>
        private void Done(Trouble trouble)
        {
            Console.WriteLine(trouble + "is resolved by " + this + ".");
        }

        /// <summary>
        /// 未解決。
        /// </summary>
        /// <param name="trouble">未解決のトラブル</param>
        private void Final(Trouble trouble)
        {
            Console.WriteLine(trouble + " cannnot be resolved.");
        }
    }
}
