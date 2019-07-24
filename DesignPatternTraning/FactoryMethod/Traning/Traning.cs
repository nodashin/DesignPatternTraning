using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using FactoryMethod.Traning.IDCard;

namespace FactoryMethod.Traning
{
    /// <summary>
    /// 練習問題4-2
    /// </summary>
    static class Traning
    {
        public static void Execute()
        {
            var factory = new IDCardFactory();
            var card1 = factory.CreateAndRedister("結城浩");
            var card2 = factory.CreateAndRedister("とむら");
            var card3 = factory.CreateAndRedister("佐藤花子");

            card1.Use();
            card2.Use();
            card3.Use();
        }
    }
}
