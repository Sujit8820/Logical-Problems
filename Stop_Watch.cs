using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Diagnostics;

namespace Logical_Problems;


class Stop_Watch
{
    public void Stop()
    {
        Console.WriteLine("Press Enter to start stop watch and Press Enter to stop stopwatch");
        Console.ReadLine();
        var stopwatch = new Stopwatch();
        stopwatch.Start();
        Console.ReadLine();
        stopwatch.Stop();
        var elapsed_time = stopwatch.ElapsedMilliseconds;
        Console.WriteLine("Time Elapsed: "+ elapsed_time / 1000);

    }

}

