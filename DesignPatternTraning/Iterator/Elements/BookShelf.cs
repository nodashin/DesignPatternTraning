using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Iterator.Elements
{
    /// <summary>
    /// 本棚を表現するクラス。
    /// </summary>
    class BookShelf : IAggregate
    {
        /// <summary>
        /// 本棚が持っている本。
        /// </summary>
        private Book[] books;

        /// <summary>
        /// 本棚が持っている本の最後の要素のIndex。
        /// </summary>
        private int last = 0;

        /// <summary>
        /// コンストラクタ
        /// </summary>
        /// <param name="maxsize">本棚の最大サイズ</param>
        public BookShelf(int maxsize)
        {
            books = new Book[maxsize];
        }

        /// <summary>
        /// 指定したIndexの本を取得する。
        /// </summary>
        /// <param name="index">取得する本のIndex。</param>
        /// <returns>
        /// Indexで指定した本。
        /// </returns>
        public Book GetBookAt(int index)
        {
            return books[index];
        }

        /// <summary>
        /// 本を追加する。
        /// </summary>
        /// <param name="book">追加する本。</param>
        public void AppendBook(Book book)
        {
            books[last] = book;
            last++;
        }

        /// <summary>
        /// 本棚の長さを取得する。
        /// </summary>
        /// <returns>本棚の長さ</returns>
        public int GetLength()
        {
            return last;
        }

        /// <summary>
        /// BookShelfクラスに対応するIteratorのBookShelfIteratorクラスのインスタンスを生成して返す。
        /// </summary>
        /// <returns>
        /// IteratorのBookShelfIteratorクラスのインスタンスを生成して返す。
        /// </returns>
        /// <remarks>
        /// この本棚の本を数え上げたいときに呼び出される。
        /// </remarks>
        public IIterator Iterator()
        {
            return new BookShelfIterator(this);
        }
    }
}
