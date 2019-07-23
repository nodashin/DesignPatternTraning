using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Iterator.Sample
{
    /// <summary>
    /// 本棚
    /// </summary>
    class BookShelf : IAggregate
    {
        /// <summary>
        /// 本棚に追加された本を格納する配列
        /// </summary>
        private Book[] books;

        /// <summary>
        /// 次に本棚に追加された本を格納する配列に本を格納する添字
        /// </summary>
        private int last = 0;

        /// <summary>
        /// コンストラクタ
        /// </summary>
        /// <param name="maxsize">本棚に追加された本を格納する配列の最大要素数</param>
        public BookShelf(int maxsize)
        {
            this.books = new Book[maxsize];
        }

        /// <summary>
        /// 指定したIndexの本を取得する。
        /// </summary>
        /// <param name="index">取得する本のIndex</param>
        /// <returns>指定したIndexの本</returns>
        public Book GetBookAt(int index)
        {
            return this.books[index];
        }

        /// <summary>
        /// 本棚に本を追加する。
        /// </summary>
        /// <param name="book">追加する本</param>
        public void AppendBook(Book book)
        {
            this.books[this.last] = book;
            this.last++;
        }

        /// <summary>
        /// 現在の本棚に追加された本を格納する配列の長さを取得する。
        /// </summary>
        /// <returns>現在の本棚に追加された本を格納する配列の長さ</returns>
        public int GetLength()
        {
            return this.last;
        }

        /// <summary>
        /// 本棚に対応するIteratorとして本棚イテレータのインスタンスを生成し返す。
        /// </summary>
        /// <returns>本棚イテレータのインスタンス</returns>
        public IIterator Iterator()
        {
            return new BookShelfIterator(this);
        }
    }
}
