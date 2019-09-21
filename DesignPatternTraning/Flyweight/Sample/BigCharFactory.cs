using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Flyweight.Sample
{
    /// <summary>
    /// BigCharのインスタンスを共有しながら生成するクラス
    /// </summary>
    public class BigCharFactory
    {
        /// <summary>
        /// すでに作ったBigCharのインスタンスを管理
        /// </summary>
        private Dictionary<char, BigChar> pool = new Dictionary<char, BigChar>();

        /// <summary>
        /// Singletonパターン
        /// </summary>
        private static BigCharFactory singleton = new BigCharFactory();

        /// <summary>
        /// コンストラクタ
        /// </summary>
        private BigCharFactory()
        {
        }

        /// <summary>
        /// 唯一のインスタンスを得る。
        /// </summary>
        /// <returns>BigCharFactory</returns>
        public static BigCharFactory GetInstance()
        {
            return singleton;
        }

        /// <summary>
        /// BigCharのインスタンス生成(共有)
        /// </summary>
        /// <param name="charName">文字の名前</param>
        /// <returns>BigChar</returns>
        public BigChar GetBigChar(char charName)
        {
            BigChar bc;
            if(pool.ContainsKey(charName))
            {
                bc = pool[charName];
            }
            else
            {
                bc = new BigChar(charName);
                pool.Add(charName, bc);
            }
            return bc;
        }
    }
}
