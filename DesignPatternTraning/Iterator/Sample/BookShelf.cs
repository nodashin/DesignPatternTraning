using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Iterator.Sample
{
    /// <summary>
    /// 本棚を表すクラス
    /// </summary>
    class BookShelf : IAggregate
    {
        /// <summary>
        /// 本棚に格納している本
        /// </summary>
        private Book[] books;

        /// <summary>
        /// 本を次に追加するIndex
        /// </summary>
        private int last = 0;

        /// <summary>
        /// コンストラクタ
        /// </summary>
        /// <param name="maxsize">本棚の最大サイズ</param>
        public BookShelf(int maxsize)
        {
            this.books = new Book[maxsize];
        }

        /// <summary>
        /// 本を取得する。
        /// </summary>
        /// <param name="index">取得する本のIndex</param>
        /// <returns>指定したIndexの本</returns>
        public Book GetBookAt(int index)
        {
            return books[index];
        }

        /// <summary>
        /// 本を追加する。
        /// </summary>
        /// <param name="book">追加する本</param>
        public void AppendBook(Book book)
        {
            this.books[last] = book;
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
        /// BookShelfクラスに対応するIteratorとしてBookShelfIteratorクラスのインスタンスを返す。
        /// </summary>
        /// <returns>BookShelfIteratorクラス</returns>
        public IIterator Iterator()
        {
            return new BookShelfIterator(this);
        }
    }
}
