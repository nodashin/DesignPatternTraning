using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FactoryMethod.Framework
{
    /// <summary>
    /// 製品を作る工場
    /// </summary>
    abstract class Factory
    {
        /// <summary>
        /// CreateProductで製品を作ってRegisterProductで登録する。
        /// </summary>
        /// <param name="owner">製品のオーナー</param>
        /// <returns>作成、登録を終えた製品</returns>
        public Product Create(string owner)
        {
            Product p = CreateProduct(owner);
            RegisterProduct(p);
            return p;
        }

        /// <summary>
        /// 製品を作成する。
        /// </summary>
        /// <param name="owner">製品のオーナー</param>
        /// <returns>作成した製品</returns>
        protected abstract Product CreateProduct(string owner);

        /// <summary>
        /// 製品を登録する。
        /// </summary>
        /// <param name="p">登録する製品</param>
        protected abstract void RegisterProduct(Product p);
    }
}
