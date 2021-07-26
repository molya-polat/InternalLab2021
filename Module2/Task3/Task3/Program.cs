using System;

namespace Task3
{
    public class Program
    {
        private static void Main(string[] args)
        {
            var arr = new[] {-48.2, 98.3, 15.12, 23.1, 8.0, 112.6, -24.28};

            Console.WriteLine(FindSpecialIndex(arr));
        }

        public static int FindSpecialIndex(double[] arr)
        {
            var leftSum = 0m;
            var totalSum = 0m;
            foreach (var t in arr)
            {
                totalSum += (decimal)t;
            }
            for (var i = 1; i < arr.Length; i++)
            {
                leftSum += (decimal)arr[i - 1];
                var rightSum = totalSum - leftSum - (decimal)arr[i];
                if (leftSum == rightSum)
                {
                    return i;
                }
            }

            return -1;
        }
    }
}
