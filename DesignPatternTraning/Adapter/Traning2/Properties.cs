using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Adapter.Traning2
{
    /// <summary>
    /// Adaptee
    /// </summary>
    /// <remarks>
    /// java.util.Propertiesの代わり
    /// 参考：https://docs.oracle.com/javase/jp/8/docs/api/java/util/Properties.html
    /// </remarks>
    class Properties
    {
        /// <summary>
        /// プロパティ・リスト
        /// </summary>
        Dictionary<string, string> PropertyList { get; set; } = new Dictionary<string, string>();

        /// <summary>
        /// 指定されたキーを持つプロパティを、プロパティ・リストから探します。
        /// </summary>
        /// <param name="key">取得したい値のキー</param>
        /// <returns>指定されたキーの値</returns>
        public string GetPropety(string key)
            => this.PropertyList[key];

        /// <summary>
        /// Hashtableのメソッドputを呼び出します。(←?)
        /// 多分プロパティリストに値を設定するだけ。
        /// 参考URLを見るとObjectを返しているが何を返せば良いか分からん。
        /// </summary>
        /// <param name="key">設定するキー</param>
        /// <param name="value">設定する値</param>
        public void SetPropery(string key, string value)
        {
            if(this.PropertyList.ContainsKey(key))
            {
                this.PropertyList[key] = value;
            }
            else
            {
                this.PropertyList.Add(key, value);
            }
        }

        /// <summary>
        /// プロパティ・リスト(キーと要素のペア)を入力文字ストリームから単純な行指向形式で読み込みます。
        /// </summary>
        /// <param name="in">読み込むStream</param>
        public void Load(StreamReader @in)
        {
            var readContent = @in.ReadToEnd();
            var values = readContent.Split('=');
            this.PropertyList.Add(values[0], values[1]);
        }

        /// <summary>
        /// このProperties表内のこのプロパティ・リスト(キーと要素のペア)を、load(InputStream)メソッドを使用してProperties表にロードするのに適した形式で出力ストリームに書き込みます。
        /// </summary>
        /// <param name="out">出力するStream</param>
        /// <param name="header">出力するヘッダー</param>
        public void Store(StreamWriter @out, string header)
        {
            @out.WriteLine(header);
            foreach (var v in PropertyList)
            {
                @out.WriteLine($"{v.Key}={v.Value}");
            }
        }
    }
}
