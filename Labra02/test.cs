using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Labra02
{
    class test
    {
        public static void Test()
        {
            Console.WriteLine("Timer starts");
            System.Timers.Timer timer = new System.Timers.Timer(200);
            timer.Enabled = true;
            timer.Start();
            Console.WriteLine("Timer stops");
            Console.Write(timer);
        }
    }
}
