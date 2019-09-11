using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Iterator.Sample
{
    class Main
    {
        public static void Execute()
        {
            Console.WriteLine("Sample start");
            Console.WriteLine();

            BookShelf bookShelf = new BookShelf(4);
            bookShelf.AppendBook(new Book("Around the world in 80 Days"));
            bookShelf.AppendBook(new Book("Bible"));
            bookShelf.AppendBook(new Book("Cinderella"));
            bookShelf.AppendBook(new Book("Daddy-Long-Legs"));
            IIterator it = bookShelf.Iterator();
            while(it.HasNext())
            {
                Book book = (Book)it.Next();
                Console.WriteLine(book.GetName());
            }

            Console.WriteLine();
            Console.WriteLine("Sample end");
            Console.ReadKey();
        }
    }
}
