using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FactoryMethod.Sample.Framework
{
    /// <summary>
    /// 製品
    /// 役割：Product(製品)
    /// </summary>
    abstract class Product
    {
        /// <summary>
        /// 使う。
        /// </summary>
        public abstract void Use();
    }
}
