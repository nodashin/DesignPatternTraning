﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Prototype.Sample.Framework;

namespace Prototype.Sample
{
    class Main
    {
        public static void Execute()
        {
            //準備
            Manager manager = new Manager();
            UnderLinePen upen = new UnderLinePen('~');
            MessageBox mbox = new MessageBox('*');
            MessageBox sbox = new MessageBox('/');
            manager.Register("strong message", upen);
            manager.Register("warning box", mbox);
            manager.Register("slash box", sbox);

            //生成
            IProduct p1 = manager.Create("strong message");
            p1.Use("Hello, world.");
            IProduct p2 = manager.Create("warning box");
            p2.Use("Hello, world.");
            IProduct p3 = manager.Create("slash box");
            p3.Use("Hello, world.");
        }
    }
}
