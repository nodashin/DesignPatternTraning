using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Builder.Sample
{
    /// <summary>
    /// プレーンテキストを使って文書を構築する。
    /// </summary>
    class TextBuilder : Builder
    {
        /// <summary>
        /// このフィールドに文章を構築していく
        /// </summary>
        private StringBuilder buffer = new StringBuilder();

        /// <summary>
        /// プレーンテキストでのタイトル。
        /// </summary>
        /// <param name="title">タイトル</param>
        public override void MakeTitle(string title)
        {
            //飾り線
            buffer.Append("==================================================\n");
            //『』つきのタイトル
            buffer.Append("『" + title + "』\n");
            //空行
            buffer.Append("\n");
        }

        /// <summary>
        /// プレーンテキストでの文字列。
        /// </summary>
        /// <param name="str">文字列</param>
        public override void MakeString(string str)
        {
            //■付き文字列
            buffer.Append("■" + str + "\n");
            //空行
            buffer.Append("\n");
        }

        /// <summary>
        /// プレーンテキストでの箇条書き
        /// </summary>
        /// <param name="items">箇条書き</param>
        public override void MakeItems(string[] items)
        {
            //・つきの項目
            for (int i = 0; i < items.Length; i++)
            {
                buffer.Append("　・" + items[i] + "\n");
            }
            //空行
            buffer.Append("\n");
        }

        /// <summary>
        /// 文書の完成。
        /// </summary>
        public override void Close()
        {
            //飾り線
            buffer.Append("==================================================\n");
        }

        /// <summary>
        /// 完成した文書を取得する。
        /// </summary>
        /// <returns>完成した文書</returns>
        public string GetResult()
        {
            return buffer.ToString();
        }
    }
}
