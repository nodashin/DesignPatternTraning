﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TemplateMethod.Sample
{
    /// <summary>
    /// メソッドOpen, Print, Closeを実行しているクラス
    /// </summary>
    class CharDisplay : AbstractDisplay
    {
        /// <summary>
        /// 表示すべき文字
        /// </summary>
        private char ch;

        /// <summary>
        /// コンストラクタ
        /// </summary>
        /// <param name="ch">表示すべき文字</param>
        public CharDisplay(char ch)
        {
            //コンストラクタで渡された文字chをフィールドに記憶しておく。
            this.ch = ch;
        }

        /// <summary>
        /// 文字列 "＜＜" を表示する。
        /// </summary>
        public override void Open()
        {
            Console.WriteLine("<<");
        }

        /// <summary>
        /// コンストラクタで与えられていた1文字を表示する。
        /// </summary>
        public override void Print()
        {
            Console.WriteLine(ch);
        }

        /// <summary>
        /// 文字列 "＞＞" を表示する。
        /// </summary>
        public override void Close()
        {
            Console.WriteLine(">>");
        }
    }
}
