using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading;

namespace Task2
{
    public static class Extension
    {
        public static int Euclidean(params int[] nums)
        {

            if (nums.Length == 0)
            {
                throw new ArgumentException();
            }
            var a = Math.Abs(nums[0]);
            var b = Math.Abs(nums[1]);
            foreach (var t in nums)
            {
                a = Math.Abs(t);
                if (a == 0)
                {
                    throw new Exception();
                }
                var r = (a > b) ? a % b : b % a;
                while (r != 0)
                {
                    if (a > b)
                    {
                        a = r;
                    }
                    else
                    {
                        b = r;
                    }
                    r = (a > b) ? a % b : b % a;
                }
                b = (a > b) ? b : a;
            }


            return (a > b) ? b : a;
        }

        public static int SteinAlgorithm(params int[] nums)
        {
            if (nums.Length == 0)
            {
                throw new ArgumentException();
            }
            var a = Math.Abs(nums[1]);
            var b = Math.Abs(nums[0]);
            var k = 1;
            for (var i = 1; i < nums.Length; i++)
            {
                a = Math.Abs(nums[i]);
                if (a == 0)
                {
                    throw new Exception();
                }
                k = 1;
                while (a != 0 && b != 0)
                {
                    while (a % 2 == 0 && b % 2 == 0)
                    {
                        a /= 2;
                        b /= 2;
                        k *= 2;
                    }

                    while (b % 2 != 1)
                    {
                        b /= 2;
                    }

                    while (a % 2 != 1)
                    {
                        a /= 2;
                    }

                    if (a >= b)
                    {
                        a -= b;
                    }
                    else
                    {
                        b -= a;
                    }
                }

                b *= k;
            }

            return b;
        }

        public static void EuclideanWithTime(out int result, out string time, params int[] nums)
        {
            Stopwatch stopWatch = new Stopwatch();
            stopWatch.Start();
            result = Euclidean(nums);
            stopWatch.Stop();
            var ts = stopWatch.Elapsed;

            time = $"{ts.Hours:00}:{ts.Minutes:00}:{ts.Seconds:00}.{ts.Milliseconds / 10:00}";
        }
        public static void SteinWithTime(out int result, out string time, params int[] nums)
        {
            Stopwatch stopWatch = new Stopwatch();
            stopWatch.Start();
            result = SteinAlgorithm(nums);
            stopWatch.Stop();
            var ts = stopWatch.Elapsed;

            time = $"{ts.Hours:00}:{ts.Minutes:00}:{ts.Seconds:00}.{ts.Milliseconds / 10:00}";
        }
    }
}
