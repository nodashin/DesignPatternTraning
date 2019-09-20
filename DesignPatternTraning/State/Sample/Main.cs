using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace State.Sample
{
    class Main
    {
        public static void Execute()
        {
            SafeForm form = new SafeForm("State Sample");
            form.Show();
            while(true)
            {
                for (int i = 0; i < 24; i++)
                {
                    form.SetClock(i);
                    Thread.Sleep(1000);
                }
            }
        }
    }
}
