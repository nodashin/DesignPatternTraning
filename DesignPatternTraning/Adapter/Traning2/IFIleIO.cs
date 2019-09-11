using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Adapter.Traning2
{
    /// <summary>
    /// Target
    /// </summary>
    interface IFIleIO
    {
        /// <summary>
        /// 指定したファイルを読み込む。
        /// </summary>
        /// <param name="fileName">読み込むファイル名</param>
        void ReadFromFile(string fileName);

        /// <summary>
        /// 指定したファイルに書き込む。
        /// </summary>
        /// <param name="fileName">書き込むファイル名</param>
        void WriteToFile(string fileName);

        /// <summary>
        /// 値を設定する。
        /// </summary>
        /// <param name="key">設定する値のキー値</param>
        /// <param name="value">設定する値</param>
        void SetValue(string key, string value);

        /// <summary>
        /// 指定したキーの値を取得する。
        /// </summary>
        /// <param name="key">取得したい値のキー</param>
        /// <returns>指定したキーの値</returns>
        string GetValue(string key);
    }
}
