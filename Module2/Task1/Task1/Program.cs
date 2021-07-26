using System;

namespace Task1
{
    public class Program
    {
        private static void Main(string[] args)
        {
            Console.WriteLine(InsertNumber(-7,1,1,2));
        }

        public static int InsertNumber(int numberSource, int numberIn, int i, int j)
        {
            var bitsSource = ConvertToBinary(numberSource);
            var bitsIn = ConvertToBinary(numberIn);
            var m = 31;

            for (var k = 31-i; k >= 31-j; k--)
            {
                bitsSource[k] = bitsIn[m];
                m--;
            }

            var result = ConvertToDecimal(bitsSource);
            return result;
        }

        private static int[] ConvertToBinary(int number)
        {
            var result = new int[32];
            var isNegative = false;
            if (number < 0)
            {
                number = -number;
                isNegative = true;
            }

            var i = 0;
            while (number > 0)
            {
                var bit = number % 2;
                result[31 - i++] = bit;
                number /= 2;
            }

            if (!isNegative) return result;
          //conversion to two's complement
            for(var t = 0; t < 32; t++)
            {
               var temp = (result[t] == 0) ? result[t] = 1 : result[t] = 0;
            }

            var p = 31;
            while (result[p] != 0)//add one
            {
                result[p] = 0;
                p--;
            }

            result[p] = 1;
            return result;
        }

        private static int ConvertToDecimal(int[] bits)
        {
            var isNegative = false;
            if (bits[0] == 1)
            {
                isNegative = true;
                var j = 31;
                while (bits[j] != 1)//subtract one
                {
                    bits[j] = 1;
                    j--;
                }

                bits[j] = 0;
                for (var k = 0; k < bits.Length; k++)//conversion from two's complement
                {
                    var temp = (bits[k] == 0) ? bits[k] = 1 : bits[k] = 0;
                }
            }
            var result = 0;
            var pow = 0;
            for (var i = bits.Length - 1; i > 0; i--)
            {
                result += (int)Math.Pow(2, pow) * bits[i];
                pow++;
            }

            if (isNegative)
            {
                result = -result;
            }
            return result;
        }
    }
}
