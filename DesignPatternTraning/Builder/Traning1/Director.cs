using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Builder.Traning1
{
    /// <summary>
    /// ディレクター
    /// </summary>
    class Director
    {
        /// <summary>
        /// ドキュメントビルダー
        /// </summary>
        private IDocumentBuilder DocumentBuilder { get; }

        /// <summary>
        /// コンストラクタ
        /// </summary>
        /// <param name="documentBuilder">ドキュメントビルダ</param>
        public Director(IDocumentBuilder documentBuilder)
        {
            this.DocumentBuilder = documentBuilder;
        }

        /// <summary>
        /// 文書を作成する。
        /// </summary>
        /// <returns>ドキュメントビルダーの戻り値</returns>
        public string Construct()
        {
            this.DocumentBuilder.WriteTitle("Greeting");

            this.DocumentBuilder.WriteString("朝から昼にかけて");
            this.DocumentBuilder.WriteItems("おはようございます。", "こんにちは。");

            this.DocumentBuilder.WriteString("夜に");
            this.DocumentBuilder.WriteItems("こんばんは。", "おやすみなさい。", "さようなら。");

            return this.DocumentBuilder.Complete();
        }
    }
}
