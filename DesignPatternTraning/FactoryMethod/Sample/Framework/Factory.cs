using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FactoryMethod.Sample.Framework
{
    /// <summary>
    /// Factory
    /// </summary>
    abstract class Factory
    {
        /// <summary>
        /// 製品を作成し登録する。
        /// </summary>
        /// <param name="owner">オーナー</param>
        /// <returns>作成した製品</returns>
        public Product Create(string owner)
        {
            Product p = this.CreateProduct(owner);
            this.RegisterProduct(p);
            return p;
        }

        /// <summary>
        /// 製品を作成する。
        /// </summary>
        /// <param name="owner">オーナー</param>
        /// <returns>作成した製品</returns>
        protected abstract Product CreateProduct(string owner);

        /// <summary>
        /// 製品を登録する。
        /// </summary>
        /// <param name="product">登録する製品</param>
        protected abstract void RegisterProduct(Product product);
    }
}
