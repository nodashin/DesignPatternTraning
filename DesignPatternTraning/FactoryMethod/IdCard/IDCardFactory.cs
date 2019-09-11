using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using FactoryMethod.Framework;

namespace FactoryMethod.IdCard
{
    /// <summary>
    /// IDカード工場
    /// </summary>
    class IDCardFactory : Factory
    {
        /// <summary>
        /// 登録したIDカードのオーナー
        /// </summary>
        private List<string> owners = new List<string>();

        /// <summary>
        /// IDカードを作成する。
        /// </summary>
        /// <param name="owner">IDカードのオーナー</param>
        /// <returns>作成したIDカード</returns>
        protected override Product CreateProduct(string owner)
        {
            return new IDCard(owner);
        }

        /// <summary>
        /// IDカードを登録する。
        /// </summary>
        /// <param name="p">登録するIDカード</param>
        protected override void RegisterProduct(Product p)
        {
            owners.Add(((IDCard)p).GetOwner());
        }

        /// <summary>
        /// 登録したIDカードのオーナーを取得する。
        /// </summary>
        /// <returns>登録したIDカードのオーナー</returns>
        public List<string> GetOwners()
        {
            return owners;
        }
    }
}
