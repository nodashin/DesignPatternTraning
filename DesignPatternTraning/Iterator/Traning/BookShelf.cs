using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Iterator.Traning
{
    /// <summary>
    /// 本棚
    /// </summary>
    class BookShelf : IAggregate<Book>
    {
        /// <summary>
        /// 本棚に格納されている本
        /// </summary>
        public List<Book> Books { get; }

        /// <summary>
        /// 本棚に格納されている本の数
        /// </summary>
        public int BookCount { get => Books.Count; }

        /// <summary>
        /// コンストラクタ
        /// </summary>
        /// <param name="books">本棚に格納する本</param>
        public BookShelf(List<Book> books)
        {
            Books = books;
        }

        /// <summary>
        /// 指定したIndexの本を取得する。
        /// </summary>
        /// <param name="index">取得する本のIndex</param>
        /// <returns>指定したIndexの本</returns>
        public Book GetBookAt(int index)
        {
            return this.Books[index];
        }

        /// <summary>
        /// 本棚イテレータを生成する。
        /// </summary>
        /// <returns>本棚イテレータ</returns>
        public IIterator<Book> CreateIterator()
        {
            return new BookShelfIterator(this);
        }
    }
}
