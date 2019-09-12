using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Prototype.Sample.Framework;

namespace Prototype.Sample
{
    /// <summary>
    /// Useメソッドに与えられた文字列を、decocharで囲う。
    /// 例えばdecocharが '*' のとき、「Hello」という文字列がUseメソッドに与えられたら
    /// 
    /// *********
    /// * Hello *
    /// *********
    /// 
    /// と表示する。
    /// </summary>
    class MessageBox : IProduct
    {
        /// <summary>
        /// Useメソッドで与えられた文字列を囲む文字
        /// </summary>
        private char decochar;

        /// <summary>
        /// コンストラクタ
        /// </summary>
        /// <param name="decochar">Useメソッドで与えられた文字列を囲む文字</param>
        public MessageBox(char decochar)
        {
            this.decochar = decochar;
        }

        /// <summary>
        /// 指定された文字列をdecocharで囲んで出力する。
        /// </summary>
        /// <param name="s">出力する文字列</param>
        public void Use(string s)
        {
            int length = Encoding.GetEncoding("shift-jis").GetBytes(s).Length;
            for (int i = 0; i < length + 4; i++)
            {
                Console.Write(decochar);
            }
            Console.WriteLine();
            Console.WriteLine(decochar + " " + s + " " + decochar);
            for (int i = 0; i < length + 4; i++)
            {
                Console.Write(decochar);
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
