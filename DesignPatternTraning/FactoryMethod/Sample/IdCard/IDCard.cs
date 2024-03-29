﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using FactoryMethod.Sample.Framework;

namespace FactoryMethod.Sample.IdCard
{
    /// <summary>
    /// 認識番号カード
    /// 役割：ConcreteProduct(具体的製品)
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
        public IDCard(string owner)
        {
            Console.WriteLine(owner + "のカードを作ります。");
            this.owner = owner;
        }

        /// <summary>
        /// 使う。
        /// </summary>
        public override void Use()
        {
            Console.WriteLine(owner + "のカードを使います。");
        }

        /// <summary>
        /// オーナーを取得する。
        /// </summary>
        /// <returns>オーナー</returns>
        public string GetOwner()
        {
            return owner;
        }
    }
}
