using System;
using System.Collections.Generic;
using System.IO;
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

        /// <summary>
        /// 指定したデータベース名のデータをDictionary形式で返す。
        /// </summary>
        /// <param name="dbName">データベース名</param>
        /// <returns>Dictionary＜メールアドレス, 名前＞</returns>
        public static Dictionary<string, string> GetProperties(string dbName)
        {
            string fileName = @"Sample\" + dbName + ".txt";
            Dictionary<string, string> prop = new Dictionary<string, string>();
            try
            {
                using (var sr = new StreamReader(fileName))
                {
                    while(!sr.EndOfStream)
                    {
                        var content = sr.ReadLine();
                        if (string.IsNullOrEmpty(content))
                            continue;

                        var contents = content.Split('=');
                        prop.Add(contents[0], contents[1]);
                    }
                }

                return prop;
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.ToString());
                throw;
            }
        }
    }
}
