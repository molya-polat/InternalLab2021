using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Threading;
using Microsoft.VisualBasic.FileIO;

namespace Task2
{
    public class Program
    {
        static void Main(string[] args)
        {
            var array = new int[][]
            {
                new int[] { 1, 3, 5, 7, 9},
                    new int[] { 0, 2, 40, 6},
                    new int[] { 11, 22}
            };
            var result = SortMin(array, 3);
            /*var result = SortMax(array, 3);
            var result = SortSum(array, 3);*/
            foreach (var num in result)
            {
                foreach (var n in num)
                {
                    Console.Write(n + " ");
                }
                Console.WriteLine();
            }
        }

        public static int[][] SortSum(int[][] arr, int n)
        {
            if (arr.Length == 0 || n <= 0)
            {
                throw new ArgumentException();
            }
            var lineNumberOfSum = new SortedList<int, int>();
            var sortedSum = new int[n];
            for (var i = 0; i < n; i++)
            {
                var sum = 0;
                for (var j = 0; j < arr[i].Length; j++)
                {
                    sum += arr[i][j];
                }

                lineNumberOfSum.Add(i, sum);
                sortedSum[i] = sum;
            }

            sortedSum = BubbleSort(sortedSum, n);

            arr = ReallocateLines(ref arr, lineNumberOfSum, sortedSum, n);

            return arr;
        }
        public static int[][] SortMax(int[][] arr, int n)
        {
            if (arr.Length == 0 || n <= 0)
            {
                throw new ArgumentException();
            }
            var lineNumberOfMax = new SortedList<int, int>();
            var sortedMax = new int[n];

            for (var i = 0; i < n; i++)
            {
                var max = int.MinValue;
                for (var j = 0; j < arr[i].Length; j++)
                {
                    if (arr[i][j] > max)
                    {
                        max = arr[i][j];
                    }
                }

                lineNumberOfMax.Add(i, max);
                sortedMax[i] = max;
            }

            sortedMax = BubbleSort(sortedMax, n);

            arr = ReallocateLines(ref arr, lineNumberOfMax, sortedMax, n);

            return arr;
        }
        public static int[][] SortMin(int[][] arr, int n)
        {
            if (arr.Length == 0 || n <= 0)
            {
                throw new ArgumentException();
            }
            var lineNumberOfMin = new SortedList<int, int>();
            var sortedMin = new int[n];
            for (var i = 0; i < n; i++)
            {
                var min = int.MaxValue;
                for (var j = 0; j < arr[i].Length; j++)
                {
                    if (arr[i][j] < min)
                    {
                        min = arr[i][j];
                    }
                }

                lineNumberOfMin.Add(i, min);
                sortedMin[i] = min;
            }

            sortedMin = BubbleSort(sortedMin, n);

            arr = ReallocateLines(ref arr, lineNumberOfMin, sortedMin, n);

            return arr;
        }
        static void Swap(ref int x, ref int y)
        {
            var t = x;
            x = y;
            y = t;
        }

        static int[] BubbleSort(int[] sortedSum, int n)
        {
            for (var k = 0; k < n - 1; k++)
            {
                for (var m = 0; m < n - k - 1; m++)
                {
                    if (sortedSum[m] > sortedSum[m + 1])
                    {
                        Swap(ref sortedSum[m], ref sortedSum[m + 1]);
                    }
                }
            }

            return sortedSum;
        }

        static int[][] ReallocateLines(ref int[][]arr, SortedList<int, int> list, int[] sorted, int n)
        {
            var result = new int[n][];
            for (var r = 0; r < n ; r++)
            {
                var key = FindKeyInLines(list, sorted[r]);
                if (key != -1)
                {
                    result[r] = arr[key];
                }

            }

            return result;
        }
        static int FindKeyInLines(SortedList<int, int> lines, int sum)
        {
            foreach (var v in lines)
            {
                if (v.Value == sum)
                {
                    return v.Key;
                }
            }

            return -1;
        }
    }
}
