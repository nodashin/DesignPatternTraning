using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Prototype.Sample.Framework;

namespace Prototype.Sample
{
    /// <summary>
    /// Useメソッドに与えられた文字列をダブルコーテーションで囲い、ulcharの文字を下線とする。
    /// 例えばulcharが '~' のとき、「Hello」という文字列がUseメソッドに与えられたら
    /// 
    /// "Hello"
    /// ~~~~~~~
    /// と表示する。
    /// 役割：ConcretePrototype(具体的な原型)
    /// </summary>
    class UnderLinePen : IProduct
    {
        /// <summary>
        /// Useメソッドで与えられた文字列の下線となる文字
        /// </summary>
        private char ulchar;

        /// <summary>
        /// コンストラクタ
        /// </summary>
        /// <param name="ulchar">Useメソッドで与えられた文字列の下線となる文字</param>
        public UnderLinePen(char ulchar)
        {
            this.ulchar = ulchar;
        }

        /// <summary>
        /// 与えられた文字列を二重引用符でくくりながら、文字列の部分に下線を引く。
        /// </summary>
        /// <param name="s">出力する文字列</param>
        public void Use(string s)
        {
            int length = Encoding.GetEncoding("shift-jis").GetBytes(s).Length;
            Console.WriteLine("\"" + s + "\"");
            Console.Write(" ");
            for (int i = 0; i < length; i++)
            {
                Console.Write(ulchar);
            }
            Console.WriteLine();
        }

        /// <summary>
        /// ICloneableのメンバ。
        /// </summary>
        /// <returns>クローンしたオブジェクト</returns>
        public object Clone()
        {
            return this.MemberwiseClone();
        }

        /// <summary>
        /// 自分自身の複製を行うメソッド
        /// </summary>
        /// <returns>複製された自分自身</returns>
        public IProduct CreateClone()
        {
            return (IProduct)this.Clone();
        }
    }
}
