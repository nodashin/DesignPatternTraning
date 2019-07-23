using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Iterator.Sample
{
    /// <summary>
    /// 本棚をスキャンするクラス
    /// </summary>
    class BookShelfIterator : IIterator
    {
        /// <summary>
        /// スキャンする本棚
        /// </summary>
        private BookShelf bookShelf;

        /// <summary>
        /// スキャンする本棚の中で現在注目している本の添字
        /// </summary>
        private int index;

        /// <summary>
        /// コンストラクタ
        /// </summary>
        /// <param name="bookShelf">スキャンさせたい本棚</param>
        public BookShelfIterator(BookShelf bookShelf)
        {
            this.bookShelf = bookShelf;
            this.index = 0;
        }

        /// <summary>
        /// 「次の本」が存在するかどうかを調べる。
        /// </summary>
        /// <returns>次の本があるならtrue、なければfalse</returns>
        public bool HasNext()
        {
            if(index < bookShelf.GetLength())
            {
                return true;
            }
            else
            {
                return false;
            }
        }

        /// <summary>
        /// 現在注目している本を返し、注目している本を次へ進める。
        /// </summary>
        /// <returns>現在注目している本</returns>
        public object Next()
        {
            Book book = bookShelf.GetBookAt(index);
            index++;
            return book;
        }
    }
}
