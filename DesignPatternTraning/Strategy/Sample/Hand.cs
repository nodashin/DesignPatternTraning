using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Strategy.Sample
{
    /// <summary>
    /// 手
    /// </summary>
    class Hand
    {
        /// <summary>
        /// グーを表す値。
        /// </summary>
        public static readonly int HANDVALUE_GUU = 0;

        /// <summary>
        /// チョキを表す値。
        /// </summary>
        public static readonly int HANDVALUE_CHO = 1;

        /// <summary>
        /// パーを表す値。
        /// </summary>
        public static readonly int HANDVALUE_PAA = 2;

        /// <summary>
        /// じゃんけんの手を表す3つのインスタンス。
        /// </summary>
        public static Hand[] hand =
        {
            new Hand(HANDVALUE_GUU),
            new Hand(HANDVALUE_CHO),
            new Hand(HANDVALUE_PAA),
        };

        /// <summary>
        /// じゃんけんの手の文字列表現
        /// </summary>
        public static string[] name =
        {
            "グー",
            "チョキ",
            "パー"
        };

        /// <summary>
        /// じゃんけんの手の値
        /// </summary>
        private int handValue;

        /// <summary>
        /// コンストラクタ
        /// </summary>
        /// <param name="handValue">じゃんけんの手の値</param>
        public Hand(int handValue)
        {
            this.handValue = handValue;
        }

        /// <summary>
        /// 指定したじゃんけんの手の値の手を取得する。
        /// </summary>
        /// <param name="handValue">取得する手のじゃんけんの手の値</param>
        /// <returns>指定したじゃんけんの手の値の手</returns>
        public static Hand GetHand(int handValue)
        {
            return hand[handValue];
        }

        /// <summary>
        /// 自分自身が指定された手より強いか。
        /// </summary>
        /// <param name="h">勝負する手</param>
        /// <returns>強いか否か</returns>
        public bool IsStrongerThan(Hand h)
        {
            return Fight(h) == 1;
        }

        /// <summary>
        /// 自分自身が指定された手より弱いか。
        /// </summary>
        /// <param name="h">勝負する手</param>
        /// <returns>弱いか否か</returns>
        public bool IsWeakerThan(Hand h)
        {
            return Fight(h) == -1;
        }

        /// <summary>
        /// 手の強さを判定する。
        /// </summary>
        /// <param name="h">自分自身と強さを判定する手</param>
        /// <returns>-1:自分自身の負け 0:あいこ 1:自分自身の勝ち</returns>
        private int Fight(Hand h)
        {
            if (this == h)
            { 
                return 0;
            }
            else if((this.handValue + 1) % 3 == h.handValue)
            {
                return 1;
            }
            else
            {
                return -1;
            }
        }

        /// <summary>
        /// じゃんけんの手の値を文字列で表現する。
        /// </summary>
        /// <returns>じゃんけんの手の値の文字列</returns>
        public override string ToString()
        {
            return name[handValue];
        }
    }
}
