using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using FactoryMethod.Traning2.Framwrork;

namespace FactoryMethod.Traning2.IdCard
{
    /// <summary>
    /// IDカード工場
    /// </summary>
    class IDCardFactory : Factory<IDCard>
    {
        /// <summary>
        /// 作成したIDカード
        /// </summary>
        public List<IDCard> CreatedIDCards { get; } = new List<IDCard>();

        /// <summary>
        /// IDカードを作成する。
        /// </summary>
        /// <param name="owner">オーナー</param>
        /// <returns>作成したIDカード</returns>
        protected override IDCard CreateProduct(string owner)
        {
            return new IDCard(owner, this.CreatedIDCards.Count + 1);
        }

        /// <summary>
        /// IDカードを登録する。
        /// </summary>
        /// <param name="idCard">登録するIDカード</param>
        protected override void RegisterProduct(IDCard idCard)
        {
            this.CreatedIDCards.Add(idCard);
        }
    }
}
