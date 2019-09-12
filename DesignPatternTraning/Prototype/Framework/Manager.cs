using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Prototype.Framework
{
    /// <summary>
    /// IProductインタフェースを利用してインスタンスの複製を行うクラス。
    /// </summary>
    class Manager
    {
        /// <summary>
        /// インスタンスの「名前」と「インスタンス」の対応関係を表現したもの。
        /// </summary>
        private Dictionary<string, IProduct> showcase = new Dictionary<string, IProduct>();

        /// <summary>
        /// 与えられた製品の名前とIProductをshowcaseに登録する。
        /// </summary>
        /// <param name="name">製品の名前</param>
        /// <param name="prot">製品</param>
        public void Register(string name, IProduct prot)
        {
            showcase.Add(name, prot);
        }

        /// <summary>
        /// 製品名に一致する製品のクローンを作成する。
        /// </summary>
        /// <param name="protoName">クローンを作成する製品名</param>
        /// <returns>指定された製品名のインスタンスのクローン</returns>
        public IProduct Create(string protoName)
        {
            IProduct p = showcase[protoName];
            return p.CreateClone();
        }
    }
}
