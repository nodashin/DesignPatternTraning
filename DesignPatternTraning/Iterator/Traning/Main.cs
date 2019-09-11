using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Iterator.Traning
{
    class Main
    {
        public static void Execute()
        {
            Console.WriteLine("***** Traning start *****");
            Console.WriteLine();

            var bookShelf = new BookShelf();
            bookShelf.AppendBook(new Book("Around the world in 80 Days"));
            bookShelf.AppendBook(new Book("Bible"));
            bookShelf.AppendBook(new Book("Cinderella"));
            bookShelf.AppendBook(new Book("Daddy-Long-Legs"));
            IIterator<Book> iterator = bookShelf.CreateIterator();
            while (iterator.HasNext())
            {
                var book = iterator.Next();
                Console.WriteLine(book.Name);
            }

            Console.WriteLine();
            Console.WriteLine("***** Traning end *****");
        }
    }
}
