using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Visitor.Sample
{
    /// <summary>
    /// ファイルやディレクトリを訪れる訪問者を表す抽象クラス。
    /// 役割：Visitor(訪問者)
    /// </summary>
    public abstract class Visitor
    {
        /// <summary>
        /// Fileを訪問したときにFileクラスが呼び出すメソッド。
        /// </summary>
        /// <param name="file">ファイル</param>
        public abstract void Visit(File file);

        /// <summary>
        /// Directoryを訪問したときにDirectoryクラスが呼び出すメソッド。
        /// </summary>
        /// <param name="directory">Directory</param>
        public abstract void Visit(Directory directory);
    }
}
