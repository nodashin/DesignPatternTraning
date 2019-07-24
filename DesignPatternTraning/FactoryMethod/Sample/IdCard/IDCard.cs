using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using FactoryMethod.Sample.Framework;

namespace FactoryMethod.Sample.IdCard
{
    /// <summary>
    /// ICカード
    /// </summary>
    class IDCard : Product
    {
        /// <summary>
        /// オーナー
        /// </summary>
        private string owner;

        /// <summary>
        /// コンストラクタ
        /// </summary>
        /// <param name="owner">オーナー</param>
        internal IDCard(string owner)
        {
            Console.WriteLine(owner + "のカードを作ります。");
            this.owner = owner;
        }

        /// <summary>
        /// ICカードを使う。
        /// </summary>
        public override void Use()
        {
            Console.WriteLine(this.owner + "のカードを使います。");
        }

        /// <summary>
        /// オーナーを取得する。
        /// </summary>
        /// <returns>オーナー</returns>
        public string GetOwner()
        {
            return this.owner;
        }
    }
}
