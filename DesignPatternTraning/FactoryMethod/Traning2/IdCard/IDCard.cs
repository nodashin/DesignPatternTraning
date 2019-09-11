using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using FactoryMethod.Traning2.Framwrork;

namespace FactoryMethod.Traning2.IdCard
{
    /// <summary>
    /// IDカード
    /// </summary>
    class IDCard : Product
    {
        /// <summary>
        /// オーナー
        /// </summary>
        public string Owner { get; }

        /// <summary>
        /// 通し番号
        /// </summary>
        public int Number { get; }

        /// <summary>
        /// コンストラクタ
        /// </summary>
        /// <param name="owner">オーナー</param>
        /// <param name="number">通し番号</param>
        public IDCard(string owner, int number)
        {
            Owner = owner;
            Number = number;
        }

        /// <summary>
        /// 使う。
        /// </summary>
        public override void Use()
        {
            Console.WriteLine($"カードを使いました。オーナー：{this.Owner} 通し番号：{this.Number}");
        }
    }
}
