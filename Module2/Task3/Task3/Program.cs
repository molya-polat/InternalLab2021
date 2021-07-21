using System;

namespace Task3
{
    public class Program
    {
        static void Main(string[] args)
        {
            double[] arr = new[] {-48.2, 98.45, 15.12, 23.1, 8.0, 112.75, -24.28};

            Console.WriteLine(FindSpecialIndex(arr));
        }

        public static int FindSpecialIndex(double[] arr)
        {
            double leftSum = 0, rightSum = 0;
            for (var i = 1; i < arr.Length; i++)
            {
                for (var j = 0; j < i; j++)
                {
                    leftSum += arr[j];
                }

                for (var k = i + 1; k < arr.Length; k++)
                {
                    rightSum += arr[k];
                }

                if (leftSum.CompareTo(rightSum) == 0)
                {
                    return i;
                }
                leftSum = rightSum = 0;
            }

            return -1;
        }
    }
}
