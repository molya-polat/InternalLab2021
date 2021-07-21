using System;

namespace Task1
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine(InsertNumber(8,15,3,8));
        }

        static int InsertNumber(int numberSource, int numberIn, int i, int j)
        {
            int t = numberIn << i;
            int f = 0xff >> j + 1;
            int k = t & f;
            return t | numberSource;
        }
    }
}
