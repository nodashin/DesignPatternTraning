using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Adapter.Traning2
{
    /// <summary>
    /// Adapter
    /// </summary>
    class FileProperties : IFIleIO
    {
        /// <summary>
        /// Properties
        /// </summary>
        Properties Properties { get; } = new Properties();

        /// <summary>
        /// コンストラクタ
        /// </summary>
        public FileProperties()
        {
        }

        /// <summary>
        /// 指定したファイルを読み込む。
        /// </summary>
        /// <param name="fileName">読み込むファイル名</param>
        public void ReadFromFile(string fileName)
        {
            using (var reader = new StreamReader(fileName))
                this.Properties.Load(reader);
        }

        /// <summary>
        /// 指定したファイルに書き込む。
        /// </summary>
        /// <param name="fileName">書き込むファイル名</param>
        public void WriteToFile(string fileName)
        {
            using (var writer = new StreamWriter(fileName))
                this.Properties.Store(writer, "#written by FileProperties");
        }

        /// <summary>
        /// 値を設定する。
        /// </summary>
        /// <param name="key">設定する値のキー値</param>
        /// <param name="value">設定する値</param>
        public void SetValue(string key, string value)
        {
            this.Properties.SetPropery(key, value);
        }

        /// <summary>
        /// 指定したキーの値を取得する。
        /// </summary>
        /// <param name="key">取得したい値のキー</param>
        /// <returns>指定したキーの値</returns>
        public string GetValue(string key)
        {
            return this.Properties.GetPropety(key);
        }
    }
}
