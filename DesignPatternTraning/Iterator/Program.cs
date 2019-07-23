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
            new Sample.Sample().Execute();

            Console.WriteLine("");

            Console.WriteLine("練習問題");
            new Traning.Main().ScanBooks();

            Console.ReadKey();
        }
    }
}
