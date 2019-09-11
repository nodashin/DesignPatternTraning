using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using FactoryMethod.Traning2.Framwrork;
using FactoryMethod.Traning2.IdCard;

namespace FactoryMethod.Traning2
{
    class Main
    {
        public static void Execute()
        {
            Factory<IDCard> f = new IDCardFactory();
            var card1 = f.Create("結城浩");
            var card2 = f.Create("とむら");
            var card3 = f.Create("佐藤花子");

            card1.Use();
            card2.Use();
            card3.Use();
        }
    }
}
