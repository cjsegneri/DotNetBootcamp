using System;

namespace DesignAStopwatch
{

    class Program
    {
        static void Main(string[] args)
        {
            StopWatch sp = new StopWatch();

            //sp.Stop();

            //Console.WriteLine(sp.GetDuration().ToString("c"));

            //sp.Start();
            //Console.WriteLine(sp.GetDuration().ToString("c"));

            sp.Start();
            sp.Stop();
            Console.WriteLine(sp.GetDuration().ToString("c"));
        }
    }
}