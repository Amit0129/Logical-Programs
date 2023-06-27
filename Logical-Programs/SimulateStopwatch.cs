using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Logical_Programs
{
    public class SimulateStopwatch
    {
        public void GetTimeElapses()
        {
            Stopwatch stopWatch = new Stopwatch();
            stopWatch.Start();
            for (int i = 0; i < 100; i++)
            {
                Thread.Sleep(10);
            }
            stopWatch.Stop();
            Console.WriteLine(" Time elapsed: {0} ", stopWatch.Elapsed);
        }
    }
}
