using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Builder.Sample
{
    /// <summary>
    /// Bulderクラスで宣言されているメソッドを使って文章を作る。
    /// </summary>
    class Director
    {
        /// <summary>
        /// Bulder
        /// </summary>
        private Builder builder;

        /// <summary>
        /// コンストラクタ
        /// </summary>
        /// <param name="builder">Bulder</param>
        public Director(Builder builder)
        {
            this.builder = builder;
        }

        /// <summary>
        /// 文章を作る。
        /// </summary>
        public void Construct()
        {
            //タイトル
            builder.MakeTitle("Greeting");

            //文字列
            builder.MakeString("朝から昼にかけて");

            //箇条書き
            builder.MakeItems(new string[] { "おはようございます。", "こんにちは。" });

            //別の文字列
            builder.MakeString("夜に");

            //別の箇条書き
            builder.MakeItems(new string[] { "こんばんは。", "おやすみなさい。", "さようなら" });

            //文章を完成させる。
            builder.Close();
        }
    }
}
