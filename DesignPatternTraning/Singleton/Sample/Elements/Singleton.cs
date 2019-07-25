using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Singleton.Sample.Elements
{
    class Singleton
    {
        /// <summary>
        /// インスタンス
        /// </summary>
        private static Singleton singleton = new Singleton();

        /// <summary>
        /// コンストラクタ
        /// </summary>
        private Singleton()
        {
            Console.WriteLine("インスタンスを生成しました。");
        }

        /// <summary>
        /// インスタンスを取得する。
        /// </summary>
        /// <returns>インスタンス</returns>
        public static Singleton GetInstance()
        {
            return singleton;
        }
    }
}
