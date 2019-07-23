using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Iterator.Traning
{
    class Main
    {
        public void ScanBooks()
        {
            var bookShelf = new BookShelf(new List<Book>()
            {
                new Book("Around the World in 80 Dyas"),
                new Book("Bible"),
                new Book("Cinderella"),
                new Book("Daddy-Long-Legs")
            });

            var itaretor = bookShelf.CreateIterator();
            while(itaretor.HasNext())
            {
                var book = itaretor.Next();
                Console.WriteLine(book.Name);
            }
        }
    }
}
