using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FactoryMethod.Traning.Framework
{
    /// <summary>
    /// 製品
    /// </summary>
    public abstract class Product
    {
        /// <summary>
        /// 製品を使う。
        /// </summary>
        public abstract void Use();
    }
}
