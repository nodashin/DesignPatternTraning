using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace IteratorExercise.Elemets
{
    /// <summary>
    /// 本棚イテレータ
    /// </summary>
    /// <remarks>
    /// 本棚に対するイテレータを行う。
    /// </remarks>
    class BookShelfIterator : IIterator<Book>
    {
        /// <summary>
        /// イテレータの対象となる本棚
        /// </summary>
        private BookShelf BookShelf { get; }

        /// <summary>
        /// 本棚内の次の本を指すIndex
        /// </summary>
        private int NextIndex { get; set; } = 0;

        /// <summary>
        /// コンストラクタ
        /// </summary>
        /// <param name="bookShelf">イテレータの対象となる本棚</param>
        public BookShelfIterator(BookShelf bookShelf)
        {
            BookShelf = bookShelf;
        }

        /// <summary>
        /// 現在のポジションの次の本があるか確認する。
        /// </summary>
        /// <returns>本</returns>
        public bool HasNext()
        {
            return (NextIndex <= BookShelf.MaxIndex);
        }

        /// <summary>
        /// 次の本を取得し、対象を次の本へ移動させる。
        /// </summary>
        /// <returns>次の本</returns>
        public Book GetNextElementAndAdvanceToNext()
        {
            var book = BookShelf.GetBookAt(NextIndex);
            NextIndex++;
            return book;
        }
    }
}
