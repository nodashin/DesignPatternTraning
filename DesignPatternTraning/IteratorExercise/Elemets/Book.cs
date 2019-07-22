using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace IteratorExercise.Elemets
{
    /// <summary>
    /// 本
    /// </summary>
    class Book
    {
        /// <summary>
        /// 本の名前
        /// </summary>
        public string Name { get; }

        /// <summary>
        /// コンストラクタ
        /// </summary>
        /// <param name="name">本の名前</param>
        public Book(string name)
        {
            Name = name;
        }
    }
}
