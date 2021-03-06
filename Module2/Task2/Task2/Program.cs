using System;

namespace Task2
{
    public class Program
    {
        private static void Main()
        {
            int [] arr = {1, 56, 123, -4, 7, 8};
            Console.WriteLine(FindMax(arr, arr.Length));
        }

        public static int FindMax(int[] arr, int size)
        {
            if (size < 0)
            {
                throw new ArgumentException();
            }

            if(size == 1)
            {
                return arr[0];
            }
            var t = arr[^1];
            return Math.Max(t, FindMax(arr, size-1));
        }
    }
}
