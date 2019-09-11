using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Iterator.Traning
{
    /// <summary>
    /// 本棚イテレータ
    /// </summary>
    class BookShelfIterator : IIterator<Book>
    {
        /// <summary>
        /// イテレートする本棚
        /// </summary>
        public BookShelf BookShelf { get; }

        /// <summary>
        /// 現在のIndex
        /// </summary>
        /// <remarks>
        /// イテレータが保持している現在のIndexは、イテレータのユーザから見ると次のIndex
        /// </remarks>
        int CurrentIndex { get; set; } = 0;

        /// <summary>
        /// コンストラクタ
        /// </summary>
        /// <param name="bookShelf">イテレートする本棚</param>
        public BookShelfIterator(BookShelf bookShelf)
        {
            BookShelf = bookShelf;
        }

        /// <summary>
        /// 次の本を保持するか。(Nextメソッドの使用可否)
        /// ループの判定条件に使用する。
        /// </summary>
        /// <returns>保持有無</returns>
        public bool HasNext()
        {
            try
            {
                this.BookShelf.GetBookAt(this.CurrentIndex);
                return true;
            }
            catch (ArgumentOutOfRangeException)
            {
                return false;
            }
        }

        /// <summary>
        /// 次の本を取得する。
        /// </summary>
        /// <returns>次の本</returns>
        public Book Next()
        {
            var book = this.BookShelf.GetBookAt(this.CurrentIndex);
            this.CurrentIndex++;
            return book;
        }
    }
}
