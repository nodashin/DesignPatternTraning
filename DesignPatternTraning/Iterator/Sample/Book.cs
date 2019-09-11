using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Iterator.Sample
{
    /// <summary>
    /// 本を表すクラス
    /// </summary>
    class Book
    {
        /// <summary>
        /// 本の名前
        /// </summary>
        private readonly string name;

        /// <summary>
        /// コンストラクタ
        /// </summary>
        /// <param name="name">本の名前</param>
        public Book(string name)
        {
            this.name = name;
        }

        /// <summary>
        /// 本の名前を返す。
        /// </summary>
        /// <returns>本の名前</returns>
        public string GetName()
        {
            return name;
        }
    }
}
