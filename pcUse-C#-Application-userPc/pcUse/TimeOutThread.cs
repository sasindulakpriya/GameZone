using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace pcUse
{
    class TimeOutThread
    {
        public void onTimeDo(int f)
        {
            for (int i = f; i > 0; i--)
            {


                Thread.Sleep(1000 * 2);

            }

            Form2 voidKillMain = new Form2();
            voidKillMain.Show();
        }
    }
}
