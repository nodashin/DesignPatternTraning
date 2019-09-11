using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Adapter.Traning2
{
    class Main
    {
        public static void Execute()
        {
            IFIleIO f = new FileProperties();

            f.ReadFromFile(@"Traning2\Files\file.txt");
            Console.WriteLine("read value:" + f.GetValue("year"));

            f.SetValue("year", "2004");
            f.SetValue("month", "4");
            f.SetValue("day", "21");
            f.WriteToFile(@"Traning2\Files\newfile.txt");
        }
    }
}
