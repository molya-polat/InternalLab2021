using System;
using System.Collections.Generic;

namespace Task6
{
    public class Program
    {
        static void Main(string[] args)
        {
            int[] arr = new[] {7, 12, 56, 67, 78, 89, 7};
            int[] r = FilterDigit(arr,7);
            foreach (var num in r)
            {
                Console.WriteLine(num);
            }
        }

        public static int[] FilterDigit(int[] arr, int number)
        {
            List<int> list = new List<int>();
            char ch = (char)(number + '0');
            foreach (var t in arr)
            {
                var str = t.ToString();
                if (str.Contains(ch))
                {
                    list.Add(int.Parse(str));
                }
            }

            if (list.Count == 0)
            {
                return null;
            }

            int[] result = new int[list.Count];
            list.CopyTo(result);
            return result;
        }
    }
}
