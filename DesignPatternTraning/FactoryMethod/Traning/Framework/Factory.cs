using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FactoryMethod.Traning.Framework
{
    /// <summary>
    /// Factory
    /// </summary>
    /// <typeparam name="T">製品の型</typeparam>
    public abstract class Factory<T>
        where T : Product
    {
        /// <summary>
        /// 製品を作成し、登録する。
        /// </summary>
        /// <param name="owner">製品のオーナー</param>
        /// <returns>作成した製品</returns>
        public T CreateAndRedister(string owner)
        {
            var product = this.CreateProduct(owner);
            this.RegisterProduct(product);

            return product;
        }

        /// <summary>
        /// 製品を作成する。
        /// </summary>
        /// <param name="owner">製品のオーナー</param>
        /// <returns>作成した製品</returns>
        protected abstract T CreateProduct(string owner);

        /// <summary>
        /// 製品を登録する。
        /// </summary>
        /// <param name="product">登録する製品</param>
        protected abstract void RegisterProduct(T product);
    }
}
