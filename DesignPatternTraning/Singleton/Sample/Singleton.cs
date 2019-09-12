using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Singleton.Sample
{
    /// <summary>
    /// シングルトン
    /// </summary>
    class Singleton
    {
        /// <summary>
        /// シングルトンのインスタンス
        /// </summary>
        private static Singleton singleton = new Singleton();

        /// <summary>
        /// コンストラクタ
        /// </summary>
        /// <remarks>
        /// 外部から new できないように、privateに制限している。
        /// </remarks>
        private Singleton()
        {
            Console.WriteLine("インスタンスを生成しました。");
        }

        /// <summary>
        /// シングルトンクラスのインスタンスを取得するメソッド。
        /// </summary>
        /// <returns>シングルトンクラスのインスタンス</returns>
        public static Singleton GetInstance()
        {
            return singleton;
        }
    }
}
