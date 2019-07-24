using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Adapter.Traning2.Elements
{
    interface IFileIO
    {
        /// <summary>
        /// ファイルを読み込む。
        /// </summary>
        /// <param name="fileName">ファイル名</param>
        void ReadFromFile(string fileName);

        /// <summary>
        /// ファイルを書き出す。
        /// </summary>
        /// <param name="fileName">ファイル名</param>
        void WriteToFile(string fileName);

        /// <summary>
        /// 値を設定する。
        /// </summary>
        /// <param name="Key">キー</param>
        /// <param name="value">値</param>
        void SetValue(string Key, string value);

        /// <summary>
        /// 指定したキーの値を取得する。
        /// </summary>
        /// <param name="key">キー</param>
        /// <returns>指定したキーの値</returns>
        string GetValue(string key);
    }
}
