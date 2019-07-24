using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Adapter.Traning2.Elements
{
    /// <summary>
    /// 元から用意されているクラス
    /// </summary>
    class Properties
    {
        /// <summary>
        /// 値
        /// </summary>
        public Dictionary<string, string> Values { get; set; } = new Dictionary<string, string>();

        /// <summary>
        /// 指定したStreamを読み込み、値を設定する。
        /// </summary>
        /// <param name="in">読み込むStream</param>
        public void Load(StreamReader @in)
        {
            using (@in)
            {
                var content = @in.ReadToEnd();
                foreach (var line in content.Split(new string[] { "\r\n" }, StringSplitOptions.None))
                {
                    var values = line.Split('=');
                    Values.Add(values[0], values[1]);
                }
            }
        }

        /// <summary>
        /// 指定したStreamに値を書き出す。
        /// </summary>
        /// <param name="out">Stream</param>
        /// <param name="header">ヘッダー</param>
        public void Store(StreamWriter @out, string header)
        {
            using (@out)
            {
                @out.WriteLine(header);
                foreach (var pair in Values)
                {
                    @out.WriteLine(pair.Key + "=" + pair.Value);
                }
            }
        }
    }
}
