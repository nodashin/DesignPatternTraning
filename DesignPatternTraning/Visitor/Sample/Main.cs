using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Visitor.Sample
{
    class Main
    {
        public static void Execute()
        {
            try
            {
                Console.WriteLine("Making root entries...");
                Directory roorDir = new Directory("root");
                Directory binDir = new Directory("bin");
                Directory tmpDir = new Directory("tmp");
                Directory usrDir = new Directory("usr");
                roorDir.Add(binDir);
                roorDir.Add(tmpDir);
                roorDir.Add(usrDir);
                binDir.Add(new File("vi", 10000));
                binDir.Add(new File("latex", 20000));
                roorDir.Accept(new ListVisitor());

                Console.WriteLine();

                Console.WriteLine("Making user entries...");
                Directory yuki = new Directory("yuki");
                Directory hanako = new Directory("hanako");
                Directory tomura = new Directory("tomura");
                yuki.Add(new File("diary.html", 100));
                yuki.Add(new File("Compsite.java", 200));
                hanako.Add(new File("memo.txt", 300));
                tomura.Add(new File("game.doc", 400));
                tomura.Add(new File("junk.mail", 500));
                roorDir.Accept(new ListVisitor());
            }
            catch (FileTreatmentException ex)
            {
                Console.WriteLine(ex.ToString());
            }
        }
    }
}
