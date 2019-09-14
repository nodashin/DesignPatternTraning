using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Bridge.Sample;

namespace Bridge.Traning1
{
    /// <summary>
    /// ランダム回数表示するクラス
    /// </summary>
    class RandomDisplay : Display
    {
        /// <summary>
        /// コンストラクタ
        /// </summary>
        /// <param name="impl">実装クラス</param>
        public RandomDisplay(DisplayImpl impl) : base(impl)
        {
        }

        /// <summary>
        /// ランダム回数表示する。
        /// </summary>
        /// <param name="times">ランダム値の上限(指定した値未満の値が乱数で取得される)</param>
        public void DisplayRandom(int times)
        {
            this.Open();
            for (int i = 0; i < new Random().Next(times); i++)
            {
                this.Print();
            }
            this.Close();
        }
    }
}
