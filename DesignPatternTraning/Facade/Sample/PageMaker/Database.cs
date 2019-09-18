using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Facade.Sample.PageMaker
{
    /// <summary>
    /// メールアドレスからユーザー名を得るクラス。
    /// </summary>
    class Database
    {
        /// <summary>
        /// コンストラクタ
        /// </summary>
        /// <remarks>
        /// newでインスタンスを生成させないためにprivate宣言。
        /// </remarks>
        private Database()
        {
            
        }

        public static Dictionary<string, string> GetProperties(string dbName)
        {
            string fileName = dbName + ".txt";
            Dictionary<string, string> prop = new Dictionary<string, string>();
            try
            {

            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.ToString());
                throw;
            }
        }
    }
}
