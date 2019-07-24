using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using FactoryMethod.Traning.Framework;

namespace FactoryMethod.Traning.IDCard
{
    /// <summary>
    /// IDカードFactory
    /// </summary>
    class IDCardFactory : Factory<IDCard>
    {
        /// <summary>
        /// 登録したオーナー
        /// </summary>
        private List<string> Owners { get; } = new List<string>();

        /// <summary>
        /// 通し番号とオーナー
        /// </summary>
        private Dictionary<int, string> OwnersAndNumbers { get; } = new Dictionary<int, string>();

        /// <summary>
        /// 現在の通し番号
        /// </summary>
        private int CurrentNumber { get; set; } = 1;

        /// <summary>
        /// IDカードを作成する。
        /// </summary>
        /// <param name="owner">IDカードのオーナー</param>
        /// <returns>作成したIDカード</returns>
        protected override IDCard CreateProduct(string owner)
        {
            return new IDCard(owner);
        }

        /// <summary>
        /// 製品のオーナーを登録する。
        /// </summary>
        /// <param name="idCard">登録するオーナーのIDカード</param>
        protected override void RegisterProduct(IDCard idCard)
        {
            this.Owners.Add(idCard.Owner);
            this.OwnersAndNumbers.Add(this.CurrentNumber, idCard.Owner);
            this.CurrentNumber++;
        }
    }
}
