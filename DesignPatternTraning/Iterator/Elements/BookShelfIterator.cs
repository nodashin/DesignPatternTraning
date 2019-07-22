namespace Iterator.Elements
{
    /// <summary>
    /// BookShelfクラスのスキャンを行うクラス。
    /// </summary>
    internal class BookShelfIterator : IIterator
    {
        /// <summary>
        /// このBookShelfIteratorがスキャンする本棚。
        /// </summary>
        private BookShelf bookShelf;

        /// <summary>
        /// 現在注目している本を指す添字。
        /// </summary>
        private int index;

        /// <summary>
        /// コンストラクタ
        /// </summary>
        /// <param name="bookShelf">本棚</param>
        public BookShelfIterator(BookShelf bookShelf)
        {
            this.bookShelf = bookShelf;
            index = 0;
        }

        /// <summary>
        /// 「次の本」があるかどうかを調べる。
        /// </summary>
        /// <returns>
        /// 次の本があるならtrue, 無ければfalseを返す。
        /// </returns>
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
        /// 次の本を返す。
        /// </summary>
        /// <returns>本</returns>
        /// <remarks>
        /// 現在注目している本の添字を次に進める処理も行う。
        /// </remarks>
        public object Next()
        {
            Book book = bookShelf.GetBookAt(index);
            index++;
            return book;
        }
    }
}