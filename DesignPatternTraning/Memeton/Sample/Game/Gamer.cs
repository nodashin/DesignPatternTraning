using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Memeton.Sample.Game
{
    /// <summary>
    /// ゲームを行う主人公のクラス。Memetonのインスタンスを作る。
    /// </summary>
    public class Gamer
    {
        /// <summary>
        /// 所持金
        /// </summary>
        private int money;

        /// <summary>
        /// フルーツ
        /// </summary>
        private List<string> fruits = new List<string>();

        /// <summary>
        /// 乱数発生器
        /// </summary>
        private Random random = new Random();

        /// <summary>
        /// フルーツ名の表
        /// </summary>
        public static string[] fruitsName =
        {
            "リンゴ",
            "ぶどう",
            "バナナ",
            "みかん"
        };

        /// <summary>
        /// コンストラクタ
        /// </summary>
        /// <param name="money">所持金</param>
        public Gamer(int money)
        {
            this.money = money;
        }

        /// <summary>
        /// 現在の所持金を得る。
        /// </summary>
        /// <returns>現在の所持金</returns>
        public int GetMoney()
        {
            return money;
        }

        /// <summary>
        /// 賭ける(ゲームの進行)
        /// </summary>
        public void Bet()
        {
            //サイコロを振る。
            int dice = random.Next(6) + 1;

            if(dice == 1)
            {
                //1の目…所持金が増える。
                money += 100;
                Console.WriteLine("所持金が増えました。");
            }
            else if(dice == 2)
            {
                //2の目…所持金が半分になる。
                money /= 2;
                Console.WriteLine("所持金が半分になりました。");
            }
            else if(dice == 6)
            {
                string f = GetFruit();
                Console.WriteLine("フルーツ（" + f + "）をもらいました。");
                fruits.Add(f);
            }
            else
            {
                Console.WriteLine("何も起こりませんでした。");
            }
        }

        /// <summary>
        /// スナップショットを撮る。
        /// </summary>
        /// <returns>スナップショットとして生成したMemento</returns>
        public Memento CreateMemento()
        {
            Memento m = new Memento(money);
            foreach (var f in fruits)
            {
                //フルーツはおいしいものだけ保存
                if(f.StartsWith("おいしい"))
                {
                    m.AddFruit(f);
                }
            }
            return m;
        }

        /// <summary>
        /// アンドゥを行う。
        /// </summary>
        /// <param name="memento">アンドゥ先のMemento</param>
        public void RestoreMemento(Memento memento)
        {
            this.money = memento.money;
            this.fruits = memento.GetFruit();
        }

        /// <summary>
        /// 文字列表現
        /// </summary>
        /// <returns>文字列</returns>
        public override string ToString()
        {
            return "[money = ]" + money + ", fruits = " + fruits + "]";
        }

        /// <summary>
        /// フルーツを1個得る
        /// </summary>
        /// <returns>フルーツ</returns>
        private string GetFruit()
        {
            string prefix = "";
            if (random.Next(1) == 0)
            {
                prefix = "おいしい";
            }
            return prefix + fruitsName[random.Next(fruitsName.Length)];
        }
    }
}
