using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AbstractFactory.Sample.Factory
{
    /// <summary>
    /// 項目
    /// LinkとTrayのスーパークラス
    /// </summary>
    public abstract class Item
    {
        /// <summary>
        /// 項目の見出し
        /// </summary>
        protected string caption;

        /// <summary>
        /// コンストラクタ
        /// </summary>
        /// <param name="caption">項目の見出し</param>
        protected Item(string caption)
        {
            this.caption = caption;
        }

        /// <summary>
        /// HTMLを作成する。
        /// </summary>
        /// <returns>作成したHTML</returns>
        public abstract string MakeHTML();
    }
}
