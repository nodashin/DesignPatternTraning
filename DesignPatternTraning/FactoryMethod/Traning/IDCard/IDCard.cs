using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using FactoryMethod.Traning.Framework;

namespace FactoryMethod.Traning.IDCard
{
    /// <summary>
    /// IDカードを使う。
    /// </summary>
    class IDCard : Product
    {
        /// <summary>
        /// オーナー
        /// </summary>
        public string Owner { get; }

        /// <summary>
        /// コンストラクタ
        /// </summary>
        /// <param name="owner">オーナー</param>
        internal IDCard(string owner)
        {
            Console.WriteLine(owner + "のカードを作ります。");
            Owner = owner;
        }

        /// <summary>
        /// IDカードを使用する。
        /// </summary>
        public override void Use()
        {
            Console.WriteLine(this.Owner + "のカードを使います。");
        }
    }
}
