using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using FactoryMethod.Sample.Framework;

namespace FactoryMethod.Sample.IdCard
{
    /// <summary>
    /// ICカードFactory
    /// </summary>
    class IDCardFactory : Factory
    {
        /// <summary>
        /// オーナー
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
        /// IDカードのオーナーを登録する。
        /// </summary>
        /// <param name="product">IDカード</param>
        protected override void RegisterProduct(Product product)
        {
            this.owners.Add(((IDCard)product).GetOwner());
        }

        /// <summary>
        /// 登録済みオーナーを取得する。
        /// </summary>
        /// <returns>登録済みオーナー</returns>
        public List<string> GetOwners()
        {
            return this.owners;
        }
    }
}
