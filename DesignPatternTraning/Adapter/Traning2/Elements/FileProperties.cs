using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Adapter.Traning2.Elements
{
    class FileProperties : IFileIO
    {
        /// <summary>
        /// Properties
        /// </summary>
        private Properties Properties { get; set; }

        /// <summary>
        /// コンストラクタ
        /// </summary>
        public FileProperties()
        {
            Properties = new Properties();
        }

        /// <summary>
        /// 指定したファイルを読み込む。
        /// </summary>
        /// <param name="fileName">読み込むファイル名</param>
        public void ReadFromFile(string fileName)
        {
            this.Properties.Load(new StreamReader(fileName));
        }

        /// <summary>
        /// 指定したファイルに保持している値を書き出す。
        /// </summary>
        /// <param name="fileName">書き出すファイル名</param>
        public void WriteToFile(string fileName)
        {
            this.Properties.Store(new StreamWriter(fileName), "#written by FileProperties" + Environment.NewLine + "#Web Apr 21 18:21:00 JST 2004");
        }

        /// <summary>
        /// 値を設定する。
        /// </summary>
        /// <param name="key">キー</param>
        /// <param name="value">値</param>
        public void SetValue(string key, string value)
        {
            if (this.Properties.Values.ContainsKey(key))
                this.Properties.Values[key] = value;
            else
                this.Properties.Values.Add(key, value);
        }

        /// <summary>
        /// 指定したキーの値を取得する。
        /// </summary>
        /// <param name="key">キー</param>
        /// <returns>指定したキーの値</returns>
        public string GetValue(string key)
        {
            return this.Properties.Values[key];
        }
    }
}
