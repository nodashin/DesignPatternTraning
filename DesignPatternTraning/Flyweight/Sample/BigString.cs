using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Flyweight.Sample
{
    /// <summary>
    /// BigCharを集めて作った「大きな文字列」を表すクラス。
    /// </summary>
    public class BigString
    {
        /// <summary>
        /// 「大きな文字」の配列。
        /// </summary>
        private BigChar[] bigChars;

        /// <summary>
        /// コンストラクタ
        /// </summary>
        public BigString(string @string)
        {
            bigChars = new BigChar[@string.Length];
            BigCharFactory factory = BigCharFactory.GetInstance();
            for (int i = 0; i < bigChars.Length; i++)
            {
                bigChars[i] = factory.GetBigChar(@string.ToCharArray()[i]);
            }
        }

        /// <summary>
        /// 表示する。
        /// </summary>
        public void Print()
        {
            for (int i = 0; i < bigChars.Length; i++)
            {
                bigChars[i].Print();
            }
        }
    }
}
