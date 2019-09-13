using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AbstractFactory.Sample.Factory
{
    /// <summary>
    /// 複数のLinkやTrayを集めてひとまとまりにしたもの
    /// </summary>
    abstract class Tray : Item
    {
        /// <summary>
        /// 追加された項目
        /// </summary>
        protected List<Item> tray = new List<Item>();

        /// <summary>
        /// コンストラクタ
        /// </summary>
        /// <param name="caption">見出し</param>
        protected Tray(string caption) : base(caption)
        {
        }

        /// <summary>
        /// このクラスに項目を追加する。
        /// </summary>
        /// <param name="item"></param>
        public void Add(Item item)
        {
            tray.Add(item);
        }
    }
}
