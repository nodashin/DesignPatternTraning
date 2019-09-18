using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Visitor.Sample
{
    /// <summary>
    /// Visitorクラスのサブクラスで、ファイルやディレクトリの一覧を表示するクラス
    /// </summary>
    public class ListVisitor : Visitor
    {
        /// <summary>
        /// 現在注目しているディレクトリ名
        /// </summary>
        private string currentDir = "";

        /// <summary>
        /// Fileを訪問したときにFileクラスが呼び出すメソッド。
        /// </summary>
        /// <param name="file">ファイル</param>
        public override void Visit(File file)
        {
            Console.WriteLine(currentDir + "/" + file);
        }

        /// <summary>
        /// Directoryを訪問したときにDirectoryクラスが呼び出すメソッド。
        /// </summary>
        /// <param name="directory">Directory</param>
        public override void Visit(Directory directory)
        {
            Console.WriteLine(currentDir + "/" + directory);
            string saveDir = currentDir;
            currentDir = currentDir + "/" + directory.GetName();
            foreach (var e in directory.Iterator())
            {
                e.Accept(this);
            }
            currentDir = saveDir;
        }
    }
}
