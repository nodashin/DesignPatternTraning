namespace Iterator.Traning
{
    /// <summary>
    /// 本棚イテレータ
    /// </summary>
    internal class BookShelfIterator : IIterator<Book>
    {
        /// <summary>
        /// イテレータ対象の本棚
        /// </summary>
        private BookShelf BookShelf { get; }

        /// <summary>
        /// 対象となる本を指すIndex
        /// </summary>
        private int TargetIndex { get; set; } = 0;

        /// <summary>
        /// コンストラクタ
        /// </summary>
        /// <param name="bookShelf">イテレータ対象の本棚</param>
        public BookShelfIterator(BookShelf bookShelf)
        {
            this.BookShelf = bookShelf;
        }

        /// <summary>
        /// 次の本があるか確認する。
        /// </summary>
        /// <returns>true:ある false:無い</returns>
        public bool HasNext()
        {
            return this.TargetIndex <= this.BookShelf.BookCount - 1;
        }

        /// <summary>
        /// 次の本を取得する。
        /// </summary>
        /// <returns>次の本</returns>
        public Book Next()
        {
            var book = BookShelf.GetBookAt(this.TargetIndex);
            this.TargetIndex++;
            return book;
        }
    }
}