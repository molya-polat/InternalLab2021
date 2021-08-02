using System;
using System.Security.Cryptography.X509Certificates;

namespace Task1
{
    public class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine(FindNthRoot(0.04100625, 4, 0.0001));
        }

        public static double FindNthRoot(double number, double n, double precision)
        {
            if (precision <= 0 || n <= 0 )
            {
                throw new ArgumentException("Precision or root is out of range");
            }

            var i = 0;
            var x = 1d;
            var xNext = Func(number, n, x);
            while (true)
            {
                i++;
                if (i > 1000)
                {
                    throw new ArgumentException("Too many iterations");
                }
                if (Math.Abs(x - xNext) < precision)
                {
                    break;
                }
                x = xNext;
                xNext = Func(number, n, x);

            }
            return Math.Round(xNext,4);
        }

        private static double Func(double number, double n, double x) => (1 / n) * (((n - 1) * x) + number / Math.Pow(x, n - 1));
    }
}
