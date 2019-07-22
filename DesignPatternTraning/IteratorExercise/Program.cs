using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using IteratorExercise.Elemets;

namespace IteratorExercise
{
    class Program
    {
        static void Main(string[] args)
        {
            var bookShelf = new BookShelf();
            bookShelf.AppendBook(new Book("Around the World in 80 Days"));
            bookShelf.AppendBook(new Book("Bible"));
            bookShelf.AppendBook(new Book("Cinderella"));
            bookShelf.AppendBook(new Book("Daddy-Long-Legs"));

            var itaretor = bookShelf.CreateIterator();
            while(itaretor.HasNext())
            {
                var book = itaretor.GetNextElementAndAdvanceToNext();
                Console.WriteLine(book.Name);
            }

            Console.ReadKey();
        }
    }
}
