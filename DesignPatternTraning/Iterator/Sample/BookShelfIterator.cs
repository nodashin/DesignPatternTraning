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
        /// 現在注目している本を指す添え字
        /// </summary>
        private int index;

        /// <summary>
        /// コンストラクタ
        /// </summary>
        /// <param name="bookShelf">スキャンする本棚</param>
        public BookShelfIterator(BookShelf bookShelf)
        {
            this.bookShelf = bookShelf;
            this.index = 0;
        }

        /// <summary>
        /// 「次の本」があるかどうかを調べる。
        /// </summary>
        /// <returns>次の本があればtrue、ないならfalseを返す。</returns>
        public bool HasNext()
        {
            //現在注目している本を指す添え字より本棚の長さが大きいかで判断する。
            if (index < bookShelf.GetLength())
            {
                return true;
            }
            else
            {
                return false;
            }
        }

        /// <summary>
        /// 現在注目している本を返し、さらに「次」へすすめる。
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