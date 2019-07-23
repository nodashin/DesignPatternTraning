using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Iterator.Sample;

namespace Iterator
{
    class Program
    {
        /// <summary>
        /// 本棚(BookShelf)の中に本(Book)を入れ、その本の名前を順に表示する。
        /// </summary>
        /// <param name="args"></param>
        static void Main(string[] args)
        {
            Console.WriteLine("サンプルプログラム");

            BookShelf bookShelf = new BookShelf(4);
            bookShelf.AppendBook(new Book("Around the World in 80 Days"));
            bookShelf.AppendBook(new Book("Bible"));
            bookShelf.AppendBook(new Book("Chinderella"));
            bookShelf.AppendBook(new Book("Daddy-Long-Legs"));

            IIterator it = bookShelf.Iterator();
            while(it.HasNext())
            {
                Book book = (Book)it.Next();
                Console.WriteLine(book.GetName());
            }

            Console.WriteLine("");
            Console.WriteLine("練習問題");
            new Traning.Main().ScanBooks();

            Console.ReadKey();
        }
    }
}
