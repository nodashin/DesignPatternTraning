using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FactoryMethod.Traning2.Framwrork
{
    /// <summary>
    /// 工場
    /// </summary>
    abstract class Factory<TProduct>
        where TProduct : Product
    {
        /// <summary>
        /// 製品を作成する。
        /// </summary>
        /// <param name="owner">製品のオーナー</param>
        /// <returns>作成した製品</returns>
        public TProduct Create(string owner)
        {
            var p = this.CreateProduct(owner);
            this.RegisterProduct(p);
            return p;
        }

        /// <summary>
        /// 製品を作成する。
        /// </summary>
        /// <param name="owner">製品のオーナー</param>
        /// <returns>作成した製品</returns>
        protected abstract TProduct CreateProduct(string owner);

        /// <summary>
        /// 製品を登録する。
        /// </summary>
        /// <param name="product">登録する製品</param>
        protected abstract void RegisterProduct(TProduct product);
    }
}
