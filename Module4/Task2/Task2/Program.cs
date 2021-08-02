using System;
using System.Diagnostics;
namespace Task2
{
    class Program
    {
        static void Main(string[] args)
        {
              Stopwatch stopWatch = new Stopwatch();
              stopWatch.Start();
              Console.WriteLine(Extension.Euclidean( 456,24));
              stopWatch.Stop();
              var ts = stopWatch.Elapsed;

              var elapsedTime = $"{ts.Hours:00}:{ts.Minutes:00}:{ts.Seconds:00}.{ts.Milliseconds / 10:00}";
              Console.WriteLine("RunTime " + elapsedTime);
            //int result;
            //string time;
            //Extension.SteinWithTime(out result, out time,45, 30, 90, 15, 105);
            //Console.WriteLine(result + " " + time);
        }
    }
}
