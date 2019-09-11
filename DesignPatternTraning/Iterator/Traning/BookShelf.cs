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
        public List<Book> Books { get; private set; } = new List<Book>();

        /// <summary>
        /// コンストラクタ
        /// </summary>
        public BookShelf()
        {
        }

        /// <summary>
        /// 本を追加する。
        /// </summary>
        /// <param name="book">追加する本</param>
        public void AppendBook(Book book)
            => this.Books.Add(book);

        /// <summary>
        /// 指定したIndexの本を取得する。
        /// </summary>
        /// <param name="index">取得したい本のIndex</param>
        /// <returns>指定したIndexの本</returns>
        public Book GetBookAt(int index)
            => this.Books[index];

        /// <summary>
        /// イテレータを生成する。
        /// </summary>
        /// <returns>本棚イテレータ</returns>
        public IIterator<Book> CreateIterator()
        {
            return new BookShelfIterator(this);
        }
    }
}
