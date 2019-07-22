using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace IteratorExercise.Elemets
{
    /// <summary>
    /// 本棚
    /// </summary>
    class BookShelf : IAggregate<Book>
    {
        /// <summary>
        /// 本棚に格納されている本
        /// </summary>
        private List<Book> Books { get; set; } = new List<Book>();

        /// <summary>
        /// 本棚に格納されている本の最大Index
        /// </summary>
        public int MaxIndex { get => Books.Count - 1; }

        /// <summary>
        /// 指定したIndexに格納されている本を取得する。
        /// </summary>
        /// <param name="index">取得する本のIndex</param>
        /// <returns>指定したIndexの本</returns>
        public Book GetBookAt(int index)
        {
            return Books[index];
        }

        /// <summary>
        /// 本棚に本を追加する。
        /// </summary>
        /// <param name="book">追加する本</param>
        public void AppendBook(Book book)
        {
            Books.Add(book);
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
