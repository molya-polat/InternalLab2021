using System;
using System.Collections.Generic;

namespace Task6
{
    public class Program
    {
        static void Main(string[] args)
        {
            var arr = new[] { 7, 12, 56, 67, 78, 89, 7 };
            var r = FilterDigit(arr, 7);
            foreach (var num in r)
            {
                Console.WriteLine(num);
            }
        }

        public static int[] FilterDigit(int[] arr, int number)
        {
            var list = new List<int>();

            foreach (var element in arr)
            {
                var initialElement = element;
                while (initialElement > 0)
                {
                    var temp = initialElement % 10;
                    if (temp == number)
                    {
                        list.Add(element);
                        break;
                    }
                    initialElement /= 10;
                }
            }

            if (list.Count == 0)
            {
                return null;
            }

            var result = new int[list.Count];
            list.CopyTo(result);
            return result;
        }
    }
}
