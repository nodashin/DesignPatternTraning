using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Flyweight.Sample
{
    /// <summary>
    /// 「大きな文字」を表すクラス。
    /// </summary>
    public class BigChar
    {
        /// <summary>
        /// 文字の名前
        /// </summary>
        private char charName;

        /// <summary>
        /// 大きな文字を表現する文字列('#' '.' '\n'の列)
        /// </summary>
        private string fontData;

        /// <summary>
        /// コンストラクタ
        /// </summary>
        /// <param name="charName">文字の名前</param>
        public BigChar(char charName)
        {
            this.charName = charName;
            try
            {
            StreamReader reader = new StreamReader("Files\big" + charName + ".txt");
            string line;
            StringBuilder buf = new StringBuilder();
            while((line = reader.ReadLine()) != null)
            {
                buf.Append(line);
                buf.Append('\n');
            }
            reader.Close();
            this.fontData = buf.ToString();
            }
            catch (IOException)
            {
                this.fontData = charName + "?";
            }
        }

        /// <summary>
        /// 大きな文字を表示する。
        /// </summary>
        public void Print()
        {
            Console.WriteLine(fontData);
        }
    }
}
